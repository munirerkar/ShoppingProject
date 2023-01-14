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
                UnitOfStock = 23,
                UnitPrice = 19999.99m,
            },
            new Product
            {
                ProductId= 2,
                CategoryId = 4,
                BrandId = 2,
                ProductName = "Gigabyte Oyuncu Laptop",
                ProductDescription = "Gigabyte oyuncular için mükemmel bir laptop tasarladı",
                BarcodeNumber = "89999999999",
                UnitOfStock = 5,
                UnitPrice = 24999.99m,
            },
            new Product
            {
                ProductId = 3,
                CategoryId = 4,
                BrandId = 3,
                ProductName = "MSI Oyuncu Laptop",
                ProductDescription = "MSI oyuncular için mükemmel bir laptop tasarladı",
                BarcodeNumber = "86999999999",
                UnitOfStock = 15,
                UnitPrice = 20999.99m,

            },
            new Product
            {
                ProductId = 4,
                CategoryId = 4,
                BrandId = 4,
                ProductName = "Casper Oyuncu Laptop",
                ProductDescription = "Casper oyuncular için mükemmel bir laptop tasarladı",
                BarcodeNumber = "87999999999",
                UnitOfStock = 30,
                UnitPrice = 17999.99m,
            });
        }
    }
}
