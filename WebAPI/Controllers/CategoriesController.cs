using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : Controller
    {
        ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAllCategoriesNonDeleted()
        {
            var result = _categoryService.GetAllCategoriesNonDeleted();
            return Ok(result);
        }
        [HttpGet("GetAllDeleted")]
        public IActionResult GetAllCategoriesDeleted()
        {
            var result = _categoryService.GetAllCategoriesDeleted();
            return Ok(result);
        }
        [HttpPost("Add")]
        public IActionResult CreateCategory(Category category)
        {
            var result = _categoryService.CreateCategory(category);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Update")]
        public IActionResult UpdateCategory(Category category)
        {
            var result = _categoryService.UpdateCategory(category);
            if (result.Success)
            {
                return Ok();
            }
            return BadRequest();
        }
        [HttpDelete("Delete")]
        public IActionResult DeleteCategory(Category category)
        {
            var result = _categoryService.DeleteCategory(category);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
