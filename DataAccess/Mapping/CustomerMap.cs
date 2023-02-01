using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapping
{
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(new Customer
            {
                CustomerId= 1,
                UserId= 1,
                TcNo = "12345678912",
                FirstName = "Münir",
                LastName = "Erkar",
                Phone = "5432344323",
                Address1 = "Kadırgalar cd.",
                Address2 = "Şişli İstanbul",
                City = "İstanbul",
                PostalCode = "34444",
                Country = "Türkiye",
                CreditCard = "4337950475337442",
                CVV = "829",
                CardExpMo = 10,
                CardExpYr= 2027,
                BillingType = "Ev",
                BillingAddress = "Kadırgalar Cad., No:1B, Şişli, İstanbul, Türkiye",
                BillingCity = "İstanbul",
                BillingCountry = "Türkiye",
                BillingPostalCode = "34444",
                ShipAddress = "Taksim",
                ShipCity = "İstanbul",
                ShipPostalCode = "34454",
                ShipCountry = "Türkiye"
            });
        }
    }
}
