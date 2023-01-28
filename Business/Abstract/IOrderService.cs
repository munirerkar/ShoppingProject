using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOrderService
    {
        IDataResult<List<OrderDto>> GetAllOrders();
        IResult CreateOrder(OrderDto orderDto);
        IResult UpdateOrder(OrderDto orderDto);
        IResult DeleteOrder(OrderDto orderDto);
    }
}
