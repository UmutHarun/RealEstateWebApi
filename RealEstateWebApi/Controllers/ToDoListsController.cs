using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Repositories.ContactRepository;
using RealEstateWebApi.Repositories.ToDoListRepository;

namespace RealEstateWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoListsController : ControllerBase
    {
        private readonly IToDoListRepository _toDoListRepository;

        public ToDoListsController(IToDoListRepository toDoListRepository)
        {
            _toDoListRepository = toDoListRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _toDoListRepository.GetAllToDoListsAsync();
            return Ok(values);
        }
    }
}
