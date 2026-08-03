using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaMedica.Negocio;

namespace ClinicaMedica
{
    // Formulario de entrada para registrar y editar pacientes
    public partial class frmPacientes : Form
    {
        private PacientesNegocio _negocio = new PacientesNegocio();
        // 0 significa modo agregar; cualquier otro valor es el id del paciente en edicion
        private int _idEditando = 0;

        public frmPacientes()
        {
            InitializeComponent();
        }

        // Inicia con todos los campos deshabilitados hasta que el usuario presione Habilitar
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

        // Habilita todos los campos y ajusta el texto del boton segun el modo actual
        private void HabilitarCampos()
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
            btnGuardar.Text = _idEditando == 0 ? "Guardar" : "Actualizar";
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
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
            _idEditando = 0;
            btnGuardar.Text = "Guardar";
            LimpiarCampos();
        }

        // Carga los datos de un paciente existente en los campos y activa el modo edicion
        public void CargarParaEditar(DataRow fila)
        {
            _idEditando = Convert.ToInt32(fila["IdPaciente"]);

            txtCedula.TextChanged -= txtCedula_TextChanged;
            txtCedula.Text = fila["Cedula"].ToString();
            txtCedula.TextChanged += txtCedula_TextChanged;

            txtNombre.Text = fila["Nombre"].ToString();
            txtApellido.Text = fila["Apellido"].ToString();

            txtTelefono.TextChanged -= txtTelefono_TextChanged;
            txtTelefono.Text = fila["Telefono"].ToString();
            txtTelefono.TextChanged += txtTelefono_TextChanged;

            dtpFechaNac.Value = Convert.ToDateTime(fila["FechaNacimiento"]);
            chkSeguro.Checked = Convert.ToBoolean(fila["TieneSeguro"]);

            HabilitarCampos();
            txtNombre.Focus();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCedula.Text) || txtCedula.Text.Length != 11)
                {
                    MessageBox.Show("La cedula debe tener 11 digitos.", "Advertencia",
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

                string resultado;

                if (_idEditando == 0)
                {
                    resultado = await _negocio.RegistrarPacienteAsync(
                        txtCedula.Text, txtNombre.Text, txtApellido.Text,
                        dtpFechaNac.Value, txtTelefono.Text, chkSeguro.Checked);
                }
                else
                {
                    resultado = await _negocio.ActualizarPacienteAsync(
                        _idEditando, txtCedula.Text, txtNombre.Text, txtApellido.Text,
                        dtpFechaNac.Value, txtTelefono.Text, chkSeguro.Checked);
                }

                if (resultado == "OK")
                {
                    string msg = _idEditando == 0 ? "Paciente guardado correctamente." : "Paciente actualizado correctamente.";
                    MessageBox.Show(msg, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _idEditando = 0;
                    btnGuardar.Text = "Guardar";
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
            _idEditando = 0;
            btnGuardar.Text = "Guardar";
            LimpiarCampos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // LimpiarCampos es sincrono porque no necesita llamar a la base de datos
        private void LimpiarCampos()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            dtpFechaNac.Value = DateTime.Now;
            chkSeguro.Checked = false;
        }

        // Solo permite digitos y la tecla de retroceso en el campo cedula
        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }
        }

        // Elimina cualquier caracter no numerico que pueda llegar por pegado de texto
        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            string solo = "";
            foreach (char c in txtCedula.Text)
                if (char.IsDigit(c)) solo += c;
            if (solo.Length > 11) solo = solo.Substring(0, 11);

            if (solo == txtCedula.Text) return;

            txtCedula.TextChanged -= txtCedula_TextChanged;
            txtCedula.Text = solo;
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

        // Elimina cualquier caracter no numerico que pueda llegar por pegado de texto
        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            string solo = "";
            foreach (char c in txtTelefono.Text)
                if (char.IsDigit(c)) solo += c;
            if (solo.Length > 10) solo = solo.Substring(0, 10);

            if (solo == txtTelefono.Text) return;

            txtTelefono.TextChanged -= txtTelefono_TextChanged;
            txtTelefono.Text = solo;
            txtTelefono.SelectionStart = txtTelefono.Text.Length;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
        }
    }
}
