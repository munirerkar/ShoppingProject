using AutoMapper;
using Entities.Concrete;
using Entities.DTOs.Cart;
using Entities.DTOs.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.AutoMapper
{
    public class OrderProfile:Profile
    {
        public OrderProfile()
        {
            CreateMap<OrderDto, Order>().ReverseMap();
            CreateMap<OrderAddDto, Order>().ReverseMap();
            CreateMap<OrderDeleteDto, Order>().ReverseMap();
        }
    }
}
