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
        IDataResult<List<PaymentDto>> GetAllPayments();
        IResult CreatePayment(PaymentDto paymentDto);
        IResult UpdatePayment(PaymentDto paymentDto);
        IResult DeletePayment(PaymentDto paymentDto);
    }
}
