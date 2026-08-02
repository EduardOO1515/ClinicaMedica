using System;
using System.Data;
using System.Threading.Tasks;
using ClinicaMedica.Datos;

namespace ClinicaMedica.Negocio
{
    public class UsuariosNegocio
    {
        private readonly IUsuariosRepositorio _dal;

        public UsuariosNegocio()
        {
            _dal = new UsuariosDAL();
        }

        public async Task<DataTable> ValidarUsuarioAsync(string usuario, string contrasena)
        {
            if (string.IsNullOrWhiteSpace(usuario))
                throw new Exception("El usuario no puede estar vacio.");
            if (string.IsNullOrWhiteSpace(contrasena))
                throw new Exception("La contrasena no puede estar vacia.");

            return await _dal.ValidarUsuarioAsync(usuario, contrasena);
        }
    }
}
