using System;
using System.Data;
using System.Threading.Tasks;
using ClinicaMedica.Datos;

namespace ClinicaMedica.Negocio
{
    // Logica de negocio para la gestion del inventario de medicamentos
    public class MedicamentosNegocio
    {
        private readonly IMedicamentosRepositorio _dal;

        public MedicamentosNegocio()
        {
            _dal = new MedicamentosDAL();
        }

        public async Task<DataTable> ObtenerTodosAsync()
        {
            return await _dal.ObtenerTodosAsync();
        }

        // Valida que el stock y el precio no sean negativos antes de guardar
        public async Task<string> RegistrarMedicamentoAsync(int idProveedor, string nombre, string presentacion,
                                                            string concentracion, int stock, decimal precio,
                                                            DateTime fechaVencimiento)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                return "El nombre del medicamento es obligatorio.";

            if (idProveedor <= 0)
                return "Debe seleccionar un proveedor.";

            if (stock < 0)
                return "El stock no puede ser negativo.";

            if (precio < 0)
                return "El precio no puede ser negativo.";

            await _dal.InsertarAsync(idProveedor, nombre, presentacion, concentracion, stock, precio, fechaVencimiento);
            return "OK";
        }
    }
}
