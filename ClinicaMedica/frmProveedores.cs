using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaMedica.Negocio;

namespace ClinicaMedica
{
    // Formulario de entrada para registrar nuevos proveedores de medicamentos
    public partial class frmProveedores : Form
    {
        private ProveedoresNegocio _negocio = new ProveedoresNegocio();
        private int _idEditando = 0;

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

        private void HabilitarCampos()
        {
            txtNombre.Enabled = true;
            txtTelefono.Enabled = true;
            txtEmail.Enabled = true;
            btnGuardar.Enabled = true;
            btnHabilitar.Enabled = false;
            btnDeshabilitar.Enabled = true;
            btnGuardar.Text = _idEditando == 0 ? "Guardar" : "Actualizar";
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            txtNombre.Focus();
        }

        // Carga los datos de un proveedor existente y activa el modo edicion
        public void CargarParaEditar(DataRow fila)
        {
            _idEditando = Convert.ToInt32(fila["IdProveedor"]);
            txtNombre.Text = fila["Nombre"].ToString();

            txtTelefono.TextChanged -= txtTelefono_TextChanged;
            txtTelefono.Text = fila["Telefono"].ToString();
            txtTelefono.TextChanged += txtTelefono_TextChanged;

            txtEmail.Text = fila["Email"].ToString();
            HabilitarCampos();
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
            _idEditando = 0;
            btnGuardar.Text = "Guardar";
            LimpiarCampos();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string resultado;

                if (_idEditando == 0)
                {
                    resultado = await _negocio.RegistrarProveedorAsync(
                        txtNombre.Text.Trim(),
                        txtTelefono.Text.Trim(),
                        txtEmail.Text.Trim());
                }
                else
                {
                    resultado = await _negocio.ActualizarProveedorAsync(
                        _idEditando,
                        txtNombre.Text.Trim(),
                        txtTelefono.Text.Trim(),
                        txtEmail.Text.Trim());
                }

                if (resultado == "OK")
                {
                    string msg = _idEditando == 0 ? "Proveedor guardado correctamente." : "Proveedor actualizado correctamente.";
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
