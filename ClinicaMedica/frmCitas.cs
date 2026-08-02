using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ClinicaMedica.Negocio;

namespace ClinicaMedica
{
    public partial class frmCitas : Form
    {
        private CitasNegocio _negocio = new CitasNegocio();
        private PacientesNegocio _negocioPacientes = new PacientesNegocio();
        private DoctoresNegocio _negocioDoctores = new DoctoresNegocio();

        public frmCitas()
        {
            InitializeComponent();
            CargarCombos();
        }

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

        private void btnDeshabilitar_Click(object sender, EventArgs e)
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
            LimpiarCampos();
        }

        private void CargarCombos()
        {
            try
            {
                DataTable dtPacientes = _negocioPacientes.ObtenerTodos();
                cmbPaciente.DataSource = dtPacientes;
                cmbPaciente.DisplayMember = "Nombre";
                cmbPaciente.ValueMember = "IdPaciente";

                DataTable dtDoctores = _negocioDoctores.ObtenerTodos();
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

        private void btnGuardar_Click(object sender, EventArgs e)
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

                string resultado = _negocio.RegistrarCita(
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

        private void LimpiarCampos()
        {
            dtpFechaCita.Value = DateTime.Now;
            txtCosto.Clear();
            cmbEstado.SelectedIndex = 0;
            cmbTipo.SelectedIndex = 0;
            lblValorOriginal.Text = "RD$0.00";
            lblValorDescuento.Text = "RD$0.00";
            lblValorTotal.Text = "RD$0.00";
            CargarCombos();
        }

        private void CalcularCostoAutomatico(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipo.SelectedItem == null || cmbPaciente.SelectedItem == null) return;

                string tipo = cmbTipo.SelectedItem.ToString();

                DataRowView fila = cmbPaciente.SelectedItem as DataRowView;
                bool tieneSeguro = Convert.ToBoolean(fila?.Row["TieneSeguro"]);

                // Usa Paciente.CalcularCosto() para obtener el precio base segun el tipo de consulta.
                // TieneSeguro queda en false (valor por defecto del constructor) para que el metodo
                // devuelva el precio completo sin descuento; el descuento se aplica abajo visualmente.
                Paciente paciente = new Paciente("", "", "");
                paciente.TipoConsulta = tipo;
                decimal costoBase = paciente.CalcularCosto();

                decimal descuento = tieneSeguro ? costoBase / 2 : 0;
                decimal costoFinal = costoBase - descuento;

                lblValorOriginal.Text = $"RD${costoBase:N2}";
                lblValorDescuento.Text = $"RD${descuento:N2}";
                lblValorTotal.Text = $"RD${costoFinal:N2}";
                txtCosto.Text = costoFinal.ToString();

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
            catch { }
        }
    }
}
