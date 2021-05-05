using System;
using System.Collections.Generic;
using System.Globalization;
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

            //List all the cities stored in the database including weather and news object.
            List<City> dbCities = await _context.Cities.Include(c => c.Weather).Include(c => c.News).ToListAsync();
            serviceResponse.Data = (dbCities.Select(c => _mapper.Map<GetCityDto>(c))).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetCityDto>> GetCityById(string name)
        {
            ServiceResponse<GetCityDto> ServiceResponse = new ServiceResponse<GetCityDto>();
            var city_name_prop = Regex
                        .Replace(name.Normalize(System.Text.NormalizationForm.FormD), @"[^a-zA-z0-9 ]+", "");
            city_name_prop = (CultureInfo.InvariantCulture.TextInfo.ToTitleCase(city_name_prop));
            var dbCity = await _context.Cities
                        .Include(c => c.Weather)
                        .Include(c => c.News)
                        .FirstOrDefaultAsync(city => city.City_Name == city_name_prop);
            //After getting the city, we need to save the city to the search history, so we create a new object of type searchHistory 
            //with the id of the city searched, that will become an item in the searchHistory database
            try{
                SearchHistory newHistory = new SearchHistory{
                    CityId = dbCity.Id
                };
                _context.SearchHistory.Add(newHistory);
                await _context.SaveChangesAsync();
            }
            catch(Exception ex){
                ServiceResponse.Message = ex.Message;
            }
            ServiceResponse.Data = _mapper.Map<GetCityDto>(dbCity);
            return ServiceResponse;
        }

    }
}