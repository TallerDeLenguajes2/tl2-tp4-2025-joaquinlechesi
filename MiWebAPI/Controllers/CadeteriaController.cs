using System.Reflection.Metadata.Ecma335;
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
            DatosCarga = new AccesoADatosJSON();
            NuevaCadeteria = DatosCarga.NuevaCadeteria("cadeteria.json"); //la ruta relativa que busca el metodo es la carpeta del proyecto
            if (NuevaCadeteria != null)
            {
                NuevaCadeteria.ListaDeCadetes = DatosCarga.LecturaDeCadetes("cadetes.json");
                NuevaCadeteria.ListadoPedidos = DatosCarga.ListadoDePedidos("pedidos.json");
            }
        }
        [HttpGet("getPedidos")]
        public IActionResult GetPedidos() //retorna la lista de pedidos //funcionando
        {
            if (NuevaCadeteria.CantidadPedidos() > 0)
            {
                return Ok(NuevaCadeteria.ListadoPedidos);
            }
            return BadRequest("No hay lista de pedidos en la cadeteria");
        }
        [HttpGet("getCadetes")]
        public ActionResult GetCadetes()
        {
            if (this.NuevaCadeteria.ListaDeCadetes.Count() != 0)
            {
                return Ok(NuevaCadeteria.ListaDeCadetes);
            }
            return BadRequest("No hay lista de cadetes"); //mensaje pendiente de corregir
        }
        [HttpGet("getInforme")] //pendiente
        public IActionResult GetInforme()
        {
            return Ok(); //incompleto //para el final
        }
        [HttpPost("postAgregarPedido")] //debo guardar el pedido
        public IActionResult PostAgregarPedido([FromBody] Pedidos NuevoPedido)
        {
            NuevaCadeteria.AgregarPedido(NuevoPedido);
            var GestionArchivos = new AccesoADatosJSON();
            GestionArchivos.GuardarPedidos(NuevaCadeteria.ListadoPedidos, "pedidos.json");
            return Created(); //incompleto
        }
        [HttpPut("putAsignarPedido")]
        public IActionResult PutAsignarPedido(int idPedido, int idCadete)
        {
            if (NuevaCadeteria.CantidadPedidos() > 0)
            {
                var respuesta = NuevaCadeteria.AsignarCadeteAPedido(idCadete, idPedido);
                var GestionArchivos = new AccesoADatosJSON();
                GestionArchivos.GuardarPedidos(NuevaCadeteria.ListadoPedidos, "pedidos.json");
                return Ok(respuesta);
            }
            return NotFound("No hay lista de pedidos");
        }
        [HttpPut("putCambiarEstadoPedido")]
        public IActionResult PutCambiarEstadoPedido(int idPedido, int NuevoEstado)
        {
            if (NuevaCadeteria.CantidadPedidos() > 0)
            {
                
            }
            return NotFound("No hay lista de pedidos");
        }
        [HttpPut("putCambiarCadetePedido")]
        public IActionResult PutCambiarCadetePedido(int idPedido, int idNuevoCadete)
        {
            return Ok(); //incompleto
        }
    }
}