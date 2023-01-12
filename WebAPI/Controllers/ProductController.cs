using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAllProductsNonDeleted()
        {
            var result = _productService.GetAllProductsNonDeleted();
            return Ok(result);
        }
        [HttpGet("GetAllDeleted")]
        public IActionResult GetAllCategoriesDeleted()
        {
            var result = _productService.GetAllProductsDeleted();
            return Ok(result);
        }
        [HttpPost("Add")]
        public IActionResult CreateCategory(ProductAddDto productAddDto)
        {
            _productService.CreateProduct(productAddDto);
            return Ok();
        }
        [HttpPost("Update")]
        public IActionResult UpdateCategory(ProductUpdateDto productUpdateDto)
        {
            _productService.UpdateProduct(productUpdateDto);
            return Ok();
        }
        [HttpDelete("Delete")]
        public IActionResult DeleteCategory(ProductDeleteDto productDeleteDto)
        {
            _productService.DeleteProduct(productDeleteDto);
            return Ok();
        }
    }
}
