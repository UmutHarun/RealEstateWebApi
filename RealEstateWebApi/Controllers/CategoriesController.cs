using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Dtos.CategoryDtos;
using RealEstateWebApi.Repositories.CategoryRepository;

namespace RealEstateWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoriesController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Index() 
        {
            var values = await _categoryRepository.GetAllCategoriesAsync();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddCategory(AddCategoryDto addCategoryDto)
        {
            _categoryRepository.AddCategoryAsync(addCategoryDto);
            return Ok("Category is added");
        }

        [HttpDelete]
        public IActionResult DeleteCategory(int id) 
        {
            _categoryRepository.DeleteCategoryAsync(id);
            return Ok("Category is deleted");
        }

        [HttpPut]
        public IActionResult UpdateCategory(UpdateCategoryDto updateCategoryDto) 
        {
            _categoryRepository.UpdateCategoryAsync(updateCategoryDto);
            return Ok("Category is updated");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(int id) 
        {
            var value = await _categoryRepository.GetCategoryByIdAsync(id);
            return Ok(value);

        }
    }
}
