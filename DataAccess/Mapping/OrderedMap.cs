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
    public class OrderedMap : IEntityTypeConfiguration<Ordered>
    {
        public void Configure(EntityTypeBuilder<Ordered> builder)
        {
            builder.HasData(new Ordered
            {
                OrderedId= 1,
                CustomerId = 1,
                FirstName = "Münir",
                LastName = "Erkar",
                Address = "Kadırgalar cd. İstanbul",
                City = "İstanbul",
                PostalCode = "34444",
                Country = "Türkiye",
                Email = "mano@gmail.com",
                Phone = "05554879878",
                Shipped = true,
                OrderDate= DateTime.Now,
            });
        }
    }
}
