using AutoMapper;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IResult CreateProduct(ProductAddDto productAddDto)
        {
            var map = _mapper.Map<Product>(productAddDto);
            _productDal.Add(map);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult DeleteProduct(ProductDeleteDto productDeleteDto)
        {
            var map = _mapper.Map<Product>(productDeleteDto);
             _productDal.Delete(map);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IDataResult<List<ProductDto>> GetAllProductsDeleted()
        {
            var products = _productDal.GetAll(p=> p.IsDeleted);
            var map = _mapper.Map<List<ProductDto>>(products);
            return new SuccessDataResult<List<ProductDto>>(Messages.ProductDeletedListed);
        }

        public IDataResult<List<ProductDto>> GetAllProductsNonDeleted()
        {
            var products = _productDal.GetAll(p => !p.IsDeleted);
            var map = _mapper.Map<List<ProductDto>>(products);
            return new SuccessDataResult<List<ProductDto>>(Messages.ProductNonDeletedListed);
        }

        public IDataResult<List<ProductDto>> GetByUnitPrice(decimal min,decimal max)
        {
            var products = _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
            var map = _mapper.Map<List<ProductDto>>(products);
            return new SuccessDataResult<List<ProductDto>>(Messages.ProductPriceListed);
        }

        public IResult SafeDeleteProduct(int productId)
        {
            var product = _productDal.Get(p => p.ProductId == productId);
            var map = _mapper.Map<Product>(product);
            map.IsDeleted = true;
            _productDal.Update(map);
            return new SuccessResult(Messages.ProductSafeDeleted);
        }

        public IResult UndoDeleteProduct(int productId)
        {
            var product = _productDal.Get(p => p.ProductId == productId);
            var map = _mapper.Map<Product>(product);
            map.IsDeleted = false;
            _productDal.Update(map);
            return new SuccessResult(Messages.ProductUndoDeleted);
        }

        public IResult UpdateProduct(ProductUpdateDto productUpdateDto)
        {
            var map = _mapper.Map<Product>(productUpdateDto);
             _productDal.Update(map);
            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}
