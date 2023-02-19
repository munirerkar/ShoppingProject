using Core.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Images
{
    public class ImageUpdateDto:IDto
    {
        public int ImageId { get; set; }
        public List<IFormFile> Photo { get; set; }
    }
}
