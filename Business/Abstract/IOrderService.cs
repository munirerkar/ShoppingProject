﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOrderService
    {
        IDataResult<List<Order>> GetAllOrders();
        IResult CreateOrder(Order order);
        IResult UpdateOrder(Order order);
        IResult DeleteOrder(Order order);
    }
}