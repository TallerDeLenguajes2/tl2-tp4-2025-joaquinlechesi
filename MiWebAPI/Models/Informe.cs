namespace MiCadeteria
{
    public class Informe
    {
        //public double montoGanado = 0;
        public double montoGanado { get; set; }
        //private int pedidosEntregadosTotal = 0;
        public double pedidosEntregadosTotal { get; set; }
        //private double promedioEnviosTotal = 0;
        public double promedioEnviosTotal { get; set; }
        public Informe()
        {
            //constructor vacio
        }
        public Informe(double monto, int pedidosEntregados, double promedioEnvios)
        {
            this.montoGanado = monto;
            this.pedidosEntregadosTotal = pedidosEntregados;
            this.promedioEnviosTotal = promedioEnvios;
        }
    }
    
}