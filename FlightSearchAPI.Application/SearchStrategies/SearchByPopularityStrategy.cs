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
    public class SearchByPopularityStrategy : IFlightSearchStrategy
    {
        public bool IsSortingStrategy => true; // This is a sorting strategy

        public bool IsApplicable(string sortBy) => sortBy?.ToLower() == "Popularity";

        public IQueryable<Flight> ApplySearchCriteria(IQueryable<Flight> flights, FlightSearchCriteria criteria)
        {
            return flights.OrderByDescending(f => f.SearchCount);
        }
    }
}
