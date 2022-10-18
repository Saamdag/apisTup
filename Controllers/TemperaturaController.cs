using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using apis.Models;
namespace apis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemperaturaController : ControllerBase
    {
        static RegistroTemp registroTemp = new RegistroTemp();
        static List<Temperatura> lst = registroTemp.registros;

        [HttpGet]
        [Route("listarRegistros")]
        public IActionResult get()
        {

            if (lst.Count == 0) return BadRequest(lst);
            else return Ok(lst);
        }

        [HttpGet]
        [Route("listarRegistrosId")]
        public IActionResult get(int id)
        {

            var temp = lst.Find(t => t.iot == id);
            if (temp == null) return BadRequest(new List<Temperatura>());
            return Ok(temp);
        }

        [HttpPost]
        [Route("addTemp")]
        public IActionResult Post(Temperatura temp)
        {
            try
            {
                lst.Add(temp);
                return Ok(temp);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }
    }
}
