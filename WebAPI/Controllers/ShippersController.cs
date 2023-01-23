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
    public class ShippersController : ControllerBase
    {
        IShipperService _shipperService;

        public ShippersController(IShipperService shipperService)
        {
            _shipperService = shipperService;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAllShippers()
        {
            var result = _shipperService.GetAllShippers();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Add")]
        public IActionResult CreateShipper(Shipper shipper)
        {
            var result = _shipperService.CreateShipper(shipper);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Update")]
        public IActionResult UpdateShipper(Shipper shipper)
        {
            var result = _shipperService.UpdateShipper(shipper);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("Delete")]
        public IActionResult DeleteShipper(Shipper shipper)
        {
            var result = _shipperService.DeleteShipper(shipper);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
