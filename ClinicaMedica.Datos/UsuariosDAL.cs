using System;
using System.Data;
using System.Data.SqlClient;

namespace ClinicaMedica.Datos
{
    public class UsuariosDAL
    {
        public DataTable ValidarUsuario(string usuario, string contrasena)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(
                        "SELECT IdUsuario, Usuario, Rol FROM Usuarios " +
                        "WHERE Usuario=@usuario AND Contrasena=@contrasena", con);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
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