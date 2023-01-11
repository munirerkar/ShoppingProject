﻿using Business.Abstract;
using Entities.Concrete;
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
        public IActionResult CreateCategory(Product product)
        {
            _productService.CreateProduct(product);
            return Ok();
        }
        [HttpPost("Update")]
        public IActionResult UpdateCategory(Product product)
        {
            _productService.UpdateProduct(product);
            return Ok();
        }
        [HttpDelete("Delete")]
        public IActionResult DeleteCategory(Product product)
        {
            _productService.DeleteProduct(product);
            return Ok();
        }
    }
}