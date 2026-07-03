using System;

namespace ClinicaMedica.Negocio
{
    public class Doctor : Persona
    {
        private string _especialidad;
        private string _email;
        private int _idDoctor;
        private int _idEspecialidad;

        //TODO Constructor completo
        public Doctor(string cedula, string nombre, string apellido,
                     string telefono, string especialidad, string email)
            : base(cedula, nombre, apellido, telefono)
        {
            _especialidad = especialidad;
            _email = email;
        }

        //TODO Constructor alternativo
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

        //TODO Implementación del método abstracto
        public override decimal CalcularCosto()
        {
            if (_especialidad == "Cardiología" || _especialidad == "Neurología")
                return 3000m;
            else
                return 1500m;
        }

        //TODO Sobreescritura del método virtual
        public override string ObtenerInfo()
        {
            return $"DOCTOR — {base.ObtenerInfo()} | " +
                   $"Especialidad: {_especialidad} | " +
                   $"Email: {_email}";
        }

        //TODO Método normal
        public string ObtenerFirma()
        {
            return $"Dr. {_nombre} {_apellido} — {_especialidad}";
        }
    }
}