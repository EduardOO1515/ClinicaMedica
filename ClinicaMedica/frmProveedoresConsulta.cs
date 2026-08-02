using System;
using System.Data;
using System.Windows.Forms;
using ClinicaMedica.Negocio;

namespace ClinicaMedica
{
    public partial class frmProveedoresConsulta : Form
    {
        private ProveedoresNegocio _negocio = new ProveedoresNegocio();
        // Tabla completa cargada al abrir; se usa como base para el filtro en memoria.
        private DataTable _tablaProveedores;

        public frmProveedoresConsulta()
        {
            InitializeComponent();
            CargarProveedores();
        }

        // Carga todos los proveedores desde la base de datos y los muestra en el grid.
        private void CargarProveedores()
        {
            try
            {
                _tablaProveedores = _negocio.ObtenerTodos();
                dgvProveedores.DataSource = _tablaProveedores;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proveedores: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Filtra en memoria los proveedores por nombre o email segun el texto ingresado.
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

        // Limpia el buscador y vuelve a cargar todos los registros.
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            CargarProveedores();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
