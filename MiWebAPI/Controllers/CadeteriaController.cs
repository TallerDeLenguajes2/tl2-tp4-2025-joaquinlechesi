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
            DatosCarga = new AccesoADatosJSON(); //uso la clase AccesoADatosJSON
            NuevaCadeteria = DatosCarga.NuevaCadeteria("cadeteria.json");
            NuevaCadeteria.agregarListaDeCadetes(DatosCarga.LecturaDeCadetes("cadetes.json"));
        }
        [HttpGet("getPedidos")]
        public IActionResult GetPedidos()
        {
            return Ok(NuevaCadeteria.ListaPedidos);//le pide al acceso a datos los pedidos existentes
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