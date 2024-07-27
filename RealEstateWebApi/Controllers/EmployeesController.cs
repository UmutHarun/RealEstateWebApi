using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Dtos.EmployeeDtos;
using RealEstateWebApi.Repositories.EmployeeRepository;

namespace RealEstateWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _EmployeeRepository;

        public EmployeesController(IEmployeeRepository EmployeeRepository)
        {
            _EmployeeRepository = EmployeeRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _EmployeeRepository.GetAllEmployeesAsync();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddEmployee(CreateEmployeeDto addEmployeeDto)
        {
            _EmployeeRepository.AddEmployeeAsync(addEmployeeDto);
            return Ok("Employee is added");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            _EmployeeRepository.DeleteEmployeeAsync(id);
            return Ok("Employee is deleted");
        }

        [HttpPut]
        public IActionResult UpdateEmployee(UpdateEmployeeDto updateEmployeeDto)
        {
            _EmployeeRepository.UpdateEmployeeAsync(updateEmployeeDto);
            return Ok("Employee is updated");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployee(int id)
        {
            var value = await _EmployeeRepository.GetEmployeeByIdAsync(id);
            return Ok(value);

        }
    }
}
