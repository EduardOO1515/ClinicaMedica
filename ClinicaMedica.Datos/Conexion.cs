using Microsoft.Data.SqlClient;

namespace ClinicaMedica.Datos
{
    // Provee la conexion compartida a SQL Server mediante autenticacion de Windows
    public class Conexion
    {
        // Cadena de conexion apunta al servidor local y a la base de datos ClinicaMedica
        private static string cadena =
            "Server=.;Database=ClinicaMedica;Trusted_Connection=True;TrustServerCertificate=True;";

        // Retorna una nueva SqlConnection (no abierta) usando la cadena compartida
        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadena);
        }
    }
}
