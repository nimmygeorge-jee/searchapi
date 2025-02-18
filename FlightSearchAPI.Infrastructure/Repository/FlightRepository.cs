using FlightSearchAPI.Application.Interfaces;
using FlightSearchAPI.Core.Entities;
using FlightSearchAPI.Core.Models;
using FlightSearchAPI.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace FlightSearchAPI.Infrastructure.Repository
{
    public class FlightRepository : IFlightRepository
    {
        private readonly ApplicationDbContext _context;

        public FlightRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IQueryable<Flight>> SearchAsync(FlightSearchCriteria criteria)
        {
            var query = _context.Flights.AsQueryable();

            if (!string.IsNullOrEmpty(criteria.Query))
            {
                query = query.Where(f => f.Airline.ToLower().Contains(criteria.Query.ToLower()) ||
                          f.Departure.ToLower().Contains(criteria.Query.ToLower()) ||
                          f.Arrival.ToLower().Contains(criteria.Query.ToLower()));

            }

            if (!string.IsNullOrEmpty(criteria.Departure))
            {
                query = query.Where(f => f.Departure.ToLower().Contains(criteria.Departure.ToLower()));
            }

            if (!string.IsNullOrEmpty(criteria.Arrival))
            {
                query = query.Where(f => f.Arrival.ToLower().Contains(criteria.Arrival.ToLower()));
            }
            if (!string.IsNullOrEmpty(criteria.Airline))
            {
                query = query.Where(f => f.Arrival.ToLower().Contains(criteria.Airline.ToLower()));
            }


            return query;
        }
        public async Task IncrementSearchCountAsync(List<int> flightIds)
        {
            if (flightIds == null || !flightIds.Any())
                return;

            await _context.Flights
                .Where(f => flightIds.Contains(f.Id))
                .ExecuteUpdateAsync(setters =>
                    setters.SetProperty(f => f.SearchCount, f => f.SearchCount + 1));

        }

    }

}
