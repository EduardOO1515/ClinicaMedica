using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaMedica.Negocio;

namespace ClinicaMedica
{
    // Formulario de consulta de doctores con busqueda en memoria
    public partial class frmDoctoresConsulta : Form
    {
        private DoctoresNegocio _negocio = new DoctoresNegocio();
        // _tablaDoctores guarda el conjunto completo; la busqueda filtra sobre esta tabla
        private DataTable _tablaDoctores;
        private frmPrincipal _principal;

        public frmDoctoresConsulta(frmPrincipal principal)
        {
            InitializeComponent();
            _principal = principal;
            this.Load += async (s, e) => await CargarDoctoresAsync();
        }

        private async Task CargarDoctoresAsync()
        {
            try
            {
                _tablaDoctores = await _negocio.ObtenerTodosAsync();
                dgvDoctores.DataSource = _tablaDoctores;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar doctores: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Filtra por nombre, apellido o cedula sobre la tabla ya cargada
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

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            await CargarDoctoresAsync();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvDoctores.CurrentRow == null) return;
            DataRow fila = ((DataRowView)dgvDoctores.CurrentRow.DataBoundItem).Row;
            _principal.AbrirDoctorParaEditar(fila);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
