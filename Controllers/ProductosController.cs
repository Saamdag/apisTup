using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using apis.Servicios;
namespace apis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase 
    {
        IAplicacion aplicacion = new Aplicacion();

        [HttpGet]
        [Route("readProductos")]
        public IActionResult get()
        {
            try
            {
                return Ok(aplicacion.read());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpGet]
        [Route("readProductosId")]
        public IActionResult get(int id)
        {
            var p = aplicacion.read(id);
            if(p == null) return BadRequest($"Producto con codigo {id} no encontrado");
            else return Ok(p);

            //try
            //{
            //    return Ok(aplicacion.read(id));
            //}
            //catch (Exception ex)
            //{
            //}
        }

        [HttpPost]
        [Route("createProducto")]
        public IActionResult post(int codigo,string nombre,decimal precio)
        {
            try
            {
                return Ok(aplicacion.create(codigo, nombre, precio));   
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


    }
}
