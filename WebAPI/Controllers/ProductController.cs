using Business.Abstract;
using Core.Utilities.Results;
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
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
            
        }
        [HttpGet("GetAllDeleted")]
        public IActionResult GetAllProductsDeleted()
        {
            var result = _productService.GetAllProductsDeleted();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Add")]
        public IActionResult CreateProduct(ProductAddDto productAddDto)
        {
            var result = _productService.CreateProduct(productAddDto);
            if (result.Success)
            {
                return Ok();
            }
            return BadRequest();
        }
        [HttpPost("Update")]
        public IActionResult UpdateProduct(ProductUpdateDto productUpdateDto)
        {
            var result = _productService.UpdateProduct(productUpdateDto);
            if (result.Success)
            {
                return Ok();
            }
            return BadRequest();
        }
        [HttpDelete("Delete")]
        public IActionResult DeleteProduct(ProductDeleteDto productDeleteDto)
        {
            var result = _productService.DeleteProduct(productDeleteDto);
            if (result.Success)
            {
                return Ok();
            }
            return BadRequest();
        }
        [HttpPost("SafeDelete")]
        public IActionResult SafeDeleteProduct(int productId)
        {
            var result = _productService.SafeDeleteProduct(productId);
            if (result.Success)
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}
