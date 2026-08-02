using System;
using System.Data;
using System.Windows.Forms;
using ClinicaMedica.Negocio;

namespace ClinicaMedica
{
    public partial class frmRecetasConsulta : Form
    {
        private RecetasNegocio _negocio = new RecetasNegocio();
        // Tabla completa cargada en memoria para filtrar sin consultar la base de datos.
        private DataTable _tablaRecetas;

        public frmRecetasConsulta()
        {
            InitializeComponent();
            CargarRecetas();
        }

        // Carga todas las recetas desde la base de datos.
        private void CargarRecetas()
        {
            try
            {
                _tablaRecetas = _negocio.ObtenerTodos();
                dgvRecetas.DataSource = _tablaRecetas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar recetas: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Filtra en memoria por indicaciones o por numero de cita.
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

        // Limpia el buscador y recarga todos los registros.
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            CargarRecetas();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
