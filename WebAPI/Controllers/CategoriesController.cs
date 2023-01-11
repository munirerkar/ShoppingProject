using Business.Abstract;
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
            _categoryService.CreateCategory(category);
            return Ok();
        }
        [HttpPost("Update")]
        public IActionResult UpdateCategory(Category category)
        {
            _categoryService.UpdateCategory(category);
            return Ok();
        }
        [HttpDelete("Delete")]
        public IActionResult DeleteCategory(Category category)
        {
            _categoryService.DeleteCategory(category);
            return Ok();
        }
    }
}
