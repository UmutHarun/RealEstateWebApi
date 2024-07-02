using Dapper;
using RealEstateWebApi.Dtos.ProductDtos;
using RealEstateWebApi.Models.DapperContext;

namespace RealEstateWebApi.Repositories.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;

        public ProductRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultProductDto>> GetAllProductsAsync()
        {
            string query = "Select * From Product";
            using (var connection = _context.CreateConnection()) 
            {
                var values = await connection.QueryAsync<ResultProductDto>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultProductWithCategoryDto>> GetAllProductsWithCategoryAsync()
        {
            string query = @"
                SELECT 
                    p.ProductId,
                    p.Title,
                    p.Price,
                    p.City,
                    p.District,
                    p.CoverImage,
                    p.Type,
                    p.Address,
                    c.CategoryName 
                FROM Product p
                INNER JOIN Category c ON p.ProductCategory = c.CategoryId";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductWithCategoryDto>(query);
                return values.ToList();
            }
        }
    }
}
