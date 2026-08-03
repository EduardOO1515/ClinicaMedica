using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaMedica.Negocio;

namespace ClinicaMedica
{
    // Formulario de entrada para registrar nuevos medicamentos en el inventario
    public partial class frmMedicamentos : Form
    {
        private MedicamentosNegocio _negocio = new MedicamentosNegocio();
        private ProveedoresNegocio _negocioProveedores = new ProveedoresNegocio();
        private int _idEditando = 0;

        public frmMedicamentos()
        {
            InitializeComponent();
            // Carga los proveedores al abrir el formulario para poblar el combo
            this.Load += async (s, e) => await CargarProveedoresAsync();
        }

        // Carga las opciones del combo de proveedores desde la base de datos
        private async Task CargarProveedoresAsync()
        {
            try
            {
                DataTable dt = await _negocioProveedores.ObtenerTodosAsync();
                cboProveedor.DataSource = dt;
                cboProveedor.DisplayMember = "Nombre";
                cboProveedor.ValueMember = "IdProveedor";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proveedores: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Inicia con todos los campos deshabilitados hasta que el usuario presione Habilitar
        private void frmMedicamentos_Load(object sender, EventArgs e)
        {
            cboProveedor.Enabled = false;
            txtNombre.Enabled = false;
            txtPresentacion.Enabled = false;
            txtConcentracion.Enabled = false;
            txtStock.Enabled = false;
            txtPrecio.Enabled = false;
            dtpFechaVencimiento.Enabled = false;
            btnGuardar.Enabled = false;
            btnHabilitar.Enabled = true;
        }

        private void HabilitarCampos()
        {
            cboProveedor.Enabled = true;
            txtNombre.Enabled = true;
            txtPresentacion.Enabled = true;
            txtConcentracion.Enabled = true;
            txtStock.Enabled = true;
            txtPrecio.Enabled = true;
            dtpFechaVencimiento.Enabled = true;
            btnGuardar.Enabled = true;
            btnHabilitar.Enabled = false;
            btnDeshabilitar.Enabled = true;
            btnGuardar.Text = _idEditando == 0 ? "Guardar" : "Actualizar";
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            txtNombre.Focus();
        }

        // Carga los datos de un medicamento existente y activa el modo edicion
        public void CargarParaEditar(DataRow fila)
        {
            _idEditando = Convert.ToInt32(fila["IdMedicamento"]);
            cboProveedor.SelectedValue = Convert.ToInt32(fila["IdProveedor"]);
            txtNombre.Text = fila["Nombre"].ToString();
            txtPresentacion.Text = fila["Presentacion"].ToString();
            txtConcentracion.Text = fila["Concentracion"].ToString();
            txtStock.Text = fila["Stock"].ToString();
            txtPrecio.Text = fila["Precio"].ToString();
            dtpFechaVencimiento.Value = Convert.ToDateTime(fila["FechaVencimiento"]);
            HabilitarCampos();
            txtNombre.Focus();
        }

        private async void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            cboProveedor.Enabled = false;
            txtNombre.Enabled = false;
            txtPresentacion.Enabled = false;
            txtConcentracion.Enabled = false;
            txtStock.Enabled = false;
            txtPrecio.Enabled = false;
            dtpFechaVencimiento.Enabled = false;
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
                if (!int.TryParse(txtStock.Text, out int stock))
                {
                    MessageBox.Show("El stock debe ser un numero entero.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
                {
                    MessageBox.Show("El precio debe ser un numero valido.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string resultado;

                if (_idEditando == 0)
                {
                    resultado = await _negocio.RegistrarMedicamentoAsync(
                        Convert.ToInt32(cboProveedor.SelectedValue),
                        txtNombre.Text.Trim(),
                        txtPresentacion.Text.Trim(),
                        txtConcentracion.Text.Trim(),
                        stock, precio, dtpFechaVencimiento.Value);
                }
                else
                {
                    resultado = await _negocio.ActualizarMedicamentoAsync(
                        _idEditando,
                        Convert.ToInt32(cboProveedor.SelectedValue),
                        txtNombre.Text.Trim(),
                        txtPresentacion.Text.Trim(),
                        txtConcentracion.Text.Trim(),
                        stock, precio, dtpFechaVencimiento.Value);
                }

                if (resultado == "OK")
                {
                    string msg = _idEditando == 0 ? "Medicamento guardado correctamente." : "Medicamento actualizado correctamente.";
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

        // Limpia los campos y recarga el combo de proveedores
        private async Task LimpiarCamposAsync()
        {
            txtNombre.Clear();
            txtPresentacion.Clear();
            txtConcentracion.Clear();
            txtStock.Clear();
            txtPrecio.Clear();
            dtpFechaVencimiento.Value = DateTime.Now;
            await CargarProveedoresAsync();
        }

        // Solo permite digitos y retroceso en campos numericos enteros
        private void txtNumerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        // Permite digitos, punto decimal y retroceso en el campo precio
        private void txtDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }
    }
}
