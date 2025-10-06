using System.Text.Json;
namespace MiCadeteria
{
    public class AccesoADatosPedidos
    {
        private readonly string _path;
        public AccesoADatosPedidos()
        {
            _path = "pedidos.json";
        }
        public List<Pedidos> Obtener()
        {
            if (File.Exists(_path))
            {
                var NuevaListaDeCadetes = JsonSerializer.Deserialize<List<Pedidos>>(File.ReadAllText(_path));
                return NuevaListaDeCadetes;
            }
            return new List<Pedidos>(); //retorna una lista con 0 elementos, para controllar con List<T>.Count()
        }
        public void Guardar(List<Pedidos> Pedidos)
        {
            //incompleto
        }
    }
}