namespace MiCadeteria.Models;
public class CargaDeDatos //que formato tiene la informacion dentro de un archivo .csv
{
    public Cadeteria cargarCadeteria(string ruta)
    {
        Cadeteria nuevaCadeteria = null;
        if (File.Exists(ruta))
        {
            string texto = File.ReadAllText(ruta); //Suponemos que es una sola linea con los datos de la cadeteria
            //for (int i = 0; i < texto.Length; i++)
            //{
            string[] linea = texto.Split(";");
            nuevaCadeteria = new Cadeteria(linea[0], linea[1]);
            //listaCadeterias.Add(nuevaCadeteria);
            //}
            //nuevaCadeteria = new Cadeteria();
        }
        return nuevaCadeteria;
    }
    public List<Cadete> listaDeCadetes(string path)
    {
        List<Cadete> listaCadetes = new List<Cadete>();
        if (File.Exists(path))
        {
            string[] texto = File.ReadAllLines(path); //ReadAllLines - metodo utilizado para leer todas las lineas y dejarlas en un arreglo de string
            for (int i = 0; i < texto.Length; i++)
            {
                string[] linea = texto[i].Split(";");
                var nuevoCadete = new Cadete(linea[0], linea[1], linea[2], linea[3]);
                listaCadetes.Add(nuevoCadete);
            }
        }
        return listaCadetes;
    }
}