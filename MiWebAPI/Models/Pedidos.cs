namespace MiCadeteria;
public class Pedidos //relacion fuerte con el cliente
{
    public int numero{ get; set; }
    public string obs{ get; set; }
    private Cliente cliente;
    public bool estado { get; set; }
    public Cadete cadeteAsignado{ get; set; }
    // Constructor
    public Pedidos(int numero, string obs, Cliente cliente, Cadete cadete)
    {
        this.numero = numero;
        this.obs = obs;
        this.cliente = cliente;
        this.estado = false;
        this.cadeteAsignado = cadete;
    }
    public Pedidos(int numero, string obs)
    {
        this.numero = numero;
        this.obs = obs;
        this.estado = false;
        this.cliente = null;
        this.cadeteAsignado = null;
    }
    public Pedidos()
    {
        //Constructor para el json
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
    public void AsignarCadete(Cadete cadete)
    {
        this.cadeteAsignado = cadete;
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
