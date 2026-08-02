using System.Data;
using ClinicaMedica.Datos;

namespace ClinicaMedica.Negocio
{
    // Logica de negocio para el modulo de Proveedores.
    public class ProveedoresNegocio
    {
        private ProveedoresDAL _dal = new ProveedoresDAL();

        // Retorna todos los proveedores sin filtro.
        public DataTable ObtenerTodos()
        {
            return _dal.ObtenerTodos();
        }

        // Valida los datos y registra un nuevo proveedor.
        // Retorna "OK" si fue exitoso, o un mensaje de error si falla la validacion.
        public string RegistrarProveedor(string nombre, string telefono, string email)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                return "El nombre del proveedor es obligatorio.";

            if (string.IsNullOrWhiteSpace(email))
                return "El email es obligatorio.";

            if (!email.Contains("@"))
                return "El email debe contener el caracter @.";

            _dal.Insertar(nombre, telefono, email);
            return "OK";
        }
    }
}
