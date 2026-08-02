using System;
using System.Data;
using ClinicaMedica.Datos;

namespace ClinicaMedica.Negocio
{
    // Logica de negocio para el modulo de Recetas.
    public class RecetasNegocio
    {
        private RecetasDAL _dalRecetas = new RecetasDAL();
        private DetalleRecetaDAL _dalDetalle = new DetalleRecetaDAL();

        // Retorna todas las recetas sin filtro.
        public DataTable ObtenerTodos()
        {
            return _dalRecetas.ObtenerTodos();
        }

        // Valida los datos, inserta la receta y luego inserta cada linea de detalle.
        // detalles es un DataTable con columnas: IdMedicamento, Dosis, Frecuencia, Duracion, Observaciones
        // Retorna "OK" si fue exitoso o un mensaje de error si falla la validacion.
        public string RegistrarReceta(int idCita, DateTime fecha, string indicaciones, DataTable detalles)
        {
            if (idCita <= 0)
                return "Debe seleccionar una cita.";

            if (string.IsNullOrWhiteSpace(indicaciones))
                return "Las indicaciones son obligatorias.";

            if (detalles == null || detalles.Rows.Count == 0)
                return "Debe agregar al menos un medicamento al detalle.";

            // Inserta la receta y obtiene el Id generado.
            int idReceta = _dalRecetas.Insertar(idCita, fecha, indicaciones);

            // Inserta cada linea de detalle usando el Id de la receta recien creada.
            foreach (DataRow fila in detalles.Rows)
            {
                int idMedicamento = Convert.ToInt32(fila["IdMedicamento"]);
                string dosis = fila["Dosis"].ToString();
                string frecuencia = fila["Frecuencia"].ToString();
                string duracion = fila["Duracion"].ToString();
                string observaciones = fila["Observaciones"].ToString();
                _dalDetalle.Insertar(idReceta, idMedicamento, dosis, frecuencia, duracion, observaciones);
            }

            return "OK";
        }
    }
}
