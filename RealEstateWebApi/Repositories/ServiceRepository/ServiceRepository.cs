using Dapper;
using RealEstateWebApi.Dtos.CategoryDtos;
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

        public void AddServiceAsync(AddServiceDto addServiceDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteServiceAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultServiceDto>> GetAllServicesAsync()
        {
            string query = "Select * From Service";
            using var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultServiceDto>(query);
            return values.ToList();
        }

        public Task<ResultServiceDto> GetServiceByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateServiceAsync(UpdateServiceDto updateServiceDto)
        {
            throw new NotImplementedException();
        }
    }
}
