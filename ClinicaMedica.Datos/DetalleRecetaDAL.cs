using System;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ClinicaMedica.Datos
{
    // Acceso a datos para la tabla DetalleReceta (lineas de medicamentos por receta)
    public class DetalleRecetaDAL : IDetalleRecetaRepositorio
    {
        // Agrega una linea de medicamento a la receta indicada por idReceta
        public async Task<bool> InsertarAsync(int idReceta, int idMedicamento, string dosis,
                                             string frecuencia, string duracion, string observaciones)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    await con.OpenAsync();
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO DetalleReceta (IdReceta, IdMedicamento, Dosis, Frecuencia, Duracion, Observaciones) " +
                        "VALUES (@idReceta, @idMedicamento, @dosis, @frecuencia, @duracion, @observaciones)", con);
                    cmd.Parameters.AddWithValue("@idReceta", idReceta);
                    cmd.Parameters.AddWithValue("@idMedicamento", idMedicamento);
                    cmd.Parameters.AddWithValue("@dosis", dosis);
                    cmd.Parameters.AddWithValue("@frecuencia", frecuencia);
                    cmd.Parameters.AddWithValue("@duracion", duracion);
                    cmd.Parameters.AddWithValue("@observaciones", observaciones);
                    await cmd.ExecuteNonQueryAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar detalle de receta: " + ex.Message);
            }
        }

        // Hace JOIN con Medicamentos para mostrar el nombre en lugar del ID
        public async Task<DataTable> ConsultarPorRecetaAsync(int idReceta)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    await con.OpenAsync();
                    SqlCommand cmd = new SqlCommand(
                        "SELECT d.IdDetalle, m.Nombre AS Medicamento, d.Dosis, " +
                        "d.Frecuencia, d.Duracion, d.Observaciones " +
                        "FROM DetalleReceta d " +
                        "INNER JOIN Medicamentos m ON d.IdMedicamento = m.IdMedicamento " +
                        "WHERE d.IdReceta = @idReceta", con);
                    cmd.Parameters.AddWithValue("@idReceta", idReceta);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    await Task.Run(() => da.Fill(dt));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar detalle de receta: " + ex.Message);
            }
            return dt;
        }
    }
}
