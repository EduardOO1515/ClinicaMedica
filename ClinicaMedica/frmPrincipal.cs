using System;
using System.Windows.Forms;

namespace ClinicaMedica
{
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

        // Convierte un formulario cualquiera en contenido embebido dentro
        // de pnlContenido, en vez de abrirlo como ventana nueva (ShowDialog).
        private void AbrirFormulario(Form frm)
        {
            // Cierra y quita lo que estuviera abierto antes en el panel
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
        // TODO: cuando cada modulo tenga su frmXEntrada, cambiar aqui la clase que se abre.

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
            AbrirFormulario(new frmPacientesConsulta());
        }

        private void mnuConsultaDoctores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmDoctoresConsulta());
        }

        private void mnuConsultaCitas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmCitasConsulta());
        }

        private void mnuConsultaProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmProveedoresConsulta());
        }

        private void mnuConsultaExpedientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmExpedientesConsulta());
        }

        private void mnuConsultaMedicamentos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmMedicamentosConsulta());
        }

        private void mnuConsultaRecetas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmRecetasConsulta());
        }

        // --- REPORTES ---

        private void mnuReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmReportes());
        }

        // --- SISTEMA ---
        // Acerca de SI se queda como ventana emergente (ShowDialog) -- no tiene
        // sentido embeberla, es solo informativa y se cierra sola.

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

        private void mnuPendiente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este modulo todavia esta en construccion.", "Proximamente",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}