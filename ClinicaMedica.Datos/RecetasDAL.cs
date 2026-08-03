using System;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ClinicaMedica.Datos
{
    // Acceso a datos para la tabla Recetas
    public class RecetasDAL : IRecetasRepositorio
    {
        public async Task<DataTable> ObtenerTodosAsync()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    await con.OpenAsync();
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT IdReceta, IdCita, Fecha, Indicaciones " +
                        "FROM Recetas ORDER BY Fecha DESC", con);
                    await Task.Run(() => da.Fill(dt));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener recetas: " + ex.Message);
            }
            return dt;
        }

        // Inserta la receta y retorna el IdReceta generado por SCOPE_IDENTITY
        // El id es necesario para insertar el detalle de medicamentos a continuacion
        public async Task<int> InsertarAsync(int idCita, DateTime fecha, string indicaciones)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    await con.OpenAsync();
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Recetas (IdCita, Fecha, Indicaciones) " +
                        "VALUES (@idCita, @fecha, @indicaciones); " +
                        "SELECT CAST(SCOPE_IDENTITY() AS INT);", con);
                    cmd.Parameters.AddWithValue("@idCita", idCita);
                    cmd.Parameters.AddWithValue("@fecha", fecha);
                    cmd.Parameters.AddWithValue("@indicaciones", indicaciones);
                    object resultado = await cmd.ExecuteScalarAsync();
                    return Convert.ToInt32(resultado);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar receta: " + ex.Message);
            }
        }
        public async Task ActualizarAsync(int idReceta, DateTime fecha, string indicaciones)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    await con.OpenAsync();
                    SqlCommand cmd = new SqlCommand(
                        "UPDATE Recetas SET Fecha=@fecha, Indicaciones=@indicaciones " +
                        "WHERE IdReceta=@idReceta", con);
                    cmd.Parameters.AddWithValue("@idReceta", idReceta);
                    cmd.Parameters.AddWithValue("@fecha", fecha);
                    cmd.Parameters.AddWithValue("@indicaciones", indicaciones);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar receta: " + ex.Message);
            }
        }
    }
}
