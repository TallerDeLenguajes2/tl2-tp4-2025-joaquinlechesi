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
        Informe NuevoInforme = null; //falta hacer informe
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
            return BadRequest("No hay lista de pedidos en la cadeteria"); //listo
        }
        [HttpGet("getCadetes")]
        public ActionResult GetCadetes()
        {
            if (NuevaCadeteria.ListaDeCadetes != null) //RECORRDAR: si no se crea la lista de cadetes queda como null
            {
                return Ok(NuevaCadeteria.ListaDeCadetes);
            }
            return BadRequest("No hay lista de cadetes"); //listo
        }
        [HttpGet("getInforme")] //pendiente
        public IActionResult GetInforme()
        {
            //var Monto = NuevaCadeteria.MontoGanado();
            NuevoInforme = new Informe(NuevaCadeteria.MontoGanado(), NuevaCadeteria.CantidadPedidosEntregados(), NuevaCadeteria.PromedioEnviosTotal());
            return Ok(NuevoInforme); //incompleto //para el final
        }
        [HttpPost("postAgregarPedido")] //debo guardar el pedido
        public IActionResult PostAgregarPedido([FromBody] Pedidos NuevoPedido)
        {
            NuevaCadeteria.AgregarPedido(NuevoPedido);
            //var GestionArchivos = new AccesoADatosJSON();
            DatosCarga.GuardarPedidos(NuevaCadeteria.ListadoPedidos, "pedidos.json");
            return Created(); //incompleto
        }
        [HttpPut("putAsignarPedido")]
        public IActionResult PutAsignarPedido(int idPedido, int idCadete)
        {
            if (NuevaCadeteria.CantidadPedidos() > 0)
            {
                var respuesta = NuevaCadeteria.AsignarCadeteAPedido(idCadete, idPedido);
                //var GestionArchivos = new AccesoADatosJSON();
                DatosCarga.GuardarPedidos(NuevaCadeteria.ListadoPedidos, "pedidos.json");
                return Ok(respuesta);
            }
            return NotFound("No hay lista de pedidos");
        }
        [HttpPut("putCambiarEstadoPedido")]
        public IActionResult PutCambiarEstadoPedido(int idPedido, int NuevoEstado)
        {
            if (NuevaCadeteria.CantidadPedidos() > 0)
            {
                var respuesta = NuevaCadeteria.CambiarEstado(idPedido, NuevoEstado);
                //var GestionArchivos = new AccesoADatosJSON();
                DatosCarga.GuardarPedidos(NuevaCadeteria.ListadoPedidos, "pedidos.json");
                return Ok(respuesta);
            }
            return NotFound("No hay lista de pedidos");
        }
        [HttpPut("putCambiarCadetePedido")]
        public IActionResult PutCambiarCadetePedido(int idPedido, int idNuevoCadete)
        {
            if (NuevaCadeteria.CantidadPedidos() > 0)
            {
                //GetPedidos();
                var respuesta = NuevaCadeteria.AsignarCadeteAPedido(idNuevoCadete, idPedido);
                DatosCarga.GuardarPedidos(NuevaCadeteria.ListadoPedidos, "pedidos.json");
                return Ok(respuesta);
            }
            return NotFound("No hay lista de pedidos");
        }
    }
}