using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ClinicaMedica.Negocio;
using System.Linq;

namespace ClinicaMedica
{
    public partial class frmPacientes : Form
    {
        private PacientesNegocio _negocio = new PacientesNegocio();
        private int _idSeleccionado = 0;

        public frmPacientes()
        {
            InitializeComponent();
            CargarPacientes();
        }

        private void CargarPacientes()
        {
            try
            {
                dgvPacientes.DataSource = _negocio.ObtenerTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPacientes_CellClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPacientes.Rows[e.RowIndex].Cells["IdPaciente"].Value != DBNull.Value)
            {
                DataGridViewRow fila = dgvPacientes.Rows[e.RowIndex];
                _idSeleccionado = Convert.ToInt32(fila.Cells["IdPaciente"].Value);
                txtCedula.Text = fila.Cells["Cedula"].Value.ToString();
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtApellido.Text = fila.Cells["Apellido"].Value.ToString();
                txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
                dtpFechaNac.Value = Convert.ToDateTime(fila.Cells["FechaNacimiento"].Value);
                chkSeguro.Checked = Convert.ToBoolean(fila.Cells["TieneSeguro"].Value);
            }
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

                string resultado;
                if (_idSeleccionado == 0)
                    resultado = _negocio.RegistrarPaciente(txtCedula.Text, txtNombre.Text,
                        txtApellido.Text, dtpFechaNac.Value, txtTelefono.Text, chkSeguro.Checked);
                else
                    resultado = _negocio.ActualizarPaciente(_idSeleccionado, txtCedula.Text,
                        txtNombre.Text, txtApellido.Text, dtpFechaNac.Value,
                        txtTelefono.Text, chkSeguro.Checked);

                if (resultado == "OK")
                {
                    MessageBox.Show("Paciente guardado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarPacientes();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_idSeleccionado == 0)
                {
                    MessageBox.Show("Seleccione un paciente de la tabla.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult res = MessageBox.Show(
                    "⚠️ ¿Está seguro que desea eliminar este paciente?\n\n" +
                    "Esta acción también eliminará todas las citas\n" +
                    "asociadas a este paciente.\n\n" +
                    "Esta acción no se puede deshacer.",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (res == DialogResult.Yes)
                {
                    string resultado = _negocio.EliminarPaciente(_idSeleccionado);
                    if (resultado == "OK")
                    {
                        MessageBox.Show("✅ Paciente eliminado correctamente.\n" +
                            "Sus citas también fueron eliminadas del sistema.",
                            "Eliminación Exitosa",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        LimpiarCampos();
                        CargarPacientes();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al eliminar: " + ex.Message, "Error",
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
            _idSeleccionado = 0;
            txtCedula.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            dtpFechaNac.Value = DateTime.Now;
            chkSeguro.Checked = false;
        }
        // Cédula dominicana automática: 000-0000000-0
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
            string solo = new string(txtCedula.Text.Where(c => char.IsDigit(c)).ToArray());
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

        // Solo letras en Nombre — mínimo 2 caracteres
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("El nombre solo puede contener letras.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Solo letras en Apellido
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("El apellido solo puede contener letras.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Teléfono dominicano automático: 000-000-0000
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