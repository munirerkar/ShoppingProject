using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Image : IEntity
    {
        public int ImageId { get; set; }
        public string? ImagePath { get; set; }
        public DateTime Date { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Supplier> Suppliers { get; set; }
    }
}
