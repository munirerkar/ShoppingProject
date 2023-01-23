using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        IImageService _imageService;

        public ImagesController(IImageService imageService)
        {
            _imageService = imageService;
        }
        [HttpPost("add")]
        public IActionResult Add([FromForm] List<IFormFile> formFile)
        {
            var image = new Image();
            var result = _imageService.Add(formFile, image);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(Image image)
        {
            var deleteImage = _imageService.GetByImageId(image.ImageId).Data;
            var result = _imageService.Delete(deleteImage);
            if (result.Success)
            {
                return Ok();
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update([FromForm] List<IFormFile> formFile, [FromForm] Image image)
        {
            var result = _imageService.Update(formFile, image);
            if (result.Success)
            {
                return Ok();
            }
            return BadRequest(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _imageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyimageid")]
        public IActionResult GetByImageId(int imageId)
        {
            var result = _imageService.GetByImageId(imageId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
