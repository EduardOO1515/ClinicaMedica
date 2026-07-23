using System;
using System.Data;
using ClinicaMedica.Datos;

namespace ClinicaMedica.Negocio
{
    public class DoctoresNegocio
    {
        private DoctoresDAL _dal = new DoctoresDAL();
        

        public DataTable ObtenerTodos()
        {
            return _dal.ObtenerTodos();
        }

        public DataTable ObtenerEspecialidades()
        {
            return _dal.ObtenerEspecialidades();
        }

        public string RegistrarDoctor(string cedula, string nombre, string apellido,
                              int idEspecialidad, string telefono, string email)
        {
            if (string.IsNullOrWhiteSpace(cedula) || cedula.Length != 13)
                return "La cédula debe tener formato 000-0000000-0.";

            if (string.IsNullOrWhiteSpace(nombre) || nombre.Trim().Length < 2)
                return "El nombre no puede estar vacío.";

            if (string.IsNullOrWhiteSpace(apellido) || apellido.Trim().Length < 2)
                return "El apellido no puede estar vacío.";

            if (idEspecialidad <= 0)
                return "Debe seleccionar una especialidad.";

            if (string.IsNullOrWhiteSpace(telefono) || telefono.Length != 12)
                return "El teléfono debe tener formato 000-000-0000.";

            if (string.IsNullOrWhiteSpace(email))
                return "El email no puede estar vacío.";

            if (!email.Contains("@") || !email.Contains("."))
                return "El email no tiene un formato válido. Ejemplo: nombre@correo.com";

            _dal.Insertar(cedula, nombre, apellido, idEspecialidad, telefono, email);
            return "OK";
        }

        public string ActualizarDoctor(int id, string cedula, string nombre, string apellido,
                                        int idEspecialidad, string telefono, string email)
        {
            if (string.IsNullOrWhiteSpace(cedula) || cedula.Length != 13)
                return "La cédula debe tener formato 000-0000000-0.";

            if (string.IsNullOrWhiteSpace(nombre) || nombre.Trim().Length < 2)
                return "El nombre no puede estar vacío.";

            if (string.IsNullOrWhiteSpace(apellido) || apellido.Trim().Length < 2)
                return "El apellido no puede estar vacío.";

            if (idEspecialidad <= 0)
                return "Debe seleccionar una especialidad.";

            if (string.IsNullOrWhiteSpace(telefono) || telefono.Length != 12)
                return "El teléfono debe tener formato 000-000-0000.";

            if (string.IsNullOrWhiteSpace(email))
                return "El email no puede estar vacío.";

            if (!email.Contains("@") || !email.Contains("."))
                return "El email no tiene un formato válido. Ejemplo: nombre@correo.com";

            _dal.Insertar(cedula, nombre, apellido, idEspecialidad, telefono, email);
            return "OK";
        }

        public string EliminarDoctor(int id)
        {
            if (id <= 0)
                return "ID de doctor no válido.";
            _dal.Eliminar(id);
            return "OK";
        }
    }
}