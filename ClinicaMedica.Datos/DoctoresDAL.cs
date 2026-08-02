using System;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ClinicaMedica.Datos
{
    // Acceso a datos para la tabla Doctores
    public class DoctoresDAL : IDoctoresRepositorio
    {
        // Hace JOIN con Especialidades para incluir el nombre de la especialidad en el resultado
        public async Task<DataTable> ObtenerTodosAsync()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    await con.OpenAsync();
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT d.IdDoctor, d.Cedula, d.Nombre, d.Apellido, " +
                        "e.Nombre AS Especialidad, d.Telefono, d.Email, d.IdEspecialidad " +
                        "FROM Doctores d INNER JOIN Especialidades e ON d.IdEspecialidad = e.IdEspecialidad", con);
                    await Task.Run(() => da.Fill(dt));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener doctores: " + ex.Message);
            }
            return dt;
        }

        // Carga las opciones disponibles para el combo de especialidades
        public async Task<DataTable> ObtenerEspecialidadesAsync()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    await con.OpenAsync();
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT IdEspecialidad, Nombre FROM Especialidades", con);
                    await Task.Run(() => da.Fill(dt));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener especialidades: " + ex.Message);
            }
            return dt;
        }

        public async Task<bool> InsertarAsync(string cedula, string nombre, string apellido,
                                              int idEspecialidad, string telefono, string email)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    await con.OpenAsync();
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Doctores (Cedula, Nombre, Apellido, IdEspecialidad, Telefono, Email) " +
                        "VALUES (@cedula, @nombre, @apellido, @idEsp, @telefono, @email)", con);
                    cmd.Parameters.AddWithValue("@cedula", cedula);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellido", apellido);
                    cmd.Parameters.AddWithValue("@idEsp", idEspecialidad);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@email", email);
                    await cmd.ExecuteNonQueryAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar doctor: " + ex.Message);
            }
        }

        public async Task<bool> ActualizarAsync(int id, string cedula, string nombre, string apellido,
                                                int idEspecialidad, string telefono, string email)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    await con.OpenAsync();
                    SqlCommand cmd = new SqlCommand(
                        "UPDATE Doctores SET Cedula=@cedula, Nombre=@nombre, Apellido=@apellido, " +
                        "IdEspecialidad=@idEsp, Telefono=@telefono, Email=@email " +
                        "WHERE IdDoctor=@id", con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@cedula", cedula);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellido", apellido);
                    cmd.Parameters.AddWithValue("@idEsp", idEspecialidad);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@email", email);
                    await cmd.ExecuteNonQueryAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar doctor: " + ex.Message);
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
                        "DELETE FROM Doctores WHERE IdDoctor=@id", con);
                    cmd.Parameters.AddWithValue("@id", id);
                    await cmd.ExecuteNonQueryAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar doctor: " + ex.Message);
            }
        }
    }
}
