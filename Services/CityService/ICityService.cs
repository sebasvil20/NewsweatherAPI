using System.Collections.Generic;
using System.Threading.Tasks;
using NewsweatherAPI.Dtos.City;
using NewsweatherAPI.Models;

namespace NewsweatherAPI.Services.CityService
{
    public interface ICityService
    {
        Task<ServiceResponse<List<GetCityDto>>> GetAllCities();
        Task<ServiceResponse<GetCityDto>> GetCityById(string name);
    }
}