using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ClinicaMedica.Negocio;

namespace ClinicaMedica
{
    public partial class frmReportes : Form
    {
        private CitasNegocio _negocio = new CitasNegocio();
        private DataTable _tablaCitas;

        public frmReportes()
        {
            InitializeComponent();
            ConfigurarFormulario();
            CargarCitas();
        }

        private void ConfigurarFormulario()
        {
            this.Text = "Clínica Médica — Reportes";
            this.BackColor = Color.FromArgb(10, 60, 120);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;

            // Título
            lblTitulo.Text = "📊 Reportes del Sistema";
            lblTitulo.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(30, 15);
            lblTitulo.Size = new Size(500, 40);

            // DataGridView
            dgvReportes.Location = new Point(30, 65);
            dgvReportes.Size = new Size(this.ClientSize.Width - 60, 450);
            dgvReportes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvReportes.ReadOnly = true;
            dgvReportes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReportes.BackgroundColor = Color.White;
            dgvReportes.BorderStyle = BorderStyle.None;
            dgvReportes.RowHeadersVisible = false;
            dgvReportes.Font = new Font("Segoe UI", 10);
            dgvReportes.RowTemplate.Height = 32;
            dgvReportes.ColumnHeadersHeight = 38;
            dgvReportes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(100, 50, 160);
            dgvReportes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvReportes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvReportes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 230, 255);
            dgvReportes.GridColor = Color.FromArgb(200, 180, 230);

            // Filtro
            lblFiltro.Text = "🔍 Filtrar por Estado:";
            lblFiltro.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblFiltro.ForeColor = Color.FromArgb(173, 216, 230);
            lblFiltro.Location = new Point(30, 535);
            lblFiltro.AutoSize = true;

            cmbFiltro.Location = new Point(200, 532);
            cmbFiltro.Size = new Size(200, 32);
            cmbFiltro.Font = new Font("Segoe UI", 10);
            cmbFiltro.BackColor = Color.White;
            cmbFiltro.ForeColor = Color.FromArgb(10, 60, 120);
            cmbFiltro.FlatStyle = FlatStyle.Flat;
            cmbFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltro.Items.Clear();
            cmbFiltro.Items.AddRange(new string[] { "Pendiente", "Completada", "Cancelada" });
            cmbFiltro.SelectedIndex = 0;
            // Info
            lblInfo.Font = new Font("Segoe UI", 11, FontStyle.Bold | FontStyle.Italic);
            lblInfo.ForeColor = Color.FromArgb(173, 216, 230);
            lblInfo.Location = new Point(430, 535);
            lblInfo.AutoSize = true;

            // Botones
            ConfigurarBoton(btnFiltrar, Color.FromArgb(100, 50, 160), new Point(30, 580));
            ConfigurarBoton(btnTodos, Color.FromArgb(0, 140, 70), new Point(160, 580));
            ConfigurarBoton(btnVolver, Color.FromArgb(180, 30, 30), new Point(290, 580));
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

        private void CargarCitas()
        {
            try
            {
                _tablaCitas = _negocio.ObtenerTodos();
                dgvReportes.DataSource = _tablaCitas;
                lblInfo.Text = $"Total de citas: {_tablaCitas.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar reportes: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbFiltro.SelectedItem == null) return;

                string estadoFiltro = cmbFiltro.SelectedItem.ToString();

                Func<DataRow, bool> filtro = fila =>
                    fila["Estado"].ToString() == estadoFiltro;

                List<DataRow> resultado = _negocio.FiltrarCitas(_tablaCitas, filtro);

                DataTable tablaFiltrada = _tablaCitas.Clone();
                foreach (DataRow fila in resultado)
                    tablaFiltrada.ImportRow(fila);

                dgvReportes.DataSource = tablaFiltrada;
                lblInfo.Text = $"Citas {estadoFiltro}: {tablaFiltrada.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            CargarCitas();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvReportes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}