using System;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ClinicaMedica.Datos
{
    // Acceso a datos para la tabla Pacientes
    public class PacientesDAL : IPacientesRepositorio
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
                        "SELECT IdPaciente, Cedula, Nombre, Apellido, FechaNacimiento, Telefono, TieneSeguro FROM Pacientes", con);
                    await Task.Run(() => da.Fill(dt));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener pacientes: " + ex.Message);
            }
            return dt;
        }

        public async Task<bool> InsertarAsync(string cedula, string nombre, string apellido,
                                              DateTime fechaNac, string telefono, bool tieneSeguro)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    await con.OpenAsync();
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Pacientes (Cedula, Nombre, Apellido, FechaNacimiento, Telefono, TieneSeguro) " +
                        "VALUES (@cedula, @nombre, @apellido, @fechaNac, @telefono, @seguro)", con);
                    cmd.Parameters.AddWithValue("@cedula", cedula);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellido", apellido);
                    cmd.Parameters.AddWithValue("@fechaNac", fechaNac);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@seguro", tieneSeguro);
                    await cmd.ExecuteNonQueryAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar paciente: " + ex.Message);
            }
        }

        public async Task<bool> ActualizarAsync(int id, string cedula, string nombre, string apellido,
                                                DateTime fechaNac, string telefono, bool tieneSeguro)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    await con.OpenAsync();
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
                    await cmd.ExecuteNonQueryAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar paciente: " + ex.Message);
            }
        }

        // Elimina primero las Citas relacionadas para evitar error de clave foranea
        public async Task<bool> EliminarAsync(int id)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    await con.OpenAsync();
                    SqlCommand cmdCitas = new SqlCommand(
                        "DELETE FROM Citas WHERE IdPaciente=@id", con);
                    cmdCitas.Parameters.AddWithValue("@id", id);
                    await cmdCitas.ExecuteNonQueryAsync();

                    SqlCommand cmd = new SqlCommand(
                        "DELETE FROM Pacientes WHERE IdPaciente=@id", con);
                    cmd.Parameters.AddWithValue("@id", id);
                    await cmd.ExecuteNonQueryAsync();
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
