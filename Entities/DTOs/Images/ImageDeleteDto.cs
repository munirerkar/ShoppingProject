using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Images
{
    public class ImageDeleteDto : IDto
    {
        public int ImageId { get; set; }
    }
}
