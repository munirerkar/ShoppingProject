﻿using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.OrderDetail
{
    public class OrderDetailDto:IDto
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int CartId { get; set; }
        public DateTime BillDate { get; set; }
    }
}
