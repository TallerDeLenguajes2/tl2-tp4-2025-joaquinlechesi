using MiCadeteria.Models;
using Microsoft.AspNetCore.Mvc; //siempre implementar

namespace MiCadeteria
{
    [ApiController]
    [Route("api/{controller}")]
    public class CadeteriaController : ControllerBase
    {
        private IAccesoADatos DatosCarga = null;
        private Cadeteria NuevaCadeteria = null;
        //Informe NuevoInforme = null; //falta hacer informe
        public CadeteriaController() //recordar ingresar el nombre de la clase en el "controller"
        {
            //constructor de la clase
            //DatosCarga = new AccesoADatosJSON(); //uso la clase AccesoADatosJSON
            this.DatosCarga = new AccesoADatosJSON();
            this.NuevaCadeteria = DatosCarga.NuevaCadeteria("cadeteria.json"); //la ruta relativa que busca el metodo es la carpeta del proyecto
            if (NuevaCadeteria != null)
            {
                this.NuevaCadeteria.ListaDeCadetes = DatosCarga.LecturaDeCadetes("..\\Models\\cadetes.json");
            }
        }
        //[HttpGet("getPedidos")]
        //public IActionResult GetPedidos()
        //{
        //    return Ok(NuevaCadeteria.ListadoPedidos);
        //}
        [HttpGet("getCadeteria")]
        public ActionResult GetCadeteria()
        {
            if (this.NuevaCadeteria != null)
            {
                return Ok("Cadeteria creada.");
            }
            return BadRequest("No se pudo crear la cadeteria.");
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