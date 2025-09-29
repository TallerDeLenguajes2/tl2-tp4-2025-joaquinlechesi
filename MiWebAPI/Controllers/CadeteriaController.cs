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
            }
        }
        [HttpGet("getPedidos")]
        public IActionResult GetPedidos() //retorna la lista de pedidos //pendiente
        {
            if (NuevaCadeteria.ListadoPedidos != null)
            {
                Ok(NuevaCadeteria.ListadoPedidos);
            }
            return BadRequest("No hay lista de pedidos en la cadeteria");
        }
        [HttpGet("getCadetes")]
        public ActionResult GetCadetes()
        {
            if (this.NuevaCadeteria.ListaDeCadetes != null)
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
            //NuevaCadeteria.AgregarPedido(NuevoPedido);
            //var GestionArchivos = new GestionPedidos();
            //GestionArchivos.GuardarPedido("pedidos.json", NuevoPedido);
            
            return Ok(NuevoPedido.numero); //incompleto
        }
        [HttpPut("putAsignarPedido")]
        public IActionResult PutAsignarPedido(int idPedido, int idCadete)
        {
            return Ok(); //incompleto
        }
        [HttpPut("putCambiarEstadoPedido")]
        public IActionResult PutCambiarEstadoPedido(int idPedido, int NuevoEstado)
        {
            return Ok(); //incompleto
        }
        [HttpPut("putCambiarCadetePedido")]
        public IActionResult PutCambiarCadetePedido(int idPedido, int idNuevoCadete)
        {
            return Ok(); //incompleto
        }
    }
}