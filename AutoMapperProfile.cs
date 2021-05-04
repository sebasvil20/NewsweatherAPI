using AutoMapper;
using NewsweatherAPI.Dtos.City;
using NewsweatherAPI.Dtos.Weather;
using NewsweatherAPI.Models;

namespace dotnet_rpg
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<City, GetCityDto>();
            CreateMap<AddWeatherDto, Weather>();
            CreateMap<Weather, GetWeatherDto>();
        }
    }
}