using System.Text.Json;

namespace MiCadeteria.Models;

public class AccesoADatosJSON : IAccesoADatos
{
    public Cadeteria NuevaCadeteria(string ruta)
    {
        Cadeteria NuevaCadeteria = null;
        if (File.Exists(ruta))
        {
            string texto = File.ReadAllText(ruta);
            NuevaCadeteria = new Cadeteria();
            NuevaCadeteria = JsonSerializer.Deserialize<Cadeteria>(texto);
        }
        return NuevaCadeteria;
    }
    public List<Cadete> LecturaDeCadetes(string ruta)
    {
        List<Cadete> ListaDeCadetes = null;
        if (File.Exists(ruta))
        {
            string texto = File.ReadAllText(ruta);
            //ListaDeCadetes = new List<Cadete>();
            //ListaDeCadetes = new List<Cadete>();
            ListaDeCadetes = JsonSerializer.Deserialize<List<Cadete>>(texto);
        }
        return ListaDeCadetes;
    }
    public void EscrituraDeDatos(string datos)
    {
        
    }
}