using Core.Utilities.Results;
using Entities.DTOs.Order;
using Entities.DTOs.OrderDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOrderDetailService
    {
        IDataResult<List<OrderDetailDto>> GetAllOrderDetails();
        IResult CreateOrderDetail(OrderDetailAddDto orderDetailAddDto);
        IResult UpdateOrderDetail(OrderDetailDto orderDetailDto);
        IResult DeleteOrderDetail(OrderDetailDeleteDto orderDetailDeleteDto);
    }
}
