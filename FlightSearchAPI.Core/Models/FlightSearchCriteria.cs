using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSearchAPI.Core.Models
{
    public class FlightSearchCriteria
    {
        public string? Query { get; set; }
        public string? Departure { get; set; }
        public string? Arrival { get; set; }
        public DateTime? DepartureDate { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public SortByOptions? SortBy { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public string? Airline { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static FlightSearchCriteria FromJson(string json)
        {
            return JsonConvert.DeserializeObject<FlightSearchCriteria>(json);
        }

        public enum SortByOptions
        {
            Price,
            Date,
            Relevance,
            Popularity
        }

    }


}
