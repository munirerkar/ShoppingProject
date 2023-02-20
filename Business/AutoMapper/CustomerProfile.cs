using AutoMapper;
using Entities.Concrete;
using Entities.DTOs.Customer;
using Entities.DTOs.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.AutoMapper
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<CustomerDto, Customer>().ReverseMap();
            CreateMap<CustomerAddDto, Customer>().ReverseMap();
        }
    }
}
