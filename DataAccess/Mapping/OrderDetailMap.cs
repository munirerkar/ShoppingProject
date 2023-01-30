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
    public class OrderDetailMap : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasData(new OrderDetail
            {
                OrderDetailId = 1,
                OrderedId= 1,
                ProductId = 1,
                Price = 500,
                Quantity = 1,
                Total = 1,
                BillDate= DateTime.Now,
            });
        }
    }
}
