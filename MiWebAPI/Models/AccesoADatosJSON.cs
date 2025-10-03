using System.Text.Json;

namespace MiCadeteria;

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
    public List<Pedidos> ListadoDePedidos(string path)
    {
        if (File.Exists(path))
        {
            string texto = File.ReadAllText(path);
            var Listado = JsonSerializer.Deserialize<List<Pedidos>>(texto);
            return Listado;
        }
        return new List<Pedidos>(); //sería como devolver una lista vacia
    }
    public void GuardarPedidos(List<Pedidos> ListadoActualDePedidos, string path)
    {
        string ListadoPedidos = JsonSerializer.Serialize<List<Pedidos>>(ListadoActualDePedidos);
        FileStream fs = new FileStream(path, FileMode.Create);
        using (StreamWriter st = new StreamWriter(fs))
        {
            st.WriteLine(ListadoPedidos);
            st.Close();
        }
    }
    public void GuardarInforme(Informe NuevoInforme, string path)
    {
        string InformeAGuardar = JsonSerializer.Serialize<Informe>(NuevoInforme);
        FileStream fs = new FileStream(path, FileMode.Create);
        using (StreamWriter st = new StreamWriter(fs))
        {
            st.WriteLine(InformeAGuardar);
            st.Close();
        }
    }
}