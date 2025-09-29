namespace MiCadeteria;

// public class AccesoADatosCSV : IAccesoADatos//que formato tiene la informacion dentro de un archivo .csv
// {
//     public Cadeteria NuevaCadeteria(string ruta)
//     {
//         Cadeteria NuevaCadeteria = null;
//         if (File.Exists(ruta))
//         {
//             string texto = File.ReadAllText(ruta); //Suponemos que es una sola cadeteria
//             string[] arreglo = texto.Split(";");
//             NuevaCadeteria = new Cadeteria(arreglo[0], arreglo[1]);
//         }
//         return NuevaCadeteria;
//     }
//     public List<Cadete> LecturaDeCadetes(string path)
//     {
//         List<Cadete> listaCadetes = new List<Cadete>();
//         if (File.Exists(path))
//         {
//             string[] texto = File.ReadAllLines(path); //ReadAllLines - metodo utilizado para leer todas las lineas y dejarlas en un arreglo de string
//             for (int i = 0; i < texto.Length; i++)
//             {
//                 string[] linea = texto[i].Split(";");
//                 var nuevoCadete = new Cadete(linea[0], linea[1], linea[2], linea[3]);
//                 listaCadetes.Add(nuevoCadete);
//             }
//         }
//         return listaCadetes;
//     }
//     public void EscrituraDeDatos(string datos)
//     {
        
//     }
// }