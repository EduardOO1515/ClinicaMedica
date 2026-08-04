namespace ClinicaMedica
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            menuPrincipal = new System.Windows.Forms.MenuStrip();
            mnuEntrada = new System.Windows.Forms.ToolStripMenuItem();
            mnuEntradaPacientes = new System.Windows.Forms.ToolStripMenuItem();
            mnuEntradaDoctores = new System.Windows.Forms.ToolStripMenuItem();
            mnuEntradaCitas = new System.Windows.Forms.ToolStripMenuItem();
            mnuEntradaMedicamentos = new System.Windows.Forms.ToolStripMenuItem();
            mnuEntradaProveedores = new System.Windows.Forms.ToolStripMenuItem();
            mnuEntradaExpedientes = new System.Windows.Forms.ToolStripMenuItem();
            mnuEntradaRecetas = new System.Windows.Forms.ToolStripMenuItem();
            mnuConsulta = new System.Windows.Forms.ToolStripMenuItem();
            mnuConsultaPacientes = new System.Windows.Forms.ToolStripMenuItem();
            mnuConsultaDoctores = new System.Windows.Forms.ToolStripMenuItem();
            mnuConsultaCitas = new System.Windows.Forms.ToolStripMenuItem();
            mnuConsultaProveedores = new System.Windows.Forms.ToolStripMenuItem();
            mnuConsultaExpedientes = new System.Windows.Forms.ToolStripMenuItem();
            mnuConsultaMedicamentos = new System.Windows.Forms.ToolStripMenuItem();
            mnuConsultaRecetas = new System.Windows.Forms.ToolStripMenuItem();
            mnuReportes = new System.Windows.Forms.ToolStripMenuItem();
            mnuSistema = new System.Windows.Forms.ToolStripMenuItem();
            mnuSistemaAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            pnlContenido = new System.Windows.Forms.Panel();
            picLogo = new System.Windows.Forms.PictureBox();
            lblTitulo = new System.Windows.Forms.Label();
            menuPrincipal.SuspendLayout();
            pnlContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // menuPrincipal
            // 
            menuPrincipal.BackColor = System.Drawing.Color.FromArgb(5, 40, 90);
            menuPrincipal.ForeColor = System.Drawing.Color.White;
            menuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuEntrada, mnuConsulta, mnuReportes, mnuSistema, mnuSalir });
            menuPrincipal.Location = new System.Drawing.Point(0, 0);
            menuPrincipal.Name = "menuPrincipal";
            menuPrincipal.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuPrincipal.Size = new System.Drawing.Size(1050, 24);
            menuPrincipal.TabIndex = 0;
            // 
            // mnuEntrada
            // 
            mnuEntrada.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuEntradaPacientes, mnuEntradaDoctores, mnuEntradaCitas, mnuEntradaMedicamentos, mnuEntradaProveedores, mnuEntradaExpedientes, mnuEntradaRecetas });
            mnuEntrada.Name = "mnuEntrada";
            mnuEntrada.Size = new System.Drawing.Size(59, 20);
            mnuEntrada.Text = "Entrada";
            // 
            // mnuEntradaPacientes
            // 
            mnuEntradaPacientes.Name = "mnuEntradaPacientes";
            mnuEntradaPacientes.Size = new System.Drawing.Size(153, 22);
            mnuEntradaPacientes.Text = "Pacientes";
            mnuEntradaPacientes.Click += mnuEntradaPacientes_Click;
            // 
            // mnuEntradaDoctores
            // 
            mnuEntradaDoctores.Name = "mnuEntradaDoctores";
            mnuEntradaDoctores.Size = new System.Drawing.Size(153, 22);
            mnuEntradaDoctores.Text = "Doctores";
            mnuEntradaDoctores.Click += mnuEntradaDoctores_Click;
            // 
            // mnuEntradaCitas
            // 
            mnuEntradaCitas.Name = "mnuEntradaCitas";
            mnuEntradaCitas.Size = new System.Drawing.Size(153, 22);
            mnuEntradaCitas.Text = "Citas";
            mnuEntradaCitas.Click += mnuEntradaCitas_Click;
            // 
            // mnuEntradaMedicamentos
            // 
            mnuEntradaMedicamentos.Name = "mnuEntradaMedicamentos";
            mnuEntradaMedicamentos.Size = new System.Drawing.Size(153, 22);
            mnuEntradaMedicamentos.Text = "Medicamentos";
            mnuEntradaMedicamentos.Click += mnuEntradaMedicamentos_Click;
            // 
            // mnuEntradaProveedores
            // 
            mnuEntradaProveedores.Name = "mnuEntradaProveedores";
            mnuEntradaProveedores.Size = new System.Drawing.Size(153, 22);
            mnuEntradaProveedores.Text = "Proveedores";
            mnuEntradaProveedores.Click += mnuEntradaProveedores_Click;
            // 
            // mnuEntradaExpedientes
            // 
            mnuEntradaExpedientes.Name = "mnuEntradaExpedientes";
            mnuEntradaExpedientes.Size = new System.Drawing.Size(153, 22);
            mnuEntradaExpedientes.Text = "Expedientes";
            mnuEntradaExpedientes.Click += mnuEntradaExpedientes_Click;
            // 
            // mnuEntradaRecetas
            // 
            mnuEntradaRecetas.Name = "mnuEntradaRecetas";
            mnuEntradaRecetas.Size = new System.Drawing.Size(153, 22);
            mnuEntradaRecetas.Text = "Recetas";
            mnuEntradaRecetas.Click += mnuEntradaRecetas_Click;
            // 
            // mnuConsulta
            // 
            mnuConsulta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuConsultaPacientes, mnuConsultaDoctores, mnuConsultaCitas, mnuConsultaProveedores, mnuConsultaExpedientes, mnuConsultaMedicamentos, mnuConsultaRecetas });
            mnuConsulta.Name = "mnuConsulta";
            mnuConsulta.Size = new System.Drawing.Size(66, 20);
            mnuConsulta.Text = "Consulta";
            // 
            // mnuConsultaPacientes
            // 
            mnuConsultaPacientes.Name = "mnuConsultaPacientes";
            mnuConsultaPacientes.Size = new System.Drawing.Size(153, 22);
            mnuConsultaPacientes.Text = "Pacientes";
            mnuConsultaPacientes.Click += mnuConsultaPacientes_Click;
            // 
            // mnuConsultaDoctores
            // 
            mnuConsultaDoctores.Name = "mnuConsultaDoctores";
            mnuConsultaDoctores.Size = new System.Drawing.Size(153, 22);
            mnuConsultaDoctores.Text = "Doctores";
            mnuConsultaDoctores.Click += mnuConsultaDoctores_Click;
            // 
            // mnuConsultaCitas
            // 
            mnuConsultaCitas.Name = "mnuConsultaCitas";
            mnuConsultaCitas.Size = new System.Drawing.Size(153, 22);
            mnuConsultaCitas.Text = "Citas";
            mnuConsultaCitas.Click += mnuConsultaCitas_Click;
            // 
            // mnuConsultaProveedores
            // 
            mnuConsultaProveedores.Name = "mnuConsultaProveedores";
            mnuConsultaProveedores.Size = new System.Drawing.Size(153, 22);
            mnuConsultaProveedores.Text = "Proveedores";
            mnuConsultaProveedores.Click += mnuConsultaProveedores_Click;
            // 
            // mnuConsultaExpedientes
            // 
            mnuConsultaExpedientes.Name = "mnuConsultaExpedientes";
            mnuConsultaExpedientes.Size = new System.Drawing.Size(153, 22);
            mnuConsultaExpedientes.Text = "Expedientes";
            mnuConsultaExpedientes.Click += mnuConsultaExpedientes_Click;
            // 
            // mnuConsultaMedicamentos
            // 
            mnuConsultaMedicamentos.Name = "mnuConsultaMedicamentos";
            mnuConsultaMedicamentos.Size = new System.Drawing.Size(153, 22);
            mnuConsultaMedicamentos.Text = "Medicamentos";
            mnuConsultaMedicamentos.Click += mnuConsultaMedicamentos_Click;
            // 
            // mnuConsultaRecetas
            // 
            mnuConsultaRecetas.Name = "mnuConsultaRecetas";
            mnuConsultaRecetas.Size = new System.Drawing.Size(153, 22);
            mnuConsultaRecetas.Text = "Recetas";
            mnuConsultaRecetas.Click += mnuConsultaRecetas_Click;
            // 
            // mnuReportes
            // 
            mnuReportes.Name = "mnuReportes";
            mnuReportes.Size = new System.Drawing.Size(65, 20);
            mnuReportes.Text = "Reportes";
            mnuReportes.Click += mnuReportes_Click;
            // 
            // mnuSistema
            // 
            mnuSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuSistemaAcercaDe });
            mnuSistema.Name = "mnuSistema";
            mnuSistema.Size = new System.Drawing.Size(60, 20);
            mnuSistema.Text = "Sistema";
            // 
            // mnuSistemaAcercaDe
            // 
            mnuSistemaAcercaDe.Name = "mnuSistemaAcercaDe";
            mnuSistemaAcercaDe.Size = new System.Drawing.Size(126, 22);
            mnuSistemaAcercaDe.Text = "Acerca de";
            mnuSistemaAcercaDe.Click += mnuSistemaAcercaDe_Click;
            // 
            // mnuSalir
            // 
            mnuSalir.Name = "mnuSalir";
            mnuSalir.Size = new System.Drawing.Size(41, 20);
            mnuSalir.Text = "Salir";
            mnuSalir.Click += mnuSalir_Click;
            // 
            // pnlContenido
            // 
            pnlContenido.BackColor = System.Drawing.Color.FromArgb(10, 60, 120);
            pnlContenido.Controls.Add(picLogo);
            pnlContenido.Controls.Add(lblTitulo);
            pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlContenido.Location = new System.Drawing.Point(0, 24);
            pnlContenido.Margin = new System.Windows.Forms.Padding(4);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new System.Drawing.Size(1050, 668);
            pnlContenido.TabIndex = 1;
            // 
            // picLogo
            // 
            picLogo.BackColor = System.Drawing.Color.Transparent;
            picLogo.Image = (System.Drawing.Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new System.Drawing.Point(388, 206);
            picLogo.Margin = new System.Windows.Forms.Padding(4);
            picLogo.Name = "picLogo";
            picLogo.Size = new System.Drawing.Size(280, 277);
            picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 2;
            picLogo.TabStop = false;
            picLogo.Click += picLogo_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            lblTitulo.ForeColor = System.Drawing.Color.White;
            lblTitulo.Location = new System.Drawing.Point(345, 101);
            lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(374, 69);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Clínica Médica";
            lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblTitulo.Click += lblTitulo_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(10, 60, 120);
            ClientSize = new System.Drawing.Size(1050, 692);
            Controls.Add(pnlContenido);
            Controls.Add(menuPrincipal);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MainMenuStrip = menuPrincipal;
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MinimumSize = new System.Drawing.Size(813, 568);
            Name = "frmPrincipal";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Clínica Médica — Panel Principal";
            menuPrincipal.ResumeLayout(false);
            menuPrincipal.PerformLayout();
            pnlContenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuEntrada;
        private System.Windows.Forms.ToolStripMenuItem mnuEntradaPacientes;
        private System.Windows.Forms.ToolStripMenuItem mnuEntradaDoctores;
        private System.Windows.Forms.ToolStripMenuItem mnuEntradaCitas;
        private System.Windows.Forms.ToolStripMenuItem mnuEntradaMedicamentos;
        private System.Windows.Forms.ToolStripMenuItem mnuEntradaProveedores;
        private System.Windows.Forms.ToolStripMenuItem mnuEntradaExpedientes;
        private System.Windows.Forms.ToolStripMenuItem mnuEntradaRecetas;
        private System.Windows.Forms.ToolStripMenuItem mnuConsulta;
        private System.Windows.Forms.ToolStripMenuItem mnuConsultaPacientes;
        private System.Windows.Forms.ToolStripMenuItem mnuConsultaDoctores;
        private System.Windows.Forms.ToolStripMenuItem mnuConsultaCitas;
        private System.Windows.Forms.ToolStripMenuItem mnuConsultaProveedores;
        private System.Windows.Forms.ToolStripMenuItem mnuConsultaExpedientes;
        private System.Windows.Forms.ToolStripMenuItem mnuConsultaMedicamentos;
        private System.Windows.Forms.ToolStripMenuItem mnuConsultaRecetas;
        private System.Windows.Forms.ToolStripMenuItem mnuReportes;
        private System.Windows.Forms.ToolStripMenuItem mnuSistema;
        private System.Windows.Forms.ToolStripMenuItem mnuSistemaAcercaDe;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox picLogo;
        #endregion
    }

}