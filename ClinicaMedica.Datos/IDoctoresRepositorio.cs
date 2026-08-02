using System;
using System.Data;
using System.Threading.Tasks;

namespace ClinicaMedica.Datos
{
    // Interfaz del repositorio para operaciones CRUD sobre la tabla Doctores
    public interface IDoctoresRepositorio
    {
        Task<DataTable> ObtenerTodosAsync();
        // ObtenerEspecialidadesAsync carga las opciones del combo de especialidades
        Task<DataTable> ObtenerEspecialidadesAsync();
        Task<bool> InsertarAsync(string cedula, string nombre, string apellido,
                                 int idEspecialidad, string telefono, string email);
        Task<bool> ActualizarAsync(int id, string cedula, string nombre, string apellido,
                                   int idEspecialidad, string telefono, string email);
        Task<bool> EliminarAsync(int id);
    }
}
