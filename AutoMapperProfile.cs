using AutoMapper;
using NewsweatherAPI.Dtos.City;
using NewsweatherAPI.Dtos.News;
using NewsweatherAPI.Dtos.Weather;
using NewsweatherAPI.Models;

namespace dotnet_rpg
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<City, GetCityDto>();
            CreateMap<Weather, GetWeatherDto>();
            CreateMap<News, GetNewsDto>();
        }
    }
}