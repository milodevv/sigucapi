using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sigucapi.Models;

namespace sigucapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDataController : ControllerBase
    {
        private readonly OrderContext _orderContext;

        public OrderDataController(OrderContext orderContext)
        {
            _orderContext = orderContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderData>>> OrderList()
        {
            var orders = await _orderContext.OrderData.ToListAsync();

            return Ok(orders);
        }

        [HttpGet("{number}")]
        public async Task<ActionResult<OrderData>> GetOrderByNumber(string number)
        {
            var order = await _orderContext.OrderData.FirstOrDefaultAsync(e => e.order_number == number);

            if (order == null)
                return NotFound();

            return Ok(order);
        }

        [HttpPatch("{number}")]
        public async Task<ActionResult<OrderData>> UpdateStatuByOrderNumber(string number, [FromBody] string statu)
        {
            var order = await _orderContext.OrderData.FirstOrDefaultAsync(e => e.order_number == number);

            if (order == null)
                return NotFound();

            order.statu = statu;

            await _orderContext.SaveChangesAsync();

            return NoContent();
            //return Ok(order);
        }
    }
}
