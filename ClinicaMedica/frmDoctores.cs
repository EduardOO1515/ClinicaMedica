using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ClinicaMedica.Negocio;

namespace ClinicaMedica
{
    public partial class frmDoctores : Form
    {
        private DoctoresNegocio _negocio = new DoctoresNegocio();
        private int _idSeleccionado = 0;

        public frmDoctores()
        {
            InitializeComponent();
            ConfigurarFormulario();
            CargarEspecialidades();
            CargarDoctores();
        }

        private void ConfigurarFormulario()
        {
            this.Text = "Clínica Médica — Doctores";
            this.BackColor = Color.FromArgb(10, 60, 120);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;

            // Título
            lblTitulo.Text = "👨‍⚕️ Gestión de Doctores";
            lblTitulo.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(30, 15);
            lblTitulo.Size = new Size(500, 40);

            // DataGridView
            dgvDoctores.Location = new Point(30, 65);
            dgvDoctores.Size = new Size(this.ClientSize.Width - 60, 350);
            dgvDoctores.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvDoctores.ReadOnly = true;
            dgvDoctores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDoctores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDoctores.BackgroundColor = Color.White;
            dgvDoctores.BorderStyle = BorderStyle.None;
            dgvDoctores.RowHeadersVisible = false;
            dgvDoctores.Font = new Font("Segoe UI", 10);
            dgvDoctores.RowTemplate.Height = 32;
            dgvDoctores.ColumnHeadersHeight = 38;
            dgvDoctores.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 140, 70);
            dgvDoctores.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDoctores.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvDoctores.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(220, 245, 230);
            dgvDoctores.GridColor = Color.FromArgb(173, 216, 200);

            // Fila 1 — Cédula, Nombre, Apellido, Teléfono
            PosicionarLabel(lblCedula, 30, 430);
            PosicionarLabel(lblNombre, 230, 430);
            PosicionarLabel(lblApellido, 430, 430);
            PosicionarLabel(lblTelefono, 630, 430);

            PosicionarTextBox(txtCedula, 30, 455, 13);
            PosicionarTextBox(txtNombre, 230, 455, 100);
            PosicionarTextBox(txtApellido, 430, 455, 100);
            PosicionarTextBox(txtTelefono, 630, 455, 15);

            // Fila 2 — Email y Especialidad
            PosicionarLabel(lblEmail, 30, 505);
            PosicionarLabel(lblEspecialidad, 430, 505);

            PosicionarTextBox(txtEmail, 30, 530, 100);

            cmbEspecialidad.Location = new Point(430, 530);
            cmbEspecialidad.Size = new Size(200, 32);
            cmbEspecialidad.Font = new Font("Segoe UI", 10);
            cmbEspecialidad.BackColor = Color.White;
            cmbEspecialidad.ForeColor = Color.FromArgb(10, 60, 120);
            cmbEspecialidad.FlatStyle = FlatStyle.Flat;

            // Botones
            ConfigurarBoton(btnGuardar, Color.FromArgb(0, 168, 232), new Point(30, 585));
            ConfigurarBoton(btnEliminar, Color.FromArgb(180, 30, 30), new Point(160, 585));
            ConfigurarBoton(btnLimpiar, Color.FromArgb(70, 130, 180), new Point(290, 585));
            ConfigurarBoton(btnVolver, Color.FromArgb(0, 100, 60), new Point(420, 585));
        }

        private void PosicionarLabel(Label lbl, int x, int y)
        {
            lbl.Location = new Point(x, y);
            lbl.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            lbl.ForeColor = Color.FromArgb(173, 216, 230);
            lbl.AutoSize = true;
        }

        private void PosicionarTextBox(TextBox txt, int x, int y, int maxLength)
        {
            txt.Location = new Point(x, y);
            txt.Size = new Size(180, 30);
            txt.Font = new Font("Segoe UI", 10);
            txt.BackColor = Color.FromArgb(20, 80, 150);
            txt.ForeColor = Color.White;
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.MaxLength = maxLength;
        }

        private void ConfigurarBoton(Button btn, Color color, Point location)
        {
            btn.BackColor = color;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;
            btn.Size = new Size(120, 38);
            btn.Location = location;
        }

        private void CargarEspecialidades()
        {
            try
            {
                DataTable dt = _negocio.ObtenerEspecialidades();
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

        private void CargarDoctores()
        {
            try
            {
                dgvDoctores.DataSource = _negocio.ObtenerTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar doctores: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDoctores_CellClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDoctores.Rows[e.RowIndex].Cells["IdDoctor"].Value != DBNull.Value)
            {
                DataGridViewRow fila = dgvDoctores.Rows[e.RowIndex];
                _idSeleccionado = Convert.ToInt32(fila.Cells["IdDoctor"].Value);
                txtCedula.Text = fila.Cells["Cedula"].Value.ToString();
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtApellido.Text = fila.Cells["Apellido"].Value.ToString();
                txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
                txtEmail.Text = fila.Cells["Email"].Value.ToString();
                cmbEspecialidad.SelectedValue = Convert.ToInt32(fila.Cells["IdEspecialidad"].Value);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCedula.Text) || txtCedula.Text.Length != 13)
                {
                    MessageBox.Show("La cédula debe tener 13 dígitos.", "Advertencia",
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
                    resultado = _negocio.RegistrarDoctor(txtCedula.Text, txtNombre.Text,
                        txtApellido.Text, Convert.ToInt32(cmbEspecialidad.SelectedValue),
                        txtTelefono.Text, txtEmail.Text);
                else
                    resultado = _negocio.ActualizarDoctor(_idSeleccionado, txtCedula.Text,
                        txtNombre.Text, txtApellido.Text,
                        Convert.ToInt32(cmbEspecialidad.SelectedValue),
                        txtTelefono.Text, txtEmail.Text);

                if (resultado == "OK")
                {
                    MessageBox.Show("Doctor guardado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarDoctores();
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
                    MessageBox.Show("Seleccione un doctor.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult res = MessageBox.Show("¿Eliminar este doctor?",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    string resultado = _negocio.EliminarDoctor(_idSeleccionado);
                    if (resultado == "OK")
                    {
                        MessageBox.Show("Doctor eliminado.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        CargarDoctores();
                    }
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
            _idSeleccionado = 0;
            txtCedula.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            CargarEspecialidades();

        }
    


    private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
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

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            if (string.IsNullOrWhiteSpace(email)) return;

            if (!email.Contains("@") || !email.Contains(".") ||
                email.IndexOf("@") < 1 ||
                email.IndexOf(".") < email.IndexOf("@") + 2 ||
                email.EndsWith("."))
            {
                MessageBox.Show("El email no es válido. Ejemplo: nombre@correo.com", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
            }
        }

        private void cmbEspecialidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // No permite escribir
        }

       
    }
}