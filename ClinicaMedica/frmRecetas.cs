using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaMedica.Negocio;

namespace ClinicaMedica
{
    // Formulario de entrada para registrar recetas medicas con detalle de medicamentos
    public partial class frmRecetas : Form
    {
        private RecetasNegocio _negocio = new RecetasNegocio();
        private CitasNegocio _negocioCitas = new CitasNegocio();
        private MedicamentosNegocio _negocioMedicamentos = new MedicamentosNegocio();
        private int _idEditando = 0;

        public frmRecetas()
        {
            InitializeComponent();
            this.Load += async (s, e) =>
            {
                await CargarCitasAsync();
                await CargarMedicamentosAsync();
            };
        }

        // Construye una descripcion legible para cada cita y la usa como texto del combo
        private async Task CargarCitasAsync()
        {
            try
            {
                DataTable dt = await _negocioCitas.ObtenerTodosAsync();
                dt.Columns.Add("Descripcion", typeof(string));
                foreach (DataRow fila in dt.Rows)
                {
                    string fecha = Convert.ToDateTime(fila["FechaCita"]).ToString("dd/MM/yyyy");
                    fila["Descripcion"] = "Cita " + fila["IdCita"] + " - " + fecha + " (" + fila["Estado"] + ")";
                }
                cboCita.DataSource = dt;
                cboCita.DisplayMember = "Descripcion";
                cboCita.ValueMember = "IdCita";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar citas: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Carga los medicamentos como fuente de datos del DataGridViewComboBoxColumn del detalle
        private async Task CargarMedicamentosAsync()
        {
            try
            {
                DataTable dt = await _negocioMedicamentos.ObtenerTodosAsync();
                colMedicamento.DataSource = dt;
                colMedicamento.DisplayMember = "Nombre";
                colMedicamento.ValueMember = "IdMedicamento";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar medicamentos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Inicia con todos los campos deshabilitados hasta que el usuario presione Habilitar
        private void frmRecetas_Load(object sender, EventArgs e)
        {
            cboCita.Enabled = false;
            dtpFecha.Enabled = false;
            txtIndicaciones.Enabled = false;
            dgvDetalle.Enabled = false;
            btnAgregarLinea.Enabled = false;
            btnEliminarLinea.Enabled = false;
            btnGuardar.Enabled = false;
            btnHabilitar.Enabled = true;
        }

        private void HabilitarCampos()
        {
            // cboCita solo se habilita en modo agregar; en edicion queda bloqueado
            cboCita.Enabled = _idEditando == 0;
            dtpFecha.Enabled = true;
            txtIndicaciones.Enabled = true;
            dgvDetalle.Enabled = true;
            btnAgregarLinea.Enabled = true;
            btnEliminarLinea.Enabled = true;
            btnGuardar.Enabled = true;
            btnHabilitar.Enabled = false;
            btnDeshabilitar.Enabled = true;
            btnGuardar.Text = _idEditando == 0 ? "Guardar" : "Actualizar";
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            txtIndicaciones.Focus();
        }

        // Carga los datos de una receta existente y activa el modo edicion (solo cabecera)
        public void CargarParaEditar(DataRow fila)
        {
            _idEditando = Convert.ToInt32(fila["IdReceta"]);
            cboCita.SelectedValue = Convert.ToInt32(fila["IdCita"]);
            dtpFecha.Value = Convert.ToDateTime(fila["Fecha"]);
            txtIndicaciones.Text = fila["Indicaciones"].ToString();
            HabilitarCampos();
            txtIndicaciones.Focus();
        }

        private async void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            cboCita.Enabled = false;
            dtpFecha.Enabled = false;
            txtIndicaciones.Enabled = false;
            dgvDetalle.Enabled = false;
            btnAgregarLinea.Enabled = false;
            btnEliminarLinea.Enabled = false;
            btnGuardar.Enabled = false;
            btnDeshabilitar.Enabled = false;
            btnHabilitar.Enabled = true;
            _idEditando = 0;
            btnGuardar.Text = "Guardar";
            await LimpiarCamposAsync();
        }

        // Agrega una fila vacia al grid de detalle para que el usuario ingrese un medicamento
        private void btnAgregarLinea_Click(object sender, EventArgs e)
        {
            dgvDetalle.Rows.Add();
        }

        // Elimina la fila seleccionada del grid de detalle
        private void btnEliminarLinea_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.CurrentRow != null && !dgvDetalle.CurrentRow.IsNewRow)
            {
                dgvDetalle.Rows.Remove(dgvDetalle.CurrentRow);
            }
        }

        // Construye una DataTable con el detalle del grid y lo envia al negocio para guardar
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboCita.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar una cita.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataTable detalles = new DataTable();
                detalles.Columns.Add("IdMedicamento", typeof(int));
                detalles.Columns.Add("Dosis", typeof(string));
                detalles.Columns.Add("Frecuencia", typeof(string));
                detalles.Columns.Add("Duracion", typeof(string));
                detalles.Columns.Add("Observaciones", typeof(string));

                foreach (DataGridViewRow fila in dgvDetalle.Rows)
                {
                    if (fila.IsNewRow) continue;

                    object medVal = fila.Cells["colMedicamento"].Value;
                    if (medVal == null) continue;

                    detalles.Rows.Add(
                        Convert.ToInt32(medVal),
                        fila.Cells["colDosis"].Value?.ToString() ?? "",
                        fila.Cells["colFrecuencia"].Value?.ToString() ?? "",
                        fila.Cells["colDuracion"].Value?.ToString() ?? "",
                        fila.Cells["colObservaciones"].Value?.ToString() ?? "");
                }

                string resultado;

                if (_idEditando == 0)
                {
                    resultado = await _negocio.RegistrarRecetaAsync(
                        Convert.ToInt32(cboCita.SelectedValue),
                        dtpFecha.Value,
                        txtIndicaciones.Text.Trim(),
                        detalles);
                }
                else
                {
                    resultado = await _negocio.ActualizarRecetaAsync(
                        _idEditando,
                        dtpFecha.Value,
                        txtIndicaciones.Text.Trim());
                }

                if (resultado == "OK")
                {
                    string msg = _idEditando == 0 ? "Receta guardada correctamente." : "Receta actualizada correctamente.";
                    MessageBox.Show(msg, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _idEditando = 0;
                    btnGuardar.Text = "Guardar";
                    await LimpiarCamposAsync();
                }
                else
                {
                    MessageBox.Show(resultado, "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnLimpiar_Click(object sender, EventArgs e)
        {
            await LimpiarCamposAsync();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Limpia los campos y recarga el combo de citas; el grid de detalle se borra completamente
        private async Task LimpiarCamposAsync()
        {
            txtIndicaciones.Clear();
            dtpFecha.Value = DateTime.Now;
            dgvDetalle.Rows.Clear();
            await CargarCitasAsync();
        }
    }
}
