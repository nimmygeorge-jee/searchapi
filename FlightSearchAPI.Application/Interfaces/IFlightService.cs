﻿using FlightSearchAPI.Core.DTOs;
using FlightSearchAPI.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSearchAPI.Application.Interfaces
{
    public interface IFlightService
    {
        Task<SearchResultDTO> SearchFlightsAsync(FlightSearchCriteria criteria);
    }
}
