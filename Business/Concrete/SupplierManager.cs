using Business.Abstract;
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
    public class SupplierManager : ISupplierService
    {
        ISupplierDal _supplierDal;

        public SupplierManager(ISupplierDal supplierDal)
        {
            _supplierDal = supplierDal;
        }

        public IResult CreateSupplier(Supplier supplier)
        {
            _supplierDal.Add(supplier);
            return new SuccessResult();
        }

        public IResult DeleteSupplier(Supplier supplier)
        {
            _supplierDal.Delete(supplier);
            return new SuccessResult();
        }

        public IDataResult<List<Supplier>> GetAllSuppliersDeleted()
        {
            return new SuccessDataResult<List<Supplier>>(_supplierDal.GetAll(s => s.IsDeleted));
        }

        public IDataResult<List<Supplier>> GetAllSuppliersNonDeleted()
        {
            return new SuccessDataResult<List<Supplier>>(_supplierDal.GetAll(s => !s.IsDeleted));
        }

        public IResult UpdateSupplier(Supplier supplier)
        {
            _supplierDal.Update(supplier);
            return new SuccessResult();
        }
    }
}
