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

        public async void AddPopularLocationAsync(AddPopularLocationDto addPopularLocationDto)
        {
            string query = "insert into PopularLocation (CityName,ImageUrl) values (@cityName,@imageUrl)";
            var parameters = new DynamicParameters();
            parameters.Add("@cityName", addPopularLocationDto.CityName);
            parameters.Add("@imageUrl", addPopularLocationDto.ImageUrl);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeletePopularLocationAsync(int id)
        {
            string query = "Delete From PopularLocation Where LocationId=@locationId";
            var parameters = new DynamicParameters();
            parameters.Add("@locationId", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultPopularLocationDto>> GetAllPopularLocationsAsync()
        {
            string query = "Select * From PopularLocation";
            using var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultPopularLocationDto>(query);
            return values.ToList();
        }

        public async Task<ResultPopularLocationDto> GetPopularLocationByIdAsync(int id)
        {
            string query = "Select * From PopularLocation where LocationId=@locationId";
            var parameters = new DynamicParameters();
            parameters.Add("@locationId", id);
            using (var connection = _context.CreateConnection())
            {
                var value = await connection.QueryFirstOrDefaultAsync<ResultPopularLocationDto>(query, parameters);
                return value;
            }
        }

        public async void UpdatePopularLocationAsync(UpdatePopularLocationDto updatePopularLocationDto)
        {
            string query = "Update PopularLocation Set CityName=@cityName,ImageUrl=@imageUrl where LocationId=@locationId";
            var parameters = new DynamicParameters();
            parameters.Add("@cityName", updatePopularLocationDto.CityName);
            parameters.Add("@imageUrl", updatePopularLocationDto.ImageUrl);
            parameters.Add("@locationId", updatePopularLocationDto.LocationId);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
