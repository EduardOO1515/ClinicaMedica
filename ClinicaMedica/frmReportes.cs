using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaMedica.Negocio;

namespace ClinicaMedica
{
    // Formulario de reportes de citas. Permite filtrar por estado usando un predicado lambda.
    public partial class frmReportes : Form
    {
        private CitasNegocio _negocio = new CitasNegocio();
        private DataTable _tablaCitas;

        public frmReportes()
        {
            InitializeComponent();
            this.Load += async (s, e) => await CargarCitasAsync();
        }

        // Carga todas las citas y actualiza el contador en la etiqueta de informacion
        private async Task CargarCitasAsync()
        {
            try
            {
                _tablaCitas = await _negocio.ObtenerTodosAsync();
                dgvReportes.DataSource = _tablaCitas;
                lblInfo.Text = $"Total de citas: {_tablaCitas.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar reportes: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Filtra las citas por el estado seleccionado usando FiltrarCitas con un predicado
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

        // Recarga todas las citas sin filtro
        private async void btnTodos_Click(object sender, EventArgs e)
        {
            await CargarCitasAsync();
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
