using System;


class Program
{
    static void Main(string[] args)
    {
        // Demostración de creación de pilotos
        Chofer piloto1 = new Chofer("Monica", 18, "B"); 
        Chofer piloto2 = new Chofer("Andrea", 31, "C");
        Chofer piloto3 = new Chofer("Pedro", 24, "M"); 

        piloto1.MostrarInformacion();
        Console.WriteLine();
        piloto2.MostrarInformacion();
        Console.WriteLine();
        piloto3.MostrarInformacion();
        Console.WriteLine();

        // Prueba de velocidad máxima con Vehículo Sedan
        Vehiculo sedan = new Vehiculo(2025, "Rojo", "Toyota", 180);
        sedan.InformacionVehiculo();
        sedan.Encender();
        sedan.acelerar(100);
        sedan.acelerar(90); // Esto excederá la velocidad máxima y mostrará un mensaje
        Console.WriteLine();

        // Prueba con Auto Chevrolet
        Auto Chevrolet = new Auto(2026, "Blanco", "Chevrolet", 200);
        Chevrolet.InformacionVehiculo();
        Console.WriteLine(Chevrolet.AsignarPiloto(new Chofer("Andrea", 31, "B")));
        Console.WriteLine(Chevrolet.Encender());
        Chevrolet.acelerar(150);
        Chevrolet.acelerar(60);
        Console.WriteLine();

        // Prueba con Freno y Apagar (Porsche 911)
        Auto Porsche911 = new Auto(2026, "Gris", "Porsche 911", 200);
        Porsche911.InformacionVehiculo();
        Console.WriteLine(Porsche911.AsignarPiloto(new Chofer("Carlos", 35, "B"))); 
        Console.WriteLine(Porsche911.Encender());
        Porsche911.acelerar(150);
        Porsche911.Frenar(50); 
        Porsche911.Frenar(100); 
        Porsche911.Apagar(); 
        Porsche911.acelerar(60); 
        Console.WriteLine();

        // Prueba con Moto
        Moto miMoto = new Moto(2025, "Negro", "Harley Davidson");
        miMoto.InformacionVehiculo();
        Console.WriteLine(miMoto.AsignarPiloto(new Chofer("Luis", 28, "M")));
        miMoto.Encender();
        miMoto.acelerar(80);
        miMoto.InformacionVehiculo();
        miMoto.HacerCaballito(); 
        Console.WriteLine();

        // Prueba con Camión
        Camion miCamion = new Camion(2025, "Blanco", "Volvo");
        miCamion.InformacionVehiculo();
        Console.WriteLine(miCamion.AsignarPiloto(new Chofer("Juan", 45, "C")));
        miCamion.Encender();
        miCamion.acelerar(50);
        miCamion.InformacionVehiculo();
        Console.WriteLine();

        // Prueba con Carro Eléctrico
        CarroElectrico miAutoElectrico = new CarroElectrico(2025, "Azul", "Tesla Model S");
        miAutoElectrico.InformacionVehiculo();
        Console.WriteLine(miAutoElectrico.AsignarPiloto(new Chofer("Ana", 30, "B")));
        miAutoElectrico.Encender();
        miAutoElectrico.acelerar(100);
        miAutoElectrico.InformacionVehiculo();
        miAutoElectrico.cargarBateria();
    }
}