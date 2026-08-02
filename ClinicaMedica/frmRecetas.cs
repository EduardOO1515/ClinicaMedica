using System;
using System.Data;
using System.Windows.Forms;
using ClinicaMedica.Negocio;

namespace ClinicaMedica
{
    public partial class frmRecetas : Form
    {
        private RecetasNegocio _negocio = new RecetasNegocio();
        private CitasNegocio _negocioCitas = new CitasNegocio();
        private MedicamentosNegocio _negocioMedicamentos = new MedicamentosNegocio();

        public frmRecetas()
        {
            InitializeComponent();
            CargarCitas();
            CargarMedicamentos();
        }

        // Carga las citas disponibles en el combo con una descripcion legible.
        private void CargarCitas()
        {
            try
            {
                DataTable dt = _negocioCitas.ObtenerTodos();
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

        // Carga los medicamentos disponibles como origen de datos del combo de la grilla.
        private void CargarMedicamentos()
        {
            try
            {
                DataTable dt = _negocioMedicamentos.ObtenerTodos();
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

        // Al cargar, deshabilita todos los controles de entrada.
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

        // Habilita todos los controles de entrada.
        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            cboCita.Enabled = true;
            dtpFecha.Enabled = true;
            txtIndicaciones.Enabled = true;
            dgvDetalle.Enabled = true;
            btnAgregarLinea.Enabled = true;
            btnEliminarLinea.Enabled = true;
            btnGuardar.Enabled = true;
            btnHabilitar.Enabled = false;
            btnDeshabilitar.Enabled = true;
            txtIndicaciones.Focus();
        }

        // Deshabilita los controles, limpia los campos y reactiva el boton Habilitar.
        private void btnDeshabilitar_Click(object sender, EventArgs e)
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
            LimpiarCampos();
        }

        // Agrega una fila vacia al detalle para que el usuario la complete.
        private void btnAgregarLinea_Click(object sender, EventArgs e)
        {
            dgvDetalle.Rows.Add();
        }

        // Elimina la fila seleccionada del detalle.
        private void btnEliminarLinea_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.CurrentRow != null && !dgvDetalle.CurrentRow.IsNewRow)
            {
                dgvDetalle.Rows.Remove(dgvDetalle.CurrentRow);
            }
        }

        // Valida y guarda la receta con su detalle.
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboCita.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar una cita.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Construye el DataTable de detalle a partir de las filas de la grilla.
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

                string resultado = _negocio.RegistrarReceta(
                    Convert.ToInt32(cboCita.SelectedValue),
                    dtpFecha.Value,
                    txtIndicaciones.Text.Trim(),
                    detalles);

                if (resultado == "OK")
                {
                    MessageBox.Show("Receta guardada correctamente.", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Limpia todos los campos y vacia la grilla de detalle.
        private void LimpiarCampos()
        {
            txtIndicaciones.Clear();
            dtpFecha.Value = DateTime.Now;
            dgvDetalle.Rows.Clear();
            CargarCitas();
        }
    }
}
