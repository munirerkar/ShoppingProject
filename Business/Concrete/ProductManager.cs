using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public async Task CreateProduct(ProductAddDto productAddDto)
        {
            await _productDal.Add(productAddDto);
        }

        public async Task DeleteProduct(Product product)
        {
            await _productDal.Delete(product);

        }

        public async Task<List<Product>> GetAllProductsDeleted()
        {
            return await _productDal.GetAll(x=> x.IsDeleted);
        }

        public async Task<List<Product>> GetAllProductsNonDeleted()
        {
            return await _productDal.GetAll(x => !x.IsDeleted);
        }

        public async Task UpdateProduct(Product product)
        {
            await _productDal.Update(product);
        }
    }
}
