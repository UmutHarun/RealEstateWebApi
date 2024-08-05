using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Repositories.EstateAgentRepositories.DashboardRepositories.StatisticRepositories;
using RealEstateWebApi.Repositories.StatisticRepository;

namespace RealEstateWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstateAgentDashboardController : Controller
    {
        private readonly IAgentStatisticRepository _agentStatisticRepository;

        public EstateAgentDashboardController(IAgentStatisticRepository agentStatisticRepository)
        {
            _agentStatisticRepository = agentStatisticRepository;
        }

        [HttpGet("AllProductCount")]
        public IActionResult AllProductCount()
        {
            return Ok(_agentStatisticRepository.AllProductCount());
        }

        [HttpGet("ProductCountByEmployeeId")]
        public IActionResult ProductCountByEmployeeId(int id)
        {
            return Ok(_agentStatisticRepository.ProductCountByEmployeeId(id));
        }

        [HttpGet("ProductCountByFalseStatus")]
        public IActionResult ProductCountByFalseStatus(int id)
        {
            return Ok(_agentStatisticRepository.ProductCountByFalseStatus(id));
        }

        [HttpGet("ProductCountByTrueStatus")]
        public IActionResult ProductCountByTrueStatus(int id)
        {
            return Ok(_agentStatisticRepository.ProductCountByTrueStatus(id));
        }
    }
}
