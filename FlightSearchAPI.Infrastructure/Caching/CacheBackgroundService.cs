using FlightSearchAPI.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace FlightSearchAPI.Infrastructure.Caching
{
    public class CacheBackgroundService : BackgroundService
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ILogger<CacheBackgroundService> _logger;
        private static readonly TimeSpan _updateInterval = TimeSpan.FromMinutes(6); 

        public CacheBackgroundService(IServiceProvider serviceProvider, ILogger<CacheBackgroundService> logger)
        {
            _serviceProvider = serviceProvider;
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    using (var scope = _serviceProvider.CreateScope())
                    {
                        var cacheHandler = scope.ServiceProvider.GetRequiredService<ICacheHandler>();

                        _logger.LogInformation("Updating cache in background job...");
                        await cacheHandler.UpdateCacheAsync();
                        await cacheHandler.RemoveExpiredCacheAsync(); // Remove old data

                        _logger.LogInformation("Cache update completed.");
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error while updating cache in background service.");
                }

                await Task.Delay(_updateInterval, stoppingToken); 
            }
        }
    }
}
