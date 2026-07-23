using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ClinicaMedica.Negocio;

namespace ClinicaMedica
{
    public partial class frmCitas : Form
    {
        private CitasNegocio _negocio = new CitasNegocio();
        private PacientesNegocio _negocioPacientes = new PacientesNegocio();
        private DoctoresNegocio _negocioDoctores = new DoctoresNegocio();
        private int _idSeleccionado = 0;

        public frmCitas()
        {
            InitializeComponent();
            ConfigurarFormulario();
            CargarCombos();
            CargarCitas();
        }

        private void ConfigurarFormulario()
        {
            this.Text = "Clínica Médica — Citas";
            this.BackColor = Color.FromArgb(10, 60, 120);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;

            // Título
            lblTitulo.Text = "📅 Gestión de Citas";
            lblTitulo.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(30, 15);
            lblTitulo.Size = new Size(500, 40);

            // DataGridView
            dgvCitas.Location = new Point(30, 65);
            dgvCitas.Size = new Size(this.ClientSize.Width - 60, 350);
            dgvCitas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvCitas.ReadOnly = true;
            dgvCitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCitas.BackgroundColor = Color.White;
            dgvCitas.BorderStyle = BorderStyle.None;
            dgvCitas.RowHeadersVisible = false;
            dgvCitas.Font = new Font("Segoe UI", 10);
            dgvCitas.RowTemplate.Height = 32;
            dgvCitas.ColumnHeadersHeight = 38;
            dgvCitas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(200, 120, 0);
            dgvCitas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCitas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvCitas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 245, 220);
            dgvCitas.GridColor = Color.FromArgb(200, 180, 150);
            // Estilo labels de costo
            lblCostoOriginal.ForeColor = Color.FromArgb(173, 216, 230);
            lblCostoOriginal.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            lblValorOriginal.ForeColor = Color.White;
            lblValorOriginal.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            lblDescuento.ForeColor = Color.FromArgb(173, 216, 230);
            lblDescuento.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            lblValorDescuento.ForeColor = Color.White;
            lblValorDescuento.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            lblTotal.ForeColor = Color.FromArgb(173, 216, 230);
            lblTotal.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            lblValorTotal.ForeColor = Color.White;
            lblValorTotal.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            // Fila 1 — Paciente, Doctor, Fecha
            PosicionarLabel(lblPaciente, 30, 430);
            PosicionarLabel(lblDoctor, 280, 430);
            PosicionarLabel(lblFecha, 530, 430);

            PosicionarCombo(cmbPaciente, 30, 455, 230);
            PosicionarCombo(cmbDoctor, 280, 455, 230);
            dtpFechaCita.Location = new Point(530, 455);
            dtpFechaCita.Size = new Size(250, 32);
            dtpFechaCita.Font = new Font("Segoe UI", 10);

            // Fila 2 — Estado, Tipo, Costo
            PosicionarLabel(lblEstado, 30, 510);
            PosicionarLabel(lblTipo, 280, 510);
            PosicionarLabel(lblCosto, 530, 510);

            PosicionarCombo(cmbEstado, 30, 535, 230);
            PosicionarCombo(cmbTipo, 280, 535, 230);

            txtCosto.Location = new Point(530, 535);
            txtCosto.Size = new Size(200, 32);
            txtCosto.Font = new Font("Segoe UI", 11);
            txtCosto.BackColor = Color.FromArgb(20, 80, 150);
            txtCosto.ForeColor = Color.White;
            txtCosto.BorderStyle = BorderStyle.FixedSingle;
            txtCosto.MaxLength = 10;

            // Llenar combos estado y tipo
            cmbEstado.Items.Clear();
            cmbEstado.Items.AddRange(new string[] { "Pendiente", "Completada", "Cancelada" });
            cmbEstado.SelectedIndex = 0;

            cmbTipo.Items.Clear();
            cmbTipo.Items.AddRange(new string[] { "General", "Especialidad", "Emergencia", "Control", "Laboratorio" });
            cmbTipo.SelectedIndex = 0;

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

        private void PosicionarCombo(ComboBox cmb, int x, int y, int ancho)
        {
            cmb.Location = new Point(x, y);
            cmb.Size = new Size(ancho, 32);
            cmb.Font = new Font("Segoe UI", 10);
            cmb.BackColor = Color.White;
            cmb.ForeColor = Color.FromArgb(10, 60, 120);
            cmb.FlatStyle = FlatStyle.Flat;
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
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

            // Panel de costos
            lblCostoOriginal.Location = new Point(30, 650);
            lblCostoOriginal.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblCostoOriginal.ForeColor = Color.FromArgb(173, 216, 230);
            lblCostoOriginal.AutoSize = true;

            lblValorOriginal.Location = new Point(200, 650);
            lblValorOriginal.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblValorOriginal.ForeColor = Color.White;
            lblValorOriginal.AutoSize = true;

            lblDescuento.Location = new Point(30, 680);
            lblDescuento.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblDescuento.ForeColor = Color.FromArgb(173, 216, 230);
            lblDescuento.AutoSize = true;

            lblValorDescuento.Location = new Point(200, 680);
            lblValorDescuento.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblValorDescuento.ForeColor = Color.FromArgb(0, 200, 100);
            lblValorDescuento.AutoSize = true;

            lblTotal.Location = new Point(30, 710);
            lblTotal.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(173, 216, 230);
            lblTotal.AutoSize = true;

            lblValorTotal.Location = new Point(200, 710);
            lblValorTotal.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblValorTotal.ForeColor = Color.FromArgb(0, 230, 118);
            lblValorTotal.AutoSize = true;
        }

