using AutoMapper;
using Entities.Concrete;
using Entities.DTOs.Suppliers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.AutoMapper
{
    public class SupplierProfile : Profile
    {
        public SupplierProfile()
        {
            CreateMap<SupplierDto, Supplier>().ReverseMap();
            CreateMap<SupplierAddDto, Supplier>().ReverseMap();
            CreateMap<SupplierAddDto, SupplierDto>().ReverseMap();
            CreateMap<SupplierDeleteDto, Supplier>().ReverseMap();
            CreateMap<SupplierDeleteDto, SupplierDto>().ReverseMap();
            CreateMap<SupplierUpdateDto, Supplier>().ReverseMap();
            CreateMap<SupplierUpdateDto, SupplierDto>().ReverseMap();
            
        }
    }
}
