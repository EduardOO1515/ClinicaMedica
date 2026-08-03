using System;
using System.Data;
using System.Threading.Tasks;

namespace ClinicaMedica.Datos
{
    // Interfaz del repositorio para operaciones sobre la tabla Expedientes
    public interface IExpedientesRepositorio
    {
        Task<DataTable> ObtenerTodosAsync();
        // InsertarAsync deriva el IdPaciente desde la tabla Citas mediante subconsulta
        Task<bool> InsertarAsync(int idCita, string diagnostico, string tratamiento, DateTime fechaRegistro);
        Task ActualizarAsync(int idExpediente, string diagnostico, string tratamiento);
        Task<DataTable> ConsultarPorPacienteAsync(int idPaciente);
    }
}
