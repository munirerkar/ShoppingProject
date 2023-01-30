using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using Entities.DTOs.Order;
using Entities.DTOs.OrderDetail;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        IOrderDetailService _orderDetailService;

        public OrderDetailsController(IOrderDetailService orderDetailService)
        {
            _orderDetailService = orderDetailService;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAllOrders()
        {
            var result = _orderDetailService.GetAllOrderDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Add")]
        public IActionResult CreateProduct(OrderDetailDto orderDetailDto)
        {
            var result = _orderDetailService.CreateOrderDetail(orderDetailDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Update")]
        public IActionResult UpdateProduct(OrderDetailDto orderDetailDto)
        {
            var result = _orderDetailService.UpdateOrderDetail(orderDetailDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("Delete")]
        public IActionResult DeleteProduct(OrderDetailDto orderDetailDto)
        {
            var result = _orderDetailService.DeleteOrderDetail(orderDetailDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
