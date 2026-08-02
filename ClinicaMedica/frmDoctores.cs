using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaMedica.Negocio;

namespace ClinicaMedica
{
    // Formulario de entrada para registrar nuevos doctores
    public partial class frmDoctores : Form
    {
        private DoctoresNegocio _negocio = new DoctoresNegocio();

        public frmDoctores()
        {
            InitializeComponent();
            // Carga las especialidades al abrir el formulario para poblar el combo
            this.Load += async (s, e) => await CargarEspecialidadesAsync();
        }

        // Inicia con todos los campos deshabilitados hasta que el usuario presione Habilitar
        private void frmDoctores_Load(object sender, EventArgs e)
        {
            txtCedula.Enabled = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtTelefono.Enabled = false;
            txtEmail.Enabled = false;
            cmbEspecialidad.Enabled = false;
            btnGuardar.Enabled = false;
            btnHabilitar.Enabled = true;
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            txtCedula.Enabled = true;
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtTelefono.Enabled = true;
            txtEmail.Enabled = true;
            cmbEspecialidad.Enabled = true;
            btnGuardar.Enabled = true;
            btnHabilitar.Enabled = false;
            btnDeshabilitar.Enabled = true;
            txtCedula.Focus();
        }

        private async void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            txtCedula.Enabled = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtTelefono.Enabled = false;
            txtEmail.Enabled = false;
            cmbEspecialidad.Enabled = false;
            btnGuardar.Enabled = false;
            btnDeshabilitar.Enabled = false;
            btnHabilitar.Enabled = true;
            await LimpiarCamposAsync();
        }

        // Carga las opciones de especialidad desde la base de datos
        private async Task CargarEspecialidadesAsync()
        {
            try
            {
                DataTable dt = await _negocio.ObtenerEspecialidadesAsync();
                cmbEspecialidad.DataSource = dt;
                cmbEspecialidad.DisplayMember = "Nombre";
                cmbEspecialidad.ValueMember = "IdEspecialidad";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar especialidades: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCedula.Text) || txtCedula.Text.Length != 13)
                {
                    MessageBox.Show("La cedula debe tener 13 digitos.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("El nombre no puede estar vacio.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtApellido.Text))
                {
                    MessageBox.Show("El apellido no puede estar vacio.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string resultado = await _negocio.RegistrarDoctorAsync(
                    txtCedula.Text, txtNombre.Text, txtApellido.Text,
                    Convert.ToInt32(cmbEspecialidad.SelectedValue),
                    txtTelefono.Text, txtEmail.Text);

                if (resultado == "OK")
                {
                    MessageBox.Show("Doctor guardado correctamente.", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LimpiarCamposAsync();
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

        private async void btnLimpiar_Click(object sender, EventArgs e)
        {
            await LimpiarCamposAsync();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Limpia los campos de texto y recarga el combo de especialidades
        private async Task LimpiarCamposAsync()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            await CargarEspecialidadesAsync();
        }

        // Solo permite digitos y retroceso en el campo cedula
        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        // Aplica formato 000-0000000-0 mientras el usuario escribe
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
                e.Handled = true;
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        // Aplica formato 000-000-0000 mientras el usuario escribe
        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            string solo = "";
            foreach (char c in txtTelefono.Text)
                if (char.IsDigit(c)) solo += c;
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

        // Bloquea la escritura directa en el combo de especialidades
        private void cmbEspecialidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
