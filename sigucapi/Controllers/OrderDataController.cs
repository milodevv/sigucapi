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
    }
}
