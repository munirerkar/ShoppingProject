using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.Cart;
using Entities.DTOs.Payment;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        IPaymentService _paymentService;

        public PaymentsController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAllPayment()
        {
            var result = _paymentService.GetAllPayments();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Add")]
        public IActionResult CreatePayment(PaymentDto paymentDto)
        {
            var result = _paymentService.CreatePayment(paymentDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Update")]
        public IActionResult UpdatePayment(PaymentDto paymentDto)
        {
            var result = _paymentService.UpdatePayment(paymentDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("Delete")]
        public IActionResult DeletePayment(PaymentDto paymentDto)
        {
            var result = _paymentService.DeletePayment(paymentDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
