using System.Data;
using System.Threading.Tasks;

namespace ClinicaMedica.Datos
{
    // Interfaz del repositorio para autenticacion de usuarios
    public interface IUsuariosRepositorio
    {
        // Retorna una fila con el usuario si las credenciales son correctas, o una tabla vacia si no
        Task<DataTable> ValidarUsuarioAsync(string usuario, string contrasena);
    }
}
