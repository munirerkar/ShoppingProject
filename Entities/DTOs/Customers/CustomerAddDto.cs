using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Customers
{
    public class CustomerAddDto : IDto
    {
        public int UserId { get; set; }
        public string TcNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string CreditCard { get; set; }
        public string CVV { get; set; }
        public int CardExpMo { get; set; }
        public int CardExpYr { get; set; }
    }
}
