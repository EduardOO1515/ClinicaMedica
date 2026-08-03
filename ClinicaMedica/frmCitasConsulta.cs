using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaMedica.Negocio;

namespace ClinicaMedica
{
    // Formulario de consulta de citas con busqueda en memoria
    public partial class frmCitasConsulta : Form
    {
        private CitasNegocio _negocio = new CitasNegocio();
        private DataTable _tablaCitas;
        private frmPrincipal _principal;

        public frmCitasConsulta(frmPrincipal principal)
        {
            InitializeComponent();
            _principal = principal;
            this.Load += async (s, e) => await CargarCitasAsync();
        }

        private async Task CargarCitasAsync()
        {
            try
            {
                _tablaCitas = await _negocio.ObtenerTodosAsync();
                dgvCitas.DataSource = _tablaCitas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar citas: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Filtra por estado, tipo de consulta o fecha sobre la tabla ya cargada
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string termino = txtBuscar.Text.Trim().ToLower();
                if (string.IsNullOrEmpty(termino))
                {
                    dgvCitas.DataSource = _tablaCitas;
                    return;
                }

                DataTable filtrada = _tablaCitas.Clone();
                foreach (DataRow fila in _tablaCitas.Rows)
                {
                    if (fila["Estado"].ToString().ToLower().Contains(termino) ||
                        fila["TipoConsulta"].ToString().ToLower().Contains(termino) ||
                        fila["FechaCita"].ToString().ToLower().Contains(termino))
                    {
                        filtrada.ImportRow(fila);
                    }
                }
                dgvCitas.DataSource = filtrada;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            await CargarCitasAsync();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCitas.CurrentRow == null) return;
            DataRow fila = ((DataRowView)dgvCitas.CurrentRow.DataBoundItem).Row;
            _principal.AbrirCitaParaEditar(fila);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
