using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Dtos.WhoWeAreDetailDtos;
using RealEstateWebApi.Repositories.WhoWeAreRepository;

namespace RealEstateWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhoWeAreDetailsController : ControllerBase
    {
        private readonly IWhoWeAreRepository _WhoWeAreDetailRepository;

        public  WhoWeAreDetailsController(IWhoWeAreRepository WhoWeAreDetailRepository)
        {
            _WhoWeAreDetailRepository = WhoWeAreDetailRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _WhoWeAreDetailRepository.GetAllWhoWeAreDetailsAsync();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddWhoWeAreDetail(AddWhoWeAreDetailDto addWhoWeAreDetailDto)
        {
            _WhoWeAreDetailRepository.AddWhoWeAreDetailAsync(addWhoWeAreDetailDto);
            return Ok("WhoWeAreDetail is added");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteWhoWeAreDetail(int id)
        {
            _WhoWeAreDetailRepository.DeleteWhoWeAreDetailAsync(id);
            return Ok("WhoWeAreDetail is deleted");
        }

        [HttpPut]
        public IActionResult UpdateWhoWeAreDetail(UpdateWhoWeAreDetailDto updateWhoWeAreDetailDto)
        {
            _WhoWeAreDetailRepository.UpdateWhoWeAreDetailAsync(updateWhoWeAreDetailDto);
            return Ok("WhoWeAreDetail is updated");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetWhoWeAreDetail(int id)
        {
            var value = await _WhoWeAreDetailRepository.GetWhoWeAreDetailByIdAsync(id);
            return Ok(value);

        }
    }
}
