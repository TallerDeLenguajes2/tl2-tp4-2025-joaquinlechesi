using Microsoft.AspNetCore.Mvc; //siempre implementar

namespace Cadeteria
{
    [ApiController]
    [Route("api/{controller}")]
    public class CadeteriaController : ControllerBase
    {
        public CadeteriaController()
        {
            //constructor de la clase
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