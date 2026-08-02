using System;
using System.Data;
using System.Threading.Tasks;

namespace ClinicaMedica.Datos
{
    // Interfaz del repositorio para operaciones sobre la tabla Medicamentos
    public interface IMedicamentosRepositorio
    {
        // ObtenerTodosAsync hace JOIN con Proveedores para mostrar el nombre del proveedor
        Task<DataTable> ObtenerTodosAsync();
        Task<bool> InsertarAsync(int idProveedor, string nombre, string presentacion,
                                 string concentracion, int stock, decimal precio, DateTime fechaVencimiento);
        Task<DataTable> BuscarPorNombreAsync(string nombre);
    }
}
