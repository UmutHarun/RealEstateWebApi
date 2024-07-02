using Dapper;
using RealEstateWebApi.Dtos.BottomGridDtos;
using RealEstateWebApi.Dtos.CategoryDtos;
using RealEstateWebApi.Models.DapperContext;

namespace RealEstateWebApi.Repositories.BottomGridRepository
{
    public class BottomGridRepository : IBottomGridRepository
    {
        private readonly Context _context;

        public BottomGridRepository(Context context)
        {
            _context = context;
        }

        public void AddBottomGridAsync(AddBottomGridDto addBottomGridDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteBottomGridAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultBottomGridDto>> GetAllBottomGridsAsync()
        {
            string query = "Select * From BottomGrid";
            using var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultBottomGridDto>(query);
            return values.ToList();
        }

        public Task<ResultBottomGridDto> GetBottomGridByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateBottomGridAsync(UpdateBottomGridDto updateBottomGridDto)
        {
            throw new NotImplementedException();
        }
    }
}
