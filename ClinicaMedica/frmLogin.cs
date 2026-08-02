using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ClinicaMedica.Negocio;

namespace ClinicaMedica
{
    // Formulario de inicio de sesion. Se abre desde frmPrincipal antes de hacerse visible.
    public partial class frmLogin : Form
    {
        private UsuariosNegocio _negocio = new UsuariosNegocio();

        public frmLogin()
        {
            InitializeComponent();
        }

        // TODO: mejora futura, agregar un limite de intentos de inicio de sesion para mayor seguridad
        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUsuario.Text))
                {
                    MessageBox.Show("Ingrese el usuario.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtContrasena.Text))
                {
                    MessageBox.Show("Ingrese la contrasena.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataTable dt = await _negocio.ValidarUsuarioAsync(
                    txtUsuario.Text.Trim(), txtContrasena.Text.Trim());

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show($"Bienvenido, {txtUsuario.Text}!",
                       "Acceso Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // DialogResult.OK indica exito a frmPrincipal para que se muestre
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Acceso Denegado",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContrasena.Clear();
                    txtContrasena.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // DialogResult.Cancel cierra la aplicacion desde frmPrincipal
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
