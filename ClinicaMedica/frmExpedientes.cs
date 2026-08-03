using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaMedica.Negocio;

namespace ClinicaMedica
{
    // Formulario de entrada para registrar expedientes medicos
    public partial class frmExpedientes : Form
    {
        private ExpedientesNegocio _negocio = new ExpedientesNegocio();
        private CitasNegocio _negocioCitas = new CitasNegocio();
        private int _idEditando = 0;

        public frmExpedientes()
        {
            InitializeComponent();
            this.Load += async (s, e) => await CargarCitasAsync();
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

        // Inicia con todos los campos deshabilitados hasta que el usuario presione Habilitar
        private void frmExpedientes_Load(object sender, EventArgs e)
        {
            cboCita.Enabled = false;
            txtDiagnostico.Enabled = false;
            txtTratamiento.Enabled = false;
            btnGuardar.Enabled = false;
            btnHabilitar.Enabled = true;
        }

        private void HabilitarCampos()
        {
            // cboCita solo se habilita en modo agregar; en edicion queda bloqueado
            cboCita.Enabled = _idEditando == 0;
            txtDiagnostico.Enabled = true;
            txtTratamiento.Enabled = true;
            btnGuardar.Enabled = true;
            btnHabilitar.Enabled = false;
            btnDeshabilitar.Enabled = true;
            btnGuardar.Text = _idEditando == 0 ? "Guardar" : "Actualizar";
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            txtDiagnostico.Focus();
        }

        // Carga los datos de un expediente existente y activa el modo edicion
        public void CargarParaEditar(DataRow fila)
        {
            _idEditando = Convert.ToInt32(fila["IdExpediente"]);
            cboCita.SelectedValue = Convert.ToInt32(fila["IdCita"]);
            txtDiagnostico.Text = fila["Diagnostico"].ToString();
            txtTratamiento.Text = fila["Tratamiento"].ToString();
            HabilitarCampos();
            txtDiagnostico.Focus();
        }

        private async void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            cboCita.Enabled = false;
            txtDiagnostico.Enabled = false;
            txtTratamiento.Enabled = false;
            btnGuardar.Enabled = false;
            btnDeshabilitar.Enabled = false;
            btnHabilitar.Enabled = true;
            _idEditando = 0;
            btnGuardar.Text = "Guardar";
            await LimpiarCamposAsync();
        }

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

                string resultado;

                if (_idEditando == 0)
                {
                    resultado = await _negocio.RegistrarExpedienteAsync(
                        Convert.ToInt32(cboCita.SelectedValue),
                        txtDiagnostico.Text.Trim(),
                        txtTratamiento.Text.Trim());
                }
                else
                {
                    resultado = await _negocio.ActualizarExpedienteAsync(
                        _idEditando,
                        txtDiagnostico.Text.Trim(),
                        txtTratamiento.Text.Trim());
                }

                if (resultado == "OK")
                {
                    string msg = _idEditando == 0 ? "Expediente guardado correctamente." : "Expediente actualizado correctamente.";
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

        // Limpia los campos de texto y recarga el combo de citas
        private async Task LimpiarCamposAsync()
        {
            txtDiagnostico.Clear();
            txtTratamiento.Clear();
            await CargarCitasAsync();
        }
    }
}
