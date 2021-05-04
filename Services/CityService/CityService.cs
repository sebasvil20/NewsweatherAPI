using System.Collections.Generic;
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

    }
}