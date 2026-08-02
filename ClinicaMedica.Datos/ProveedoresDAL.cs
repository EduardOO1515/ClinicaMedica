using System;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ClinicaMedica.Datos
{
    // Acceso a datos para la tabla Proveedores
    public class ProveedoresDAL : IProveedoresRepositorio
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
                        "SELECT IdProveedor, Nombre, Telefono, Email FROM Proveedores ORDER BY Nombre", con);
                    await Task.Run(() => da.Fill(dt));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener proveedores: " + ex.Message);
            }
            return dt;
        }

        public async Task<bool> InsertarAsync(string nombre, string telefono, string email)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    await con.OpenAsync();
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Proveedores (Nombre, Telefono, Email) VALUES (@nombre, @telefono, @email)", con);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@email", email);
                    await cmd.ExecuteNonQueryAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar proveedor: " + ex.Message);
            }
        }

        // Busqueda parcial usando LIKE con comodines a ambos lados del termino
        public async Task<DataTable> BuscarPorNombreAsync(string nombre)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    await con.OpenAsync();
                    SqlCommand cmd = new SqlCommand(
                        "SELECT IdProveedor, Nombre, Telefono, Email FROM Proveedores WHERE Nombre LIKE @nombre ORDER BY Nombre", con);
                    cmd.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    await Task.Run(() => da.Fill(dt));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar proveedores: " + ex.Message);
            }
            return dt;
        }
    }
}
