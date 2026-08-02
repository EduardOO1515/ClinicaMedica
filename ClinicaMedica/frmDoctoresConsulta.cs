using System;
using System.Data;
using System.Windows.Forms;
using ClinicaMedica.Negocio;

namespace ClinicaMedica
{
    public partial class frmDoctoresConsulta : Form
    {
        private DoctoresNegocio _negocio = new DoctoresNegocio();
        private DataTable _tablaDoctores;

        public frmDoctoresConsulta()
        {
            InitializeComponent();
            CargarDoctores();
        }

        private void CargarDoctores()
        {
            try
            {
                _tablaDoctores = _negocio.ObtenerTodos();
                dgvDoctores.DataSource = _tablaDoctores;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar doctores: " + ex.Message, "Error",
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
                    dgvDoctores.DataSource = _tablaDoctores;
                    return;
                }

                DataTable filtrada = _tablaDoctores.Clone();
                foreach (DataRow fila in _tablaDoctores.Rows)
                {
                    if (fila["Nombre"].ToString().ToLower().Contains(termino) ||
                        fila["Apellido"].ToString().ToLower().Contains(termino) ||
                        fila["Cedula"].ToString().ToLower().Contains(termino))
                    {
                        filtrada.ImportRow(fila);
                    }
                }
                dgvDoctores.DataSource = filtrada;
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
            CargarDoctores();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
