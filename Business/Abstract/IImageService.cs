using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.Images;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IImageService
    {
        IResult Add(List<IFormFile> formFile, Image image);
        IResult Delete(ImageDeleteDto imageDeleteDto);
        IResult Update(ImageUpdateDto imageUpdateDto);
        IDataResult<List<ImageDto>> GetAll();
        IDataResult<ImageDto> GetByImageId(int imageId);
    }
}
