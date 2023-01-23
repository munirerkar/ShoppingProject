using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
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

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public IResult CreateOrder(Order order)
        {
            _orderDal.Add(order);
            return new SuccessResult(Messages.Added);
        }

        public IResult DeleteOrder(Order order)
        {
            _orderDal.Delete(order);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Order>> GetAllOrders()
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll());
        }

        public IResult UpdateOrder(Order order)
        {
            _orderDal.Update(order);
            return new SuccessResult(Messages.Updated);
        }
    }
}
