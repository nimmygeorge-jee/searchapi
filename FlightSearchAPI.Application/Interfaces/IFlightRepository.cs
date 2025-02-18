using FlightSearchAPI.Core.Entities;
using FlightSearchAPI.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSearchAPI.Application.Interfaces
{
   

    public interface IFlightRepository
    {
        Task<IQueryable<Flight>> SearchAsync(FlightSearchCriteria criteria);
        Task IncrementSearchCountAsync(List<int> flightIds);
    }
}
