using Business.Abstract;
using Entities.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        IBrandService _brandService;
        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet()]
        public IActionResult GetAll()
        {
            var result = _brandService.GetAll();
            return Ok(result);
        }

        [HttpGet("{brandId}")]
        public IActionResult GetByBrand(int brandId)
        {
            var result = _brandService.GetByBrandId(brandId);
            return Ok(result);
        }

        [HttpPost()]
        public IActionResult Add(Brand brand)
        {
            var result = _brandService.Add(brand);
            return Ok(result);
        }

        [HttpPut()]
        public IActionResult Update(Brand brand)
        {
            var result = _brandService.Update(brand);
            return Ok(result);
        }

        [HttpDelete()]
        public IActionResult Delete(Brand brand)
        {
            var result = _brandService.Delete(brand);
            return Ok(result);
        }
    }
}
