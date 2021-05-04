using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewsweatherAPI.Data;
using NewsweatherAPI.Models;

namespace NewsweatherAPI.Services.CityService
{
    public class CityService : ICityService
    {
        private readonly DataContext _context;
        public CityService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<City>>> GetAllCities(){
            var ServiceResponse = new ServiceResponse<List<City>>();
            var dbCities = await _context.City.ToListAsync();
            ServiceResponse.Data = dbCities;
            return ServiceResponse;
        }

        public async Task<ServiceResponse<City>> GetCityById(string name){
            
            var ServiceResponse = new ServiceResponse<City>();
            var city_name_prop = Regex.Replace(name.Normalize(System.Text.NormalizationForm.FormD), @"[^a-zA-z0-9 ]+", "");
            var dbCity = await _context.City.FirstOrDefaultAsync(city => city.city_name == city_name_prop);
            ServiceResponse.Data = dbCity;
            return ServiceResponse;
        }

    }
}