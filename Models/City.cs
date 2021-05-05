using System.Collections.Generic;

namespace NewsweatherAPI.Models
{
    public class City
    {
        public int Id { get; set; }
        public string City_Name { get; set; }
        public string City_Population { get; set; }
        public Weather Weather { get; set; }
        public List<News> News {get; set;}
        public int? SearchHistoryId { get; set; }
        public SearchHistory SearchHistory { get; set; }
    }
}