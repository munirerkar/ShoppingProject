﻿using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Order
{
    public class OrderDeleteDto:IDto
    {
        public int OrderId { get; set; }
    }
}
