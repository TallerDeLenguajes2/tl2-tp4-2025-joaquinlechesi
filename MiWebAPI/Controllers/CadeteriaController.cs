using System.Reflection.Metadata.Ecma335;
using MiCadeteria.Models;
using Microsoft.AspNetCore.Mvc; //siempre implementar

namespace MiCadeteria
{
    [ApiController]
    [Route("api/{controller}")]
    public class CadeteriaController : ControllerBase
    {
        private Cadeteria cadeteria;
        private AccesoADatosCadeteria ADCadeteria;
        private AccesoADatosCadete ADCadetes;
        private AccesoADatosPedidos ADPedidos;
        public CadeteriaController()
        {
            ADCadeteria = new AccesoADatosCadeteria();
            ADCadetes = new AccesoADatosCadete();
            ADPedidos = new AccesoADatosPedidos();

            cadeteria = ADCadeteria.Obtener(); //funciona, crea la cadeteria
            cadeteria.AgregarListaCadetes(ADCadetes.Obtener());
            cadeteria.AgregarListaPedidos(ADPedidos.Obtener()); //queda comentado para evitar que se muestre como error
        }
        [HttpGet("getCadeteria")] //solo de prueba
        public ActionResult<Cadeteria> GetCadeteria() //retorna la lista de pedidos //funcionando
        {
            return Ok(cadeteria);
        }
        [HttpGet("getPedidos")]
        public ActionResult<List<Pedidos>> GetPedidos() //retorna la lista de pedidos //funcionando
        {
            return cadeteria.ListadoPedidos.Count() == 0 ? BadRequest("No hay lista de pedidos en la cadeteria") : Ok(cadeteria.ListadoPedidos); //controla bien cuando hay elemenos y cuando no hay
        }
        [HttpGet("getCadetes")]
        public ActionResult<List<Cadete>> GetCadetes()
        {
            return Ok(cadeteria.ListaDeCadetes); //retorna bien la lista
        }
        // falta GetInforme

