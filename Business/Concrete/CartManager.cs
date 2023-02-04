using AutoMapper;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs.Cart;
using Entities.DTOs.Products;
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

        public IResult CreateCart(CartDto cartDto)
        {
            var map = _mapper.Map<Cart>(cartDto);
            _cartDal.Add(map);
            return new SuccessResult(Messages.Added);
        }

        public IResult DeleteCart(CartDto cartDto)
        {
            var map = _mapper.Map<Cart>(cartDto);
            _cartDal.Delete(map);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<CartDto>> GetAllCarts()
        {
            var carts = _cartDal.GetAll();
            var map = _mapper.Map<List<CartDto>>(carts);
            return new SuccessDataResult<List<CartDto>>(map);
        }

        public IResult UpdateCart(CartDto cartDto)
        {
            var map = _mapper.Map<Cart>(cartDto);
            _cartDal.Update(map);
            return new SuccessResult(Messages.Updated);
        }
    }
}
