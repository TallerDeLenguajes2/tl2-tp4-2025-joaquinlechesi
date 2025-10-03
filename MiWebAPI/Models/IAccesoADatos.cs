namespace MiCadeteria;

public interface IAccesoADatos
{
    //falta lectura de cadeteria
    Cadeteria NuevaCadeteria(string ruta);
    List<Cadete> LecturaDeCadetes(string ruta);
    void GuardarPedidos(List<Pedidos> ListadoActualDePedidos, string path);
    List<Pedidos> ListadoDePedidos(string path);
    public void GuardarInforme(Informe NuevoInforme, string path);
}
