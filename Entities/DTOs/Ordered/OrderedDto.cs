using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Ordered
{
    public class OrderedDto:IDto
    {
        public int OrderedId { get; set; }
        public int CustomerId { get; set; }
        public int OrderId { get; set; }
        public DateTime? OrderDate { get; set; }
        public bool? Shipped { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
