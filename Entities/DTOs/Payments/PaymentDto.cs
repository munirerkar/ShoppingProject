using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Payment
{
    public class PaymentDto:IDto
    {
        public int PaymentId { get; set; }
        public string PaymentType { get; set; }
        public bool Allowed { get; set; }
    }
}
