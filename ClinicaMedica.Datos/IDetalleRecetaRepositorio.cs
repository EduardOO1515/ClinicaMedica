using System.Data;
using System.Threading.Tasks;

namespace ClinicaMedica.Datos
{
    // Interfaz del repositorio para operaciones sobre la tabla DetalleReceta
    public interface IDetalleRecetaRepositorio
    {
        // InsertarAsync agrega una linea de medicamento a una receta existente
        Task<bool> InsertarAsync(int idReceta, int idMedicamento, string dosis,
                                 string frecuencia, string duracion, string observaciones);
        // ConsultarPorRecetaAsync hace JOIN con Medicamentos para mostrar el nombre
        Task<DataTable> ConsultarPorRecetaAsync(int idReceta);
    }
}
