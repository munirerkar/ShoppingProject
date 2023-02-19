using AutoMapper;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Autofac.Caching;
using Core.Autofac.Performance;
using Core.Autofac.Validation;
using Core.Utilities.Helper.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
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
        IImageDal _imageDal;
        IFileHelper _fileHelper;
        public ProductManager(IProductDal productDal,IMapper mapper,IImageDal imageDal, IFileHelper fileHelper)
        {
            _productDal = productDal;
            _mapper = mapper;
            _fileHelper= fileHelper;
            _imageDal= imageDal;
        }

        [ValidationAspect(typeof(ProductValidator))]
        public IResult CreateProduct(ProductAddDto productAddDto)
        {
            var imageUpload = _fileHelper.Upload(productAddDto.Photo, FilePath.ImagesPath);
            Image image = new(imageUpload, DateTime.Now);
            _imageDal.Add(image);
            var map = _mapper.Map<Product>(productAddDto);
            map.ImageId = image.ImageId;
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
            return new SuccessDataResult<List<ProductDto>>(map);

        }
        //[SecuredOperation("superadmin,admin")]
        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<List<ProductDto>> GetAllProductsNonDeleted()
        {
            var products = _productDal.GetAll(p => !p.IsDeleted);
            var map = _mapper.Map<List<ProductDto>>(products);
            return new SuccessDataResult<List<ProductDto>>(map);
        }

        public IDataResult<List<ProductDto>> GetByProductId(int productId)
        {
            var products = _productDal.GetAll(p => p.ProductId == productId);
            var map = _mapper.Map<List<ProductDto>>(products);
            return new SuccessDataResult<List<ProductDto>>(map);
        }

        public  IDataResult<List<ProductDto>> GetByUnitPrice(decimal min,decimal max)
        {
            var products = _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
            var map = _mapper.Map<List<ProductDto>>(products);
            return new SuccessDataResult<List<ProductDto>>(map);
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
        [CacheRemoveAspect("IProductService.Get")]
        public IResult UpdateProduct(ProductUpdateDto productUpdateDto)
        {
            var map = _mapper.Map<Product>(productUpdateDto);
             _productDal.Update(map);
            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}
