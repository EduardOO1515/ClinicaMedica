using System;
using System.Windows.Forms;
using ClinicaMedica.Negocio;

namespace ClinicaMedica
{
    public partial class frmProveedores : Form
    {
        private ProveedoresNegocio _negocio = new ProveedoresNegocio();

        public frmProveedores()
        {
            InitializeComponent();
        }

        // Al cargar, deshabilita todos los controles de entrada hasta que el usuario habilite el ingreso.
        private void frmProveedores_Load(object sender, EventArgs e)
        {
            txtNombre.Enabled = false;
            txtTelefono.Enabled = false;
            txtEmail.Enabled = false;
            btnGuardar.Enabled = false;
            btnHabilitar.Enabled = true;
        }

        // Habilita todos los controles de entrada y activa el boton Deshabilitar.
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

        // Deshabilita los controles, limpia los campos y activa el boton Habilitar.
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

        // Valida y guarda el nuevo proveedor.
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string resultado = _negocio.RegistrarProveedor(
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

        // Limpia todos los campos de entrada.
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
        }

        // Solo permite digitos en el telefono.
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        // Formatea el telefono automaticamente con guiones (000-000-0000).
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

        // Valida el formato del email al salir del campo.
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
