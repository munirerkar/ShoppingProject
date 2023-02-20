using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.OrderDetail
{
    public class OrderDetailAddDto:IDto
    {
        public int OrderId { get; set; }
        public int CartId { get; set; }
    }
}
