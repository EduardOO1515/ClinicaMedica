using System.Data;
using System.Threading.Tasks;
using ClinicaMedica.Datos;

namespace ClinicaMedica.Negocio
{
    // Logica de negocio para la gestion de proveedores de medicamentos
    public class ProveedoresNegocio
    {
        private readonly IProveedoresRepositorio _dal;

        public ProveedoresNegocio()
        {
            _dal = new ProveedoresDAL();
        }

        public async Task<DataTable> ObtenerTodosAsync()
        {
            return await _dal.ObtenerTodosAsync();
        }

        // Valida nombre y formato de email antes de insertar el proveedor
        public async Task<string> RegistrarProveedorAsync(string nombre, string telefono, string email)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                return "El nombre del proveedor es obligatorio.";

            if (string.IsNullOrWhiteSpace(email))
                return "El email es obligatorio.";

            if (!email.Contains("@"))
                return "El email debe contener el caracter @.";

            await _dal.InsertarAsync(nombre, telefono, email);
            return "OK";
        }

        public async Task<string> ActualizarProveedorAsync(int id, string nombre, string telefono, string email)
        {
            if (id <= 0)
                return "ID de proveedor no valido.";

            if (string.IsNullOrWhiteSpace(nombre))
                return "El nombre del proveedor es obligatorio.";

            if (string.IsNullOrWhiteSpace(email))
                return "El email es obligatorio.";

            if (!email.Contains("@"))
                return "El email debe contener el caracter @.";

            await _dal.ActualizarAsync(id, nombre, telefono, email);
            return "OK";
        }
    }
}
