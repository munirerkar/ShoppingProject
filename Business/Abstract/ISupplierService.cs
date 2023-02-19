using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.Images;
using Entities.DTOs.Suppliers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISupplierService
    {
        IDataResult<List<SupplierDto>> GetAllSuppliersNonDeleted();
        IDataResult<List<SupplierDto>> GetAllSuppliersDeleted();
        IResult CreateSupplier(SupplierAddDto supplierAddDto);
        IResult UpdateSupplier(SupplierUpdateDto supplierUpdateDto);
        IResult DeleteSupplier(SupplierDeleteDto supplierDeleteDto);
        IResult SafeDeleteProduct(int supplierId);
        IResult UndoDeleteProduct(int supplierId);
    }
}
