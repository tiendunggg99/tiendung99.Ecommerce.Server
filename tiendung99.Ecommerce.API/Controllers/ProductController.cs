using Microsoft.AspNetCore.Mvc;
using tiendung99.Ecommerce.BLL.IServices;
using tiendung99.Ecommerce.BLL.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tiendung99.Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;
        public ProductController(IProductService service)
        {
            _productService = service;
        }
        // GET: api/<ProductController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _productService.GetAllAsync();
            return Ok(result);
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await _productService.GetByIdAsync(id);
            return Ok(result);
        }

        // POST api/<ProductController>
        [HttpPost]
        public async Task<IActionResult> Post(ProductModel model)
        {
            await _productService.AddAsync(model);
            return Ok();
        }

        // PUT api/<ProductController>/5
        [HttpPut()]
        public async Task<IActionResult> Put(ProductModel model)
        {
            await _productService.UpdateAsync(model);
            return Ok();
        }

        // DELETE api/<ProductController>/5
        [HttpDelete()]
        public async Task<IActionResult> Delete(ProductModel model)
        {
            await _productService.DeleteAsync(model);
            return Ok();
        }
    }
}
