using FlightSearchAPI.Core.Entities;
using FlightSearchAPI.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSearchAPI.Application.Interfaces
{
    public interface IFlightSearchStrategy
    {
        bool IsApplicable(string sortBy); // Check if strategy should be applied
        IQueryable<Flight> ApplySearchCriteria(IQueryable<Flight> flights, FlightSearchCriteria criteria);
        bool IsSortingStrategy { get; } //property to distinguish sorting strategies
    }
}
