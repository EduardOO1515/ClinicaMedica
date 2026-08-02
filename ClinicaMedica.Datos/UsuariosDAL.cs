using System;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ClinicaMedica.Datos
{
    // Acceso a datos para autenticacion de usuarios
    public class UsuariosDAL : IUsuariosRepositorio
    {
        // Retorna tabla con el usuario si las credenciales coinciden; tabla vacia si no
        public async Task<DataTable> ValidarUsuarioAsync(string usuario, string contrasena)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    await con.OpenAsync();
                    SqlCommand cmd = new SqlCommand(
                        "SELECT IdUsuario, Usuario FROM Usuarios " +
                        "WHERE Usuario=@usuario AND Contrasena=@contrasena", con);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    await Task.Run(() => da.Fill(dt));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al validar usuario: " + ex.Message);
            }
            return dt;
        }
    }
}
