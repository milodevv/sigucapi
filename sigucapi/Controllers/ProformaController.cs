using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sigucapi.Models;

namespace sigucapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProformaController : ControllerBase
    {
        private readonly ProformaContext _context;
        private readonly OrderContext _orderContext;

        public ProformaController(ProformaContext context, OrderContext orderContext)
        {
            _context = context;
            _orderContext = orderContext;
        }

        [HttpGet("{number}")]
        public async Task<ActionResult<IEnumerable<Proforma>>> GetProformaByNumber(string number)
        {
            var proforma = await _context.Proforma.FirstOrDefaultAsync(e => e.order_number == number);
            var orders = await _orderContext.OrderData.Where(e => e.proforma_id == number).ToListAsync();

            foreach (var order in orders)
            {
                proforma.orders.Add(order);
            }

            if(proforma == null)
                return NotFound();

            return Ok(proforma);
        }
    }
}
