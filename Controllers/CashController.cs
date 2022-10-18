using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CashController : ControllerBase
    {
        private static List<Models.Moneda> lst = new List<Models.Moneda>();
        private void llenarLista()
        {
            lst.Add(new Models.Moneda("Dolar", 300));
            lst.Add(new Models.Moneda("Peso Argegntino", 1));
            lst.Add(new Models.Moneda("Uruguayo", 4));
            lst.Add(new Models.Moneda("Chile", 2));
        }




        [HttpGet]
        [Route("listar")]
        public IActionResult Get()
        {
            lst.Clear();
            llenarLista();
            return Ok(lst);
        }

        [HttpGet]
        [Route("listarNombre")]
        public IActionResult GetNombre(string nombre)
        {
            Models.Moneda oMoneda = lst.Find(m => m.nombre == nombre);
            return Ok(oMoneda);
        }

        [HttpPost]
        public IActionResult Post(Models.Moneda oMoneda)
        {
            lst.Add(oMoneda);
            return Ok(oMoneda);
        }
    }
}
