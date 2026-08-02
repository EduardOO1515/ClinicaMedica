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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuEntrada = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEntradaPacientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEntradaDoctores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEntradaCitas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEntradaMedicamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEntradaProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEntradaRecetas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsultaPacientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsultaDoctores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsultaCitas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsultaExpedientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsultaMedicamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsultaRecetas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSistemaAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.menuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            //
            // menuPrincipal
            //
            this.menuPrincipal.BackColor = System.Drawing.Color.FromArgb(5, 40, 90);
            this.menuPrincipal.ForeColor = System.Drawing.Color.White;
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        this.mnuEntrada, this.mnuConsulta, this.mnuReportes, this.mnuSistema, this.mnuSalir});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(500, 28);
            this.menuPrincipal.TabIndex = 0;
            //
            // mnuEntrada
            //
            this.mnuEntrada.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        this.mnuEntradaPacientes, this.mnuEntradaDoctores, this.mnuEntradaCitas,
        this.mnuEntradaMedicamentos, this.mnuEntradaProveedores, this.mnuEntradaRecetas});
            this.mnuEntrada.Name = "mnuEntrada";
            this.mnuEntrada.Text = "Entrada";
            //
            // mnuEntradaPacientes
            //
            this.mnuEntradaPacientes.Name = "mnuEntradaPacientes";
            this.mnuEntradaPacientes.Text = "Pacientes";
            this.mnuEntradaPacientes.Click += new System.EventHandler(this.mnuEntradaPacientes_Click);
            //
            // mnuEntradaDoctores
            //
            this.mnuEntradaDoctores.Name = "mnuEntradaDoctores";
            this.mnuEntradaDoctores.Text = "Doctores";
            this.mnuEntradaDoctores.Click += new System.EventHandler(this.mnuEntradaDoctores_Click);
            //
            // mnuEntradaCitas
            //
            this.mnuEntradaCitas.Name = "mnuEntradaCitas";
            this.mnuEntradaCitas.Text = "Citas";
            this.mnuEntradaCitas.Click += new System.EventHandler(this.mnuEntradaCitas_Click);
            //
            // mnuEntradaMedicamentos
            //
            this.mnuEntradaMedicamentos.Name = "mnuEntradaMedicamentos";
            this.mnuEntradaMedicamentos.Text = "Medicamentos";
            this.mnuEntradaMedicamentos.Click += new System.EventHandler(this.mnuPendiente_Click);
            //
            // mnuEntradaProveedores
            //
            this.mnuEntradaProveedores.Name = "mnuEntradaProveedores";
            this.mnuEntradaProveedores.Text = "Proveedores";
            this.mnuEntradaProveedores.Click += new System.EventHandler(this.mnuPendiente_Click);
            //
            // mnuEntradaRecetas
            //
            this.mnuEntradaRecetas.Name = "mnuEntradaRecetas";
            this.mnuEntradaRecetas.Text = "Recetas";
            this.mnuEntradaRecetas.Click += new System.EventHandler(this.mnuPendiente_Click);
            //
            // mnuConsulta
            //
            this.mnuConsulta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        this.mnuConsultaPacientes, this.mnuConsultaDoctores, this.mnuConsultaCitas,
        this.mnuConsultaExpedientes, this.mnuConsultaMedicamentos, this.mnuConsultaRecetas});
            this.mnuConsulta.Name = "mnuConsulta";
            this.mnuConsulta.Text = "Consulta";
            //
            // mnuConsultaPacientes
            //
            this.mnuConsultaPacientes.Name = "mnuConsultaPacientes";
            this.mnuConsultaPacientes.Text = "Pacientes";
            this.mnuConsultaPacientes.Click += new System.EventHandler(this.mnuConsultaPacientes_Click);
            //
            // mnuConsultaDoctores
            //
            this.mnuConsultaDoctores.Name = "mnuConsultaDoctores";
            this.mnuConsultaDoctores.Text = "Doctores";
            this.mnuConsultaDoctores.Click += new System.EventHandler(this.mnuConsultaDoctores_Click);
            //
            // mnuConsultaCitas
            //
            this.mnuConsultaCitas.Name = "mnuConsultaCitas";
            this.mnuConsultaCitas.Text = "Citas";
            this.mnuConsultaCitas.Click += new System.EventHandler(this.mnuConsultaCitas_Click);
            //
            // mnuConsultaExpedientes
            //
            this.mnuConsultaExpedientes.Name = "mnuConsultaExpedientes";
            this.mnuConsultaExpedientes.Text = "Expedientes";
            this.mnuConsultaExpedientes.Click += new System.EventHandler(this.mnuPendiente_Click);
            //
            // mnuConsultaMedicamentos
            //
            this.mnuConsultaMedicamentos.Name = "mnuConsultaMedicamentos";
            this.mnuConsultaMedicamentos.Text = "Medicamentos";
            this.mnuConsultaMedicamentos.Click += new System.EventHandler(this.mnuPendiente_Click);
            //
            // mnuConsultaRecetas
            //
            this.mnuConsultaRecetas.Name = "mnuConsultaRecetas";
            this.mnuConsultaRecetas.Text = "Recetas";
            this.mnuConsultaRecetas.Click += new System.EventHandler(this.mnuPendiente_Click);
            //
            // mnuReportes
            //
            this.mnuReportes.Name = "mnuReportes";
            this.mnuReportes.Text = "Reportes";
            this.mnuReportes.Click += new System.EventHandler(this.mnuReportes_Click);
            //
            // mnuSistema
            //
            this.mnuSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        this.mnuSistemaAcercaDe});
            this.mnuSistema.Name = "mnuSistema";
            this.mnuSistema.Text = "Sistema";
            //
            // mnuSistemaAcercaDe
            //
            this.mnuSistemaAcercaDe.Name = "mnuSistemaAcercaDe";
            this.mnuSistemaAcercaDe.Text = "Acerca de";
            this.mnuSistemaAcercaDe.Click += new System.EventHandler(this.mnuSistemaAcercaDe_Click);
            //
            // mnuSalir
            //
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Text = "Salir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = false;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Location = new System.Drawing.Point(150, 60);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(320, 60);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Clínica Médica";
            //
            // picLogo
            //
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Location = new System.Drawing.Point(190, 150);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(120, 120);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            //
            // frmPrincipal
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(10, 60, 120);
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.menuPrincipal);
            this.MainMenuStrip = this.menuPrincipal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clínica Médica — Panel Principal";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
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
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox picLogo;
        #endregion
    }

}