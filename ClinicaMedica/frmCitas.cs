using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaMedica.Negocio;

namespace ClinicaMedica
{
    // Formulario de entrada para registrar nuevas citas medicas
    public partial class frmCitas : Form
    {
        private CitasNegocio _negocio = new CitasNegocio();
        private PacientesNegocio _negocioPacientes = new PacientesNegocio();
        private DoctoresNegocio _negocioDoctores = new DoctoresNegocio();

        public frmCitas()
        {
            InitializeComponent();
            this.Load += async (s, e) => await CargarCombosAsync();
        }

        // Inicia con todos los campos deshabilitados hasta que el usuario presione Habilitar
        private void frmCitas_Load(object sender, EventArgs e)
        {
            cmbPaciente.Enabled = false;
            cmbDoctor.Enabled = false;
            dtpFechaCita.Enabled = false;
            cmbEstado.Enabled = false;
            cmbTipo.Enabled = false;
            txtCosto.Enabled = false;
            btnGuardar.Enabled = false;
            btnHabilitar.Enabled = true;
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            cmbPaciente.Enabled = true;
            cmbDoctor.Enabled = true;
            dtpFechaCita.Enabled = true;
            cmbEstado.Enabled = true;
            cmbTipo.Enabled = true;
            txtCosto.Enabled = true;
            btnGuardar.Enabled = true;
            btnHabilitar.Enabled = false;
            btnDeshabilitar.Enabled = true;
        }

        private async void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            cmbPaciente.Enabled = false;
            cmbDoctor.Enabled = false;
            dtpFechaCita.Enabled = false;
            cmbEstado.Enabled = false;
            cmbTipo.Enabled = false;
            txtCosto.Enabled = false;
            btnGuardar.Enabled = false;
            btnDeshabilitar.Enabled = false;
            btnHabilitar.Enabled = true;
            await LimpiarCamposAsync();
        }

        // Carga pacientes y doctores en sus combos, y conecta CalcularCostoAutomatico a los eventos
        private async Task CargarCombosAsync()
        {
            try
            {
                DataTable dtPacientes = await _negocioPacientes.ObtenerTodosAsync();
                cmbPaciente.DataSource = dtPacientes;
                cmbPaciente.DisplayMember = "Nombre";
                cmbPaciente.ValueMember = "IdPaciente";

                DataTable dtDoctores = await _negocioDoctores.ObtenerTodosAsync();
                cmbDoctor.DataSource = dtDoctores;
                cmbDoctor.DisplayMember = "Nombre";
                cmbDoctor.ValueMember = "IdDoctor";

                cmbPaciente.SelectedIndexChanged += CalcularCostoAutomatico;
                cmbTipo.SelectedIndexChanged += CalcularCostoAutomatico;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCosto.Text))
                {
                    MessageBox.Show("Ingrese el costo.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal costo = Convert.ToDecimal(txtCosto.Text);

                string resultado = await _negocio.RegistrarCitaAsync(
                    Convert.ToInt32(cmbPaciente.SelectedValue),
                    Convert.ToInt32(cmbDoctor.SelectedValue),
                    dtpFechaCita.Value,
                    cmbEstado.SelectedItem.ToString(),
                    cmbTipo.SelectedItem.ToString(),
                    costo);

                if (resultado == "OK")
                {
                    MessageBox.Show("Cita guardada correctamente.", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private async Task LimpiarCamposAsync()
        {
            dtpFechaCita.Value = DateTime.Now;
            txtCosto.Clear();
            cmbEstado.SelectedIndex = 0;
            cmbTipo.SelectedIndex = 0;
            lblValorOriginal.Text = "RD$0.00";
            lblValorDescuento.Text = "RD$0.00";
            lblValorTotal.Text = "RD$0.00";
            await CargarCombosAsync();
        }

        // Calcula el costo automaticamente al cambiar el paciente o el tipo de consulta.
        // CalcularCosto() aplica el descuento de seguro internamente.
        // El precio original se reconstruye al reves cuando hay seguro (costoFinal * 2).
        private void CalcularCostoAutomatico(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipo.SelectedItem == null || cmbPaciente.SelectedItem == null) return;

                string tipo = cmbTipo.SelectedItem.ToString();

                DataRowView fila = cmbPaciente.SelectedItem as DataRowView;
                bool tieneSeguro = Convert.ToBoolean(fila?.Row["TieneSeguro"]);

                Paciente paciente = new Paciente("", "", "");
                paciente.TipoConsulta = tipo;
                paciente.TieneSeguro = tieneSeguro;

                decimal costoFinal = paciente.CalcularCosto();
                decimal costoBase = tieneSeguro ? costoFinal * 2 : costoFinal;
                decimal descuento = costoBase - costoFinal;

                lblValorOriginal.Text = $"RD${costoBase:N2}";
                lblValorDescuento.Text = $"RD${descuento:N2}";
                lblValorTotal.Text = $"RD${costoFinal:N2}";
                txtCosto.Text = costoFinal.ToString();

                // Resalta en verde cuando hay descuento por seguro
                if (tieneSeguro)
                {
                    lblValorDescuento.ForeColor = Color.FromArgb(0, 200, 100);
                    lblValorTotal.ForeColor = Color.FromArgb(0, 200, 100);
                }
                else
                {
                    lblValorDescuento.ForeColor = Color.White;
                    lblValorTotal.ForeColor = Color.White;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular el costo: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
