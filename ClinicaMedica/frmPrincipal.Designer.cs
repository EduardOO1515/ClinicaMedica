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
            mnuEntradaRecetas = new System.Windows.Forms.ToolStripMenuItem();
            mnuConsulta = new System.Windows.Forms.ToolStripMenuItem();
            mnuConsultaPacientes = new System.Windows.Forms.ToolStripMenuItem();
            mnuConsultaDoctores = new System.Windows.Forms.ToolStripMenuItem();
            mnuConsultaCitas = new System.Windows.Forms.ToolStripMenuItem();
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
            menuPrincipal.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            menuPrincipal.Size = new System.Drawing.Size(1200, 30);
            menuPrincipal.TabIndex = 0;
            // 
            // mnuEntrada
            // 
            mnuEntrada.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuEntradaPacientes, mnuEntradaDoctores, mnuEntradaCitas, mnuEntradaMedicamentos, mnuEntradaProveedores, mnuEntradaRecetas });
            mnuEntrada.Name = "mnuEntrada";
            mnuEntrada.Size = new System.Drawing.Size(74, 24);
            mnuEntrada.Text = "Entrada";
            // 
            // mnuEntradaPacientes
            // 
            mnuEntradaPacientes.Name = "mnuEntradaPacientes";
            mnuEntradaPacientes.Size = new System.Drawing.Size(190, 26);
            mnuEntradaPacientes.Text = "Pacientes";
            mnuEntradaPacientes.Click += mnuEntradaPacientes_Click;
            // 
            // mnuEntradaDoctores
            // 
            mnuEntradaDoctores.Name = "mnuEntradaDoctores";
            mnuEntradaDoctores.Size = new System.Drawing.Size(190, 26);
            mnuEntradaDoctores.Text = "Doctores";
            mnuEntradaDoctores.Click += mnuEntradaDoctores_Click;
            // 
            // mnuEntradaCitas
            // 
            mnuEntradaCitas.Name = "mnuEntradaCitas";
            mnuEntradaCitas.Size = new System.Drawing.Size(190, 26);
            mnuEntradaCitas.Text = "Citas";
            mnuEntradaCitas.Click += mnuEntradaCitas_Click;
            // 
            // mnuEntradaMedicamentos
            // 
            mnuEntradaMedicamentos.Name = "mnuEntradaMedicamentos";
            mnuEntradaMedicamentos.Size = new System.Drawing.Size(190, 26);
            mnuEntradaMedicamentos.Text = "Medicamentos";
            mnuEntradaMedicamentos.Click += mnuPendiente_Click;
            // 
            // mnuEntradaProveedores
            // 
            mnuEntradaProveedores.Name = "mnuEntradaProveedores";
            mnuEntradaProveedores.Size = new System.Drawing.Size(190, 26);
            mnuEntradaProveedores.Text = "Proveedores";
            mnuEntradaProveedores.Click += mnuPendiente_Click;
            // 
            // mnuEntradaRecetas
            // 
            mnuEntradaRecetas.Name = "mnuEntradaRecetas";
            mnuEntradaRecetas.Size = new System.Drawing.Size(190, 26);
            mnuEntradaRecetas.Text = "Recetas";
            mnuEntradaRecetas.Click += mnuPendiente_Click;
            // 
            // mnuConsulta
            // 
            mnuConsulta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuConsultaPacientes, mnuConsultaDoctores, mnuConsultaCitas, mnuConsultaExpedientes, mnuConsultaMedicamentos, mnuConsultaRecetas });
            mnuConsulta.Name = "mnuConsulta";
            mnuConsulta.Size = new System.Drawing.Size(80, 24);
            mnuConsulta.Text = "Consulta";
            // 
            // mnuConsultaPacientes
            // 
            mnuConsultaPacientes.Name = "mnuConsultaPacientes";
            mnuConsultaPacientes.Size = new System.Drawing.Size(190, 26);
            mnuConsultaPacientes.Text = "Pacientes";
            mnuConsultaPacientes.Click += mnuConsultaPacientes_Click;
            // 
            // mnuConsultaDoctores
            // 
            mnuConsultaDoctores.Name = "mnuConsultaDoctores";
            mnuConsultaDoctores.Size = new System.Drawing.Size(190, 26);
            mnuConsultaDoctores.Text = "Doctores";
            mnuConsultaDoctores.Click += mnuConsultaDoctores_Click;
            // 
            // mnuConsultaCitas
            // 
            mnuConsultaCitas.Name = "mnuConsultaCitas";
            mnuConsultaCitas.Size = new System.Drawing.Size(190, 26);
            mnuConsultaCitas.Text = "Citas";
            mnuConsultaCitas.Click += mnuConsultaCitas_Click;
            // 
            // mnuConsultaExpedientes
            // 
            mnuConsultaExpedientes.Name = "mnuConsultaExpedientes";
            mnuConsultaExpedientes.Size = new System.Drawing.Size(190, 26);
            mnuConsultaExpedientes.Text = "Expedientes";
            mnuConsultaExpedientes.Click += mnuPendiente_Click;
            // 
            // mnuConsultaMedicamentos
            // 
            mnuConsultaMedicamentos.Name = "mnuConsultaMedicamentos";
            mnuConsultaMedicamentos.Size = new System.Drawing.Size(190, 26);
            mnuConsultaMedicamentos.Text = "Medicamentos";
            mnuConsultaMedicamentos.Click += mnuPendiente_Click;
            // 
            // mnuConsultaRecetas
            // 
            mnuConsultaRecetas.Name = "mnuConsultaRecetas";
            mnuConsultaRecetas.Size = new System.Drawing.Size(190, 26);
            mnuConsultaRecetas.Text = "Recetas";
            mnuConsultaRecetas.Click += mnuPendiente_Click;
            // 
            // mnuReportes
            // 
            mnuReportes.Name = "mnuReportes";
            mnuReportes.Size = new System.Drawing.Size(82, 24);
            mnuReportes.Text = "Reportes";
            mnuReportes.Click += mnuReportes_Click;
            // 
            // mnuSistema
            // 
            mnuSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuSistemaAcercaDe });
            mnuSistema.Name = "mnuSistema";
            mnuSistema.Size = new System.Drawing.Size(75, 24);
            mnuSistema.Text = "Sistema";
            // 
            // mnuSistemaAcercaDe
            // 
            mnuSistemaAcercaDe.Name = "mnuSistemaAcercaDe";
            mnuSistemaAcercaDe.Size = new System.Drawing.Size(158, 26);
            mnuSistemaAcercaDe.Text = "Acerca de";
            mnuSistemaAcercaDe.Click += mnuSistemaAcercaDe_Click;
            // 
            // mnuSalir
            // 
            mnuSalir.Name = "mnuSalir";
            mnuSalir.Size = new System.Drawing.Size(52, 24);
            mnuSalir.Text = "Salir";
            mnuSalir.Click += mnuSalir_Click;
            // 
            // pnlContenido
            // 
            pnlContenido.BackColor = System.Drawing.Color.FromArgb(10, 60, 120);
            pnlContenido.Controls.Add(picLogo);
            pnlContenido.Controls.Add(lblTitulo);
            pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlContenido.Location = new System.Drawing.Point(0, 30);
            pnlContenido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new System.Drawing.Size(1200, 893);
            pnlContenido.TabIndex = 1;
            // 
            // picLogo
            // 
            picLogo.BackColor = System.Drawing.Color.Transparent;
            picLogo.Image = (System.Drawing.Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new System.Drawing.Point(444, 275);
            picLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            picLogo.Name = "picLogo";
            picLogo.Size = new System.Drawing.Size(320, 369);
            picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 2;
            picLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            lblTitulo.ForeColor = System.Drawing.Color.White;
            lblTitulo.Location = new System.Drawing.Point(386, 202);
            lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(427, 92);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Clínica Médica";
            lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(10, 60, 120);
            ClientSize = new System.Drawing.Size(1200, 923);
            Controls.Add(pnlContenido);
            Controls.Add(menuPrincipal);
            MainMenuStrip = menuPrincipal;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MinimumSize = new System.Drawing.Size(927, 744);
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
        private System.Windows.Forms.ToolStripMenuItem mnuEntradaRecetas;
        private System.Windows.Forms.ToolStripMenuItem mnuConsulta;
        private System.Windows.Forms.ToolStripMenuItem mnuConsultaPacientes;
        private System.Windows.Forms.ToolStripMenuItem mnuConsultaDoctores;
        private System.Windows.Forms.ToolStripMenuItem mnuConsultaCitas;
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