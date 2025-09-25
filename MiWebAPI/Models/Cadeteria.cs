namespace MiCadeteria.Models;
public class Cadeteria
{
    public string nombre { get; set; }
    public int telefono { get; set; }
    private List<Cadete> cadetes; //generico
    // Constructores
    public Cadeteria(string nombre, int telefono) //puedo crear el objeto sin una lista de cadetes, se la agrego despues con un metodo
    {
        this.nombre = nombre;
        this.telefono = telefono;
    }
    public Cadeteria(string nombre, string telefono) //puedo crear el objeto sin una lista de cadetes, se la agrego despues con un metodo
    {
        this.nombre = nombre;
        this.telefono = Convert.ToInt32(telefono);
    }
    public Cadeteria(string nombre, int telefono, List<Cadete> listado) //puedo crear el objeto con las lista de cadetes
    {
        this.nombre = nombre;
        this.telefono = telefono;
        this.cadetes = listado;
    }
    public Cadeteria()
    {
        
    }
    public void agregarListaDeCadetes(List<Cadete> lista) //agrega por aparte la lista de cadetes
    {
        cadetes = lista;
    }
}

//optar la lectura por fuera de la clase cadeteria