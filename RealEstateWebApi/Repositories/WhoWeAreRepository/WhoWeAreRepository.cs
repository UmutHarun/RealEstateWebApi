using Dapper;
using RealEstateWebApi.Dtos.CategoryDtos;
using RealEstateWebApi.Dtos.WhoWeAreDetailDtos;
using RealEstateWebApi.Models.DapperContext;

namespace RealEstateWebApi.Repositories.WhoWeAreRepository
{
    public class WhoWeAreRepository : IWhoWeAreRepository
    {
        private readonly Context _context;

        public WhoWeAreRepository(Context context)
        {
            _context = context;
        }

        public async void AddWhoWeAreDetailAsync(AddWhoWeAreDetailDto addWhoWeAreDetailDto)
        {
            string query = "insert into WhoWeAreDetail (Title,Subtitle,Description1,Description2) values (@Title,@Subtitle,@Description1,@Description2)";
            var parameters = new DynamicParameters();
            parameters.Add("@Title", addWhoWeAreDetailDto.Title);
            parameters.Add("@Subtitle", addWhoWeAreDetailDto.Subtitle);
            parameters.Add("@Description1", addWhoWeAreDetailDto.Description1);
            parameters.Add("@Description2", addWhoWeAreDetailDto.Description2);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteWhoWeAreDetailAsync(int id)
        {
            string query = "Delete From WhoWeAreDetail Where WhoWeAreDetailId=@WhoWeAreDetailId";
            var parameters = new DynamicParameters();
            parameters.Add("@WhoWeAreDetailId", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultWhoWeAreDetailDto>> GetAllWhoWeAreDetailsAsync()
        {
            string query = "Select * From WhoWeAreDetail";
            //using (var connection = _context.CreateConnection()) 
            //{
            //    var values = await connection.QueryAsync<ResultCategoryDto>(query);
            //    return values.ToList();
            //}

            using var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultWhoWeAreDetailDto>(query);
            return values.ToList();
        }

        public async Task<ResultWhoWeAreDetailDto> GetWhoWeAreDetailByIdAsync(int id)
        {
            string query = "Select * From WhoWeAreDetail where WhoWeAreDetailId=@WhoWeAreDetailId";
            var parameters = new DynamicParameters();
            parameters.Add("@WhoWeAreDetailId", id);
            using (var connection = _context.CreateConnection())
            {
                var value = await connection.QueryFirstOrDefaultAsync<ResultWhoWeAreDetailDto>(query, parameters);
                return value;
            }
        }

        public async void UpdateWhoWeAreDetailAsync(UpdateWhoWeAreDetailDto updateWhoWeAreDetailDto)
        {
            string query = "Update WhoWeAreDetail Set Title=@Title,Subtitle=@Subtitle,Description1=@Description1,Description2=@Description2 where WhoWeAreDetailId=@WhoWeAreDetailId";
            var parameters = new DynamicParameters();
            parameters.Add("@Title", updateWhoWeAreDetailDto.Title);
            parameters.Add("@Subtitle", updateWhoWeAreDetailDto.Subtitle);
            parameters.Add("@Description1", updateWhoWeAreDetailDto.Description1);
            parameters.Add("@Description2", updateWhoWeAreDetailDto.Description2);
            parameters.Add("@WhoWeAreDetailId", updateWhoWeAreDetailDto.WhoWeAreDetailId);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
