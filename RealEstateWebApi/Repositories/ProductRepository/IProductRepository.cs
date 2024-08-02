using RealEstateWebApi.Dtos.ProductDtos;

namespace RealEstateWebApi.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllProductsAsync();
        Task<List<ResultProductAdvertListWithCategoryByEmployee>> GetProductAdvertListByEmployeeAsync(int id);
        Task<List<ResultProductWithCategoryDto>> GetAllProductsWithCategoryAsync();
        void ProductDealOfTheDayStatusChange(int id);
        Task<List<ResultLast5ProductWithCategoryDto>> GetLast5ProductAsync();
    }
}
