using AutoMapper;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Helper.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs.Images;
using Entities.DTOs.Products;
using Entities.DTOs.Suppliers;
using Microsoft.AspNetCore.Http.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SupplierManager : ISupplierService
    {
        ISupplierDal _supplierDal;
        IMapper _mapper;
        IImageDal _imageDal;
        IFileHelper _fileHelper;
        public SupplierManager(ISupplierDal supplierDal,IMapper mapper, IImageDal imageDal,IFileHelper fileHelper)
        {
            _supplierDal = supplierDal;
            _mapper = mapper;
            _imageDal = imageDal;
            _fileHelper = fileHelper;
        }

        public IResult CreateSupplier(SupplierAddDto supplierAddDto)
        {
            var imageUpload = _fileHelper.Upload(supplierAddDto.Photo, FilePath.ImagesPath);
            Image image = new(imageUpload, DateTime.Now);
            _imageDal.Add(image);
            var map = _mapper.Map<Supplier>(supplierAddDto);
            map.ImageId = image.ImageId;
            _supplierDal.Add(map);
            return new SuccessResult(Messages.Added);
        }

        public IResult DeleteSupplier(SupplierDeleteDto supplierDeleteDto)
        {
            var map = _mapper.Map<Supplier>(supplierDeleteDto);
            _supplierDal.Delete(map);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<SupplierDto>> GetAllSuppliersDeleted()
        {
            var suppliers = _supplierDal.GetAll(s => s.IsDeleted);
            var map = _mapper.Map<List<SupplierDto>>(suppliers);
            return new SuccessDataResult<List<SupplierDto>>(map);
        }

        public IDataResult<List<SupplierDto>> GetAllSuppliersNonDeleted()
        {
            var suppliers = _supplierDal.GetAll(s => !s.IsDeleted);
            var map = _mapper.Map<List<SupplierDto>>(suppliers);
            return new SuccessDataResult<List<SupplierDto>>(map);
        }
        public IResult SafeDeleteProduct(int supplierId)
        {
            var supplier = _supplierDal.Get(p => p.SupplierId == supplierId);
            var map = _mapper.Map<Supplier>(supplier);
            map.IsDeleted = true;
            _supplierDal.Update(map);
            return new SuccessResult(Messages.SupplierSafeDeleted);
        }

        public IResult UndoDeleteProduct(int supplierId)
        {
            var supplier = _supplierDal.Get(p => p.SupplierId == supplierId);
            var map = _mapper.Map<Supplier>(supplier);
            map.IsDeleted = false;
            _supplierDal.Update(map);
            return new SuccessResult(Messages.SupplierUndoDeleted);
        }
        public IResult UpdateSupplier(SupplierUpdateDto supplierUpdateDto)
        {
            
            if (supplierUpdateDto.Photo != null)
            {
                var supplier = _supplierDal.Get(x => x.SupplierId == supplierUpdateDto.SupplierId);
                var imagee = _imageDal.Get(x => x.ImageId == supplier.ImageId);
                _fileHelper.Delete(FilePath.ImagesPath + imagee.ImagePath);
                var imageUpload = _fileHelper.Upload(supplierUpdateDto.Photo, FilePath.ImagesPath);
                Image image = new(imageUpload, DateTime.Now);
                _imageDal.Add(image);
                var map = _mapper.Map<Supplier>(supplierUpdateDto);
                map.ImageId = image.ImageId;
                _supplierDal.Update(map);
                return new SuccessResult(Messages.Updated);
            }
            else
            {
                var map = _mapper.Map<Supplier>(supplierUpdateDto);
                _supplierDal.Update(map);
                return new SuccessResult(Messages.Updated);
            }
        }
    }
}
