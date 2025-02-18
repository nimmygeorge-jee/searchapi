using FlightSearchAPI.Application.Interfaces;
using FlightSearchAPI.Core.Entities;
using FlightSearchAPI.Core.Models;
using FlightSearchAPI.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace FlightSearchAPI.Infrastructure.Repository
{
    public class SearchHistoryRepository : ISearchHistoryRepository
    {
        private readonly ApplicationDbContext _context;

        public SearchHistoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddSearchHistoryAsync(SearchHistory criteria)
        {

            _context.SearchHistories.Add(criteria);
            await _context.SaveChangesAsync();
        }

       
        public async Task<List<SearchHistory>> GetSearchHistoryAsync(string searchQuery = null, int limit = 10)
        {
            var query = _context.SearchHistories.AsQueryable();

            if (!string.IsNullOrEmpty(searchQuery))
            {
                query = query.Where(sh => sh.SearchQuery.Contains(searchQuery)); 
            }

            return await query.OrderByDescending(sh => sh.SearchDate)
                              .Take(limit)
                              .ToListAsync();
        }
    }
}
