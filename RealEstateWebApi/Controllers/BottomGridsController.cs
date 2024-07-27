using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Dtos.BottomGridDtos;
using RealEstateWebApi.Repositories.BottomGridRepository;

namespace RealEstateWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BottomGridsController : ControllerBase
    {
        private readonly IBottomGridRepository _bottomGridRepository;

        public BottomGridsController(IBottomGridRepository bottomGridRepository)
        {
            _bottomGridRepository = bottomGridRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _bottomGridRepository.GetAllBottomGridsAsync();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddBottomGrid(AddBottomGridDto addBottomGridDto)
        {
            _bottomGridRepository.AddBottomGridAsync(addBottomGridDto);
            return Ok("BottomGrid is added");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBottomGrid(int id)
        {
            _bottomGridRepository.DeleteBottomGridAsync(id);
            return Ok("BottomGrid is deleted");
        }

        [HttpPut]
        public IActionResult UpdateBottomGrid(UpdateBottomGridDto updateBottomGridDto)
        {
            _bottomGridRepository.UpdateBottomGridAsync(updateBottomGridDto);
            return Ok("BottomGrid is updated");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBottomGrid(int id)
        {
            var value = await _bottomGridRepository.GetBottomGridByIdAsync(id);
            return Ok(value);

        }
    }
}
