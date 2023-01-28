﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapping
{
    public class OrderMap : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasData(new Order
            {
                OrderId = 1,
                CustomerId= 1,
                PaymentId= 1,
                ShipperId= 1,
                OrderDate= DateTime.Now,
                ShipDate = DateTime.Now,
            });
        }
    }
}
