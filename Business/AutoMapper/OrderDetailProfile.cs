using AutoMapper;
using Entities.Concrete;
using Entities.DTOs.OrderDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.AutoMapper
{
    public class OrderDetailProfile:Profile
    {
        public OrderDetailProfile()
        {
            CreateMap<OrderDetailDto, OrderDetail>().ReverseMap();
            CreateMap<OrderDetailAddDto, OrderDetail>().ReverseMap();
            CreateMap<OrderDetailDeleteDto, OrderDetail>().ReverseMap();
        }
    }
}
