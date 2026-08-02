using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaMedica.Negocio;

namespace ClinicaMedica
{
    // Formulario de consulta de medicamentos con busqueda en memoria y alertas visuales
    public partial class frmMedicamentosConsulta : Form
    {
        private MedicamentosNegocio _negocio = new MedicamentosNegocio();
        private DataTable _tablaMedicamentos;

        public frmMedicamentosConsulta()
        {
            InitializeComponent();
            this.Load += async (s, e) => await CargarMedicamentosAsync();
        }

        private async Task CargarMedicamentosAsync()
        {
            try
            {
                _tablaMedicamentos = await _negocio.ObtenerTodosAsync();
                dgvMedicamentos.DataSource = _tablaMedicamentos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar medicamentos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Filtra por nombre del medicamento o nombre del proveedor sobre la tabla ya cargada
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

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            await CargarMedicamentosAsync();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Resalta en rojo las filas con stock menor a 20 o que vencen en menos de 30 dias
        // TODO: mejora futura, hacer los umbrales de alerta configurables desde una tabla de parametros
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
