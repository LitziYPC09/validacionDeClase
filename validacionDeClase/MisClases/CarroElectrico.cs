internal class CarroElectrico : Vehiculo 
    {
        private int cargaBateria;

        public CarroElectrico(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo, 200) 
        {
            CapacidadTanque = 0; // Sin tanque de combustible
            ConsumoCombustible = 0; // Sin consumo de combustible
            cargaBateria = 50; // Carga inicial de batería
            tipoLicenciaAceptados = new List<string> { "B" }; // Requiere licencia B
        }

        public override void acelerar(int cuanto) 
        {
            base.acelerar(cuanto);
            cargaBateria--; // Reduce carga de batería al acelerar
        }

        public int NivelBateria() 
        {
            return cargaBateria;
        }

        public void cargarBateria() 
        {
            cargaBateria++;
        }
    }
