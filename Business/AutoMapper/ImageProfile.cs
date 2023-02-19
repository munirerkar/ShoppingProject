using AutoMapper;
using Entities.Concrete;
using Entities.DTOs.Cart;
using Entities.DTOs.Images;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.AutoMapper
{
    public class ImageProfile:Profile
    {
        public ImageProfile()
        {
            CreateMap<ImageDto, Image>().ReverseMap();
            CreateMap<ImageUpdateDto, Image>().ReverseMap();
            CreateMap<ImageDeleteDto, Image>().ReverseMap();
        }
    }
}
