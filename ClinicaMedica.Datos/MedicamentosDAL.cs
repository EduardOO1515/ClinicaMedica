using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ClinicaMedica.Datos
{
    // Acceso a datos para la tabla Medicamentos.
    // Tabla: Medicamentos (IdMedicamento, IdProveedor, Nombre, Presentacion, Concentracion, Stock, Precio, FechaVencimiento)
    public class MedicamentosDAL
    {
        // Retorna todos los medicamentos con el nombre del proveedor incluido.
        public DataTable ObtenerTodos()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT m.IdMedicamento, p.Nombre AS Proveedor, m.Nombre, " +
                        "m.Presentacion, m.Concentracion, m.Stock, m.Precio, m.FechaVencimiento " +
                        "FROM Medicamentos m " +
                        "INNER JOIN Proveedores p ON m.IdProveedor = p.IdProveedor " +
                        "ORDER BY m.Nombre", con);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener medicamentos: " + ex.Message);
            }
            return dt;
        }

        // Inserta un nuevo medicamento en la base de datos.
        public bool Insertar(int idProveedor, string nombre, string presentacion,
                             string concentracion, int stock, decimal precio, DateTime fechaVencimiento)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Medicamentos (IdProveedor, Nombre, Presentacion, Concentracion, Stock, Precio, FechaVencimiento) " +
                        "VALUES (@idProveedor, @nombre, @presentacion, @concentracion, @stock, @precio, @fechaVencimiento)", con);
                    cmd.Parameters.AddWithValue("@idProveedor", idProveedor);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@presentacion", presentacion);
                    cmd.Parameters.AddWithValue("@concentracion", concentracion);
                    cmd.Parameters.AddWithValue("@stock", stock);
                    cmd.Parameters.AddWithValue("@precio", precio);
                    cmd.Parameters.AddWithValue("@fechaVencimiento", fechaVencimiento);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar medicamento: " + ex.Message);
            }
        }

        // Busca medicamentos cuyo nombre contenga el texto indicado.
        public DataTable BuscarPorNombre(string nombre)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT m.IdMedicamento, p.Nombre AS Proveedor, m.Nombre, " +
                        "m.Presentacion, m.Concentracion, m.Stock, m.Precio, m.FechaVencimiento " +
                        "FROM Medicamentos m " +
                        "INNER JOIN Proveedores p ON m.IdProveedor = p.IdProveedor " +
                        "WHERE m.Nombre LIKE @nombre ORDER BY m.Nombre", con);
                    da.SelectCommand.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar medicamentos: " + ex.Message);
            }
            return dt;
        }
    }
}
