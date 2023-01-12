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
        Task CreateProduct(ProductAddDto productAddDto);
        Task UpdateProduct(ProductUpdateDto productUpdateDto);
        Task DeleteProduct(ProductDeleteDto productDeleteDto);
    }
}
