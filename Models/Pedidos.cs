namespace CadeteriaModels;
public class Pedidos //relacion fuerte con el cliente
{
    public int numero{ get; set; }
    public string obs{ get; set; }
    private Cliente cliente;
    public bool estado { get; set; }
    // Constructor
    public Pedidos(int numero, string obs, Cliente cliente)
    {
        this.numero = numero;
        this.obs = obs;
        this.cliente = cliente;
        this.estado = false;
    }
    public Pedidos(int numero, string obs)
    {
        this.numero = numero;
        this.obs = obs;
        //this.cliente = cliente;
        this.estado = false;
    }
    // Metodos
    public void agregarCliente(Cliente nuevoCliente)
    {
        this.cliente = nuevoCliente;
    }
    public void verDireccionCliente()
    {
        Console.WriteLine(cliente.direccion);
    }
    public void verDatosCliente()
    {
        Console.WriteLine(cliente.nombre);
        Console.WriteLine(cliente.telefono);
    }

    // public Pedidos(int numero, string cliente, )
    // {
    // }

    // List<Pedidos> pedidos;
    // public Pedidos(List<Pedidos> pedidos)
    // {
    //     this.pedidos = pedidos;
    // }
}
