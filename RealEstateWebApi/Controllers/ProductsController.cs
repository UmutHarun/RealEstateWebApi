using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Dtos.ProductDtos;
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

        [HttpGet("ProductAdvertsListByEmployeeIdTrueStatus")]
        public async Task<IActionResult> GetProductAdvertsListByEmployeeIdTrueStatus(int id)
        {
            var values = await _productRepository.GetProductAdvertListByEmployeeAsyncByTrue(id);
            return Ok(values);
        }

        [HttpGet("ProductAdvertsListByEmployeeIdFalseStatus")]
        public async Task<IActionResult> GetProductAdvertsListByEmployeeIdFalseStatus(int id)
        {
            var values = await _productRepository.GetProductAdvertListByEmployeeAsyncByFalse(id);
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
        {
            await _productRepository.CreateProduct(createProductDto);
            return Ok("Advert is created");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id) 
        {
            var value = await _productRepository.GetProductById(id);
            return Ok(value);
        }

        [HttpGet("GetProductDetailByProductId/{id}")]
        public async Task<IActionResult> GetProductDetailByProductId(int id)
        {
            var value = await _productRepository.GetProductDetailByProductId(id);
            return Ok(value);
        }
    }
}