        private void CargarCombos()
        {
            try
            {
                DataTable dtPacientes = _negocioPacientes.ObtenerTodos();
                cmbPaciente.DataSource = dtPacientes;
                cmbPaciente.DisplayMember = "Nombre";
                cmbPaciente.ValueMember = "IdPaciente";

                DataTable dtDoctores = _negocioDoctores.ObtenerTodos();
                cmbDoctor.DataSource = dtDoctores;
                cmbDoctor.DisplayMember = "Nombre";
                cmbDoctor.ValueMember = "IdDoctor";
                cmbPaciente.SelectedIndexChanged += CalcularCostoAutomatico;
                cmbTipo.SelectedIndexChanged += CalcularCostoAutomatico;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCitas()
        {
            try
            {
                dgvCitas.DataSource = _negocio.ObtenerTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar citas: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCitas_CellClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCitas.Rows[e.RowIndex].Cells["IdCita"].Value != DBNull.Value)
            {
                DataGridViewRow fila = dgvCitas.Rows[e.RowIndex];
                _idSeleccionado = Convert.ToInt32(fila.Cells["IdCita"].Value);
                cmbPaciente.SelectedValue = Convert.ToInt32(fila.Cells["IdPaciente"].Value);
                cmbDoctor.SelectedValue = Convert.ToInt32(fila.Cells["IdDoctor"].Value);
                dtpFechaCita.Value = Convert.ToDateTime(fila.Cells["FechaCita"].Value);
                cmbEstado.SelectedItem = fila.Cells["Estado"].Value.ToString();
                cmbTipo.SelectedItem = fila.Cells["TipoConsulta"].Value.ToString();
                txtCosto.Text = fila.Cells["Costo"].Value.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCosto.Text))
                {
                    MessageBox.Show("Ingrese el costo.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal costo = Convert.ToDecimal(txtCosto.Text);
                string resultado;

                if (_idSeleccionado == 0)
                    resultado = _negocio.RegistrarCita(
                        Convert.ToInt32(cmbPaciente.SelectedValue),
                        Convert.ToInt32(cmbDoctor.SelectedValue),
                        dtpFechaCita.Value,
                        cmbEstado.SelectedItem.ToString(),
                        cmbTipo.SelectedItem.ToString(),
                        costo);
                else
                    resultado = _negocio.ActualizarCita(
                        _idSeleccionado,
                        Convert.ToInt32(cmbPaciente.SelectedValue),
                        Convert.ToInt32(cmbDoctor.SelectedValue),
                        dtpFechaCita.Value,
                        cmbEstado.SelectedItem.ToString(),
                        cmbTipo.SelectedItem.ToString(),
                        costo);

                if (resultado == "OK")
                {
                    MessageBox.Show("Cita guardada correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarCitas();
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
                    MessageBox.Show("Seleccione una cita.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult res = MessageBox.Show("¿Eliminar esta cita?",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    string resultado = _negocio.EliminarCita(_idSeleccionado);
                    if (resultado == "OK")
                    {
                        MessageBox.Show("Cita eliminada.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        CargarCitas();
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
            dtpFechaCita.Value = DateTime.Now;
            txtCosto.Clear();
            cmbEstado.SelectedIndex = 0;
            cmbTipo.SelectedIndex = 0;
            CargarCombos();
        }

        private void CalcularCostoAutomatico(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipo.SelectedItem == null || cmbPaciente.SelectedItem == null) return;

                string tipo = cmbTipo.SelectedItem.ToString();

                // Obtener si el paciente tiene seguro
                DataRowView fila = cmbPaciente.SelectedItem as DataRowView;
                bool tieneSeguro = Convert.ToBoolean(fila?.Row["TieneSeguro"]);

                // Costo base según tipo de consulta
                decimal costoBase = 0;
                if (tipo == "General")
                    costoBase = 1500m;
                else if (tipo == "Especialidad")
                    costoBase = 3000m;
                else if (tipo == "Emergencia")
                    costoBase = 5000m;
                else if (tipo == "Control")
                    costoBase = 800m;
                else if (tipo == "Laboratorio")
                    costoBase = 1200m;

                // Calcular descuento y total
                decimal descuento = tieneSeguro ? costoBase / 2 : 0;
                decimal costoFinal = costoBase - descuento;

                // Mostrar en los labels
                lblValorOriginal.Text = $"RD${costoBase:N2}";
                lblValorDescuento.Text = $"RD${descuento:N2}";
                lblValorTotal.Text = $"RD${costoFinal:N2}";
                txtCosto.Text = costoFinal.ToString();

                // Estilo según si tiene seguro
                if (tieneSeguro)
                {
                    lblValorDescuento.ForeColor = Color.FromArgb(0, 200, 100);
                    lblValorTotal.ForeColor = Color.FromArgb(0, 200, 100);
                }
                else
                {
                    lblValorDescuento.ForeColor = Color.White;
                    lblValorTotal.ForeColor = Color.White;
                }
            }
            catch { }
        }
    }
}