using AutoMapper;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Helper.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs.Images;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
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
        IMapper _mapper;

        public ImageManager(IImageDal imageDal, IFileHelper fileHelper,IMapper mapper)
        {
            _imageDal = imageDal;
            _fileHelper = fileHelper;
            _mapper = mapper;
        }
        public IResult Add(List<IFormFile> formFile, Image image)
        {
            image.ImagePath = _fileHelper.Upload(formFile, FilePath.ImagesPath);
            image.Date = DateTime.Now;
            _imageDal.Add(image);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(ImageDeleteDto imageDeleteDto)
        {
            var image = _imageDal.Get(x => x.ImageId == imageDeleteDto.ImageId);
            _fileHelper.Delete(FilePath.ImagesPath + image.ImagePath);
            _mapper.Map<Image>(imageDeleteDto);
            _imageDal.Delete(image);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<ImageDto>> GetAll()
        {
            var image = _imageDal.GetAll();
            var map = _mapper.Map<List<ImageDto>>(image);
            return new SuccessDataResult<List<ImageDto>>(map);
        }

        public IDataResult<ImageDto> GetByImageId(int imageId)
        {
            var image = _imageDal.Get(i => i.ImageId == imageId);
            var map = _mapper.Map<ImageDto>(image);
            return new SuccessDataResult<ImageDto>(map);
        }

        public IResult Update(ImageUpdateDto imageUpdateDto)
        {
            var image = _imageDal.Get(x =>  x.ImageId == imageUpdateDto.ImageId);
            image.ImagePath = _fileHelper.Update(imageUpdateDto.Photo, FilePath.ImagesPath + image.ImagePath, FilePath.ImagesPath);
            _mapper.Map<Image>(imageUpdateDto);
            _imageDal.Update(image);
            return new SuccessResult(Messages.Updated);
        }
    }
}
