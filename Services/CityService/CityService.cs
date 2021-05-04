using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NewsweatherAPI.Data;
using NewsweatherAPI.Dtos.City;
using NewsweatherAPI.Models;

namespace NewsweatherAPI.Services.CityService
{
    public class CityService : ICityService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public CityService(DataContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<ServiceResponse<List<GetCityDto>>> GetAllCities()
        {
            ServiceResponse<List<GetCityDto>> serviceResponse = new ServiceResponse<List<GetCityDto>>();
            List<City> dbCities = await _context.Cities.Include(c => c.Weather).ToListAsync();
            serviceResponse.Data = (dbCities.Select(c => _mapper.Map<GetCityDto>(c))).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetCityDto>> GetCityById(string name)
        {

            ServiceResponse<GetCityDto> ServiceResponse = new ServiceResponse<GetCityDto>();
            var city_name_prop = Regex.Replace(name.Normalize(System.Text.NormalizationForm.FormD), @"[^a-zA-z0-9 ]+", "");
            var dbCity = await _context.Cities.FirstOrDefaultAsync(city => city.City_Name == city_name_prop);
            ServiceResponse.Data = _mapper.Map<GetCityDto>(dbCity);
            return ServiceResponse;
        }

    }
}