using Dapper;
using RealEstateWebApi.Dtos.PropertyAmenityDtos;
using RealEstateWebApi.Models.DapperContext;

namespace RealEstateWebApi.Repositories.PropertyAmenityRepository
{
    public class PropertyAmenityRepository : IPropertyAmenityRepository
    {
        private readonly Context _context;

        public PropertyAmenityRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultPropertyAmenityByTrueStatusDto>> GetResultPropertyAmenityByTrueStatus(int id)
        {
            string query = "Select PropertyAmenityId,Title From PropertyAmenity Inner Join Amenity On Amenity.AmenityId=PropertyAmenity.AmenityId Where PropertyId=@propertyId And Status=1";
            var parameters = new DynamicParameters();
            parameters.Add("@propertyId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultPropertyAmenityByTrueStatusDto>(query, parameters);
                return values.ToList();
            }
        }
    }
}
