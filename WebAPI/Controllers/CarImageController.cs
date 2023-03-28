using Business.Abstract;
using Entities.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImageController : ControllerBase
    {
        ICarImageService _carImageService;

        public CarImageController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }

        [HttpPost()]
        public IActionResult Add([FromForm(Name = ("Image"))] IFormFile file, [FromForm] CarImage carImages)
        {
            var result = _carImageService.Add(file, carImages);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut()]
        public IActionResult Update([FromForm(Name = ("Image"))] IFormFile file, [FromForm(Name = ("Id"))] int Id)
        {
            var updateImage = _carImageService.Get(Id).Data;
            var result = _carImageService.Update(file, updateImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete()]
        public IActionResult Delete([FromForm(Name = ("Id"))] int Id)
        {
            var carDeleteImage = _carImageService.Get(Id).Data;
            var result = _carImageService.Delete(carDeleteImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet()]
        public IActionResult GetAll(int Id)
        {
            var result = _carImageService.GetAll(Id);
            if (result.Success == true)
            {
                Ok(result);
            }
            return BadRequest(result);
        }
    }
}