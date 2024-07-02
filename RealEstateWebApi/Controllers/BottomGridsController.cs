using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    }
}
