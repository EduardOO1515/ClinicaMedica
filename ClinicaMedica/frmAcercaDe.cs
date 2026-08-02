using System;
using System.Windows.Forms;

namespace ClinicaMedica
{
    // Formulario informativo del sistema. Se abre como ventana emergente (ShowDialog).
    public partial class frmAcercaDe : Form
    {
        public frmAcercaDe()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
