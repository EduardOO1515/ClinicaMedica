using System;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ClinicaMedica.Datos
{
    // Acceso a datos para la tabla Medicamentos
    public class MedicamentosDAL : IMedicamentosRepositorio
    {
        // Hace JOIN con Proveedores para mostrar el nombre del proveedor en los resultados
        public async Task<DataTable> ObtenerTodosAsync()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    await con.OpenAsync();
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT m.IdMedicamento, p.Nombre AS Proveedor, m.Nombre, " +
                        "m.Presentacion, m.Concentracion, m.Stock, m.Precio, m.FechaVencimiento " +
                        "FROM Medicamentos m " +
                        "INNER JOIN Proveedores p ON m.IdProveedor = p.IdProveedor " +
                        "ORDER BY m.Nombre", con);
                    await Task.Run(() => da.Fill(dt));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener medicamentos: " + ex.Message);
            }
            return dt;
        }

        public async Task<bool> InsertarAsync(int idProveedor, string nombre, string presentacion,
                                             string concentracion, int stock, decimal precio, DateTime fechaVencimiento)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    await con.OpenAsync();
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
                    await cmd.ExecuteNonQueryAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar medicamento: " + ex.Message);
            }
        }

        public async Task<DataTable> BuscarPorNombreAsync(string nombre)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    await con.OpenAsync();
                    SqlCommand cmd = new SqlCommand(
                        "SELECT m.IdMedicamento, p.Nombre AS Proveedor, m.Nombre, " +
                        "m.Presentacion, m.Concentracion, m.Stock, m.Precio, m.FechaVencimiento " +
                        "FROM Medicamentos m " +
                        "INNER JOIN Proveedores p ON m.IdProveedor = p.IdProveedor " +
                        "WHERE m.Nombre LIKE @nombre ORDER BY m.Nombre", con);
                    cmd.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    await Task.Run(() => da.Fill(dt));
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
