using AutoMapper;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.AutoMapper
{
    public class CartProfile : Profile
    {
        public CartProfile()
        {
            CreateMap<CartAddDto, Cart>().ReverseMap();
        }
    }
}
