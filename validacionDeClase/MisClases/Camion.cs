internal class Camion : Vehiculo 
    {
        public Camion(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo, 120) 
        {
            CapacidadTanque = 150; // Capacidad del tanque en galones
            ConsumoCombustible = 5; // Consumo de combustible en galones/km
            tipoLicenciaAceptados = new List<string> { "A", "C" }; // Licencias para camiones
        }
    }