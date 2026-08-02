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

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            frmPacientes frm = new frmPacientes();
            frm.ShowDialog();
        }

        private void btnDoctores_Click(object sender, EventArgs e)
        {
            frmDoctores frm = new frmDoctores();
            frm.ShowDialog();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            frmCitas frm = new frmCitas();
            frm.ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            frmReportes frm = new frmReportes();
            frm.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
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
        private void frmPrincipal_Load_1(object sender, EventArgs e)
        {

        }
    }

}