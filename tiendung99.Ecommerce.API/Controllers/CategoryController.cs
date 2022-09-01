using Microsoft.AspNetCore.Mvc;
using tiendung99.Ecommerce.BLL.IServices;
using tiendung99.Ecommerce.BLL.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tiendung99.Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryService _categoryService;
        public CategoryController(ICategoryService service)
        {
            _categoryService = service;
        }
        // GET: api/<CategoryController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _categoryService.GetAllAsync();
            return Ok(result);
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await _categoryService.GetByIdAsync(id);
            return Ok(result);
        }

        // POST api/<CategoryController>
        [HttpPost]
        public async Task<IActionResult> Post(CategoryModel model)
        {
            await _categoryService.AddAsync(model);
            return Ok();
        }

        // PUT api/<CategoryController>/5
        [HttpPut()]
        public async Task<IActionResult> Put(CategoryModel model)
        {
            await _categoryService.UpdateAsync(model);
            return Ok();
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete()]
        public async Task<IActionResult> Delete(CategoryModel model)
        {
            await _categoryService.DeleteAsync(model);
            return Ok();
        }
    }
}
