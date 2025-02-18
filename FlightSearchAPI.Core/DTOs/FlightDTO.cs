using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSearchAPI.Core.DTOs
{
    public class FlightDTO
    {
        public int Id { get; set; }
        public string Airline { get; set; }
        public string Departure { get; set; }
        public string Arrival { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public decimal Price { get; set; }
        public int BookingCount { get; set; }
    }

    public class SearchResultDTO
    {
        public List<FlightDTO> Flights { get; set; }
        public int TotalCount { get; set; }
    }
}
