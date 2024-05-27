using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ReparacionFrenos:Servicio
{
    public override void RealizarServicio()
    {
        Console.WriteLine("  Realizando reparacion de frenos .");
    }
    public override double CalcularCosto()
    {
        return 100.0;// costo  reparacon de frenos
    }

    public override double CalcularTiempo()
    {
        return 3.0; //  3 horas  
    }
}
