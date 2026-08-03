using System;
using System.Data;
using System.Threading.Tasks;

namespace ClinicaMedica.Datos
{
    // Interfaz del repositorio para operaciones sobre la tabla Recetas
    public interface IRecetasRepositorio
    {
        Task<DataTable> ObtenerTodosAsync();
        // InsertarAsync retorna el IdReceta generado por SCOPE_IDENTITY para insertar el detalle
        Task<int> InsertarAsync(int idCita, DateTime fecha, string indicaciones);
        Task ActualizarAsync(int idReceta, DateTime fecha, string indicaciones);
    }
}
