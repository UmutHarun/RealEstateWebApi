using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Repositories.ProductRepository;

namespace RealEstateWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _productRepository.GetAllProductsWithCategoryAsync();
            return Ok(values);
        }

        [HttpGet("ProductDealOfTheDayStatusChange/{id}")]
        public async Task<IActionResult> ProductDealOfTheDayStatusChange(int id)
        {
            _productRepository.ProductDealOfTheDayStatusChange(id);
            return Ok("Status is changed");
        }

        [HttpGet("Last5ProductList")]
        public async Task<IActionResult> Last5ProductAsync()
        {
            var values = await _productRepository.GetLast5ProductAsync();
            return Ok(values);
        }
    }
}
