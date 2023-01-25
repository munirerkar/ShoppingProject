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
    public class CartManager : ICartService
    {
        ICartDal _cartDal;

        public CartManager(ICartDal cartDal)
        {
            _cartDal = cartDal;
        }

        public IResult CreateCart(Cart cart)
        {
            _cartDal.Add(cart);
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
