using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ClinicaMedica.Datos
{
    // Acceso a datos para la tabla Proveedores.
    // Tabla esperada: Proveedores (IdProveedor INT PK IDENTITY, Nombre NVARCHAR(100), Telefono NVARCHAR(20), Email NVARCHAR(100))
    public class ProveedoresDAL
    {
        // Retorna todos los proveedores registrados.
        public DataTable ObtenerTodos()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT IdProveedor, Nombre, Telefono, Email FROM Proveedores ORDER BY Nombre", con);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener proveedores: " + ex.Message);
            }
            return dt;
        }

        // Inserta un nuevo proveedor en la base de datos.
        public bool Insertar(string nombre, string telefono, string email)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Proveedores (Nombre, Telefono, Email) VALUES (@nombre, @telefono, @email)", con);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar proveedor: " + ex.Message);
            }
        }

        // Busca proveedores cuyo nombre contenga el texto indicado.
        public DataTable BuscarPorNombre(string nombre)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT IdProveedor, Nombre, Telefono, Email FROM Proveedores WHERE Nombre LIKE @nombre ORDER BY Nombre", con);
                    da.SelectCommand.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
                    da.Fill(dt);
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
