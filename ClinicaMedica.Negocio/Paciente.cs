using System;

namespace ClinicaMedica.Negocio
{
    public class Paciente : Persona
    {
        private bool _tieneSeguro;
        private DateTime _fechaNacimiento;
        private int _idPaciente;
        private string _tipoConsulta = "";

        //TODO Constructor completo
        public Paciente(string cedula, string nombre, string apellido,
                       string telefono, DateTime fechaNacimiento, bool tieneSeguro)
            : base(cedula, nombre, apellido, telefono)
        {
            _fechaNacimiento = fechaNacimiento;
            _tieneSeguro = tieneSeguro;
        }

        // Constructor alternativo
        public Paciente(string cedula, string nombre, string apellido)
            : base(cedula, nombre, apellido)
        {
            _fechaNacimiento = DateTime.Now;
            _tieneSeguro = false;
        }

        //TODO Destructor
        ~Paciente()
        {
            Console.WriteLine($"Paciente {_nombre} {_apellido} liberado de memoria.");
        }

        public bool TieneSeguro { get => _tieneSeguro; set => _tieneSeguro = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public int IdPaciente { get => _idPaciente; set => _idPaciente = value; }
        public string TipoConsulta { get => _tipoConsulta; set => _tipoConsulta = value; }

        // Retorna el costo de la consulta segun el tipo y aplica 50% de descuento si tiene seguro.
        public override decimal CalcularCosto()
        {
            decimal costoBase = 0m;
            if (_tipoConsulta == "General") costoBase = 1500m;
            else if (_tipoConsulta == "Especialidad") costoBase = 3000m;
            else if (_tipoConsulta == "Emergencia") costoBase = 5000m;
            else if (_tipoConsulta == "Control") costoBase = 800m;
            else if (_tipoConsulta == "Laboratorio") costoBase = 1200m;

            if (!_tieneSeguro)
                return costoBase;

            return costoBase * 0.5m;
        }

        //TODO Sobreescritura del método virtual
        public override string ObtenerInfo()
        {
            return $"PACIENTE — {base.ObtenerInfo()} | " +
                   $"Seguro: {(_tieneSeguro ? "Sí" : "No")} | " +
                   $"Fecha Nac: {_fechaNacimiento:dd/MM/yyyy}";
        }

        //TODO Método normal
        public int CalcularEdad()
        {
            return DateTime.Now.Year - _fechaNacimiento.Year;
        }
    }
}