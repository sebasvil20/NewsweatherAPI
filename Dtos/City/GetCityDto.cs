using NewsweatherAPI.Dtos.Weather;
using NewsweatherAPI.Models;

namespace NewsweatherAPI.Dtos.City
{
    public class GetCityDto
    {
        public int Id { get; set; }
        public string City_Name { get; set; }
        public string City_Population { get; set; }
        public GetWeatherDto Weather {get; set;}
    }
}