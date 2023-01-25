using AutoMapper;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CartManager : ICartService
    {
        ICartDal _cartDal;
        IMapper _mapper;

        public CartManager(ICartDal cartDal,IMapper mapper)
        {
            _cartDal = cartDal;
            _mapper = mapper;
        }

        public IResult CreateCart(CartAddDto cartAddDto)
        {
            var map = _mapper.Map<Cart>(cartAddDto);
            _cartDal.Add(map);
            return new SuccessResult(Messages.Added);
        }

        public IResult DeleteCart(Cart cart)
        {
            _cartDal.Delete(cart);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Cart>> GetAllCarts()
        {
            return new SuccessDataResult<List<Cart>>(_cartDal.GetAll());
        }

        public IResult UpdateCart(Cart cart)
        {
            _cartDal.Update(cart);
            return new SuccessResult(Messages.Updated);
        }
    }
}
