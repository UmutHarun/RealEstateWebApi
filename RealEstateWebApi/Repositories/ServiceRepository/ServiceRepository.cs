using Dapper;
using RealEstateWebApi.Dtos.CategoryDtos;
using RealEstateWebApi.Dtos.EmployeeDtos;
using RealEstateWebApi.Dtos.ServiceDtos;
using RealEstateWebApi.Models.DapperContext;

namespace RealEstateWebApi.Repositories.ServiceRepository
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly Context _context;

        public ServiceRepository(Context context)
        {
            _context = context;
        }

        public async void AddServiceAsync(AddServiceDto addServiceDto)
        {
            string query = "insert into Service (ServiceName,ServiceStatus) values (@serviceName,@serviceStatus)";
            var parameters = new DynamicParameters();
            parameters.Add("@serviceName", addServiceDto.ServiceName);
            parameters.Add("@serviceStatus", true);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteServiceAsync(int id)
        {
            string query = "Delete From Service Where ServiceId=@serviceId";
            var parameters = new DynamicParameters();
            parameters.Add("@serviceId", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultServiceDto>> GetAllServicesAsync()
        {
            string query = "Select * From Service";
            using var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultServiceDto>(query);
            return values.ToList();
        }

        public async Task<ResultServiceDto> GetServiceByIdAsync(int id)
        {
            string query = "Select * From Service where ServiceId=@serviceId";
            var parameters = new DynamicParameters();
            parameters.Add("@serviceId", id);
            using (var connection = _context.CreateConnection())
            {
                var value = await connection.QueryFirstOrDefaultAsync<ResultServiceDto>(query, parameters);
                return value;
            }
        }

        public async void UpdateServiceAsync(UpdateServiceDto updateServiceDto)
        {
            string query = "Update Employee Set ServiceName=@serviceName,ServiceStatus=@serviceStatus where ServiceId=@serviceId";
            var parameters = new DynamicParameters();
            parameters.Add("@serviceName", updateServiceDto.ServiceName);
            parameters.Add("@ServiceStatus", updateServiceDto.ServiceStatus);
            parameters.Add("@serviceId", updateServiceDto.ServiceId);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