        [HttpPost("postAgregarPedido")]
        public ActionResult<Pedidos> PostAgregarPedido([FromBody] Pedidos NuevoPedido)
        {
            cadeteria.AgregarPedido(NuevoPedido);
            ADPedidos.Guardar(cadeteria.ListadoPedidos); //funciona
            return Ok(NuevoPedido); //retorna el objeto NuevoPedido
        }
        [HttpPut("putAsignarPedido")]
        public ActionResult<string> PutAsignarPedido(int idPedido, int idCadete)
        {
            //if (NuevaCadeteria.CantidadPedidos() > 0)
            //{
            //    var respuesta = NuevaCadeteria.AsignarCadeteAPedido(idCadete, idPedido);
            //    //var GestionArchivos = new AccesoADatosJSON();
            //    DatosCarga.GuardarPedidos(NuevaCadeteria.ListadoPedidos, "pedidos.json");
            //    return Ok(respuesta);
            //}
            if (cadeteria.ListadoPedidos.Count() == 0) return NotFound("No hay lista de pedidos");
            var resultado = cadeteria.AsignarCadeteAPedido(idCadete, idPedido);
            ADPedidos.Guardar(cadeteria.ListadoPedidos);
            return Ok(resultado); //funciona
        }
        // [HttpPut("putCambiarEstadoPedido")]
        // public IActionResult PutCambiarEstadoPedido(int idPedido, int NuevoEstado)
        // {
        //     if (NuevaCadeteria.ListadoPedidos != null)
        //     {
        //         var respuesta = NuevaCadeteria.CambiarEstado(idPedido, NuevoEstado);
        //         //var GestionArchivos = new AccesoADatosJSON();
        //         DatosCarga.GuardarPedidos(NuevaCadeteria.ListadoPedidos, "pedidos.json");
        //         return Ok(respuesta); //listo
        //     }
        //     return NotFound("No hay lista de pedidos"); //listo
        // }
    }
}
        // private IAccesoADatos DatosCarga = null;
        // private Cadeteria NuevaCadeteria = null;
        // Informe NuevoInforme = null; //falta hacer informe
        // public CadeteriaController() //recordar ingresar el nombre de la clase en el "controller"
        // {
        //     //constructor de la clase
        //     //DatosCarga = new AccesoADatosJSON(); //uso la clase AccesoADatosJSON
        //     DatosCarga = new AccesoADatosJSON();
        //     NuevaCadeteria = DatosCarga.NuevaCadeteria("cadeteria.json"); //la ruta relativa que busca el metodo es la carpeta del proyecto
        //     if (NuevaCadeteria != null)
        //     {
        //         NuevaCadeteria.ListaDeCadetes = DatosCarga.LecturaDeCadetes("cadetes.json");
        //         NuevaCadeteria.ListadoPedidos = DatosCarga.ListadoDePedidos("pedidos.json");
        //     }
        // }
        // [HttpGet("getPedidos")]
        // public IActionResult GetPedidos() //retorna la lista de pedidos //funcionando
        // {
        //     if (NuevaCadeteria.CantidadPedidos() > 0)
        //     {
        //         return Ok(NuevaCadeteria.ListadoPedidos);
        //     }
        //     return BadRequest("No hay lista de pedidos en la cadeteria"); //listo
        // }
        // [HttpGet("getCadetes")]
        // public ActionResult GetCadetes()
        // {
        //     if (NuevaCadeteria.ListaDeCadetes != null) //RECORRDAR: si no se crea la lista de cadetes queda como null
        //     {
        //         return Ok(NuevaCadeteria.ListaDeCadetes);
        //     }
        //     return BadRequest("No hay lista de cadetes"); //listo
        // }
        // [HttpGet("getInforme")]
        // public IActionResult GetInforme()
        // {
        //     //var Monto = NuevaCadeteria.MontoGanado();
        //     NuevoInforme = new Informe(NuevaCadeteria.MontoGanado(), NuevaCadeteria.CantidadPedidosEntregados(), NuevaCadeteria.PromedioEnviosTotal());
        //     DatosCarga.GuardarInforme(NuevoInforme, "informe.json");
        //     return Ok(NuevoInforme);//listo
        // }
        // [HttpPost("postAgregarPedido")]
        // public IActionResult PostAgregarPedido([FromBody] Pedidos NuevoPedido)
        // {
        //     NuevaCadeteria.AgregarPedido(NuevoPedido);
        //     //var GestionArchivos = new AccesoADatosJSON();
        //     DatosCarga.GuardarPedidos(NuevaCadeteria.ListadoPedidos, "pedidos.json");
        //     return Created(); //listo
        // }
        // [HttpPut("putAsignarPedido")]
        // public IActionResult PutAsignarPedido(int idPedido, int idCadete)
        // {
        //     if (NuevaCadeteria.CantidadPedidos() > 0)
        //     {
        //         var respuesta = NuevaCadeteria.AsignarCadeteAPedido(idCadete, idPedido);
        //         //var GestionArchivos = new AccesoADatosJSON();
        //         DatosCarga.GuardarPedidos(NuevaCadeteria.ListadoPedidos, "pedidos.json");
        //         return Ok(respuesta);
        //     }
        //     return NotFound("No hay lista de pedidos"); //listo
        // }
        // [HttpPut("putCambiarEstadoPedido")]
        // public IActionResult PutCambiarEstadoPedido(int idPedido, int NuevoEstado)
        // {
        //     if (NuevaCadeteria.ListadoPedidos != null)
        //     {
        //         var respuesta = NuevaCadeteria.CambiarEstado(idPedido, NuevoEstado);
        //         //var GestionArchivos = new AccesoADatosJSON();
        //         DatosCarga.GuardarPedidos(NuevaCadeteria.ListadoPedidos, "pedidos.json");
        //         return Ok(respuesta); //listo
        //     }
        //     return NotFound("No hay lista de pedidos"); //listo
        // }
        // [HttpPut("putCambiarCadetePedido")]
        // public IActionResult PutCambiarCadetePedido(int idPedido, int idNuevoCadete)
        // {
        //     if (NuevaCadeteria.CantidadPedidos() > 0)
        //     {
        //         //GetPedidos();
        //         var respuesta = NuevaCadeteria.AsignarCadeteAPedido(idNuevoCadete, idPedido);
        //         DatosCarga.GuardarPedidos(NuevaCadeteria.ListadoPedidos, "pedidos.json");
        //         return Ok(respuesta);
        //     }
        //     return NotFound("No hay lista de pedidos"); //listo
        // }

//FALTA IMPLEMENTAR LA CLASE ESTATICA PARA LA PERSISTENCIA DE DATOS     