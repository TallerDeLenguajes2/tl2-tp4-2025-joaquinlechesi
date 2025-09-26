namespace MiCadeteria;

public class GestionCadeteria
{
    public Cadeteria CrearCadeteria(string ruta)
    {
        Cadeteria NuevaCadeteria = null;
        if (File.Exists(ruta))
        {
            string texto = File.ReadAllText(ruta); //Suponemos que es una sola cadeteria
            string[] arreglo = texto.Split(";");
            NuevaCadeteria = new Cadeteria(arreglo[0], arreglo[1]);
        }
        return NuevaCadeteria;
    }
}