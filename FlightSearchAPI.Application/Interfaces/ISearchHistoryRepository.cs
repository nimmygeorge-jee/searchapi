using FlightSearchAPI.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSearchAPI.Application.Interfaces
{
    public interface ISearchHistoryRepository
    {
        Task AddSearchHistoryAsync(SearchHistory searchHistory);  
        Task<List<SearchHistory>> GetSearchHistoryAsync(string searchQuery = null, int limit = 10);  
    }
}
