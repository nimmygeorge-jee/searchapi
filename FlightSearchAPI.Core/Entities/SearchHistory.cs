using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSearchAPI.Core.Entities
{
    public class SearchHistory
    {
        public int Id { get; set; }
        public string SearchQuery { get; set; }  
        public string SearchResults { get; set; }  
        public DateTime SearchDate { get; set; } 
    }

}
