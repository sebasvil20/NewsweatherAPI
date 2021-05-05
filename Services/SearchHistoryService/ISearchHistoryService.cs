using System.Collections.Generic;
using System.Threading.Tasks;
using NewsweatherAPI.Dtos.History;
using NewsweatherAPI.Models;

namespace NewsweatherAPI.Services.SearchHistoryService
{
    public interface ISearchHistoryService
    {
        Task<ServiceResponse<List<GetSearchHistoryDto>>> GetHistory();
    }
}