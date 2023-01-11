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
        Task<List<Product>> GetAllProductsNonDeleted();
        Task<List<Product>> GetAllProductsDeleted();
        Task CreateProduct(ProductAddDto productAddDto);
        Task UpdateProduct(Product product);
        Task DeleteProduct(Product product);
    }
}
