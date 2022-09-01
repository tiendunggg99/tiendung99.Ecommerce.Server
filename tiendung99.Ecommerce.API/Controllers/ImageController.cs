using Microsoft.AspNetCore.Mvc;
using tiendung99.Ecommerce.BLL.IServices;
using tiendung99.Ecommerce.BLL.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tiendung99.Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private IImageService _imageService;
        public ImageController(IImageService service)
        {
            _imageService = service;
        }
        // GET: api/<ImageController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _imageService.GetAllAsync();
            return Ok(result);
        }

        // GET api/<ImageController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await _imageService.GetByIdAsync(id);
            return Ok(result);
        }

        // POST api/<ImageController>
        [HttpPost]
        public async Task<IActionResult> Post(ImageModel model)
        {
            await _imageService.AddAsync(model);
            return Ok();
        }

        // PUT api/<ImageController>/5
        [HttpPut()]
        public async Task<IActionResult> Put(ImageModel model)
        {
            await _imageService.UpdateAsync(model);
            return Ok();
        }

        // DELETE api/<ImageController>/5
        [HttpDelete()]
        public async Task<IActionResult> Delete(ImageModel model)
        {
            await _imageService.DeleteAsync(model);
            return Ok();
        }
    }
}
