using System;
using System.Data;
using System.Windows.Forms;
using ClinicaMedica.Negocio;

namespace ClinicaMedica
{
    public partial class frmCitasConsulta : Form
    {
        private CitasNegocio _negocio = new CitasNegocio();
        private DataTable _tablaCitas;

        public frmCitasConsulta()
        {
            InitializeComponent();
            CargarCitas();
        }

        private void CargarCitas()
        {
            try
            {
                _tablaCitas = _negocio.ObtenerTodos();
                dgvCitas.DataSource = _tablaCitas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar citas: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            CargarCitas();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
