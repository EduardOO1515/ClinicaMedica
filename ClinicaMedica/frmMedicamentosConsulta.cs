using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ClinicaMedica.Negocio;

namespace ClinicaMedica
{
    public partial class frmMedicamentosConsulta : Form
    {
        private MedicamentosNegocio _negocio = new MedicamentosNegocio();
        // Tabla completa en memoria usada como base para filtrar.
        private DataTable _tablaMedicamentos;

        public frmMedicamentosConsulta()
        {
            InitializeComponent();
            CargarMedicamentos();
        }

        // Carga todos los medicamentos desde la base de datos.
        private void CargarMedicamentos()
        {
            try
            {
                _tablaMedicamentos = _negocio.ObtenerTodos();
                dgvMedicamentos.DataSource = _tablaMedicamentos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar medicamentos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Filtra en memoria por nombre o proveedor segun el texto ingresado.
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string termino = txtBuscar.Text.Trim().ToLower();
                if (string.IsNullOrEmpty(termino))
                {
                    dgvMedicamentos.DataSource = _tablaMedicamentos;
                    return;
                }

                DataTable filtrada = _tablaMedicamentos.Clone();
                foreach (DataRow fila in _tablaMedicamentos.Rows)
                {
                    if (fila["Nombre"].ToString().ToLower().Contains(termino) ||
                        fila["Proveedor"].ToString().ToLower().Contains(termino))
                    {
                        filtrada.ImportRow(fila);
                    }
                }
                dgvMedicamentos.DataSource = filtrada;
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
            CargarMedicamentos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Resalta en rojo las filas con stock menor a 20 o con fecha de vencimiento
        // a menos de 30 dias desde hoy.
        private void dgvMedicamentos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                DataGridViewRow fila = dgvMedicamentos.Rows[e.RowIndex];
                object stockVal = fila.Cells["Stock"].Value;
                object fechaVal = fila.Cells["FechaVencimiento"].Value;

                if (stockVal == null || fechaVal == null) return;

                int stock = Convert.ToInt32(stockVal);
                DateTime vencimiento = Convert.ToDateTime(fechaVal);
                bool alerta = stock < 20 || vencimiento < DateTime.Now.AddDays(30);

                if (alerta)
                {
                    e.CellStyle.BackColor = Color.FromArgb(255, 180, 180);
                    e.CellStyle.ForeColor = Color.DarkRed;
                }
            }
            catch { }
        }
    }
}
