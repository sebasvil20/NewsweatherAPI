using System.Collections.Generic;
using NewsweatherAPI.Dtos.City;

namespace NewsweatherAPI.Dtos.History
{
    public class GetSearchHistoryDto
    {
        public List<GetCityDto> Cities {get; set;}
    }
}