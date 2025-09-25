using Microsoft.AspNetCore.Mvc; //siempre implementar

namespace MiCadeteria
{
    [ApiController]
    [Route("api/{controller}")]
    public class CadeteriaController : ControllerBase
    {
        public CadeteriaController()
        {
            //constructor de la clase
        }

        public IActionResult PostCadeteria(string path)
        {
            
            if (true)
            {
                return NotFound("Ruta incorrecta");
            }
        }
        [HttpGet]
        public IActionResult GetPedidos()
        {
            if (true)
            {
                
            }
            return Ok();
        }
    }
}