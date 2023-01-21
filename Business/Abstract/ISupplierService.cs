using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISupplierService
    {
        IDataResult<List<Supplier>> GetAllSuppliersNonDeleted();
        IDataResult<List<Supplier>> GetAllSuppliersDeleted();
        IResult CreateSupplier(Supplier supplier);
        IResult UpdateSupplier(Supplier supplier);
        IResult DeleteSupplier(Supplier supplier);
    }
}
