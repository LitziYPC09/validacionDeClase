internal class Auto : Vehiculo 
    {
        public Auto(int anio, string elColor, string elModelo, int velocidadMaxima) : base(anio, elColor, elModelo, velocidadMaxima) 
        {
            tipoLicenciaAceptados = new List<string> { "B" };
            CapacidadTanque = 60; // Capacidad específica para autos
            ConsumoCombustible = 8; // Consumo específico para autos
        }
    }