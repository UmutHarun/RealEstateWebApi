using Dapper;
using RealEstateWebApi.Dtos.CategoryDtos;
using RealEstateWebApi.Dtos.EmployeeDtos;
using RealEstateWebApi.Models.DapperContext;

namespace RealEstateWebApi.Repositories.EmployeeRepository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly Context _context;

        public EmployeeRepository(Context context)
        {
            _context = context;
        }

        public async void AddEmployeeAsync(CreateEmployeeDto createEmployeeDto)
        {
            string query = "insert into Employee (Name,Title,Mail,PhoneNumber,ImageUrl,Status) values (@name,@title,@mail,@phoneNumber,@imageUrl,@status)";
            var parameters = new DynamicParameters();
            parameters.Add("@Name", createEmployeeDto.Title);
            parameters.Add("@title", createEmployeeDto.Title);
            parameters.Add("@mail", createEmployeeDto.Title);
            parameters.Add("@phoneNumber", createEmployeeDto.Title);
            parameters.Add("@imageUrl", createEmployeeDto.Title);
            parameters.Add("@status", true);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteEmployeeAsync(int id)
        {
            string query = "Delete From Employee Where EmployeeId=@employeeId";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeId", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultEmployeeDto>> GetAllEmployeesAsync()
        {
            string query = "Select * From Employee";
            using var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultEmployeeDto>(query);
            return values.ToList();
        }

        public async Task<ResultEmployeeDto> GetEmployeeByIdAsync(int id)
        {
            string query = "Select * From Employee where EmployeeId=@employeeId";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeId", id);
            using (var connection = _context.CreateConnection())
            {
                var value = await connection.QueryFirstOrDefaultAsync<ResultEmployeeDto>(query, parameters);
                return value;
            }
        }

        public async void UpdateEmployeeAsync(UpdateEmployeeDto updateEmployeeDto)
        {
            string query = "Update Employee Set Name=@name,Title=@title,Title=@title,Mail=@mail,PhoneNumber=@phoneNumber,ImageUrl=@imageUrl,Status=@status where EmployeeId=@employeeId";
            var parameters = new DynamicParameters();
            parameters.Add("@name", updateEmployeeDto.Name);
            parameters.Add("@title", updateEmployeeDto.Title);
            parameters.Add("@mail", updateEmployeeDto.Mail);
            parameters.Add("@phoneNumber", updateEmployeeDto.PhoneNumber);
            parameters.Add("@imageUrl", updateEmployeeDto.ImageUrl);
            parameters.Add("@status", updateEmployeeDto.Status);
            parameters.Add("@employeeId", updateEmployeeDto.EmployeeId);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
