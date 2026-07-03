using System;
using System.Data;
using System.Data.SqlClient;

namespace ClinicaMedica.Datos
{
    public class CitasDAL
    {
        public DataTable ObtenerTodos()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT c.IdCita, p.Nombre + ' ' + p.Apellido AS Paciente, " +
                        "d.Nombre + ' ' + d.Apellido AS Doctor, " +
                        "c.FechaCita, c.Estado, c.TipoConsulta, c.Costo, " +
                        "c.IdPaciente, c.IdDoctor " +
                        "FROM Citas c " +
                        "INNER JOIN Pacientes p ON c.IdPaciente = p.IdPaciente " +
                        "INNER JOIN Doctores d ON c.IdDoctor = d.IdDoctor", con);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener citas: " + ex.Message);
            }
            return dt;
        }

        public bool Insertar(int idPaciente, int idDoctor, DateTime fechaCita,
                            string estado, string tipoConsulta, decimal costo)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Citas (IdPaciente, IdDoctor, FechaCita, Estado, TipoConsulta, Costo) " +
                        "VALUES (@idPaciente, @idDoctor, @fechaCita, @estado, @tipoConsulta, @costo)", con);
                    cmd.Parameters.AddWithValue("@idPaciente", idPaciente);
                    cmd.Parameters.AddWithValue("@idDoctor", idDoctor);
                    cmd.Parameters.AddWithValue("@fechaCita", fechaCita);
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.Parameters.AddWithValue("@tipoConsulta", tipoConsulta);
                    cmd.Parameters.AddWithValue("@costo", costo);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar cita: " + ex.Message);
            }
        }

        public bool Actualizar(int id, int idPaciente, int idDoctor, DateTime fechaCita,
                              string estado, string tipoConsulta, decimal costo)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    con.Open();
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
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar cita: " + ex.Message);
            }
        }

        public bool Eliminar(int id)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(
                        "DELETE FROM Citas WHERE IdCita=@id", con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
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