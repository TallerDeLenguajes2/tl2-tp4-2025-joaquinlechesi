using MiCadeteria.Models;
using Microsoft.AspNetCore.Mvc; //siempre implementar

namespace MiCadeteria
{
    [ApiController]
    [Route("api/{controller}")]
    public class CadeteriaController : ControllerBase
    {
        IAccesoADatos DatosCarga = null;
        Cadeteria NuevaCadeteria = null;
        //Informe NuevoInforme = null; //falta hacer informe
        public CadeteriaController()
        {
            //constructor de la clase
            DatosCarga = new AccesoADatosJSON();
        }
        //[HttpGet]
        // public IActionResult ObtenerCadeteria()
        // {
            
        // }
        // public IActionResult PostCadeteria(string path)
        // {

        //     if (true)
        //     {
        //         return NotFound("Ruta incorrecta");
        //     }
        // }
        // [HttpGet]
        // public IActionResult GetPedidos() //2)c) endpoint
        // {
        //     if (true)
        //     {

        //     }
        //     return Ok();
        // }
    }
}