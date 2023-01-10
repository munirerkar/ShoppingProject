using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : Controller
    {
        IBrandService _brandService;
        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAllCategoriesNonDeleted()
        {
            var result = _brandService.GetAllBrandNonDeleted();
            return Ok(result);
        }
        [HttpGet("GetAllDeleted")]
        public IActionResult GetAllCategoriesDeleted()
        {
            var result = _brandService.GetAllBrandDeleted();
            return Ok(result);
        }
        [HttpPost("Add")]
        public IActionResult CreateCategory(Brand brand)
        {
            _brandService.CreateBrand(brand);
            return Ok();
        }
        [HttpPost("Update")]
        public IActionResult UpdateCategory(Brand brand)
        {
            _brandService.UpdateBrand(brand);
            return Ok();
        }
        [HttpPost("Delete")]
        public IActionResult DeleteCategory(Brand brand)
        {
            _brandService.DeleteBrand(brand);
            return Ok();
        }
    }
}
