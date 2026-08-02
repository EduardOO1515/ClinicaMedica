using System;
using System.Data;
using System.Threading.Tasks;

namespace ClinicaMedica.Datos
{
    // Interfaz del repositorio para operaciones CRUD sobre la tabla Citas
    public interface ICitasRepositorio
    {
        // ObtenerTodosAsync hace JOIN con Pacientes y Doctores para mostrar nombres
        Task<DataTable> ObtenerTodosAsync();
        Task<bool> InsertarAsync(int idPaciente, int idDoctor, DateTime fechaCita,
                                 string estado, string tipoConsulta, decimal costo);
        Task<bool> ActualizarAsync(int id, int idPaciente, int idDoctor, DateTime fechaCita,
                                   string estado, string tipoConsulta, decimal costo);
        Task<bool> EliminarAsync(int id);
    }
}
