using FlightSearchAPI.Application.Interfaces;
using FlightSearchAPI.Core.DTOs;
using FlightSearchAPI.Core.Models;
using FlightSearchAPI.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace FlightSearchAPI.Infrastructure.Caching
{
    public class CacheHandler : ICacheHandler
    {
        private readonly IMemoryCache _memoryCache;
        private readonly ApplicationDbContext _context;
        private readonly ILogger<CacheHandler> _logger;
        private readonly IServiceProvider _serviceProvider;

        public CacheHandler(
            IMemoryCache memoryCache,
            IServiceProvider serviceProvider,
            ApplicationDbContext context,
            ILogger<CacheHandler> logger)
        {
            _memoryCache = memoryCache;
            _serviceProvider = serviceProvider;
            _context = context;
            _logger = logger;
        }
        private IFlightService _flightService => _serviceProvider.GetRequiredService<IFlightService>();
        /// <summary>
        /// Fetches or updates cache for a given search criteria.
        /// </summary>
        public async Task GetOrUpdateCacheAsync(FlightSearchCriteria criteria)
        {
            string cacheKey = JsonConvert.SerializeObject(criteria);

            if (!_memoryCache.TryGetValue(cacheKey, out SearchResultDTO cachedResult))
            {
                _logger.LogInformation($"Cache miss for key: {cacheKey}. Fetching data.");

                var flightData = await _flightService.SearchFlightsAsync(criteria);

                await SetCacheAsync(cacheKey, flightData, TimeSpan.FromMinutes(5));
            }
            else
            {
                _logger.LogInformation($"Cache hit for key: {cacheKey}. Returning cached data.");
            }
        }

        /// <summary>
        /// Updates cache for all search histories in the database.
        /// </summary>
        public async Task UpdateCacheAsync()
        {
            _logger.LogInformation("Updating cache for all stored search queries...");

            var allSearchCriteriaJson = await _context.SearchHistories.Select(x => x.SearchQuery).ToListAsync();

            foreach (var criteriaJson in allSearchCriteriaJson)
            {
                var criteria = JsonConvert.DeserializeObject<FlightSearchCriteria>(criteriaJson);
                if (criteria != null)
                {
                    await GetOrUpdateCacheAsync(criteria);
                }
            }

            _logger.LogInformation("Cache update completed.");
        }

        /// <summary>
        /// Retrieves data from cache.
        /// </summary>
        public async Task<T?> GetCacheAsync<T>(string cacheKey)
        {
            return _memoryCache.TryGetValue(cacheKey, out string jsonData)
                ? JsonConvert.DeserializeObject<T>(jsonData)
                : default;
        }

        /// <summary>
        /// Adds data to cache with expiration.
        /// </summary>
        public async Task SetCacheAsync<T>(string cacheKey, T data, TimeSpan expiration)
        {
            _logger.LogInformation($"Setting cache for key: {cacheKey} with expiration {expiration.TotalMinutes} minutes.");

            var cacheOptions = new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = expiration,
                SlidingExpiration = TimeSpan.FromMinutes(2),
                Size = 1
            };

            _memoryCache.Set(cacheKey, JsonConvert.SerializeObject(data), cacheOptions);
        }

        /// <summary>
        /// Removes expired cache entries.
        /// </summary>
        public async Task RemoveExpiredCacheAsync()
        {
            _logger.LogInformation("Removing expired cache entries...");

            var allSearchCriteriaJson = await _context.SearchHistories.Select(x => x.SearchQuery).ToListAsync();
            foreach (var criteriaJson in allSearchCriteriaJson)
            {
                var criteria = JsonConvert.DeserializeObject<FlightSearchCriteria>(criteriaJson);
                if (criteria != null)
                {
                    string cacheKey = JsonConvert.SerializeObject(criteria);
                    _memoryCache.Remove(cacheKey);
                    _logger.LogInformation($"Removed expired cache for key: {cacheKey}");
                }
            }

            _logger.LogInformation("Expired cache removal completed.");
        }
    }
}
