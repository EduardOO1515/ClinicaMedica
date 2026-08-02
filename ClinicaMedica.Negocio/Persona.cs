using System;

namespace ClinicaMedica.Negocio
{
    // Clase base abstracta para todas las personas del sistema (pacientes y doctores)
    public abstract class Persona
    {
        protected string _cedula;
        protected string _nombre;
        protected string _apellido;
        protected string _telefono;

        // Constructor completo con todos los campos
        public Persona(string cedula, string nombre, string apellido, string telefono)
        {
            _cedula = cedula;
            _nombre = nombre;
            _apellido = apellido;
            _telefono = telefono;
        }

        // Constructor alternativo - telefono queda como valor por defecto
        public Persona(string cedula, string nombre, string apellido)
        {
            _cedula = cedula;
            _nombre = nombre;
            _apellido = apellido;
            _telefono = "Sin teléfono";
        }

        public string Cedula { get => _cedula; set => _cedula = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }

        // Metodo abstracto - debe ser implementado por las subclases
        public abstract decimal CalcularCosto();

        // Metodo virtual - puede ser sobreescrito para mostrar detalles especificos del rol
        public virtual string ObtenerInfo()
        {
            return $"Nombre: {_nombre} {_apellido} | Cédula: {_cedula}";
        }

        // Retorna el nombre completo como una sola cadena
        public string NombreCompleto()
        {
            return $"{_nombre} {_apellido}";
        }
    }
}
