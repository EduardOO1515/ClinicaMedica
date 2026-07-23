using System.Data.SqlClient;

namespace ClinicaMedica.Datos
{
    public class Conexion
    {
        private static string cadena =
            "Server=.;Database=ClinicaMedica;Trusted_Connection=True;";

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadena);
        }
    }
}