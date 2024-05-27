using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Moto : Vehiculo
{
    public override void RealizarMantenimiento()

    {
        Console.WriteLine("Realizando mantenimiento de la moto : lubricacion de la cadena y revision de neumaticos");
    }

    public override double ObtenerCostoMantenimiento()
    {
        return 100.0;// costo mantenimiento de la moto
    }

}
