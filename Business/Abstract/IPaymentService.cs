using Core.Utilities.Results;
using Entities.DTOs.Order;
using Entities.DTOs.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPaymentService
    {
        IDataResult<List<PaymentDto>> GetAllOrders();
        IResult CreateOrder(PaymentDto paymentDto);
        IResult UpdateOrder(PaymentDto paymentDto);
        IResult DeleteOrder(PaymentDto paymentDto);
    }
}
