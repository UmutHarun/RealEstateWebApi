using RealEstateWebApi.Dtos.ProductDtos;

namespace RealEstateWebApi.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllProductsAsync();
        Task<List<ResultProductWithCategoryDto>> GetAllProductsWithCategoryAsync();
        void ProductDealOfTheDayStatusChange(int id);
    }
}
