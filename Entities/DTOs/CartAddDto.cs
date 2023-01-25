using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CartAddDto:IDto
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int Total { get; set; }
    }
}
