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
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                CategoryId = 1,
                ParentId= 0,
                CategoryName = "Bilgisayar"
            },
            new Category
            {
                CategoryId = 2,
                ParentId = 0,
                CategoryName = "Televizyon"
            }, 
            new Category
            {
                CategoryId = 3,
                ParentId = 0,
                CategoryName = "Moda"
            },
            new Category
            {
                CategoryId = 4,     
                ParentId = 1,
                CategoryName = "Notebook"
            },
            new Category
            {
                CategoryId = 5,
                ParentId = 2,
                CategoryName = "Uydu"
            });
        }
    }
    
}
