using FlightSearchAPI.Application.Interfaces;
using FlightSearchAPI.Core.Entities;
using FlightSearchAPI.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FlightSearchAPI.Application.SearchStrategies
{
    public class PriceSortStrategy : IFlightSearchStrategy
    {
        public bool IsSortingStrategy => true; // This is a sorting strategy

        public bool IsApplicable(string sortBy) => sortBy?.ToLower() == "Price";

        public IQueryable<Flight> ApplySearchCriteria(IQueryable<Flight> flights, FlightSearchCriteria criteria)
        {
          var data = flights.OrderByDescending(f => f.Price);
            return data;
        }
    }
}
