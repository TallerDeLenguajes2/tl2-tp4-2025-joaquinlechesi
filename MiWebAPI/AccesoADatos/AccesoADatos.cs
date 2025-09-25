using System.Text.Json;
using MiCadeteria.Models;

namespace MiCadeteria
{
    public class AccesoADatos
    {
        public Cadeteria LeerCadeteria(string path)
        {
            if (!File.Exists(path))
            {
                return new Cadeteria();
            }
            string text = File.ReadAllText(path);
            Cadeteria NuevaCadeteria = new Cadeteria();
            NuevaCadeteria = JsonSerializer.Deserialize<Cadeteria>(path);
            return NuevaCadeteria;
        }
        public List<Pedidos> LeerPedidos(string path)
        {
            if (!File.Exists(path))
            {
                return new List<Pedidos>();
            }
            var json = File.ReadAllLines(path);
            return JsonSerializer.Deserialize<List<Pedidos>>(path);
        }
        // public List<Pedidos> GetAll(string path)
        // {
        //     return 
        // }
    }
}