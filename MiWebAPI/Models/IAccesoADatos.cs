namespace MiCadeteria.Models;
public interface IAccesoADatos
{
    //falta lectura de cadeteria
    Cadeteria NuevaCadeteria(string ruta);
    List<Cadete> LecturaDeCadetes(string ruta);
    void EscrituraDeDatos(string ruta);
}
