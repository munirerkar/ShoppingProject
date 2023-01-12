using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapping
{
    public class BrandMap : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasData(new Brand
            {
                BrandId = 1,
                BrandName = "Asus"
            },
            new Brand
            {
                BrandId = 2,
                BrandName = "Gigabyte"
            },
            new Brand
            {
                BrandId = 3,
                BrandName = "MSI"
            },
            new Brand
            {
                BrandId = 4,
                BrandName = "Casper"
            },
            new Brand
            {
                BrandId = 5,
                BrandName = "Monster"
            });
        }
    }
}
