using System.Collections.Generic;
using System.Threading.Tasks;
using NewsweatherAPI.Models;

namespace NewsweatherAPI.Services.CityService
{
    public interface ICityService
    {
        Task<ServiceResponse<List<City>>> GetAllCities();
        Task<ServiceResponse<City>> GetCityById(string name);
    }
}