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
                    p.DealOfTheDay,
                    c.CategoryName 
                FROM Product p
                INNER JOIN Category c ON p.ProductCategory = c.CategoryId";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductWithCategoryDto>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultLast5ProductWithCategoryDto>> GetLast5ProductAsync()
        {
            string query = "Select Top(5) ProductID,Title,Price,City,District,ProductCategory,CategoryName " +
                "From Product Inner Join Category On Product.ProductCategory=Category.CategoryID Where Type='Kiralık' Order By ProductID Desc";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultLast5ProductWithCategoryDto>(query);
                return values.ToList();
            }
        }

        public async void ProductDealOfTheDayStatusChange(int id)
        {
            string query = @"
                UPDATE Product
                SET DealOfTheDay = CASE 
                    WHEN DealOfTheDay = 1 THEN 0
                    ELSE 1
                END
                WHERE ProductId = @productId";
            var parameters = new DynamicParameters();
            parameters.Add("@productId", id);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
