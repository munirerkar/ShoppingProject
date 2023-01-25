using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Cart : IEntity
    {
        public int CartId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public int Total { get; set; }
    }
}
