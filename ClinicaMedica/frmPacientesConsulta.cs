using System;
using System.Data;
using System.Windows.Forms;
using ClinicaMedica.Negocio;

namespace ClinicaMedica
{
    public partial class frmPacientesConsulta : Form
    {
        private PacientesNegocio _negocio = new PacientesNegocio();
        private DataTable _tablaPacientes;

        public frmPacientesConsulta()
        {
            InitializeComponent();
            CargarPacientes();
        }

        private void CargarPacientes()
        {
            try
            {
                _tablaPacientes = _negocio.ObtenerTodos();
                dgvPacientes.DataSource = _tablaPacientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pacientes: " + ex.Message, "Error",
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
                    dgvPacientes.DataSource = _tablaPacientes;
                    return;
                }

                DataTable filtrada = _tablaPacientes.Clone();
                foreach (DataRow fila in _tablaPacientes.Rows)
                {
                    if (fila["Nombre"].ToString().ToLower().Contains(termino) ||
                        fila["Apellido"].ToString().ToLower().Contains(termino) ||
                        fila["Cedula"].ToString().ToLower().Contains(termino))
                    {
                        filtrada.ImportRow(fila);
                    }
                }
                dgvPacientes.DataSource = filtrada;
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
            CargarPacientes();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
