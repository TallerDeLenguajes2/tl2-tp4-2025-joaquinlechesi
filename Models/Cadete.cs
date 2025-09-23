namespace CadeteriaModels;
public class Cadete
{
    //Atributos
    public int id { get; set; }
    public string nombre { get; set; }
    public string direccion { get; set; }
    public int telefono { get; set; }
    public List<Pedidos> listaPedidos{ get; set; } //generico, reemplazar por clase
    // Metodos
    // Constructores
    public Cadete(string id, string nombre, string direccion, string telefono)
    {
        this.id = Convert.ToInt32(id);
        this.nombre = nombre;
        this.direccion = direccion;
        this.telefono = Convert.ToInt32(telefono);
    }
    public Cadete(string id, string nombre, string direccion, string telefono, List<Pedidos> listaPedidos)
    {
        this.id = Convert.ToInt32(id);
        this.nombre = nombre;
        this.direccion = direccion;
        this.telefono = Convert.ToInt32(telefono);
        this.listaPedidos = listaPedidos;
    }

    public void agregarListaPedidos(List<Pedidos> listaPedidos)
    {
        this.listaPedidos = listaPedidos;
    }

    public double jornalACobrar()
    {
        double total = 0;
        foreach (var pedido in listaPedidos)
        {
            if (pedido.estado)
            {
                total++;
            }
        }
        return (total * 500);
    }

    // public Cadete()
    // {

    // }

    // private List<Pedidos> listaPedidos;
    // public Cadete(List<Pedidos> listaPedidos)
    // {
    //     this.listaPedidos = listaPedidos;
    // }
}