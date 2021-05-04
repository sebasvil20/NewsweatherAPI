using System.Threading.Tasks;
using NewsweatherAPI.Dtos.City;
using NewsweatherAPI.Dtos.Weather;
using NewsweatherAPI.Models;

namespace NewsweatherAPI.Services.WeatherService
{
    public interface IWeatherService
    {
         Task<ServiceResponse<GetCityDto>> AddWeather(AddWeatherDto newWeather);
    }
}