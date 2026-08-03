using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaMedica.Negocio;

namespace ClinicaMedica
{
    // Formulario de consulta de proveedores con busqueda en memoria
    public partial class frmProveedoresConsulta : Form
    {
        private ProveedoresNegocio _negocio = new ProveedoresNegocio();
        private DataTable _tablaProveedores;
        private frmPrincipal _principal;

        public frmProveedoresConsulta(frmPrincipal principal)
        {
            InitializeComponent();
            _principal = principal;
            this.Load += async (s, e) => await CargarProveedoresAsync();
        }

        private async Task CargarProveedoresAsync()
        {
            try
            {
                _tablaProveedores = await _negocio.ObtenerTodosAsync();
                dgvProveedores.DataSource = _tablaProveedores;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proveedores: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Filtra por nombre o email sobre la tabla ya cargada
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string termino = txtBuscar.Text.Trim().ToLower();
                if (string.IsNullOrEmpty(termino))
                {
                    dgvProveedores.DataSource = _tablaProveedores;
                    return;
                }

                DataTable filtrada = _tablaProveedores.Clone();
                foreach (DataRow fila in _tablaProveedores.Rows)
                {
                    if (fila["Nombre"].ToString().ToLower().Contains(termino) ||
                        fila["Email"].ToString().ToLower().Contains(termino))
                    {
                        filtrada.ImportRow(fila);
                    }
                }
                dgvProveedores.DataSource = filtrada;
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
            await CargarProveedoresAsync();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.CurrentRow == null) return;
            DataRow fila = ((DataRowView)dgvProveedores.CurrentRow.DataBoundItem).Row;
            _principal.AbrirProveedorParaEditar(fila);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
