using System;

namespace ClinicaMedica.Negocio
{
    // Representa un paciente. Extiende Persona con seguro medico y fecha de nacimiento.
    public class Paciente : Persona
    {
        private bool _tieneSeguro;
        private DateTime _fechaNacimiento;
        private int _idPaciente;
        private string _tipoConsulta = "";

        // Constructor completo con todos los campos
        public Paciente(string cedula, string nombre, string apellido,
                       string telefono, DateTime fechaNacimiento, bool tieneSeguro)
            : base(cedula, nombre, apellido, telefono)
        {
            _fechaNacimiento = fechaNacimiento;
            _tieneSeguro = tieneSeguro;
        }

        // Constructor alternativo - usa valores por defecto para los campos opcionales
        public Paciente(string cedula, string nombre, string apellido)
            : base(cedula, nombre, apellido)
        {
            _fechaNacimiento = DateTime.Now;
            _tieneSeguro = false;
        }

        // Destructor
        ~Paciente()
        {
            Console.WriteLine($"Paciente {_nombre} {_apellido} liberado de memoria.");
        }

        public bool TieneSeguro { get => _tieneSeguro; set => _tieneSeguro = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public int IdPaciente { get => _idPaciente; set => _idPaciente = value; }
        public string TipoConsulta { get => _tipoConsulta; set => _tipoConsulta = value; }

        // Retorna el costo de la consulta segun el tipo y aplica 50% de descuento si tiene seguro
        public override decimal CalcularCosto()
        {
            decimal costoBase = 0m;
            if (_tipoConsulta == "General") costoBase = 1500m;
            else if (_tipoConsulta == "Especialista") costoBase = 3000m;
            else if (_tipoConsulta == "Control") costoBase = 800m;
            else if (_tipoConsulta == "Emergencia") costoBase = 5000m;
            else if (_tipoConsulta == "Laboratorio") costoBase = 1200m;

            if (!_tieneSeguro)
                return costoBase;

            return costoBase * 0.5m;
        }

        // Sobreescritura de ObtenerInfo de Persona - agrega seguro y fecha de nacimiento
        public override string ObtenerInfo()
        {
            return $"PACIENTE — {base.ObtenerInfo()} | " +
                   $"Seguro: {(_tieneSeguro ? "Sí" : "No")} | " +
                   $"Fecha Nac: {_fechaNacimiento:dd/MM/yyyy}";
        }

        // Retorna la edad del paciente calculada en base al año de nacimiento
        public int CalcularEdad()
        {
            return DateTime.Now.Year - _fechaNacimiento.Year;
        }
    }
}
