using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicaMedica
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            this.Text = "Clínica Médica — Panel Principal";
            this.BackColor = Color.FromArgb(10, 60, 120);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(500, 550);

            lblTitulo.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblTitulo.Text = "🏥 Clínica Médica";
            lblTitulo.Size = new Size(440, 90);
            lblTitulo.Location = new Point(30, 20);

            ConfigurarBoton(btnPacientes, Color.FromArgb(0, 168, 232));
            ConfigurarBoton(btnDoctores, Color.FromArgb(0, 140, 70));
            ConfigurarBoton(btnCitas, Color.FromArgb(200, 120, 0));
            ConfigurarBoton(btnReportes, Color.FromArgb(100, 50, 160));
            ConfigurarBoton(btnSalir, Color.FromArgb(180, 30, 30));
        }

        private void ConfigurarBoton(Button btn, Color color)
        {
            btn.BackColor = color;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;
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
                Application.Restart();
        }
    }
}