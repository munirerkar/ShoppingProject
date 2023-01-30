using AutoMapper;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PaymentManager : IPaymentService
    {
        IPaymentDal _paymentDal;
        IMapper _mapper;
        public PaymentManager(IPaymentDal paymentDal, IMapper mapper)
        {
            _paymentDal = paymentDal;
            _mapper = mapper;
        }

        public IResult CreatePayment(PaymentDto paymentDto)
        {
            var map = _mapper.Map<Payment>(paymentDto);
            _paymentDal.Add(map);
            return new SuccessResult(Messages.Added);
        }

        public IResult DeletePayment(PaymentDto paymentDto)
        {
            var map = _mapper.Map<Payment>(paymentDto);
            _paymentDal.Delete(map);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<PaymentDto>> GetAllPayments()
        {
            var payments = _paymentDal.GetAll();
            var map = _mapper.Map<List<PaymentDto>>(payments);
            return new SuccessDataResult<List<PaymentDto>>(map);
        }

        public IResult UpdatePayment(PaymentDto paymentDto)
        {
            var map = _mapper.Map<Payment>(paymentDto);
            _paymentDal.Update(map);
            return new SuccessResult(Messages.Updated);
        }
    }
}
