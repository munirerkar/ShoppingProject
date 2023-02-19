using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs.Images;
using Entities.DTOs.Suppliers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {
        ISupplierService _supplierService;

        public SuppliersController(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }
        [HttpGet("getall")]
        public IActionResult GetAllSupplierNonDeleted()
        {
            var result = _supplierService.GetAllSuppliersNonDeleted();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getalldeleted")]
        public IActionResult GetAllSupplierDeleted()
        {
            var result = _supplierService.GetAllSuppliersDeleted();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult CreateSupplier([FromForm]SupplierAddDto supplierAddDto)
        {
            var result = _supplierService.CreateSupplier(supplierAddDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult UpdateSupplier([FromForm]SupplierUpdateDto supplierUpdateDto)
        {
            var result = _supplierService.UpdateSupplier(supplierUpdateDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("delete")]
        public IActionResult DeleteSupplier(SupplierDeleteDto supplierDeleteDto)
        {
            var result = _supplierService.DeleteSupplier(supplierDeleteDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
