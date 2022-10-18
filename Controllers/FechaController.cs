using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FechaController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            Models.Fecha fecha = new Models.Fecha();

            return Ok(fecha);
        }

    }
}
