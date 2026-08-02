using System;
using System.Data;
using System.Windows.Forms;
using ClinicaMedica.Negocio;

namespace ClinicaMedica
{
    public partial class frmExpedientes : Form
    {
        private ExpedientesNegocio _negocio = new ExpedientesNegocio();
        private CitasNegocio _negocioCitas = new CitasNegocio();

        public frmExpedientes()
        {
            InitializeComponent();
            CargarCitas();
        }

        // Carga las citas disponibles en el combo con una descripcion legible.
        private void CargarCitas()
        {
            try
            {
                DataTable dt = _negocioCitas.ObtenerTodos();
                // Columna de descripcion para mostrar en el combo.
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

        // Al cargar, deshabilita todos los controles de entrada.
        private void frmExpedientes_Load(object sender, EventArgs e)
        {
            cboCita.Enabled = false;
            txtDiagnostico.Enabled = false;
            txtTratamiento.Enabled = false;
            btnGuardar.Enabled = false;
            btnHabilitar.Enabled = true;
        }

        // Habilita todos los controles de entrada.
        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            cboCita.Enabled = true;
            txtDiagnostico.Enabled = true;
            txtTratamiento.Enabled = true;
            btnGuardar.Enabled = true;
            btnHabilitar.Enabled = false;
            btnDeshabilitar.Enabled = true;
            txtDiagnostico.Focus();
        }

        // Deshabilita los controles, limpia y reactiva el boton Habilitar.
        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            cboCita.Enabled = false;
            txtDiagnostico.Enabled = false;
            txtTratamiento.Enabled = false;
            btnGuardar.Enabled = false;
            btnDeshabilitar.Enabled = false;
            btnHabilitar.Enabled = true;
            LimpiarCampos();
        }

        // Valida y guarda el nuevo expediente.
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

                string resultado = _negocio.RegistrarExpediente(
                    Convert.ToInt32(cboCita.SelectedValue),
                    txtDiagnostico.Text.Trim(),
                    txtTratamiento.Text.Trim());

                if (resultado == "OK")
                {
                    MessageBox.Show("Expediente guardado correctamente.", "Exito",
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

        // Limpia los campos y recarga el combo de citas.
        private void LimpiarCampos()
        {
            txtDiagnostico.Clear();
            txtTratamiento.Clear();
            CargarCitas();
        }
    }
}
