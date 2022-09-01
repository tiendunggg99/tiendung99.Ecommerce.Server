using Microsoft.AspNetCore.Mvc;
using tiendung99.Ecommerce.BLL.IServices;
using tiendung99.Ecommerce.BLL.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tiendung99.Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IOrderService _orderService;
        public OrderController(IOrderService service)
        {
            _orderService = service;
        }
        // GET: api/<OrderController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _orderService.GetAllAsync();
            return Ok(result);
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await _orderService.GetByIdAsync(id);
            return Ok(result);
        }

        // POST api/<OrderController>
        [HttpPost]
        public async Task<IActionResult> Post(OrderModel model)
        {
            await _orderService.AddAsync(model);
            return Ok();
        }

        // PUT api/<OrderController>/5
        [HttpPut()]
        public async Task<IActionResult> Put(OrderModel model)
        {
            await _orderService.UpdateAsync(model);
            return Ok();
        }

        // DELETE api/<OrderController>/5
        [HttpDelete()]
        public async Task<IActionResult> Delete(OrderModel model)
        {
            await _orderService.DeleteAsync(model);
            return Ok();
        }
    }
}
