using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Helper.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ImageManager : IImageService
    {
        IImageDal _imageDal;
        IFileHelper _fileHelper;

        public ImageManager(IImageDal imageDal, IFileHelper fileHelper)
        {
            _imageDal = imageDal;
            _fileHelper = fileHelper;
        }
        public IResult Add(List<IFormFile> formFile, Image image)
        {
            image.ImagePath = _fileHelper.Upload(formFile, FilePath.ImagesPath);
            image.Date = DateTime.Now;
            _imageDal.Add(image);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Image image)
        {
            _fileHelper.Delete(FilePath.ImagesPath + image.ImagePath);
            _imageDal.Delete(image);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Image>> GetAll()
        {
            return new SuccessDataResult<List<Image>>(_imageDal.GetAll());
        }

        public IDataResult<Image> GetByImageId(int imageId)
        {
            return new SuccessDataResult<Image>(_imageDal.Get(i => i.ImageId == imageId));
        }

        public IResult Update(List<IFormFile> formFile, Image image)
        {
            image.ImagePath = _fileHelper.Update(formFile, FilePath.ImagesPath + image.ImagePath, FilePath.ImagesPath);
            _imageDal.Update(image);
            return new SuccessResult(Messages.Updated);
        }
    }
}
