using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaMedica
{
    // Formulario principal del sistema. Contiene el menu y el panel de contenido embebido.
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            this.Load += frmPrincipal_Load;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
                return;

            // Oculta el principal y muestra el login; si el usuario cancela, sale de la app
            this.Hide();

            using (frmLogin login = new frmLogin())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        // Embebe un formulario dentro de pnlContenido en lugar de abrirlo como ventana nueva
        private void AbrirFormulario(Form frm)
        {
            // Cierra y elimina el formulario que estuviera abierto antes en el panel
            foreach (Control control in pnlContenido.Controls)
            {
                if (control is Form formAbierto)
                {
                    formAbierto.Close();
                }
            }
            pnlContenido.Controls.Clear();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            pnlContenido.Controls.Add(frm);
            frm.Show();
        }

        // --- ENTRADA ---

        private void mnuEntradaPacientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmPacientes());
        }

        private void mnuEntradaDoctores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmDoctores());
        }

        private void mnuEntradaCitas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmCitas());
        }

        private void mnuEntradaProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmProveedores());
        }

        private void mnuEntradaExpedientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmExpedientes());
        }

        private void mnuEntradaMedicamentos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmMedicamentos());
        }

        private void mnuEntradaRecetas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmRecetas());
        }

        // --- CONSULTA ---

        private void mnuConsultaPacientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmPacientesConsulta(this));
        }

        // Abre frmPacientes embebido y carga el registro seleccionado para edicion
        public void AbrirPacienteParaEditar(DataRow fila)
        {
            frmPacientes frm = new frmPacientes();
            AbrirFormulario(frm);
            frm.CargarParaEditar(fila);
        }

        private void mnuConsultaDoctores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmDoctoresConsulta(this));
        }

        public void AbrirDoctorParaEditar(DataRow fila)
        {
            frmDoctores frm = new frmDoctores();
            AbrirFormulario(frm);
            frm.CargarParaEditar(fila);
        }

        private void mnuConsultaCitas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmCitasConsulta(this));
        }

        public void AbrirCitaParaEditar(DataRow fila)
        {
            frmCitas frm = new frmCitas();
            AbrirFormulario(frm);
            frm.CargarParaEditar(fila);
        }

        private void mnuConsultaProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmProveedoresConsulta(this));
        }

        public void AbrirProveedorParaEditar(DataRow fila)
        {
            frmProveedores frm = new frmProveedores();
            AbrirFormulario(frm);
            frm.CargarParaEditar(fila);
        }

        private void mnuConsultaExpedientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmExpedientesConsulta(this));
        }

        public void AbrirExpedienteParaEditar(DataRow fila)
        {
            frmExpedientes frm = new frmExpedientes();
            AbrirFormulario(frm);
            frm.CargarParaEditar(fila);
        }

        private void mnuConsultaMedicamentos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmMedicamentosConsulta(this));
        }

        public void AbrirMedicamentoParaEditar(DataRow fila)
        {
            frmMedicamentos frm = new frmMedicamentos();
            AbrirFormulario(frm);
            frm.CargarParaEditar(fila);
        }

        private void mnuConsultaRecetas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmRecetasConsulta(this));
        }

        public async Task AbrirRecetaParaEditar(DataRow fila)
        {
            frmRecetas frm = new frmRecetas();
            AbrirFormulario(frm);
            await frm.CargarParaEditar(fila);
        }

        // --- REPORTES ---

        private void mnuReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmReportes());
        }

        // --- SISTEMA ---
        // frmAcercaDe se abre como ventana emergente (ShowDialog), no embebida

        private void mnuSistemaAcercaDe_Click(object sender, EventArgs e)
        {
            new frmAcercaDe().ShowDialog();
        }

        // --- SALIR ---

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Desea cerrar sesión?", "Cerrar Sesión",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                CerrarSesion();
            }
        }

        // Oculta el principal y vuelve a mostrar el login para cambio de sesion
        private void CerrarSesion()
        {
            this.Hide();

            using (frmLogin login = new frmLogin())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        // Manejador provisional para elementos de menu que aun no tienen modulo
        private void mnuPendiente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este modulo todavia esta en construccion.", "Proximamente",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void picLogo_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
