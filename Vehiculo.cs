
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Vehiculo
{
    private List<Servicio> _servicios;

    public virtual void RealizarMantenimento()
    {
        Console.WriteLine("Realizar mantenimiento general del Vehiculo.");
    }

    public virtual double ObtenerCostoMantenimiento()
    {
        return 50.0;// costo base del mantenimiento general



    }
    public void Lavar()
    {
        Console.WriteLine(" lavando el vehiculo");
    }



    public double CalcularTiempoTotal(List<Servicio> servicios)
    {
        double totalTime = 0;

        foreach (var servicio in servicios)
        {
            totalTime += servicio.CalcularTiempo();
        }
        return totalTime;



    }

  

    
}




        





