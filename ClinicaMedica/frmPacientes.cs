using System;
using System.Windows.Forms;
using ClinicaMedica.Negocio;

namespace ClinicaMedica
{
    public partial class frmPacientes : Form
    {
        private PacientesNegocio _negocio = new PacientesNegocio();

        public frmPacientes()
        {
            InitializeComponent();
        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            txtCedula.Enabled = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtTelefono.Enabled = false;
            dtpFechaNac.Enabled = false;
            chkSeguro.Enabled = false;
            btnGuardar.Enabled = false;
            btnHabilitar.Enabled = true;
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            txtCedula.Enabled = true;
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtTelefono.Enabled = true;
            dtpFechaNac.Enabled = true;
            chkSeguro.Enabled = true;
            btnGuardar.Enabled = true;
            btnHabilitar.Enabled = false;
            btnDeshabilitar.Enabled = true;
            txtCedula.Focus();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            txtCedula.Enabled = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtTelefono.Enabled = false;
            dtpFechaNac.Enabled = false;
            chkSeguro.Enabled = false;
            btnGuardar.Enabled = false;
            btnDeshabilitar.Enabled = false;
            btnHabilitar.Enabled = true;
            LimpiarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCedula.Text) || txtCedula.Text.Length != 13)
                {
                    MessageBox.Show("La cédula debe tener 13  dígitos.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("El nombre no puede estar vacío.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtApellido.Text))
                {
                    MessageBox.Show("El apellido no puede estar vacío.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string resultado = _negocio.RegistrarPaciente(
                    txtCedula.Text, txtNombre.Text, txtApellido.Text,
                    dtpFechaNac.Value, txtTelefono.Text, chkSeguro.Checked);

                if (resultado == "OK")
                {
                    MessageBox.Show("Paciente guardado correctamente.", "Exito",
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

        private void LimpiarCampos()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            dtpFechaNac.Value = DateTime.Now;
            chkSeguro.Checked = false;
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            string solo = "";
            foreach (char c in txtCedula.Text)
                if (char.IsDigit(c)) solo += c;
            if (solo.Length > 11) solo = solo.Substring(0, 11);

            string formateado = solo;
            if (solo.Length > 3)
                formateado = solo.Substring(0, 3) + "-" + solo.Substring(3);
            if (solo.Length > 10)
                formateado = solo.Substring(0, 3) + "-" + solo.Substring(3, 7) + "-" + solo.Substring(10);

            txtCedula.TextChanged -= txtCedula_TextChanged;
            txtCedula.Text = formateado;
            txtCedula.SelectionStart = txtCedula.Text.Length;
            txtCedula.TextChanged += txtCedula_TextChanged;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("El nombre solo puede contener letras.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("El apellido solo puede contener letras.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }
        }

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
    }
}
