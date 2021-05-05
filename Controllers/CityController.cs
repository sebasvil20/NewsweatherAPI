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

        //Constructor to initilize the Controller with cityService object
        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }

        //Method to list all the cities saved in the database, 
        //it use the city service and the method of it

        //EndPoint: /City/GetAllCities
        [HttpGet("GetAllCities")]
        public async Task<ActionResult<ServiceResponse<List<GetCityDto>>>> Get(){
            return Ok(await _cityService.GetAllCities());
        }


        //Method to search for certain city, it receives the name of the city

        //EndPoint: /City/{name}
        [HttpGet("{name}")]
        public async Task<ActionResult<ServiceResponse<GetCityDto>>> GetCityById(string name){
            return Ok(await _cityService.GetCityById(name));
        }
    }
}