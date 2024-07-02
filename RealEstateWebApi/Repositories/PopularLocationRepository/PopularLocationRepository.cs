using Dapper;
using RealEstateWebApi.Dtos.CategoryDtos;
using RealEstateWebApi.Dtos.PopularLocationDtos;
using RealEstateWebApi.Models.DapperContext;

namespace RealEstateWebApi.Repositories.PopularLocationRepository
{
    public class PopularLocationRepository : IPopularLocationRepository
    {
        private readonly Context _context;

        public PopularLocationRepository(Context context)
        {
            _context = context;
        }

        public void AddPopularLocationAsync(AddPopularLocationDto addPopularLocationDto)
        {
            throw new NotImplementedException();
        }

        public void DeletePopularLocationAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultPopularLocationDto>> GetAllPopularLocationsAsync()
        {
            string query = "Select * From PopularLocation";
            using var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultPopularLocationDto>(query);
            return values.ToList();
        }

        public Task<ResultPopularLocationDto> GetPopularLocationByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdatePopularLocationAsync(UpdatePopularLocationDto updatePopularLocationDto)
        {
            throw new NotImplementedException();
        }
    }
}
