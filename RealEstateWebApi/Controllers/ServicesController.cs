using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Dtos.ServiceDtos;
using RealEstateWebApi.Repositories.ServiceRepository;

namespace RealEstateWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IServiceRepository _serviceRepository;

        public ServicesController(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _serviceRepository.GetAllServicesAsync();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddService(AddServiceDto addServiceDto)
        {
            _serviceRepository.AddServiceAsync(addServiceDto);
            return Ok("Service is added");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteService(int id)
        {
            _serviceRepository.DeleteServiceAsync(id);
            return Ok("Service is deleted");
        }

        [HttpPut]
        public IActionResult UpdateService(UpdateServiceDto updateServiceDto)
        {
            _serviceRepository.UpdateServiceAsync(updateServiceDto);
            return Ok("Service is updated");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetService(int id)
        {
            var value = await _serviceRepository.GetServiceByIdAsync(id);
            return Ok(value);

        }
    }
}
