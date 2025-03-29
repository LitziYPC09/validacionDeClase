public class Chofer : IPiloto 
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string TipoLicencia { get; set; }

        public Chofer(string nombre, int edad, string tipoLicencia) 
        {
            // Validaciones de edad según tipo de licencia
            switch (tipoLicencia) 
            {
                case "A": // Motocicletas
                    if (edad < 16) 
                    {
                        throw new ArgumentException($"La edad mínima para licencia tipo {tipoLicencia} es 16 años.");
                    }
                    break;
                
                case "B": // Automóviles
                    if (edad < 18) 
                    {
                        throw new ArgumentException($"La edad mínima para licencia tipo {tipoLicencia} es 18 años.");
                    }
                    break;
                
                case "C": // Vehículos pesados
                    if (edad < 21) 
                    {
                        throw new ArgumentException($"La edad mínima para licencia tipo {tipoLicencia} es 21 años.");
                    }
                    break;
                
                case "M": // Motocicletas pequeñas
                    if (edad < 16) 
                    {
                        throw new ArgumentException($"La edad mínima para licencia tipo {tipoLicencia} es 16 años.");
                    }
                    break;
                
                default:
                    throw new ArgumentException("Tipo de licencia no válido.");
            }

            this.Nombre = nombre;
            this.Edad = edad;
            this.TipoLicencia = tipoLicencia;
        }

        public void MostrarInformacion() 
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Tipo de Licencia: {TipoLicencia}");
        }
    }
