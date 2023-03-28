using Business.Abstract;
using Entities.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet()]
        public IActionResult GetAll()
        {
            var result = _categoryService.GetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _categoryService.Get(id);
            return Ok(result);
        }

        [HttpPost()]
        public IActionResult Add(Category category)
        {
            var result = _categoryService.Add(category);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult Update(Category category)
        {
            var result = _categoryService.Update(category);
            if (result.Success == false)
            {
                return BadRequest("Veri hatalı");
            }
            return Ok(category);
        }

        [HttpDelete()]
        public IActionResult Delete(Category category)
        {
            var result = _categoryService.Delete(category);
            return Ok(result);
        }
    }
}