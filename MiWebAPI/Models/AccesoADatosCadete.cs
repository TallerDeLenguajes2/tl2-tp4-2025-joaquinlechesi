using System.Text.Json;
namespace MiCadeteria
{
    public class AccesoADatosCadete
    {
        private readonly string _path;
        public AccesoADatosCadete()
        {
            _path = "cadetes.json";
        }
        public List<Cadete> Obtener()
        {
            if (File.Exists(_path))
            {
                var NuevaListaDeCadetes = JsonSerializer.Deserialize<List<Cadete>>(File.ReadAllText(_path));
                return NuevaListaDeCadetes;
            }
            return new List<Cadete>(); //dejo de esta forma para que no marque error
        }
    }
}