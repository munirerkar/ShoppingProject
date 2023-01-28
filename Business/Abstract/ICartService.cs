using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICartService
    {
        IDataResult<List<CartDto>> GetAllCarts();
        IResult CreateCart(CartDto cartDto);
        IResult UpdateCart(CartDto cartDto);
        IResult DeleteCart(CartDto cartDto);
    }
}
