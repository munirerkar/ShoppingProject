using AutoMapper;
using Entities.Concrete;
using Entities.DTOs.Order;
using Entities.DTOs.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.AutoMapper
{
    public class PaymentProfile : Profile
    {
        public PaymentProfile()
        {
            CreateMap<PaymentDto, Payment>().ReverseMap();

        }
    }
}
