using Core.Entities.Concrete;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Order : IEntity
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int PaymentId { get; set; }
        public Payment Payment { get; set; }
        public int ShipperId { get; set; }
        public Shipper Shipper { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShipDate { get; set; }
        public bool Shipped { get; set; }
    }
}
