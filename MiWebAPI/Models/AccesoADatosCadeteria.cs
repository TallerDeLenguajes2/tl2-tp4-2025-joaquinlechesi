using System.Text.Json;

namespace MiCadeteria
{
    public class AccesoADatosCadeteria
    {
        private readonly string _path;
        public AccesoADatosCadeteria()
        {
            _path = "cadeteria.json";
        }
        public Cadeteria Obtener()
        {
            if (File.Exists(_path))
            {
                var NuevaCadeteria = JsonSerializer.Deserialize<Cadeteria>(File.ReadAllText(_path));
                //NuevaCadeteria.Lis
                return NuevaCadeteria;
            }
            return new Cadeteria(); //dejo de esta forma para que no marque error
        }
    }
}