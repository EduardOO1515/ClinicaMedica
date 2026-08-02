using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaMedica.Negocio;

namespace ClinicaMedica
{
    // Formulario de consulta de pacientes con busqueda en memoria
    public partial class frmPacientesConsulta : Form
    {
        private PacientesNegocio _negocio = new PacientesNegocio();
        // _tablaPacientes guarda el conjunto completo; la busqueda filtra sobre esta tabla
        private DataTable _tablaPacientes;

        public frmPacientesConsulta()
        {
            InitializeComponent();
            this.Load += async (s, e) => await CargarPacientesAsync();
        }

        private async Task CargarPacientesAsync()
        {
            try
            {
                _tablaPacientes = await _negocio.ObtenerTodosAsync();
                dgvPacientes.DataSource = _tablaPacientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pacientes: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Filtra por nombre, apellido o cedula sobre la tabla ya cargada (sin ir a la BD)
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

        // Recarga la tabla completa desde la base de datos y limpia el campo de busqueda
        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            await CargarPacientesAsync();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
