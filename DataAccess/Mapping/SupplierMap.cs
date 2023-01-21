
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
    public class SupplierMap : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.HasData(new Supplier
            {
                SupplierId = 1,
                CompanyName = "Mano",
                ContactName = "Münir Erkar",
                Address = "Kadırgalar Cad., No:1B, Şişli, İstanbul, Türkiye",
                City = "İstanbul",
                Country = "Türkiye",
                PostalCode = 34400,
                Email = "mano@gmail.com",
                Phone = "5432432248"
            });
        }
    }
}
