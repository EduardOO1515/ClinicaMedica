using System.Data;
using System.Threading.Tasks;
using ClinicaMedica.Datos;

namespace ClinicaMedica.Negocio
{
    // Logica de negocio para la gestion de doctores
    public class DoctoresNegocio
    {
        private readonly IDoctoresRepositorio _dal;

        public DoctoresNegocio()
        {
            _dal = new DoctoresDAL();
        }

        public async Task<DataTable> ObtenerTodosAsync()
        {
            return await _dal.ObtenerTodosAsync();
        }

        // Retorna las especialidades disponibles para poblar el combo del formulario
        public async Task<DataTable> ObtenerEspecialidadesAsync()
        {
            return await _dal.ObtenerEspecialidadesAsync();
        }

        // Valida el formato de los campos antes de insertar el doctor
        public async Task<string> RegistrarDoctorAsync(string cedula, string nombre, string apellido,
                                                       int idEspecialidad, string telefono, string email)
        {
            if (string.IsNullOrWhiteSpace(cedula) || cedula.Length != 13)
                return "La cedula debe tener formato 000-0000000-0.";

            if (string.IsNullOrWhiteSpace(nombre) || nombre.Trim().Length < 2)
                return "El nombre no puede estar vacio.";

            if (string.IsNullOrWhiteSpace(apellido) || apellido.Trim().Length < 2)
                return "El apellido no puede estar vacio.";

            if (idEspecialidad <= 0)
                return "Debe seleccionar una especialidad.";

            if (string.IsNullOrWhiteSpace(telefono) || telefono.Length != 12)
                return "El telefono debe tener formato 000-000-0000.";

            if (string.IsNullOrWhiteSpace(email))
                return "El email no puede estar vacio.";

            if (!email.Contains("@") || !email.Contains("."))
                return "El email no tiene un formato valido. Ejemplo: nombre@correo.com";

            await _dal.InsertarAsync(cedula, nombre, apellido, idEspecialidad, telefono, email);
            return "OK";
        }

        public async Task<string> ActualizarDoctorAsync(int id, string cedula, string nombre, string apellido,
                                                        int idEspecialidad, string telefono, string email)
        {
            if (string.IsNullOrWhiteSpace(cedula) || cedula.Length != 13)
                return "La cedula debe tener formato 000-0000000-0.";

            if (string.IsNullOrWhiteSpace(nombre) || nombre.Trim().Length < 2)
                return "El nombre no puede estar vacio.";

            if (string.IsNullOrWhiteSpace(apellido) || apellido.Trim().Length < 2)
                return "El apellido no puede estar vacio.";

            if (idEspecialidad <= 0)
                return "Debe seleccionar una especialidad.";

            if (string.IsNullOrWhiteSpace(telefono) || telefono.Length != 12)
                return "El telefono debe tener formato 000-000-0000.";

            if (string.IsNullOrWhiteSpace(email))
                return "El email no puede estar vacio.";

            if (!email.Contains("@") || !email.Contains("."))
                return "El email no tiene un formato valido. Ejemplo: nombre@correo.com";

            await _dal.InsertarAsync(cedula, nombre, apellido, idEspecialidad, telefono, email);
            return "OK";
        }

        public async Task<string> EliminarDoctorAsync(int id)
        {
            if (id <= 0)
                return "ID de doctor no valido.";
            await _dal.EliminarAsync(id);
            return "OK";
        }
    }
}
