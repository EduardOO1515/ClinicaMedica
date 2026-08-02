using System;
using System.Data;
using System.Threading.Tasks;
using ClinicaMedica.Datos;

namespace ClinicaMedica.Negocio
{
    // Logica de negocio para autenticacion de usuarios
    public class UsuariosNegocio
    {
        private readonly IUsuariosRepositorio _dal;

        public UsuariosNegocio()
        {
            _dal = new UsuariosDAL();
        }

        // Valida que los campos no esten vacios antes de consultar la base de datos
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
