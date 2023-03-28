using Business.Abstract;
using Entities.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorController : ControllerBase
    {
        IColorService _colorService;
        public ColorController(IColorService colorService)
        {
            _colorService = colorService;
        }

        [HttpGet()]
        public IActionResult GetAll()
        {
            var result = _colorService.GetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetByColorId(int id)
        {
            var result = _colorService.GetByColorId(id);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost()]
        public IActionResult Add(Color color)
        {
            var result = _colorService.Add(color);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult Update(Color color)
        {
            var result = _colorService.Update(color);
            return Ok(result);
        }

        [HttpDelete()]
        public IActionResult Delete(Color color)
        {
            var result = _colorService.Delete(color);
            return Ok(result);
        }
    }
}