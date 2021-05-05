using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewsweatherAPI.Dtos.History;
using NewsweatherAPI.Models;
using NewsweatherAPI.Services.SearchHistoryService;

namespace NewsweatherAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SearchHistoryController : ControllerBase
    {
        private readonly ISearchHistoryService _historyService;

        public SearchHistoryController(ISearchHistoryService historyService)
        {
            _historyService = historyService;
        }
        
        //Method to list all histories

        //EndPoint: /SearchHistory/GetHistory
        [HttpGet("GetHistory")]
        public async Task<ActionResult<ServiceResponse<List<GetSearchHistoryDto>>>> Get(){
            return Ok(await _historyService.GetHistory());
        }
    }
}