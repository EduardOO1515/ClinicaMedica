using System;
using System.Data;
using System.Threading.Tasks;
using ClinicaMedica.Datos;

namespace ClinicaMedica.Negocio
{
    // Logica de negocio para la gestion de recetas medicas
    public class RecetasNegocio
    {
        private readonly IRecetasRepositorio _dalRecetas;
        private readonly IDetalleRecetaRepositorio _dalDetalle;

        public RecetasNegocio()
        {
            _dalRecetas = new RecetasDAL();
            _dalDetalle = new DetalleRecetaDAL();
        }

        public async Task<DataTable> ObtenerTodosAsync()
        {
            return await _dalRecetas.ObtenerTodosAsync();
        }

        // Devuelve el detalle de medicamentos de una receta para cargarlos al editar
        public async Task<DataTable> ObtenerDetalleAsync(int idReceta)
        {
            return await _dalDetalle.ConsultarPorRecetaAsync(idReceta);
        }

        // Actualiza la cabecera y reemplaza el detalle completo de la receta (borra e inserta de nuevo)
        public async Task<string> ActualizarRecetaAsync(int idReceta, DateTime fecha, string indicaciones, DataTable detalles)
        {
            if (idReceta <= 0)
                return "ID de receta no valido.";

            if (string.IsNullOrWhiteSpace(indicaciones))
                return "Las indicaciones son obligatorias.";

            if (detalles == null || detalles.Rows.Count == 0)
                return "Debe agregar al menos un medicamento al detalle.";

            await _dalRecetas.ActualizarAsync(idReceta, fecha, indicaciones);
            await _dalDetalle.EliminarPorRecetaAsync(idReceta);

            foreach (DataRow fila in detalles.Rows)
            {
                int idMedicamento = Convert.ToInt32(fila["IdMedicamento"]);
                string dosis = fila["Dosis"].ToString();
                string frecuencia = fila["Frecuencia"].ToString();
                string duracion = fila["Duracion"].ToString();
                string observaciones = fila["Observaciones"].ToString();
                await _dalDetalle.InsertarAsync(idReceta, idMedicamento, dosis, frecuencia, duracion, observaciones);
            }

            return "OK";
        }

        public async Task<string> RegistrarRecetaAsync(int idCita, DateTime fecha, string indicaciones, DataTable detalles)
        {
            if (idCita <= 0)
                return "Debe seleccionar una cita.";

            if (string.IsNullOrWhiteSpace(indicaciones))
                return "Las indicaciones son obligatorias.";

            if (detalles == null || detalles.Rows.Count == 0)
                return "Debe agregar al menos un medicamento al detalle.";

            int idReceta = await _dalRecetas.InsertarAsync(idCita, fecha, indicaciones);

            // Itera las filas del detalle y guarda cada medicamento con su dosis
            foreach (DataRow fila in detalles.Rows)
            {
                int idMedicamento = Convert.ToInt32(fila["IdMedicamento"]);
                string dosis = fila["Dosis"].ToString();
                string frecuencia = fila["Frecuencia"].ToString();
                string duracion = fila["Duracion"].ToString();
                string observaciones = fila["Observaciones"].ToString();
                await _dalDetalle.InsertarAsync(idReceta, idMedicamento, dosis, frecuencia, duracion, observaciones);
            }

            return "OK";
        }
    }
}
