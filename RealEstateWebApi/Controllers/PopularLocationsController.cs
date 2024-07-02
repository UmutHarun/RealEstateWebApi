using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Repositories.PopularLocationRepository;

namespace RealEstateWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PopularLocationsController : ControllerBase
    {
        private readonly IPopularLocationRepository _popularLocationRepository;

        public PopularLocationsController(IPopularLocationRepository popularLocationRepository)
        {
            _popularLocationRepository = popularLocationRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _popularLocationRepository.GetAllPopularLocationsAsync();
            return Ok(values);
        }
    }
}
