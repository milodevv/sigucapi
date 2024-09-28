using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sigucapi.Models;

namespace sigucapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesOrderController : ControllerBase
    {
        private readonly SalesOrderContext _salesOrderContext;

        public SalesOrderController(SalesOrderContext salesOrderContext)
        {
            _salesOrderContext = salesOrderContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SalesOrder>>> NoteList()
        {
            var salesOrders = await _salesOrderContext.SalesOrders.ToListAsync();

            return Ok(salesOrders);
        }
    }
}
