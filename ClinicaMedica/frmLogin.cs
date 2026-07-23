using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ClinicaMedica.Negocio;

namespace ClinicaMedica
{
    public partial class frmLogin : Form
    {
        private UsuariosNegocio _negocio = new UsuariosNegocio();

        public frmLogin()
        {
            InitializeComponent();
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            this.Text = "Clínica Médica — Iniciar Sesión";
            this.BackColor = Color.FromArgb(10, 60, 120);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(480, 580);

            // Título
            lblTitulo.Text = "🏥 Clínica Médica\nSistema de Gestión";
            lblTitulo.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblTitulo.Size = new Size(420, 80);
            lblTitulo.Location = new Point(30, 40);

            // Labels
            lblUsuario.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblUsuario.ForeColor = Color.FromArgb(173, 216, 230);
            lblUsuario.Location = new Point(60, 160);

            lblContrasena.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblContrasena.ForeColor = Color.FromArgb(173, 216, 230);
            lblContrasena.Location = new Point(60, 240);

            // TextBoxes
            txtUsuario.Font = new Font("Segoe UI", 12);
            txtUsuario.Size = new Size(320, 35);
            txtUsuario.Location = new Point(60, 185);
            txtUsuario.BackColor = Color.FromArgb(20, 80, 150);
            txtUsuario.ForeColor = Color.White;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;

            txtContrasena.Font = new Font("Segoe UI", 12);
            txtContrasena.Size = new Size(320, 35);
            txtContrasena.Location = new Point(60, 265);
            txtContrasena.BackColor = Color.FromArgb(20, 80, 150);
            txtContrasena.ForeColor = Color.White;
            txtContrasena.BorderStyle = BorderStyle.FixedSingle;
            txtContrasena.PasswordChar = '*';

            // Botón Iniciar
            btnEntrar.Text = "  INICIAR SESIÓN";
            btnEntrar.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnEntrar.Size = new Size(320, 50);
            btnEntrar.Location = new Point(60, 360);
            btnEntrar.BackColor = Color.FromArgb(0, 168, 232);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.Cursor = Cursors.Hand;

            // Botón Cancelar
            btnCancelar.Text = "  CANCELAR";
            btnCancelar.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnCancelar.Size = new Size(320, 45);
            btnCancelar.Location = new Point(60, 425);
            btnCancelar.BackColor = Color.FromArgb(180, 30, 30);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.Cursor = Cursors.Hand;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUsuario.Text))
                {
                    MessageBox.Show("Ingrese el usuario.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtContrasena.Text))
                {
                    MessageBox.Show("Ingrese la contraseña.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataTable dt = _negocio.ValidarUsuario(
                    txtUsuario.Text.Trim(), txtContrasena.Text.Trim());

                if (dt.Rows.Count > 0)
                {
                    string rol = dt.Rows[0]["Rol"].ToString();
                    MessageBox.Show($"Bienvenido, {txtUsuario.Text}!\nRol: {rol}",
                        "Acceso Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmPrincipal principal = new frmPrincipal();
                    principal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Acceso Denegado",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContrasena.Clear();
                    txtContrasena.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}