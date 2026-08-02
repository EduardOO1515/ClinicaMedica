using System;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ClinicaMedica.Datos
{
    // Acceso a datos para la tabla Citas
    public class CitasDAL : ICitasRepositorio
    {
        // Hace JOIN con Pacientes y Doctores para mostrar los nombres en la consulta
        public async Task<DataTable> ObtenerTodosAsync()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    await con.OpenAsync();
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT c.IdCita, p.Nombre + ' ' + p.Apellido AS Paciente, " +
                        "d.Nombre + ' ' + d.Apellido AS Doctor, " +
                        "c.FechaCita, c.Estado, c.TipoConsulta, c.Costo, " +
                        "c.IdPaciente, c.IdDoctor " +
                        "FROM Citas c " +
                        "INNER JOIN Pacientes p ON c.IdPaciente = p.IdPaciente " +
                        "INNER JOIN Doctores d ON c.IdDoctor = d.IdDoctor", con);
                    await Task.Run(() => da.Fill(dt));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener citas: " + ex.Message);
            }
            return dt;
        }

        public async Task<bool> InsertarAsync(int idPaciente, int idDoctor, DateTime fechaCita,
                                              string estado, string tipoConsulta, decimal costo)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    await con.OpenAsync();
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Citas (IdPaciente, IdDoctor, FechaCita, Estado, TipoConsulta, Costo) " +
                        "VALUES (@idPaciente, @idDoctor, @fechaCita, @estado, @tipoConsulta, @costo)", con);
                    cmd.Parameters.AddWithValue("@idPaciente", idPaciente);
                    cmd.Parameters.AddWithValue("@idDoctor", idDoctor);
                    cmd.Parameters.AddWithValue("@fechaCita", fechaCita);
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.Parameters.AddWithValue("@tipoConsulta", tipoConsulta);
                    cmd.Parameters.AddWithValue("@costo", costo);
                    await cmd.ExecuteNonQueryAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar cita: " + ex.Message);
            }
        }

        public async Task<bool> ActualizarAsync(int id, int idPaciente, int idDoctor, DateTime fechaCita,
                                                string estado, string tipoConsulta, decimal costo)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    await con.OpenAsync();
                    SqlCommand cmd = new SqlCommand(
                        "UPDATE Citas SET IdPaciente=@idPaciente, IdDoctor=@idDoctor, " +
                        "FechaCita=@fechaCita, Estado=@estado, TipoConsulta=@tipoConsulta, Costo=@costo " +
                        "WHERE IdCita=@id", con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@idPaciente", idPaciente);
                    cmd.Parameters.AddWithValue("@idDoctor", idDoctor);
                    cmd.Parameters.AddWithValue("@fechaCita", fechaCita);
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.Parameters.AddWithValue("@tipoConsulta", tipoConsulta);
                    cmd.Parameters.AddWithValue("@costo", costo);
                    await cmd.ExecuteNonQueryAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar cita: " + ex.Message);
            }
        }

        public async Task<bool> EliminarAsync(int id)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    await con.OpenAsync();
                    SqlCommand cmd = new SqlCommand(
                        "DELETE FROM Citas WHERE IdCita=@id", con);
                    cmd.Parameters.AddWithValue("@id", id);
                    await cmd.ExecuteNonQueryAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar cita: " + ex.Message);
            }
        }
    }
}
