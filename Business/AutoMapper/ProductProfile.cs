using AutoMapper;
using Entities.Concrete;
using Entities.DTOs.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.AutoMapper
{
    public class ProductProfile:Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductAddDto, Product>().ReverseMap();
            CreateMap<ProductAddDto, ProductDto>().ReverseMap();
            CreateMap<ProductUpdateDto, Product>().ReverseMap();
            CreateMap<ProductUpdateDto, ProductDto>().ReverseMap();
            CreateMap<ProductDeleteDto, Product>().ReverseMap();
            CreateMap<ProductDto, Product>().ReverseMap();
        }
    }
}
