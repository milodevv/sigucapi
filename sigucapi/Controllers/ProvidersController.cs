using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sigucapi.Models;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace sigucapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvidersController : ControllerBase
    {
        private readonly ProvidersContext _providersContext;

        public ProvidersController(ProvidersContext providersContext)
        {
            _providersContext = providersContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProvidersDTO>>> ProvidersList()
        {
            var providers = await _providersContext.Providers.ToListAsync();
            return Ok(providers);
        }
    }
}
