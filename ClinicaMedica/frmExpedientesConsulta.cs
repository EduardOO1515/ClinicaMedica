using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaMedica.Negocio;

namespace ClinicaMedica
{
    // Formulario de consulta de expedientes medicos con busqueda en memoria
    public partial class frmExpedientesConsulta : Form
    {
        private ExpedientesNegocio _negocio = new ExpedientesNegocio();
        private DataTable _tablaExpedientes;

        public frmExpedientesConsulta()
        {
            InitializeComponent();
            this.Load += async (s, e) => await CargarExpedientesAsync();
        }

        private async Task CargarExpedientesAsync()
        {
            try
            {
                _tablaExpedientes = await _negocio.ObtenerTodosAsync();
                dgvExpedientes.DataSource = _tablaExpedientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar expedientes: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Filtra por nombre del paciente o diagnostico sobre la tabla ya cargada
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string termino = txtBuscar.Text.Trim().ToLower();
                if (string.IsNullOrEmpty(termino))
                {
                    dgvExpedientes.DataSource = _tablaExpedientes;
                    return;
                }

                DataTable filtrada = _tablaExpedientes.Clone();
                foreach (DataRow fila in _tablaExpedientes.Rows)
                {
                    if (fila["Paciente"].ToString().ToLower().Contains(termino) ||
                        fila["Diagnostico"].ToString().ToLower().Contains(termino))
                    {
                        filtrada.ImportRow(fila);
                    }
                }
                dgvExpedientes.DataSource = filtrada;
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
            await CargarExpedientesAsync();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
