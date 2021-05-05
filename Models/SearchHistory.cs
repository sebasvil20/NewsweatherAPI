using System.Collections.Generic;

namespace NewsweatherAPI.Models
{
    public class SearchHistory
    {
        public int Id { get; set; }
        public string HistoryName { get; set; } = "New history";
        public int? CityId {get; set;}
        public City City {get; set;}
    }
}