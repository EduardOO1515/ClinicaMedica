using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ClinicaMedica.Datos
{
    // Acceso a datos para la tabla Recetas.
    // Tabla: Recetas (IdReceta, IdCita, Fecha, Indicaciones)
    public class RecetasDAL
    {
        // Retorna todas las recetas registradas.
        public DataTable ObtenerTodos()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT IdReceta, IdCita, Fecha, Indicaciones " +
                        "FROM Recetas ORDER BY Fecha DESC", con);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener recetas: " + ex.Message);
            }
            return dt;
        }

        // Inserta una nueva receta y retorna el IdReceta generado.
        public int Insertar(int idCita, DateTime fecha, string indicaciones)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Recetas (IdCita, Fecha, Indicaciones) " +
                        "VALUES (@idCita, @fecha, @indicaciones); " +
                        "SELECT CAST(SCOPE_IDENTITY() AS INT);", con);
                    cmd.Parameters.AddWithValue("@idCita", idCita);
                    cmd.Parameters.AddWithValue("@fecha", fecha);
                    cmd.Parameters.AddWithValue("@indicaciones", indicaciones);
                    object resultado = cmd.ExecuteScalar();
                    return Convert.ToInt32(resultado);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar receta: " + ex.Message);
            }
        }
    }
}
