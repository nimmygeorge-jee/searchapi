using FlightSearchAPI.Application.Interfaces;
using FlightSearchAPI.Core.Entities;
using FlightSearchAPI.Core.Models;

namespace FlightSearchAPI.Application.SearchStrategies
{
        public class BasicSearchStrategy : IFlightSearchStrategy
        {
        public bool IsSortingStrategy => false;

        public bool IsApplicable(string sortBy) => true; // Always applicable for filtering
        public IQueryable<Flight> ApplySearchCriteria(IQueryable<Flight> flights, FlightSearchCriteria criteria)
            {
                if (!string.IsNullOrEmpty(criteria.Query))
                {
                   flights = flights.Where(f => f.Airline.ToLower().Contains(criteria.Query.ToLower()) ||
                             f.Departure.ToLower().Contains(criteria.Query.ToLower()) ||
                             f.Arrival.ToLower().Contains(criteria.Query.ToLower()));

                }

                if (!string.IsNullOrEmpty(criteria.Departure))
                {
                    flights = flights.Where(f => f.Departure == criteria.Departure);
                }

                if (!string.IsNullOrEmpty(criteria.Arrival))
                {
                    flights = flights.Where(f => f.Arrival == criteria.Arrival);
                }

                if (criteria.DepartureDate.HasValue)
                {
                    flights = flights.Where(f => f.DepartureTime.Date == criteria.DepartureDate.Value.Date);
                }

                return flights;
            }
        }

}
