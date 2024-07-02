using Dapper;
using Microsoft.AspNetCore.Http.HttpResults;
using RealEstateWebApi.Dtos.CategoryDtos;
using RealEstateWebApi.Models.DapperContext;

namespace RealEstateWebApi.Repositories.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Context _context;

        public CategoryRepository(Context context)
        {
            _context = context;
        }

        public async void AddCategoryAsync(AddCategoryDto addCategoryDto)
        {
            string query = "insert into Category (CategoryName,CategoryStatus) values (@categoryName,@categoryStatus)";
            var parameters = new DynamicParameters();
            parameters.Add("@CategoryName", addCategoryDto.CategoryName);
            parameters.Add("@CategoryStatus", true);
            using (var connection = _context.CreateConnection()) 
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteCategoryAsync(int id)
        {
            string query = "Delete From Category Where CategoryId=@categoryId";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryId", id);
            using (var connection = _context.CreateConnection()) 
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultCategoryDto>> GetAllCategoriesAsync()
        {
            string query = "Select * From Category";
            using var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultCategoryDto>(query);
            return values.ToList();
        }

        public async void UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto)
        {
            string query = "Update Category Set CategoryName=@CategoryName,CategoryStatus=@CategoryStatus where CategoryId=@categoryId";
            var parameters = new DynamicParameters();
            parameters.Add("@CategoryName", updateCategoryDto.CategoryName);
            parameters.Add("@CategoryStatus", updateCategoryDto.CategoryStatus);
            parameters.Add("@categoryId", updateCategoryDto.CategoryId);
            using(var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<ResultCategoryDto> GetCategoryByIdAsync(int id)
        {
            string query = "Select * From Category where CategoryId=@categoryId";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryId", id);
            using (var connection = _context.CreateConnection())
            {
                var value = await connection.QueryFirstOrDefaultAsync<ResultCategoryDto>(query, parameters);
                return value;
            }
        }
    }
}
