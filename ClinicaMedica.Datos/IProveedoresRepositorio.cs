using System.Data;
using System.Threading.Tasks;

namespace ClinicaMedica.Datos
{
    // Interfaz del repositorio para operaciones sobre la tabla Proveedores
    public interface IProveedoresRepositorio
    {
        Task<DataTable> ObtenerTodosAsync();
        Task<bool> InsertarAsync(string nombre, string telefono, string email);
        Task ActualizarAsync(int idProveedor, string nombre, string telefono, string email);
        // BuscarPorNombreAsync usa LIKE con comodines para busqueda parcial
        Task<DataTable> BuscarPorNombreAsync(string nombre);
    }
}
