using System;

namespace ClinicaMedica.Negocio
{
    public class Paciente : Persona
    {
        private bool _tieneSeguro;
        private DateTime _fechaNacimiento;
        private int _idPaciente;

        //TODO Constructor completo
        public Paciente(string cedula, string nombre, string apellido,
                       string telefono, DateTime fechaNacimiento, bool tieneSeguro)
            : base(cedula, nombre, apellido, telefono)
        {
            _fechaNacimiento = fechaNacimiento;
            _tieneSeguro = tieneSeguro;
        }

        //TODO Constructor alternativo
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

        //TODO Implementación del método abstracto
        public override decimal CalcularCosto()
        {
            if (_tieneSeguro)
                return 500m;
            else
                return 1500m;
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