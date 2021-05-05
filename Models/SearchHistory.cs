using System.Collections.Generic;

namespace NewsweatherAPI.Models
{
    public class SearchHistory
    {
        public int Id { get; set; }
        public List<City> Cities {get; set;}
    }
}