using System.Text;
using System.Text.Json.Serialization;

namespace MiCadeteria;

public class Cadete
{
    //Atributos
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    //public List<Pedidos> listaPedidos { get; set; } //generico, reemplazar por clase
    // Metodos
    // Constructores
    public Cadete(int id, string nombre, string direccion, string telefono)
    {
        this.Id = id;
        this.Nombre = nombre;
        this.Direccion = direccion;
        this.Telefono = telefono;
        //this.listaPedidos = new List<Pedidos>();
    }
    public Cadete(string id, string nombre, string direccion, string telefono)
    {
        this.Id = Convert.ToInt32(id);
        this.Nombre = nombre;
        this.Direccion = direccion;
        this.Telefono = telefono;
        //this.listaPedidos = new List<Pedidos>();
    }
    public Cadete() //JSON emplea un constructor VACIO
    {
        //Constructor vacio
    }
    // public Cadete(string id, string nombre, string direccion, string telefono, List<Pedidos> listaPedidos)
    // {
    //     this.id = Convert.ToInt32(id);
    //     this.nombre = nombre;
    //     this.direccion = direccion;
    //     this.telefono = Convert.ToInt32(telefono);
    //     this.listaPedidos = listaPedidos;
    // }
    // public void agregarNuevoPedidoLista(Pedidos nuevoPedido)
    // {
    //     this.listaPedidos.Add(nuevoPedido);
    // }
    //public void agregarListaPedidos(List<Pedidos> listaPedidos)
    //{
    //    this.listaPedidos = listaPedidos;
    //}

    // public double jornalACobrar()
    // {
    //     double total = 0;
    //     foreach (var pedido in listaPedidos)
    //     {
    //         if (pedido.estado)
    //         {
    //             total++;
    //         }
    //     }
    //     return (total * 500);
    // }
    //LISTAR PEDIDOS
    // public void listaDePedidos() //para mostrar desde el cadete
    // {
    //     if (listaPedidos.Count() > 0)
    //     {
    //         Console.WriteLine($"{nombre}:\nLISTA DE PEDIDOS");
    //         foreach (var pedido in listaPedidos)
    //         {
    //             string estado = "NO ENTREGADO";
    //             if (pedido.estado)
    //             {
    //                 estado = "ENTREGADO";
    //             }
    //             Console.WriteLine($"NUMERO: {pedido.numero} - OBS: {pedido.obs} - ESTADO: {estado}");
    //         }
    //     }
    //     else
    //     {
    //         Console.WriteLine("El cadete no posee pedidos.");
    //     }
    // }
    // public void cambiarEstado(int numero)
    // {
    //     if (listaPedidos != null)
    //     {
    //         foreach (var pedido in listaPedidos)
    //         {
    //             if (pedido.numero == numero)
    //             {
    //                 //pedido.estado = !(pedido.estado);
    //                 pedido.estado = true;
    //             }
    //         }
    //     }
    // }
    // public void quitarPedido(int numero)
    // {
    //     foreach (var pedido in listaPedidos)
    //     {
    //         if (pedido.numero == numero)
    //         {
    //             listaPedidos.Remove(pedido);
    //             break;
    //         }
    //     }
    // }
    // public void cambioDeCadete(Cadete nuevoCadeteParaPedido, int numero)
    // {
    //     foreach (var pedido in listaPedidos)
    //     {
    //         if (pedido.numero == numero)
    //         {
    //             nuevoCadeteParaPedido.listaPedidos.Add(pedido);
    //             this.listaPedidos.Remove(pedido);
    //         }
    //     }
    // }
    // public int cantidadEnviosCompletados()
    // {
    //     int cantidad = 0;
    //     foreach (var pedido in listaPedidos)
    //     {
    //         if (pedido.estado)
    //         {
    //             cantidad++;
    //         }
    //     }
    //     return cantidad;
    // }
    // public double promedioEnviosCadete()
    // {
    //     double resultado = 0;
    //     if (cantidadEnviosCompletados() > 0)
    //     {
    //         resultado = (listaPedidos.Count() / cantidadEnviosCompletados());
    //     }
    //     return resultado;
    // }

    // public Pedidos pedidoConsulado(int numero)
    // {
    //     Pedidos resultado = null;
    //     if (listaPedidos != null)
    //     {
    //         foreach (var pedido in listaPedidos)
    //         {
    //             if (pedido.numero == numero)
    //             {
    //                 resultado = pedido;
    //             }
    //         }
    //     }
    //     return resultado;
    // }
    // public Cadete()
    // {

    // }

    // private List<Pedidos> listaPedidos;
    // public Cadete(List<Pedidos> listaPedidos)
    // {
    //     this.listaPedidos = listaPedidos;
    // }
}
