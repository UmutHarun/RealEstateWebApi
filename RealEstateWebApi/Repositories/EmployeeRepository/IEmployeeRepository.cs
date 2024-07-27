using RealEstateWebApi.Dtos.EmployeeDtos;

namespace RealEstateWebApi.Repositories.EmployeeRepository
{
    public interface IEmployeeRepository
    {
        Task<List<ResultEmployeeDto>> GetAllEmployeesAsync();
        void AddEmployeeAsync(CreateEmployeeDto createEmployeeDto);
        void DeleteEmployeeAsync(int id);
        void UpdateEmployeeAsync(UpdateEmployeeDto updateEmployeeDto);
        Task<ResultEmployeeDto> GetEmployeeByIdAsync(int id);
    }
}
