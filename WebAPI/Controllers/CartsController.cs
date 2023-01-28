using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.Cart;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartsController : ControllerBase
    {
        ICartService _cartService;

        public CartsController(ICartService cartService)
        {
            _cartService = cartService;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAllCart()
        {
            var result = _cartService.GetAllCarts();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Add")]
        public IActionResult CreateCart(CartDto cartDto)
        {
            var result = _cartService.CreateCart(cartDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Update")]
        public IActionResult UpdateCart(CartDto cartDto)
        {
            var result = _cartService.UpdateCart(cartDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("Delete")]
        public IActionResult DeleteCart(CartDto cartDto)
        {
            var result = _cartService.DeleteCart(cartDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
