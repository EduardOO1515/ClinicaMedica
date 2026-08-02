using System;
using System.Collections.Generic;
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
        private int _idSeleccionado = 0;

        public frmCitas()
        {
            InitializeComponent();
            CargarCombos();
            CargarCitas();
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

        private void CargarCitas()
        {
            try
            {
                dgvCitas.DataSource = _negocio.ObtenerTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar citas: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCitas_CellClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCitas.Rows[e.RowIndex].Cells["IdCita"].Value != DBNull.Value)
            {
                DataGridViewRow fila = dgvCitas.Rows[e.RowIndex];
                _idSeleccionado = Convert.ToInt32(fila.Cells["IdCita"].Value);
                cmbPaciente.SelectedValue = Convert.ToInt32(fila.Cells["IdPaciente"].Value);
                cmbDoctor.SelectedValue = Convert.ToInt32(fila.Cells["IdDoctor"].Value);
                dtpFechaCita.Value = Convert.ToDateTime(fila.Cells["FechaCita"].Value);
                cmbEstado.SelectedItem = fila.Cells["Estado"].Value.ToString();
                cmbTipo.SelectedItem = fila.Cells["TipoConsulta"].Value.ToString();
                txtCosto.Text = fila.Cells["Costo"].Value.ToString();
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
                string resultado;

                if (_idSeleccionado == 0)
                    resultado = _negocio.RegistrarCita(
                        Convert.ToInt32(cmbPaciente.SelectedValue),
                        Convert.ToInt32(cmbDoctor.SelectedValue),
                        dtpFechaCita.Value,
                        cmbEstado.SelectedItem.ToString(),
                        cmbTipo.SelectedItem.ToString(),
                        costo);
                else
                    resultado = _negocio.ActualizarCita(
                        _idSeleccionado,
                        Convert.ToInt32(cmbPaciente.SelectedValue),
                        Convert.ToInt32(cmbDoctor.SelectedValue),
                        dtpFechaCita.Value,
                        cmbEstado.SelectedItem.ToString(),
                        cmbTipo.SelectedItem.ToString(),
                        costo);

                if (resultado == "OK")
                {
                    MessageBox.Show("Cita guardada correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarCitas();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_idSeleccionado == 0)
                {
                    MessageBox.Show("Seleccione una cita.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult res = MessageBox.Show("¿Eliminar esta cita?",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    string resultado = _negocio.EliminarCita(_idSeleccionado);
                    if (resultado == "OK")
                    {
                        MessageBox.Show("Cita eliminada.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        CargarCitas();
                    }
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
            _idSeleccionado = 0;
            dtpFechaCita.Value = DateTime.Now;
            txtCosto.Clear();
            cmbEstado.SelectedIndex = 0;
            cmbTipo.SelectedIndex = 0;
            CargarCombos();
        }

        private void CalcularCostoAutomatico(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipo.SelectedItem == null || cmbPaciente.SelectedItem == null) return;

                string tipo = cmbTipo.SelectedItem.ToString();

                // Obtener si el paciente tiene seguro
                DataRowView fila = cmbPaciente.SelectedItem as DataRowView;
                bool tieneSeguro = Convert.ToBoolean(fila?.Row["TieneSeguro"]);

                // Costo base según tipo de consulta
                decimal costoBase = 0;
                if (tipo == "General")
                    costoBase = 1500m;
                else if (tipo == "Especialidad")
                    costoBase = 3000m;
                else if (tipo == "Emergencia")
                    costoBase = 5000m;
                else if (tipo == "Control")
                    costoBase = 800m;
                else if (tipo == "Laboratorio")
                    costoBase = 1200m;

                // Calcular descuento y total
                decimal descuento = tieneSeguro ? costoBase / 2 : 0;
                decimal costoFinal = costoBase - descuento;

                // Mostrar en los labels
                lblValorOriginal.Text = $"RD${costoBase:N2}";
                lblValorDescuento.Text = $"RD${descuento:N2}";
                lblValorTotal.Text = $"RD${costoFinal:N2}";
                txtCosto.Text = costoFinal.ToString();

                // Estilo según si tiene seguro
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