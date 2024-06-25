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
    }
}
