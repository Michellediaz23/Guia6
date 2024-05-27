using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Coche : Vehiculo
{
    public override void RealizarMantenimento()


    {
        Console.WriteLine("Realizar mantenimiento del coche : cambio de aceite y revision de frenos");
    }

    public override double ObtenerCostoMantenimiento()
    {
        return 150.0; // costo del mantemiento del coche
    }

    public new Lavar()
    {
        Console.WriteLine("lavando el coche con cera y shampo especial.");
    }
}
