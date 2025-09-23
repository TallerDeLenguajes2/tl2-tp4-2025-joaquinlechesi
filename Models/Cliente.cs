namespace CadeteriaModels;
public class Cliente //cuendo creo un cliente, puedo crear un pedido
{
    // Atributos
    public string nombre { get; set; }
    public string direccion { get; set; }
    public string telefono { get; set; }
    public string datosRefenciaDireccion { get; set; }
    // Constructor
    public Cliente(string nombre, string direccion, string telefono, string datosRefenciaDireccion)
    {
        this.nombre = nombre;
        this.direccion = direccion;
        this.telefono = telefono;
        this.datosRefenciaDireccion = datosRefenciaDireccion;
    }

}
