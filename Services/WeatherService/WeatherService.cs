using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NewsweatherAPI.Data;
using NewsweatherAPI.Dtos.City;
using NewsweatherAPI.Dtos.Weather;
using NewsweatherAPI.Models;

namespace NewsweatherAPI.Services.WeatherService
{
    public class WeatherService : IWeatherService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public WeatherService(DataContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;

        }
        public async Task<ServiceResponse<GetCityDto>> AddWeather(AddWeatherDto newWeather)
        {
            var response = new ServiceResponse<GetCityDto>();
            try
            {
                var city = await _context.Cities.FirstOrDefaultAsync(c => c.Id == newWeather.CityId);
                var weather = new Weather
                {
                    Weather_Time = newWeather.Weather_Time,
                    Temperature = newWeather.Temperature,
                    Weather_Description = newWeather.Weather_Description,
                    Wind_Speed = newWeather.Wind_Speed,
                    Wind_Degree = newWeather.Wind_Degree,
                    Wind_Direction = newWeather.Wind_Direction,
                    Presure = newWeather.Presure,
                    City = city
                };
                _context.Weather.Add(weather);
                await _context.SaveChangesAsync();
                response.Data = _mapper.Map<GetCityDto>(city);
            }
            catch (Exception ex)
            {
                response.Sucess = false;
                response.Message = ex.Message;
            }
            return response;

        }
    }
}