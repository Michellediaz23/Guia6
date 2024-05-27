
internal class program
{
    static void Main(string[] arg)
    {
        Console.WriteLine(" hello ,wordl");


        Vehiculo miCoche = new Coche();
        miCoche.RealizarMantenimento();// Output: realizando mantenimento del coche: cambio de aceite y revision de frenos.
        Console.WriteLine(" costo del mantenimiento del coche : $" + miCoche.ObtenerCostoMantenimiento());

        Vehiculo miMoto = new Moto();
        miMoto.RealizarMantenimento();
        Console.WriteLine("costo del mantenimiento de la moto : $" + miMoto.ObtenerCostoMantenimiento());

        miCoche.Lavar();    // Output: lavando el vehiculo
        Coche miCocheReal = new Coche();
        miCocheReal.Lavar();    // Output : lavando el coche con cera y shampo especial

        Servicio servicioAceite = new CambioAceite();
        servicioAceite.RealizarServicio(); // Output : realizando cambio de aceite
        Console.WriteLine("costo del cambio de aceite :$" + servicioAceite.CalcularCosto());

        Servicio servicioFrenos = new ReparacionFrenos();
        servicioFrenos.RealizarServicio();
        Console.WriteLine(" costo de la reparacion de frenos :$" + servicioFrenos.CalcularCosto());

        // servicio Ser= new Servicio();


        // Creamos un taller
        Taller taller = new();

        // Agregamos servicios al taller
        taller.AgregarServicio(new ReparacionFrenos());
        taller.AgregarServicio(new ReparacionFrenos());
        taller.AgregarServicio(new ReparacionFrenos());

        // Creamos un vehículo
        var vehiculo = new Vehiculo();

        // El vehículo se inscribe en el taller
        vehiculo.InscribirseEnTaller(taller);

        // Calculamos el tiempo total de servicio
        var totalTime = vehiculo.ObtenerTiempoTotalDeServicio();

        // Mostramos el resultado
        Console.WriteLine($"El tiempo total de servicio es: {totalTime} horas");

    }
}
