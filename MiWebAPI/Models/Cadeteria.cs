using System.ComponentModel.Design;

namespace MiCadeteria;

public class Cadeteria
{
    public string nombre { get; set; }
    public int telefono { get; set; }
    //private List<Cadete> listaDeCadetes;
    public List<Cadete> ListaDeCadetes { get; set; } //generico
    public List<Pedidos> ListadoPedidos { get; set; }
    // Constructores
    public Cadeteria(string nombre, int telefono) //puedo crear el objeto sin una lista de cadetes, se la agrego despues con un metodo
    {
        this.nombre = nombre;
        this.telefono = telefono;
        this.ListadoPedidos = new List<Pedidos>();
    }
    public Cadeteria(string nombre, string telefono) //puedo crear el objeto sin una lista de cadetes, se la agrego despues con un metodo
    {
        this.nombre = nombre;
        this.telefono = Convert.ToInt32(telefono);
        this.ListadoPedidos = new List<Pedidos>();
    }
    public Cadeteria()
    {
        //this.ListaDeCadetes = null;    
    }
    public Cadeteria(bool estado)
    {
        this.ListaDeCadetes = null;
        this.ListadoPedidos = null;
    }
    // public void altaPedido(int id)
    // {
    //     //Datos del pedido
    //     //Pedidos nuevoPedido;
    //     //asigno el numero
    //     //observacion
    //     Console.WriteLine("Observacion:");
    //     string obs;
    //     obs = Console.ReadLine();
    //     Pedidos nuevoPedido = new Pedidos(id, obs);
    //     ListadoPedidos.Add(nuevoPedido);
    //     //asigno cliente
    //     //Cliente nuevoCliente;
    //     //Datos cliente
    //     //Nombre
    //     //Console.WriteLine("Nombre:");
    //     //string nombre = Console.ReadLine();
    //     //Direccion
    //     //Console.WriteLine("Direccion");
    //     //string direccion = Console.ReadLine();
    //     //Telefono
    //     Console.WriteLine("Telefono");
    //     //string telefono = Console.ReadLine();
    //     //Referencia
    //     //Console.WriteLine("Referencia");
    //     //string referencia = Console.ReadLine();
    //     //nuevoCliente = new Cliente(nombre, direccion, telefono, referencia);
    //     //nuevoPedido.agregarCliente(nuevoCliente);
    //     //return nuevoPedido;
    //     //pedido = nuevoPedido;
    // }
    // public void crearCliente()
    // {
    //     Cliente nuevoCliente;
    //     Console.WriteLine("Alta cliente");
    //     Console.WriteLine("Ingrese el nombre del cliente");
    //     string nombre;
    //     nombre = Console.ReadLine();
    //     Console.WriteLine("Ingrese el direccion del cliente");
    //     string direccion;
    //     direccion = Console.ReadLine();
    //     Console.WriteLine("Ingrese el telefono del cliente");
    //     string telefono;
    //     telefono = Console.ReadLine();
    //     Console.WriteLine("Ingrese datos de referencia del cliente");
    //     string datosReferencia;
    //     datosReferencia = Console.ReadLine();
    //     nuevoCliente = new Cliente(nombre, direccion, telefono, datosReferencia);
    // }
    // public Cadeteria(string nombre, int telefono, List<Cadete> listado) //genera dependecia
    // {
    //     this.nombre = nombre;
    //     this.telefono = telefono;
    //     this.cadetes = listado;
    // }
    // public void listaDeCadetes()//muestra la lista de cadetes
    // {
    //     if (cadetes.Count() != 0)
    //     {
    //         foreach (var cadete in cadetes)
    //         {
    //             Console.WriteLine($"ID: {cadete.id} - NOMBRE: {cadete.nombre} - DIRECCION: {cadete.direccion} - NUMERO: {cadete.telefono}");
    //         }
    //     }
    // }
    // public void listaDeCadetesConPedidos()//muestra la lista de cadetes, para mostrar desde la lista de cadetes
    // {
    //     if (cadetes.Count() != 0)
    //     {
    //         foreach (var cadete in cadetes)
    //         {
    //             Console.WriteLine($"ID: {cadete.id} - NOMBRE: {cadete.nombre} - DIRECCION: {cadete.direccion} - NUMERO: {cadete.telefono}");
    //             if (cadete.listaPedidos.Count() > 0)
    //             {
    //                 Console.WriteLine("LISTA DE PEDIDOS:");
    //                 foreach (var pedido in cadete.listaPedidos)
    //                 {
    //                     string estado = "NO ENTREGADO";
    //                     if (pedido.estado)
    //                     {
    //                         estado = "ENTREGADO";
    //                     }
    //                     Console.WriteLine($"NUMERO: {pedido.numero} - OBS: {pedido.obs} - ESTADO: {estado}");
    //                 }
    //             }
    //             else
    //             {
    //                 Console.WriteLine("El cadete no posee pedidos.");
    //             }
    //         }
    //         Console.WriteLine("\n");
    //     }
    // }
    // public void agregarListaDeCadetes(List<Cadete> lista) //agrega por aparte la lista de cadetes
    // {
    //     cadetes = lista;
    // }
    // public void cambioDeCadete() //funciona ok
    // {
    //     int numeroPedidoBuscar, idCadete;
    //     Console.WriteLine("Lista de Cadetes con sus pedidos:");
    //     listaDeCadetesConPedidos();
    //     Console.WriteLine("Ingrese el ID del pedido para asignarlo a otro cadete:");
    //     int.TryParse(Console.ReadLine(), out numeroPedidoBuscar);
    //     Console.WriteLine("Ingrese el ID del cadete al que le asignara el pedido:");
    //     int.TryParse(Console.ReadLine(), out idCadete);
    //     Pedidos nuevoPedido1 = null;
    //     Cadete cadeteAnterior = null;
    //     foreach (var cadete in cadetes)
    //     {
    //         foreach (var pedido in cadete.listaPedidos)
    //         {
    //             if (pedido.numero == numeroPedidoBuscar)
    //             {
    //                 nuevoPedido1 = pedido;
    //                 cadeteAnterior = cadete;
    //                 break; //¿puedo usar "break;"?
    //             }
    //         }
    //     }
    //     if (nuevoPedido1 != null)
    //     {
    //         foreach (var cadete in cadetes)
    //         {
    //             if (cadete.id == idCadete)
    //             {
    //                 cadete.agregarNuevoPedidoLista(nuevoPedido1);
    //                 cadeteAnterior.quitarPedido(numeroPedidoBuscar);
    //                 break;
    //             }
    //         }
    //     }
    // }

    public double JornalACobrar(int iDcadete)
    {
        double resultado = 0;
        foreach (var pedido in ListadoPedidos)
        {
            if ((pedido.cadeteAsignado != null) && (pedido.cadeteAsignado.Id == iDcadete) && (pedido.estado))
            {
                resultado++;
            }
        }
        return (resultado * 500);
    }
    public void AsignarCadeteAPedido(int IdCadete, int IdPedido)
    {
        //Pedidos nuevoPedido = null;
        foreach (var pedido in ListadoPedidos)
        {
            if (pedido.numero == IdPedido)
            {
                //nuevoPedido = pedido;
                foreach (var cadete in ListaDeCadetes)
                {
                    if (cadete.Id == IdCadete)
                    {
                        pedido.cadeteAsignado = cadete;
                        break;
                    }
                }
                break;
            }
        }
        // if (nuevoPedido != null)
        // {
        //     Cadete nuevoCadete = null;
        // }
    }
    public string GetNombre()
    {
        return this.nombre;
    }
    public void AgregarPedido(Pedidos NuevoPedido)
    {
        this.ListadoPedidos.Add(NuevoPedido);
    }
}
