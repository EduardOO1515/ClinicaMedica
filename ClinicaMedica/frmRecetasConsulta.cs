using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaMedica.Negocio;

namespace ClinicaMedica
{
    // Formulario de consulta de recetas medicas con busqueda en memoria
    public partial class frmRecetasConsulta : Form
    {
        private RecetasNegocio _negocio = new RecetasNegocio();
        private DataTable _tablaRecetas;

        public frmRecetasConsulta()
        {
            InitializeComponent();
            this.Load += async (s, e) => await CargarRecetasAsync();
        }

        private async Task CargarRecetasAsync()
        {
            try
            {
                _tablaRecetas = await _negocio.ObtenerTodosAsync();
                dgvRecetas.DataSource = _tablaRecetas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar recetas: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Filtra por indicaciones o numero de cita sobre la tabla ya cargada
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string termino = txtBuscar.Text.Trim().ToLower();
                if (string.IsNullOrEmpty(termino))
                {
                    dgvRecetas.DataSource = _tablaRecetas;
                    return;
                }

                DataTable filtrada = _tablaRecetas.Clone();
                foreach (DataRow fila in _tablaRecetas.Rows)
                {
                    if (fila["Indicaciones"].ToString().ToLower().Contains(termino) ||
                        fila["IdCita"].ToString().Contains(termino))
                    {
                        filtrada.ImportRow(fila);
                    }
                }
                dgvRecetas.DataSource = filtrada;
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
            await CargarRecetasAsync();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
