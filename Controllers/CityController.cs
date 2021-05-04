using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewsweatherAPI.Dtos.City;
using NewsweatherAPI.Models;
using NewsweatherAPI.Services.CityService;

namespace NewsweatherAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CityController : ControllerBase
    {

        private readonly ICityService _cityService;

        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }

        [HttpGet("GetAllCities")]
        public async Task<ActionResult<ServiceResponse<List<GetCityDto>>>> Get(){
            return Ok(await _cityService.GetAllCities());
        }

        
        [HttpGet("{name}")]
        public async Task<ActionResult<ServiceResponse<GetCityDto>>> GetCityById(string name){
            return Ok(await _cityService.GetCityById(name));
        }
    }
}