using Business.Abstract;
using Entities.Concrate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class CarController : ControllerBase
    {
        ICarService _carService;
        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet()]
        public IActionResult GetAll()
        {
            var result = _carService.GetAll();
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("{brandId}")]
        public IActionResult GetByBrand(int brandId)
        {
            var result = _carService.GetByBrand(brandId);
            return Ok(result);
        }

        [HttpGet("{colorId}")]
        public IActionResult GetByColor(int colorId)
        {
            var result = _carService.GetByColor(colorId);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetByCar(int id)
        {
            var result = _carService.GetByCar(id);
            return Ok(result);
        }


        [HttpGet("{categoryId}")]
        public IActionResult GetByCategory(int categoryId)
        {
            var result = _carService.GetByCategory(categoryId);
            return Ok(result);
        }

        //[HttpGet("getcardetail")]
        //public IActionResult GetCarDetail()
        //{
        //    var result = _carService.GetCarDetails();
        //    return Ok(result);
        //}

        [HttpPost()]
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);
            return Ok(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Car car)
        {
            var result = _carService.Delete(car);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut()]
        public IActionResult Update(Car car)
        {
            var result = _carService.Update(car);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}