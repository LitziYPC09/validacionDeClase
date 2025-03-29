 internal class Moto : Vehiculo 
    {
        public Moto(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo, 300) 
        {
            CapacidadTanque = 10; // Capacidad del tanque en galones
            ConsumoCombustible = 1; // Consumo de combustible en galones/km
            tipoLicenciaAceptados = new List<string> { "M", "A" }; // Solo acepta licencia tipo "M" o "A"
        }

        // Método específico de Moto
        public void HacerCaballito() 
        {
            if (EstadoTexto == "En movimiento") 
            {
                Console.WriteLine("¡Estás haciendo un caballito!");
            } 
            else 
            {
                Console.WriteLine("No puedes hacer un caballito si la moto no está en movimiento.");
            }
        }
    }