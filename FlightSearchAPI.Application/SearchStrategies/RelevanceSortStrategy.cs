using FlightSearchAPI.Application.Interfaces;
using FlightSearchAPI.Core.Entities;
using FlightSearchAPI.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSearchAPI.Application.SearchStrategies
{
    public class RelevanceSortStrategy : IFlightSearchStrategy
    {
        public bool IsSortingStrategy => true; // This is a sorting strategy

        public bool IsApplicable(string sortBy) => sortBy?.ToLower() == "Relevance";

        public IQueryable<Flight> ApplySearchCriteria(IQueryable<Flight> flights, FlightSearchCriteria criteria)
        {
            var relevantFlights = flights;

            // Basic query matching
            if (!string.IsNullOrEmpty(criteria.Departure))
                relevantFlights = relevantFlights.Where(f => f.Departure.Contains(criteria.Departure));

            if (!string.IsNullOrEmpty(criteria.Arrival))
                relevantFlights = relevantFlights.Where(f => f.Arrival.Contains(criteria.Arrival));

            // Relevance could be a combination of price and booking count, for instance
            relevantFlights = relevantFlights.OrderBy(f => f.Price).ThenByDescending(f => f.SearchCount);

            return relevantFlights;
        }
    }
}
