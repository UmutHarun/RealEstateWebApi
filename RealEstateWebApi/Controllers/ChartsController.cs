using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Repositories.EstateAgentRepositories.DashboardRepositories.ChartRepositories;

namespace RealEstateWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChartsController : ControllerBase
    {
        private readonly IChartRepository _chartRepository;

        public ChartsController(IChartRepository chartRepository)
        {
            _chartRepository = chartRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get5CityForChart()
        {
            return Ok(await _chartRepository.Get5CityForChart());
        }
    }
}
