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
            var result = _brandService.CreateBrand(brand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Update")]
        public IActionResult UpdateCategory(Brand brand)
        {
            var result = _brandService.UpdateBrand(brand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("Delete")]
        public IActionResult DeleteCategory(Brand brand)
        {
            var result = _brandService.DeleteBrand(brand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
