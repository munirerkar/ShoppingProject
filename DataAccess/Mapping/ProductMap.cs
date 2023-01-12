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
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product
            {
                ProductId= 1,
                CategoryId = 4,
                BrandId = 1,
                ProductName = "Asus Oyuncu Laptop",
                ProductDescription = "Asus oyuncular için mükemmel bir laptop tasarladı",
                BarcodeNumber = "888888888888",
            },
            new Product
            {
                ProductId= 2,
                CategoryId = 4,
                BrandId = 2,
                ProductName = "Gigabyte Oyuncu Laptop",
                ProductDescription = "Gigabyte oyuncular için mükemmel bir laptop tasarladı",
                BarcodeNumber = "89999999999",
            },
            new Product
            {
                ProductId = 3,
                CategoryId = 4,
                BrandId = 3,
                ProductName = "MSI Oyuncu Laptop",
                ProductDescription = "MSI oyuncular için mükemmel bir laptop tasarladı",
                BarcodeNumber = "86999999999",
            },
            new Product
            {
                ProductId = 4,
                CategoryId = 4,
                BrandId = 4,
                ProductName = "Casper Oyuncu Laptop",
                ProductDescription = "Casper oyuncular için mükemmel bir laptop tasarladı",
                BarcodeNumber = "87999999999"
            });
        }
    }
}
