using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ClinicaMedica.Datos
{
    // Acceso a datos para la tabla Expedientes.
    // Tabla: Expedientes (IdExpediente, IdPaciente, IdCita, Diagnostico, Tratamiento, FechaRegistro)
    public class ExpedientesDAL
    {
        // Retorna todos los expedientes con el nombre completo del paciente.
        public DataTable ObtenerTodos()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT e.IdExpediente, p.Nombre + ' ' + p.Apellido AS Paciente, " +
                        "e.IdCita, e.Diagnostico, e.Tratamiento, e.FechaRegistro " +
                        "FROM Expedientes e " +
                        "INNER JOIN Pacientes p ON e.IdPaciente = p.IdPaciente " +
                        "ORDER BY e.FechaRegistro DESC", con);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener expedientes: " + ex.Message);
            }
            return dt;
        }

        // Inserta un expediente. Obtiene el IdPaciente desde la tabla Citas usando el IdCita.
        public bool Insertar(int idCita, string diagnostico, string tratamiento, DateTime fechaRegistro)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Expedientes (IdPaciente, IdCita, Diagnostico, Tratamiento, FechaRegistro) " +
                        "SELECT c.IdPaciente, @idCita, @diagnostico, @tratamiento, @fechaRegistro " +
                        "FROM Citas c WHERE c.IdCita = @idCita", con);
                    cmd.Parameters.AddWithValue("@idCita", idCita);
                    cmd.Parameters.AddWithValue("@diagnostico", diagnostico);
                    cmd.Parameters.AddWithValue("@tratamiento", tratamiento);
                    cmd.Parameters.AddWithValue("@fechaRegistro", fechaRegistro);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar expediente: " + ex.Message);
            }
        }

        // Retorna todos los expedientes de un paciente especifico.
        public DataTable ConsultarPorPaciente(int idPaciente)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT IdExpediente, IdCita, Diagnostico, Tratamiento, FechaRegistro " +
                        "FROM Expedientes WHERE IdPaciente = @idPaciente ORDER BY FechaRegistro DESC", con);
                    da.SelectCommand.Parameters.AddWithValue("@idPaciente", idPaciente);
                    da.Fill(dt);
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
