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
    public class ShipperManager : IShipperService
    {
        IShipperDal _shipperDal;

        public ShipperManager(IShipperDal shipperDal)
        {
            _shipperDal = shipperDal;
        }

        public IResult CreateShipper(Shipper shipper)
        {
            _shipperDal.Add(shipper);
            return new SuccessResult(Messages.Added);
        }

        public IResult DeleteShipper(Shipper shipper)
        {
            _shipperDal.Delete(shipper);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Shipper>> GetAllShippers()
        {
            return new SuccessDataResult<List<Shipper>>(_shipperDal.GetAll());
        }

        public IResult UpdateShipper(Shipper shipper)
        {
            _shipperDal.Update(shipper);
            return new SuccessResult(Messages.Updated);
        }
    }
}
