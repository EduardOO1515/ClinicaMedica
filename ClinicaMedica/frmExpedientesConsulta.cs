using System;
using System.Data;
using System.Windows.Forms;
using ClinicaMedica.Negocio;

namespace ClinicaMedica
{
    public partial class frmExpedientesConsulta : Form
    {
        private ExpedientesNegocio _negocio = new ExpedientesNegocio();
        // Tabla completa cargada una vez en memoria para filtrar sin ir a la base de datos.
        private DataTable _tablaExpedientes;

        public frmExpedientesConsulta()
        {
            InitializeComponent();
            CargarExpedientes();
        }

        // Carga todos los expedientes desde la base de datos.
        private void CargarExpedientes()
        {
            try
            {
                _tablaExpedientes = _negocio.ObtenerTodos();
                dgvExpedientes.DataSource = _tablaExpedientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar expedientes: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Filtra en memoria por nombre de paciente o diagnostico.
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

        // Limpia el buscador y recarga todos los registros.
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            CargarExpedientes();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
