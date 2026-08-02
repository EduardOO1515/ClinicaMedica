using System;

namespace ClinicaMedica.Negocio
{
    // Representa un doctor. Extiende Persona con especialidad y correo electronico.
    public class Doctor : Persona
    {
        private string _especialidad;
        private string _email;
        private int _idDoctor;
        private int _idEspecialidad;

        // Constructor completo con todos los campos
        public Doctor(string cedula, string nombre, string apellido,
                     string telefono, string especialidad, string email)
            : base(cedula, nombre, apellido, telefono)
        {
            _especialidad = especialidad;
            _email = email;
        }

        // Constructor alternativo - email queda como valor por defecto
        public Doctor(string cedula, string nombre, string apellido, string especialidad)
            : base(cedula, nombre, apellido)
        {
            _especialidad = especialidad;
            _email = "Sin email";
        }

        public string Especialidad { get => _especialidad; set => _especialidad = value; }
        public string Email { get => _email; set => _email = value; }
        public int IdDoctor { get => _idDoctor; set => _idDoctor = value; }
        public int IdEspecialidad { get => _idEspecialidad; set => _idEspecialidad = value; }

        // Implementacion del metodo abstracto de Persona - el costo varia por especialidad
        public override decimal CalcularCosto()
        {
            if (_especialidad == "Cardiología" || _especialidad == "Neurología")
                return 3000m;
            else
                return 1500m;
        }

        // Sobreescritura de ObtenerInfo de Persona - agrega especialidad y correo
        public override string ObtenerInfo()
        {
            return $"DOCTOR — {base.ObtenerInfo()} | " +
                   $"Especialidad: {_especialidad} | " +
                   $"Email: {_email}";
        }

        // Retorna la firma del doctor usada en recetas
        public string ObtenerFirma()
        {
            return $"Dr. {_nombre} {_apellido} — {_especialidad}";
        }
    }
}
