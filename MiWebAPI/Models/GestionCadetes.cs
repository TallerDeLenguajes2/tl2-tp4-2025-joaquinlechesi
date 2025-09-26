namespace MiCadeteria;

public class GestionCadetes
{
    //METODO PARA MOSTRAR LOS CADETES
    public void VerCadetes(List<Cadete> ListaCadetes)
    {
        if (ListaCadetes != null)
        {
            foreach (var cadete in ListaCadetes)
            {
                Console.WriteLine($"{cadete.Id} - {cadete.Nombre}");
            }
        }else
        {
            Console.WriteLine("No hay cadetes en la lista.");
        }
        //Console.WriteLine("\n");
    }    
}