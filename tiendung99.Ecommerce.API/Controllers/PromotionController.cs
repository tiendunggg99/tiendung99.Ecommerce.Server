using Microsoft.AspNetCore.Mvc;
using tiendung99.Ecommerce.BLL.IServices;
using tiendung99.Ecommerce.BLL.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tiendung99.Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromotionController : ControllerBase
    {
        private IPromotionService _promotionService;
        public PromotionController(IPromotionService service)
        {
            _promotionService = service;
        }
        // GET: api/<PromotionController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _promotionService.GetAllAsync();
            return Ok(result);
        }

        // GET api/<PromotionController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await _promotionService.GetByIdAsync(id);
            return Ok(result);
        }

        // POST api/<PromotionController>
        [HttpPost]
        public async Task<IActionResult> Post(PromotionModel model)
        {
            await _promotionService.AddAsync(model);
            return Ok();
        }

        // PUT api/<PromotionController>/5
        [HttpPut()]
        public async Task<IActionResult> Put(PromotionModel model)
        {
            await _promotionService.UpdateAsync(model);
            return Ok();
        }

        // DELETE api/<PromotionController>/5
        [HttpDelete()]
        public async Task<IActionResult> Delete(PromotionModel model)
        {
            await _promotionService.DeleteAsync(model);
            return Ok();
        }
    }
}
