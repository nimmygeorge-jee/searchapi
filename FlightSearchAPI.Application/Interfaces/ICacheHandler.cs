using FlightSearchAPI.Core.DTOs;
using FlightSearchAPI.Core.Models;

namespace FlightSearchAPI.Application.Interfaces
{
    public interface ICacheHandler
    {
        Task GetOrUpdateCacheAsync(FlightSearchCriteria criteria);

        Task UpdateCacheAsync();

        Task<T?> GetCacheAsync<T>(string cacheKey);

        Task SetCacheAsync<T>(string cacheKey, T data, TimeSpan expiration);

        Task RemoveExpiredCacheAsync();
    }
}
