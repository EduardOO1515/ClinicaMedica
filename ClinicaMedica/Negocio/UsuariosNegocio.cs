using System;
using System.Data;
using ClinicaMedica.Datos;

namespace ClinicaMedica.Negocio
{
    public class UsuariosNegocio
    {
        private UsuariosDAL _dal = new UsuariosDAL();

        public DataTable ValidarUsuario(string usuario, string contrasena)
        {
            if (string.IsNullOrWhiteSpace(usuario))
                throw new Exception("El usuario no puede estar vacío.");
            if (string.IsNullOrWhiteSpace(contrasena))
                throw new Exception("La contraseña no puede estar vacía.");

            return _dal.ValidarUsuario(usuario, contrasena);
        }
    }
}