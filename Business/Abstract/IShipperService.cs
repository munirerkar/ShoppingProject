using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IShipperService
    {
        IDataResult<List<Shipper>> GetAllShippers();
        IResult CreateShipper(Shipper shipper);
        IResult UpdateShipper(Shipper shipper);
        IResult DeleteShipper(Shipper shipper);
    }
}
