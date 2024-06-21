using RealEstateWebApi.Dtos.CategoryDtos;

namespace RealEstateWebApi.Repositories.CategoryRepository
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDto>> GetAllCategoriesAsync();
        void AddCategoryAsync(AddCategoryDto addCategoryDto);
        void DeleteCategoryAsync(int id);   
        void UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto);
        Task<ResultCategoryDto> GetCategoryByIdAsync(int id);
    }
}
