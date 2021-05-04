using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewsweatherAPI.Dtos.City;
using NewsweatherAPI.Dtos.Weather;
using NewsweatherAPI.Models;
using NewsweatherAPI.Services.WeatherService;

namespace NewsweatherAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : ControllerBase
    {
        private readonly IWeatherService _weatherService;
        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;

        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<GetCityDto>>> AddWeather(AddWeatherDto newWeather){
            return Ok(await _weatherService.AddWeather(newWeather));
        }

    }
}