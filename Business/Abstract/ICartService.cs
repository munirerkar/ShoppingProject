using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICartService
    {
        IDataResult<List<Cart>> GetAllCarts();
        IResult CreateCart(Cart cart);
        IResult UpdateCart(Cart cart);
        IResult DeleteCart(Cart cart);
    }
}
