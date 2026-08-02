using System;
using System.Data;
using ClinicaMedica.Datos;

namespace ClinicaMedica.Negocio
{
    // Logica de negocio para el modulo de Medicamentos.
    public class MedicamentosNegocio
    {
        private MedicamentosDAL _dal = new MedicamentosDAL();

        // Retorna todos los medicamentos sin filtro.
        public DataTable ObtenerTodos()
        {
            return _dal.ObtenerTodos();
        }

        // Valida los datos y registra un nuevo medicamento.
        // Retorna "OK" si fue exitoso o un mensaje de error si falla la validacion.
        public string RegistrarMedicamento(int idProveedor, string nombre, string presentacion,
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

            _dal.Insertar(idProveedor, nombre, presentacion, concentracion, stock, precio, fechaVencimiento);
            return "OK";
        }
    }
}
