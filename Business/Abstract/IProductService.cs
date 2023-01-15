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
    public interface IProductService
    {
        Task<List<ProductDto>> GetAllProductsNonDeleted();
        Task<List<ProductDto>> GetAllProductsDeleted();
        Task<List<ProductDto>> GetByUnitPrice(decimal min, decimal max);
        IResult CreateProduct(ProductAddDto productAddDto);
        IResult UpdateProduct(ProductUpdateDto productUpdateDto);
        IResult DeleteProduct(ProductDeleteDto productDeleteDto);
        IResult SafeDeleteProduct(int productId);
        IResult UndoDeleteProduct(int productId);
    }
}
