using AutoMapper;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;
        IMapper _mapper;

        public OrderManager(IOrderDal orderDal,IMapper mapper)
        {
            _orderDal = orderDal;
            _mapper = mapper;
        }

        public IResult CreateOrder(OrderDto orderDto)
        {
            var map = _mapper.Map<Order>(orderDto);
            _orderDal.Add(map);
            return new SuccessResult(Messages.Added);
        }

        public IResult DeleteOrder(OrderDto orderDto)
        {
            var map = _mapper.Map<Order>(orderDto);
            _orderDal.Delete(map);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<OrderDto>> GetAllOrders()
        {
            var orders = _orderDal.GetAll();
            var map = _mapper.Map<List<OrderDto>>(orders);
            return new SuccessDataResult<List<OrderDto>>(map);
        }

        public IResult UpdateOrder(OrderDto orderDto)
        {
            var map = _mapper.Map<Order>(orderDto);
            _orderDal.Update(map);
            return new SuccessResult(Messages.Updated);
        }
    }
}
