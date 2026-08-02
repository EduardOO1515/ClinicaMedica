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
            CargarCitas();
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