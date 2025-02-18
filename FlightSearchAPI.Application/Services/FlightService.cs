using FlightSearchAPI.Application.Interfaces;
using FlightSearchAPI.Core.DTOs;
using FlightSearchAPI.Core.Entities;
using FlightSearchAPI.Core.Models;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;

namespace FlightSearchAPI.Application.Services
{
    public class FlightService : IFlightService
    {
        private readonly IFlightRepository _flightRepository;
        private readonly ICacheHandler _cacheHandler;
        private readonly IEnumerable<IFlightSearchStrategy> _searchStrategies;
        private readonly ISearchHistoryRepository _searchHistoryRepository;
        private readonly ILogger _logger;

        public FlightService(
            IFlightRepository flightRepository,
            ICacheHandler cacheHandler,
            IEnumerable<IFlightSearchStrategy> searchStrategies,
            ISearchHistoryRepository searchHistoryRepository,
            ILogger logger)
        {
            _flightRepository = flightRepository;
            _cacheHandler = cacheHandler;
            _searchStrategies = searchStrategies;
            _searchHistoryRepository = searchHistoryRepository;
            _logger = logger;
        }

        public async Task<SearchResultDTO> SearchFlightsAsync(FlightSearchCriteria criteria)
        {
            string cacheKey = $"FlightSearchCache_{JsonConvert.SerializeObject(criteria)}";

            _logger.Info($"Checking cache for key: {cacheKey}");

            // Check if the result is already cached
            var cachedResult = await _cacheHandler.GetCacheAsync<SearchResultDTO>(cacheKey);
            if (cachedResult != null && cachedResult.TotalCount >0)
            {
                _logger.Info("Cache hit. Returning cached data.");
                return cachedResult;
            }

            _logger.Info("Cache miss. Fetching data from repository.");

            // Fetch flights from the database
            var flights = await _flightRepository.SearchAsync(criteria);
            var flightQuery = flights.AsQueryable();

            // Apply search strategies (filters)
            foreach (var strategy in _searchStrategies.Where(s => !s.IsSortingStrategy))
            {
                flightQuery = strategy.ApplySearchCriteria(flightQuery, criteria);
            }

            // Apply sorting strategy
            var sortingStrategy = _searchStrategies.FirstOrDefault(s => s.IsSortingStrategy );
            if (sortingStrategy != null)
            {
                flightQuery = sortingStrategy.ApplySearchCriteria(flightQuery, criteria);
            }

            // Track search popularity
            var flightIds = await flightQuery.Select(f => f.Id).ToListAsync();
            if (flightIds.Any())
            {
                await _flightRepository.IncrementSearchCountAsync(flightIds);
            }

            // Apply pagination
            var paginatedFlights = await flightQuery
                .Skip((criteria.Page - 1) * criteria.PageSize)
                .Take(criteria.PageSize)
                .ToListAsync();

            // Prepare DTO
            var searchResultDTO = new SearchResultDTO
            {
                Flights = paginatedFlights.Select(f => new FlightDTO
                {
                    Id = f.Id,
                    Airline = f.Airline,
                    Departure = f.Departure,
                    Arrival = f.Arrival,
                    DepartureTime = f.DepartureTime,
                    ArrivalTime = f.ArrivalTime,
                    Price = f.Price
                }).ToList(),
                TotalCount = flightQuery.Count()
            };

            _logger.Info("Caching new search results.");

            // Store result in cache
            await _cacheHandler.SetCacheAsync(cacheKey, searchResultDTO, TimeSpan.FromMinutes(5));

            // Save search history
            var searchHistory = new SearchHistory
            {
                SearchQuery = JsonConvert.SerializeObject(criteria),
                SearchResults = JsonConvert.SerializeObject(searchResultDTO),
                SearchDate = DateTime.UtcNow
            };
            await _searchHistoryRepository.AddSearchHistoryAsync(searchHistory);

            return searchResultDTO;
        }
    }
}
