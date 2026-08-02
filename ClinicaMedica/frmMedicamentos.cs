using System;
using System.Data;
using System.Windows.Forms;
using ClinicaMedica.Negocio;

namespace ClinicaMedica
{
    public partial class frmMedicamentos : Form
    {
        private MedicamentosNegocio _negocio = new MedicamentosNegocio();
        private ProveedoresNegocio _negocioProveedores = new ProveedoresNegocio();

        public frmMedicamentos()
        {
            InitializeComponent();
            CargarProveedores();
        }

        // Carga los proveedores en el combo al abrir el formulario.
        private void CargarProveedores()
        {
            try
            {
                DataTable dt = _negocioProveedores.ObtenerTodos();
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

        // Al cargar, deshabilita todos los controles de entrada.
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

        // Habilita todos los controles de entrada.
        private void btnHabilitar_Click(object sender, EventArgs e)
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
            txtNombre.Focus();
        }

        // Deshabilita los controles, limpia los campos y reactiva el boton Habilitar.
        private void btnDeshabilitar_Click(object sender, EventArgs e)
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
            LimpiarCampos();
        }

        // Valida y guarda el nuevo medicamento.
        private void btnGuardar_Click(object sender, EventArgs e)
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

                string resultado = _negocio.RegistrarMedicamento(
                    Convert.ToInt32(cboProveedor.SelectedValue),
                    txtNombre.Text.Trim(),
                    txtPresentacion.Text.Trim(),
                    txtConcentracion.Text.Trim(),
                    stock,
                    precio,
                    dtpFechaVencimiento.Value);

                if (resultado == "OK")
                {
                    MessageBox.Show("Medicamento guardado correctamente.", "Exito",
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

        // Limpia todos los campos de entrada.
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtPresentacion.Clear();
            txtConcentracion.Clear();
            txtStock.Clear();
            txtPrecio.Clear();
            dtpFechaVencimiento.Value = DateTime.Now;
            CargarProveedores();
        }

        // Solo permite digitos en campos numericos enteros.
        private void txtNumerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        // Solo permite digitos y punto decimal en campos de precio.
        private void txtDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }
    }
}
