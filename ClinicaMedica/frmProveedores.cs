using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaMedica.Negocio;

namespace ClinicaMedica
{
    // Formulario de entrada para registrar nuevos proveedores de medicamentos
    public partial class frmProveedores : Form
    {
        private ProveedoresNegocio _negocio = new ProveedoresNegocio();

        public frmProveedores()
        {
            InitializeComponent();
        }

        // Inicia con todos los campos deshabilitados hasta que el usuario presione Habilitar
        private void frmProveedores_Load(object sender, EventArgs e)
        {
            txtNombre.Enabled = false;
            txtTelefono.Enabled = false;
            txtEmail.Enabled = false;
            btnGuardar.Enabled = false;
            btnHabilitar.Enabled = true;
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtTelefono.Enabled = true;
            txtEmail.Enabled = true;
            btnGuardar.Enabled = true;
            btnHabilitar.Enabled = false;
            btnDeshabilitar.Enabled = true;
            txtNombre.Focus();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = false;
            txtTelefono.Enabled = false;
            txtEmail.Enabled = false;
            btnGuardar.Enabled = false;
            btnDeshabilitar.Enabled = false;
            btnHabilitar.Enabled = true;
            LimpiarCampos();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string resultado = await _negocio.RegistrarProveedorAsync(
                    txtNombre.Text.Trim(),
                    txtTelefono.Text.Trim(),
                    txtEmail.Text.Trim());

                if (resultado == "OK")
                {
                    MessageBox.Show("Proveedor guardado correctamente.", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(resultado, "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // LimpiarCampos es sincrono porque no necesita llamar a la base de datos
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        // Aplica formato 000-000-0000 mientras el usuario escribe
        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            string solo = txtTelefono.Text.Replace("-", "");
            if (solo.Length > 10) solo = solo.Substring(0, 10);

            string formateado = solo;
            if (solo.Length > 3)
                formateado = solo.Substring(0, 3) + "-" + solo.Substring(3);
            if (solo.Length > 6)
                formateado = solo.Substring(0, 3) + "-" + solo.Substring(3, 3) + "-" + solo.Substring(6);

            txtTelefono.TextChanged -= txtTelefono_TextChanged;
            txtTelefono.Text = formateado;
            txtTelefono.SelectionStart = txtTelefono.Text.Length;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
        }

        // Valida el formato del email al perder el foco el campo
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            if (string.IsNullOrWhiteSpace(email)) return;

            if (!email.Contains("@") || !email.Contains(".") ||
                email.IndexOf("@") < 1 ||
                email.IndexOf(".") < email.IndexOf("@") + 2 ||
                email.EndsWith("."))
            {
                MessageBox.Show("El email no es valido. Ejemplo: nombre@correo.com", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
            }
        }
    }
}
