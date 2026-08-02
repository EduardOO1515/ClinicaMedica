using System;
using System.Data;
using System.Threading.Tasks;

namespace ClinicaMedica.Datos
{
    // Interfaz del repositorio para operaciones CRUD sobre la tabla Pacientes
    public interface IPacientesRepositorio
    {
        Task<DataTable> ObtenerTodosAsync();
        Task<bool> InsertarAsync(string cedula, string nombre, string apellido,
                                 DateTime fechaNac, string telefono, bool tieneSeguro);
        Task<bool> ActualizarAsync(int id, string cedula, string nombre, string apellido,
                                   DateTime fechaNac, string telefono, bool tieneSeguro);
        // EliminarAsync elimina tambien las Citas relacionadas para evitar violaciones de FK
        Task<bool> EliminarAsync(int id);
    }
}
