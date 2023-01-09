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
        [HttpGet]
        public IActionResult GetAllCategoriesNonDeleted()
        {
            var result = _categoryService.GetAllCategoriesNonDeleted();
            return Ok(result);
        }
        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {
            _categoryService.CreateCategory(category);
            return Ok();
        }
    }
}
