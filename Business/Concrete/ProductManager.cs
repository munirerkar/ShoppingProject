using AutoMapper;
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
        IMapper _mapper;

        public ProductManager(IProductDal productDal,IMapper mapper)
        {
            _productDal = productDal;
            _mapper = mapper;
        }

        public async Task CreateProduct(ProductAddDto productAddDto)
        {
            var map = _mapper.Map<Product>(productAddDto);
            await _productDal.Add(map);
        }

        public async Task DeleteProduct(ProductDeleteDto productDeleteDto)
        {
            var map = _mapper.Map<Product>(productDeleteDto);
            await _productDal.Delete(map);
        }

        public async Task<List<ProductDto>> GetAllProductsDeleted()
        {
            var products = await _productDal.GetAll(x=> x.IsDeleted);
            return _mapper.Map<List<ProductDto>>(products);
        }

        public async Task<List<ProductDto>> GetAllProductsNonDeleted()
        {
            var products = await _productDal.GetAll(x => !x.IsDeleted);
            return _mapper.Map<List<ProductDto>>(products);
        }

        public async Task UpdateProduct(ProductUpdateDto productUpdateDto)
        {
            var map = _mapper.Map<Product>(productUpdateDto);
            await _productDal.Update(map);
        }
    }
}
