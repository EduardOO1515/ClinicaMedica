using System.Data;
using System.Threading.Tasks;

namespace ClinicaMedica.Datos
{
    public interface IUsuariosRepositorio
    {
        Task<DataTable> ValidarUsuarioAsync(string usuario, string contrasena);
    }
}
