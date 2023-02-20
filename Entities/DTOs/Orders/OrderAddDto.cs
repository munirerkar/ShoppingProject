using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Order
{
    public class OrderAddDto:IDto
    {
        public int CustomerId { get; set; }
        public int PaymentId { get; set; }
        public int ShipperId { get; set; }
    }
}
