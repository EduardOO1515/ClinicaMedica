using System;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ClinicaMedica.Datos
{
    // Acceso a datos para la tabla Expedientes
    public class ExpedientesDAL : IExpedientesRepositorio
    {
        // Hace JOIN con Pacientes y ordena por fecha descendente
        public async Task<DataTable> ObtenerTodosAsync()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    await con.OpenAsync();
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT e.IdExpediente, p.Nombre + ' ' + p.Apellido AS Paciente, " +
                        "e.IdCita, e.Diagnostico, e.Tratamiento, e.FechaRegistro " +
                        "FROM Expedientes e " +
                        "INNER JOIN Pacientes p ON e.IdPaciente = p.IdPaciente " +
                        "ORDER BY e.FechaRegistro DESC", con);
                    await Task.Run(() => da.Fill(dt));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener expedientes: " + ex.Message);
            }
            return dt;
        }

        // Deriva IdPaciente desde Citas via subconsulta para no requerir el ID directamente
        public async Task<bool> InsertarAsync(int idCita, string diagnostico, string tratamiento, DateTime fechaRegistro)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    await con.OpenAsync();
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Expedientes (IdPaciente, IdCita, Diagnostico, Tratamiento, FechaRegistro) " +
                        "SELECT c.IdPaciente, @idCita, @diagnostico, @tratamiento, @fechaRegistro " +
                        "FROM Citas c WHERE c.IdCita = @idCita", con);
                    cmd.Parameters.AddWithValue("@idCita", idCita);
                    cmd.Parameters.AddWithValue("@diagnostico", diagnostico);
                    cmd.Parameters.AddWithValue("@tratamiento", tratamiento);
                    cmd.Parameters.AddWithValue("@fechaRegistro", fechaRegistro);
                    await cmd.ExecuteNonQueryAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar expediente: " + ex.Message);
            }
        }

        public async Task ActualizarAsync(int idExpediente, string diagnostico, string tratamiento)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    await con.OpenAsync();
                    SqlCommand cmd = new SqlCommand(
                        "UPDATE Expedientes SET Diagnostico=@diagnostico, Tratamiento=@tratamiento " +
                        "WHERE IdExpediente=@idExpediente", con);
                    cmd.Parameters.AddWithValue("@idExpediente", idExpediente);
                    cmd.Parameters.AddWithValue("@diagnostico", diagnostico);
                    cmd.Parameters.AddWithValue("@tratamiento", tratamiento);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar expediente: " + ex.Message);
            }
        }

        public async Task<DataTable> ConsultarPorPacienteAsync(int idPaciente)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    await con.OpenAsync();
                    SqlCommand cmd = new SqlCommand(
                        "SELECT IdExpediente, IdCita, Diagnostico, Tratamiento, FechaRegistro " +
                        "FROM Expedientes WHERE IdPaciente = @idPaciente ORDER BY FechaRegistro DESC", con);
                    cmd.Parameters.AddWithValue("@idPaciente", idPaciente);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    await Task.Run(() => da.Fill(dt));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar expedientes por paciente: " + ex.Message);
            }
            return dt;
        }
    }
}
