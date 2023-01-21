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
                SupplierId = 1,
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
                SupplierId = 1,
                ProductName = "Gigabyte Oyuncu Laptop",
                ProductDescription = "Gigabyte oyuncular için mükemmel bir laptop tasarladı",
                BarcodeNumber = "899999999993",
                UnitOfStock = 5,
                UnitPrice = 24999.99m,
            },
            new Product
            {
                ProductId = 3,
                CategoryId = 4,
                BrandId = 3,
                SupplierId = 1,
                ProductName = "MSI Oyuncu Laptop",
                ProductDescription = "MSI oyuncular için mükemmel bir laptop tasarladı",
                BarcodeNumber = "869999999992",
                UnitOfStock = 15,
                UnitPrice = 20999.99m,

            },
            new Product
            {
                ProductId = 4,
                CategoryId = 4,
                BrandId = 4,
                SupplierId = 1,
                ProductName = "Casper Oyuncu Laptop",
                ProductDescription = "Casper oyuncular için mükemmel bir laptop tasarladı",
                BarcodeNumber = "879999999991",
                UnitOfStock = 30,
                UnitPrice = 17999.99m,
            });
        }
    }
}
