using System.Collections.Generic;
using NewsweatherAPI.Dtos.City;

namespace NewsweatherAPI.Dtos.History
{
    public class GetSearchHistoryDto
    {
        public GetCityDto City {get; set;}
    }
}