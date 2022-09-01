using Microsoft.AspNetCore.Mvc;
using tiendung99.Ecommerce.BLL.IServices;
using tiendung99.Ecommerce.BLL.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tiendung99.Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailController : ControllerBase
    {
        private IOrderDetailService _orderDetailService;
        public OrderDetailController(IOrderDetailService service)
        {
            _orderDetailService = service;
        }
        // GET: api/<OrderDetailController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _orderDetailService.GetAllAsync();
            return Ok(result);
        }

        // GET api/<OrderDetailController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await _orderDetailService.GetByIdAsync(id);
            return Ok(result);
        }

        // POST api/<OrderDetailController>
        [HttpPost]
        public async Task<IActionResult> Post(OrderDetailModel model)
        {
            await _orderDetailService.AddAsync(model);
            return Ok();
        }

        // PUT api/<OrderDetailController>/5
        [HttpPut()]
        public async Task<IActionResult> Put(OrderDetailModel model)
        {
            await _orderDetailService.UpdateAsync(model);
            return Ok();
        }

        // DELETE api/<OrderDetailController>/5
        [HttpDelete()]
        public async Task<IActionResult> Delete(OrderDetailModel model)
        {
            await _orderDetailService.DeleteAsync(model);
            return Ok();
        }
    }
}
