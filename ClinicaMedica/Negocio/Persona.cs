using System;

namespace ClinicaMedica.Negocio
{
    public abstract class Persona
    {
        //TODO Clase Abstracto
        protected string _cedula;
        protected string _nombre;
        protected string _apellido;
        protected string _telefono;

        // Constructor completo
        public Persona(string cedula, string nombre, string apellido, string telefono)
        {
            _cedula = cedula;
            _nombre = nombre;
            _apellido = apellido;
            _telefono = telefono;
        }

        // Constructor alternativo
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

        //TODO Método abstracto
        public abstract decimal CalcularCosto();

        //TODO Método virtual
        public virtual string ObtenerInfo()
        {
            return $"Nombre: {_nombre} {_apellido} | Cédula: {_cedula}";
        }

        //TODO Método normal
        public string NombreCompleto()
        {
            return $"{_nombre} {_apellido}";
        }
    }
}