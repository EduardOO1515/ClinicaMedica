using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ClinicaMedica.Datos
{
    // Acceso a datos para la tabla DetalleReceta.
    // Tabla: DetalleReceta (IdDetalle, IdReceta, IdMedicamento, Dosis, Frecuencia, Duracion, Observaciones)
    public class DetalleRecetaDAL
    {
        // Inserta una linea de detalle para una receta existente.
        public bool Insertar(int idReceta, int idMedicamento, string dosis,
                             string frecuencia, string duracion, string observaciones)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO DetalleReceta (IdReceta, IdMedicamento, Dosis, Frecuencia, Duracion, Observaciones) " +
                        "VALUES (@idReceta, @idMedicamento, @dosis, @frecuencia, @duracion, @observaciones)", con);
                    cmd.Parameters.AddWithValue("@idReceta", idReceta);
                    cmd.Parameters.AddWithValue("@idMedicamento", idMedicamento);
                    cmd.Parameters.AddWithValue("@dosis", dosis);
                    cmd.Parameters.AddWithValue("@frecuencia", frecuencia);
                    cmd.Parameters.AddWithValue("@duracion", duracion);
                    cmd.Parameters.AddWithValue("@observaciones", observaciones);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar detalle de receta: " + ex.Message);
            }
        }

        // Retorna todos los detalles de una receta especifica con el nombre del medicamento.
        public DataTable ConsultarPorReceta(int idReceta)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT d.IdDetalle, m.Nombre AS Medicamento, d.Dosis, " +
                        "d.Frecuencia, d.Duracion, d.Observaciones " +
                        "FROM DetalleReceta d " +
                        "INNER JOIN Medicamentos m ON d.IdMedicamento = m.IdMedicamento " +
                        "WHERE d.IdReceta = @idReceta", con);
                    da.SelectCommand.Parameters.AddWithValue("@idReceta", idReceta);
                    da.Fill(dt);
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
