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

        public async void AddBottomGridAsync(AddBottomGridDto addBottomGridDto)
        {
            string query = "insert into BottomGrid (Icon,Title,Description) values (@icon,@title,@description)";
            var parameters = new DynamicParameters();
            parameters.Add("@icon", addBottomGridDto.Icon);
            parameters.Add("@title", addBottomGridDto.Title);
            parameters.Add("@description", addBottomGridDto.Description);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteBottomGridAsync(int id)
        {
            string query = "Delete From BottomGrid Where BottomGridId=@bottomGridId";
            var parameters = new DynamicParameters();
            parameters.Add("@bottomGridId", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultBottomGridDto>> GetAllBottomGridsAsync()
        {
            string query = "Select * From BottomGrid";
            using var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultBottomGridDto>(query);
            return values.ToList();
        }

        public async Task<ResultBottomGridDto> GetBottomGridByIdAsync(int id)
        {
            string query = "Select * From BottomGrid where BottomGridId=@bottomGridId";
            var parameters = new DynamicParameters();
            parameters.Add("@bottomGridId", id);
            using (var connection = _context.CreateConnection())
            {
                var value = await connection.QueryFirstOrDefaultAsync<ResultBottomGridDto>(query, parameters);
                return value;
            }
        }

        public async void UpdateBottomGridAsync(UpdateBottomGridDto updateBottomGridDto)
        {
            string query = "Update BottomGrid Set Icon=@icon,Title=@title,Description=@description where BottomGridId=@bottomGridId";
            var parameters = new DynamicParameters();
            parameters.Add("@icon", updateBottomGridDto.Icon);
            parameters.Add("@title", updateBottomGridDto.Title);
            parameters.Add("@description", updateBottomGridDto.Description);
            parameters.Add("@bottomGridId", updateBottomGridDto.BottomGridId);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
