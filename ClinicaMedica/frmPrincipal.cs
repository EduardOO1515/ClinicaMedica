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

        // --- ENTRADA ---
        // TODO: cuando cada modulo tenga su frmXEntrada, cambiar aqui la clase que se abre.

        private void mnuEntradaPacientes_Click(object sender, EventArgs e)
        {
            new frmPacientes().ShowDialog();
        }

        private void mnuEntradaDoctores_Click(object sender, EventArgs e)
        {
            new frmDoctores().ShowDialog();
        }

        private void mnuEntradaCitas_Click(object sender, EventArgs e)
        {
            new frmCitas().ShowDialog();
        }

        // --- CONSULTA ---
        // TODO: cuando cada modulo tenga su frmXConsulta, cambiar aqui la clase que se abre.

        private void mnuConsultaPacientes_Click(object sender, EventArgs e)
        {
            new frmPacientes().ShowDialog();
        }

        private void mnuConsultaDoctores_Click(object sender, EventArgs e)
        {
            new frmDoctores().ShowDialog();
        }

        private void mnuConsultaCitas_Click(object sender, EventArgs e)
        {
            new frmCitas().ShowDialog();
        }

        // --- REPORTES ---

        private void mnuReportes_Click(object sender, EventArgs e)
        {
            new frmReportes().ShowDialog();
        }

        // --- SISTEMA ---

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

        // Opciones de modulos que todavia no tienen formulario (Medicamentos,
        // Proveedores, Recetas, Expedientes) -- se reemplaza cuando existan.
        private void mnuPendiente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este modulo todavia esta en construccion.", "Proximamente",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}