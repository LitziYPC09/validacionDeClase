 internal class Vehiculo 
    {
        public string Color { get; set; }
        public string Modelo { get; }
        public int Year { get; }
        
        private int velocidad = 0;
        
        // Propiedades protegidas para sobrescribir en clases derivadas
        protected int CapacidadTanque { get; set; } = 50; // Valor por defecto
        protected int ConsumoCombustible { get; set; } = 10; // Valor por defecto
        protected int VelocidadMaxima { get; set; } = 180; // Valor por defecto
        
        protected List<string> tipoLicenciaAceptados = new List<string> { "A", "B", "C" };
        
        private Chofer? piloto = null;
        private int estadoVehiculo = 0; // 0 = apagado, 1 = encendido, 2 = en movimiento

        // Propiedad para obtener el estado del vehículo como texto
        protected string EstadoTexto { get { return estadoVehiculo switch { 0 => "Apagado", 1 => "Encendido", 2 => "En movimiento", _ => "Desconocido" }; } }

        // Constructor
        public Vehiculo(int anio, string elColor, string elModelo, int velocidadMaxima) 
        {
            this.Color = elColor;
            this.Modelo = elModelo;
            this.Year = anio;
            this.VelocidadMaxima = velocidadMaxima;
        }

        // Método para asignar un piloto
        public string AsignarPiloto(Chofer elPiloto) 
        {
            if (elPiloto == null) return "No se puede asignar un piloto nulo";
            if (!tipoLicenciaAceptados.Contains(elPiloto.TipoLicencia)) { 
                return "El piloto no tiene la licencia adecuada a este carro"; 
            }
            if (piloto != null) { 
                return "Este vehiculo ya tiene asignado un piloto"; 
            }
            piloto = elPiloto;
            return "Piloto asignado correctamente";
        }

        // Método para encender
        public string Encender() 
        {
            if (piloto == null) { 
                return "No se puede encender el vehículo sin un piloto asignado"; 
            }
            if (estadoVehiculo == 0) { 
                estadoVehiculo = 1; // Cambia el estado del vehículo a encendido
                return "Listo! Vehículo arrancado"; 
            }
            return "El vehículo ya está encendido";
        }

        // Método para mostrar información del vehículo (mejorado)
        public void InformacionVehiculo() 
        {
            Console.WriteLine("Información del Vehículo:");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Año: {Year}");
            Console.WriteLine($"Velocidad Actual: {velocidad} km/h");
            Console.WriteLine($"Velocidad Máxima: {VelocidadMaxima} km/h");
            Console.WriteLine($"Capacidad del Tanque: {CapacidadTanque} galones");
            Console.WriteLine($"Consumo de Combustible: {ConsumoCombustible} galones/km");
            Console.WriteLine($"Estado del Vehículo: {EstadoTexto}");

            if (piloto != null) 
            {
                Console.WriteLine($"Piloto Asignado: {piloto.Nombre}, Edad: {piloto.Edad}, Licencia: {piloto.TipoLicencia}");
            } 
            else 
            {
                Console.WriteLine("Piloto Asignado: Ninguno");
            }
        }

        // Método para acelerar (mejorado)
        public virtual void acelerar(int cuanto) 
        {
            if (estadoVehiculo == 1) 
            {
                if (velocidad + cuanto > VelocidadMaxima) 
                {
                    Console.WriteLine($"¡Alerta! No se puede superar la velocidad máxima de {VelocidadMaxima} km/h.");
                    return;
                }
                
                velocidad += cuanto;
                Console.WriteLine($"Vas a {velocidad} km/h");
                estadoVehiculo = 2; // Cambia el estado a "en movimiento"
            } 
            else 
            {
                Console.WriteLine("No puedes acelerar si el vehículo está apagado");
            }
        }

        // Método para frenar
        public void Frenar(int cuanto) 
        {
            if (velocidad > 0) 
            {
                velocidad -= cuanto;
                
                if (velocidad < 0) 
                {
                    velocidad = 0;
                }
                
                Console.WriteLine($"Has frenado. Velocidad actual: {velocidad} km/h");
                
                if (velocidad == 0) 
                {
                    estadoVehiculo = 1; // Cambia el estado a "encendido"
                    Console.WriteLine("El vehículo está detenido y en estado encendido.");
                }
            } 
            else 
            {
                Console.WriteLine("El vehículo ya está detenido.");
            }
        }

        // Método para apagar
        public void Apagar() 
        {
            if (velocidad == 0) 
            {
                if (estadoVehiculo == 1) 
                {
                    estadoVehiculo = 0;
                    Console.WriteLine("El vehículo se ha apagado.");
                } 
                else 
                {
                    Console.WriteLine("El vehículo ya está apagado.");
                }
            } 
            else 
            {
                Console.WriteLine("No se puede apagar el vehículo en movimiento.");
            }
        }
    }