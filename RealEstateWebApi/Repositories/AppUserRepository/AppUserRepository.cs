using Dapper;
using RealEstateWebApi.Dtos.AppUserDtos;
using RealEstateWebApi.Models.DapperContext;

namespace RealEstateWebApi.Repositories.AppUserRepository
{
    public class AppUserRepository : IAppUserRepository
    {
        private readonly Context _context;

        public AppUserRepository(Context context)
        {
            _context = context;
        }

        public async Task<GetAppUserByProductId> GetAppUserByProductId(int id)
        {
            string query = "Select * From AppUser Where UserId=@UserId";
            var parameters = new DynamicParameters();
            parameters.Add("@UserId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetAppUserByProductId>(query, parameters);
                return values;
            }
        }
    }
}
