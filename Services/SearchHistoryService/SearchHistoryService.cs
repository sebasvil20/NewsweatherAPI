using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NewsweatherAPI.Data;
using NewsweatherAPI.Dtos.History;
using NewsweatherAPI.Models;

namespace NewsweatherAPI.Services.SearchHistoryService
{
    public class SearchHistoryService : ISearchHistoryService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public SearchHistoryService(DataContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<ServiceResponse<List<GetSearchHistoryDto>>> GetHistory()
        {
            ServiceResponse<List<GetSearchHistoryDto>> serviceResponse = new ServiceResponse<List<GetSearchHistoryDto>>();
            List<SearchHistory> dbHistory = await _context.SearchHistory.Include(c => c.Cities).ToListAsync();
            serviceResponse.Data = (dbHistory.Select(c => _mapper.Map<GetSearchHistoryDto>(c))).ToList();
            return serviceResponse;
        }
    }
}