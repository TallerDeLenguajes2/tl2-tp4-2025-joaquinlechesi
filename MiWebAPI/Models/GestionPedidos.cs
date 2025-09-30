using System.Text.Json;
namespace MiCadeteria;

public class GestionPedidos
{
    public void AltaPedido(List<Pedidos> listaDePedidos, int id)
    {
        //Datos del pedido
        Console.WriteLine("Observacion:");
        string obs;
        obs = Console.ReadLine();
        Pedidos nuevoPedido = new Pedidos(id, obs);
        listaDePedidos.Add(nuevoPedido);
    }
    // public void AsignarCadete(List<Pedidos> listaDePedidos, int NumeroPedido, Cadete cadete)
    // {
    //     foreach (var pedido in listaDePedidos)
    //     {
    //         if (pedido.numero == NumeroPedido)
    //         {
    //             pedido.cadeteAsignado = cadete;
    //             break;
    //         }
    //     }
    // }
    public void VerListadoPedidos(List<Pedidos> ListadoPedidos)
    {
        if (ListadoPedidos != null)
        {
            foreach (var pedido in ListadoPedidos)
            {
                string cadete = "SIN CADETE";
                string estado = "ENTREGADO";
                if (pedido.cadeteAsignado != null)
                {
                    cadete = "CADETE:" + pedido.cadeteAsignado.Nombre;
                }
                if (pedido.estado == 0)
                {
                    estado = "NO " + estado;
                }
                Console.WriteLine($"{pedido.numero} - {pedido.obs} - {cadete} - {estado}");
            }
        }
        else
        {
            Console.WriteLine("No hay pedidos en la lista.");
        }
    }
    // public void CambioDeEstado(List<Pedidos> ListadoPedidos, int iDPedido)
    // {
    //     foreach (var pedido in ListadoPedidos)
    //     {
    //         if (pedido.numero == iDPedido)
    //         {
    //             pedido.estado = 1;
    //             break;
    //         }
    //     }
    // }
    public void ReasignacionDeCadete(List<Pedidos> ListadoPedidos, List<Cadete> ListadoCadetes, int IdCadete, int IdPedido)
    {
        foreach (var pedido in ListadoPedidos)
        {
            if (pedido.numero == IdPedido && pedido.estado == 0)
            {
                //nuevoPedido = pedido;
                foreach (var cadete in ListadoCadetes)
                {
                    if (cadete.Id == IdCadete)
                    {
                        pedido.cadeteAsignado = cadete;
                        break;
                    }
                }
                break;
            }
        }
    }
    public void GuardarListadoPedido(string ruta, List<Pedidos> ListaDePedidos)
    {
        string ListadoPedidos = JsonSerializer.Serialize<List<Pedidos>>(ListaDePedidos);
        FileStream fs = new FileStream(ruta, FileMode.Create);
        using (StreamWriter st = new StreamWriter(fs))
        {
            st.WriteLine(ListadoPedidos);
            st.Close();
        }
    }
}