using System;
using System.Data;
using System.Data.SqlClient;

namespace ClinicaMedica.Datos
{
    public class PacientesDAL
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
                        "SELECT IdPaciente, Cedula, Nombre, Apellido, FechaNacimiento, Telefono, TieneSeguro FROM Pacientes", con);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener pacientes: " + ex.Message);
            }
            return dt;
        }

        public bool Insertar(string cedula, string nombre, string apellido,
                            DateTime fechaNac, string telefono, bool tieneSeguro)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Pacientes (Cedula, Nombre, Apellido, FechaNacimiento, Telefono, TieneSeguro) " +
                        "VALUES (@cedula, @nombre, @apellido, @fechaNac, @telefono, @seguro)", con);
                    cmd.Parameters.AddWithValue("@cedula", cedula);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellido", apellido);
                    cmd.Parameters.AddWithValue("@fechaNac", fechaNac);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@seguro", tieneSeguro);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar paciente: " + ex.Message);
            }
        }

        public bool Actualizar(int id, string cedula, string nombre, string apellido,
                              DateTime fechaNac, string telefono, bool tieneSeguro)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(
                        "UPDATE Pacientes SET Cedula=@cedula, Nombre=@nombre, Apellido=@apellido, " +
                        "FechaNacimiento=@fechaNac, Telefono=@telefono, TieneSeguro=@seguro " +
                        "WHERE IdPaciente=@id", con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@cedula", cedula);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellido", apellido);
                    cmd.Parameters.AddWithValue("@fechaNac", fechaNac);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@seguro", tieneSeguro);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar paciente: " + ex.Message);
            }
        }

        public bool Eliminar(int id)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    con.Open();

                    // Primero eliminar las citas del paciente
                    SqlCommand cmdCitas = new SqlCommand(
                        "DELETE FROM Citas WHERE IdPaciente=@id", con);
                    cmdCitas.Parameters.AddWithValue("@id", id);
                    cmdCitas.ExecuteNonQuery();

                    // Luego eliminar el paciente
                    SqlCommand cmd = new SqlCommand(
                        "DELETE FROM Pacientes WHERE IdPaciente=@id", con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar paciente: " + ex.Message);
            }
        }
    }
}