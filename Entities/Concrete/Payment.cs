using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Payment : IEntity
    {
        public int PaymentId { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string PaymentType { get; set; }
        public bool Allowed { get; set; }
    }
}
