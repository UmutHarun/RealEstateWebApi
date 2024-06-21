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
            string query = "insert into Category (Name,Status) values (@Name,@Status)";
            var parameters = new DynamicParameters();
            parameters.Add("@Name", addCategoryDto.Name);
            parameters.Add("@Status", true);
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
            //using (var connection = _context.CreateConnection()) 
            //{
            //    var values = await connection.QueryAsync<ResultCategoryDto>(query);
            //    return values.ToList();
            //}

            using var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultCategoryDto>(query);
            return values.ToList();
        }

        public async void UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto)
        {
            string query = "Update Category Set Name=@Name,Status=@Status where CategoryId=@categoryId";
            var parameters = new DynamicParameters();
            parameters.Add("@Name", updateCategoryDto.Name);
            parameters.Add("@Status", updateCategoryDto.Status);
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
