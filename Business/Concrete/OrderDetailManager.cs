using AutoMapper;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs.OrderDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OrderDetailManager : IOrderDetailService
    {
        IOrderDetailDal _orderDetailDal;
        IMapper _mapper;
        public OrderDetailManager(IOrderDetailDal orderDetailDal,IMapper mapper)
        {
            _orderDetailDal = orderDetailDal;
            _mapper = mapper;
        }

        
        public IResult CreateOrderDetail(OrderDetailDto orderDetailDto)
        {
            var map = _mapper.Map<OrderDetail>(orderDetailDto);
            _orderDetailDal.Add(map);
            return new SuccessResult(Messages.Added);
        }

        public IResult DeleteOrderDetail(OrderDetailDto orderDetailDto)
        {
            var map = _mapper.Map<OrderDetail>(orderDetailDto);
            _orderDetailDal.Delete(map);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<OrderDetailDto>> GetAllOrderDetails()
        {
            var orderDetails = _orderDetailDal.GetAll();
            var map = _mapper.Map<List<OrderDetailDto>>(orderDetails);
            return new SuccessDataResult<List<OrderDetailDto>>(map);
        }

        public IResult UpdateOrderDetail(OrderDetailDto orderDetailDto)
        {
            var map = _mapper.Map<OrderDetail>(orderDetailDto);
            _orderDetailDal.Update(map);
            return new SuccessResult(Messages.Updated);
        }
    }
}
