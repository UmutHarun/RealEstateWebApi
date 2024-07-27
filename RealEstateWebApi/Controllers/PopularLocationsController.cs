using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Dtos.PopularLocationDtos;
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

        [HttpPost]
        public IActionResult AddPopularLocation(AddPopularLocationDto addPopularLocationDto)
        {
            _popularLocationRepository.AddPopularLocationAsync(addPopularLocationDto);
            return Ok("PopularLocation is added");
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePopularLocation(int id)
        {
            _popularLocationRepository.DeletePopularLocationAsync(id);
            return Ok("PopularLocation is deleted");
        }

        [HttpPut]
        public IActionResult UpdatePopularLocation(UpdatePopularLocationDto updatePopularLocationDto)
        {
            _popularLocationRepository.UpdatePopularLocationAsync(updatePopularLocationDto);
            return Ok("PopularLocation is updated");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPopularLocation(int id)
        {
            var value = await _popularLocationRepository.GetPopularLocationByIdAsync(id);
            return Ok(value);

        }
    }
}
