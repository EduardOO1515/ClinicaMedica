namespace ClinicaMedica
{
    partial class frmExpedientes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExpedientes));
            lblTitulo = new System.Windows.Forms.Label();
            btnHabilitar = new System.Windows.Forms.Button();
            btnDeshabilitar = new System.Windows.Forms.Button();
            lblCita = new System.Windows.Forms.Label();
            lblDiagnostico = new System.Windows.Forms.Label();
            lblTratamiento = new System.Windows.Forms.Label();
            cboCita = new System.Windows.Forms.ComboBox();
            txtDiagnostico = new System.Windows.Forms.TextBox();
            txtTratamiento = new System.Windows.Forms.TextBox();
            btnGuardar = new System.Windows.Forms.Button();
            btnLimpiar = new System.Windows.Forms.Button();
            btnVolver = new System.Windows.Forms.Button();
            picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            lblTitulo.ForeColor = System.Drawing.Color.White;
            lblTitulo.Location = new System.Drawing.Point(35, 17);
            lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(583, 46);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Alta de Expedientes";
            // 
            // btnHabilitar
            // 
            btnHabilitar.BackColor = System.Drawing.Color.FromArgb(0, 160, 80);
            btnHabilitar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnHabilitar.FlatAppearance.BorderSize = 0;
            btnHabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHabilitar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnHabilitar.ForeColor = System.Drawing.Color.White;
            btnHabilitar.Location = new System.Drawing.Point(35, 81);
            btnHabilitar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnHabilitar.Name = "btnHabilitar";
            btnHabilitar.Size = new System.Drawing.Size(187, 44);
            btnHabilitar.TabIndex = 1;
            btnHabilitar.Text = "Habilitar Ingreso";
            btnHabilitar.UseVisualStyleBackColor = false;
            btnHabilitar.Click += btnHabilitar_Click;
            // 
            // btnDeshabilitar
            // 
            btnDeshabilitar.BackColor = System.Drawing.Color.FromArgb(180, 90, 0);
            btnDeshabilitar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDeshabilitar.Enabled = false;
            btnDeshabilitar.FlatAppearance.BorderSize = 0;
            btnDeshabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeshabilitar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnDeshabilitar.ForeColor = System.Drawing.Color.White;
            btnDeshabilitar.Location = new System.Drawing.Point(233, 81);
            btnDeshabilitar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDeshabilitar.Name = "btnDeshabilitar";
            btnDeshabilitar.Size = new System.Drawing.Size(210, 44);
            btnDeshabilitar.TabIndex = 2;
            btnDeshabilitar.Text = "Deshabilitar Ingreso";
            btnDeshabilitar.UseVisualStyleBackColor = false;
            btnDeshabilitar.Click += btnDeshabilitar_Click;
            // 
            // lblCita
            // 
            lblCita.AutoSize = true;
            lblCita.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblCita.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            lblCita.Location = new System.Drawing.Point(35, 150);
            lblCita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCita.Name = "lblCita";
            lblCita.Size = new System.Drawing.Size(31, 15);
            lblCita.TabIndex = 3;
            lblCita.Text = "Cita:";
            // 
            // lblDiagnostico
            // 
            lblDiagnostico.AutoSize = true;
            lblDiagnostico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblDiagnostico.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            lblDiagnostico.Location = new System.Drawing.Point(35, 242);
            lblDiagnostico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDiagnostico.Name = "lblDiagnostico";
            lblDiagnostico.Size = new System.Drawing.Size(75, 15);
            lblDiagnostico.TabIndex = 5;
            lblDiagnostico.Text = "Diagnostico:";
            // 
            // lblTratamiento
            // 
            lblTratamiento.AutoSize = true;
            lblTratamiento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblTratamiento.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            lblTratamiento.Location = new System.Drawing.Point(35, 392);
            lblTratamiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTratamiento.Name = "lblTratamiento";
            lblTratamiento.Size = new System.Drawing.Size(78, 15);
            lblTratamiento.TabIndex = 6;
            lblTratamiento.Text = "Tratamiento:";
            // 
            // cboCita
            // 
            cboCita.BackColor = System.Drawing.Color.White;
            cboCita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboCita.Font = new System.Drawing.Font("Segoe UI", 10F);
            cboCita.ForeColor = System.Drawing.Color.FromArgb(10, 60, 120);
            cboCita.FormattingEnabled = true;
            cboCita.Location = new System.Drawing.Point(35, 179);
            cboCita.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboCita.Name = "cboCita";
            cboCita.Size = new System.Drawing.Size(583, 25);
            cboCita.TabIndex = 4;
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.BackColor = System.Drawing.Color.FromArgb(20, 80, 150);
            txtDiagnostico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtDiagnostico.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtDiagnostico.ForeColor = System.Drawing.Color.White;
            txtDiagnostico.Location = new System.Drawing.Point(35, 271);
            txtDiagnostico.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtDiagnostico.MaxLength = 500;
            txtDiagnostico.Multiline = true;
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtDiagnostico.Size = new System.Drawing.Size(583, 104);
            txtDiagnostico.TabIndex = 7;
            // 
            // txtTratamiento
            // 
            txtTratamiento.BackColor = System.Drawing.Color.FromArgb(20, 80, 150);
            txtTratamiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtTratamiento.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtTratamiento.ForeColor = System.Drawing.Color.White;
            txtTratamiento.Location = new System.Drawing.Point(35, 421);
            txtTratamiento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtTratamiento.MaxLength = 500;
            txtTratamiento.Multiline = true;
            txtTratamiento.Name = "txtTratamiento";
            txtTratamiento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtTratamiento.Size = new System.Drawing.Size(583, 104);
            txtTratamiento.TabIndex = 8;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = System.Drawing.Color.FromArgb(60, 80, 180);
            btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnGuardar.ForeColor = System.Drawing.Color.White;
            btnGuardar.Location = new System.Drawing.Point(35, 599);
            btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(140, 44);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = System.Drawing.Color.FromArgb(70, 130, 180);
            btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnLimpiar.ForeColor = System.Drawing.Color.White;
            btnLimpiar.Location = new System.Drawing.Point(190, 599);
            btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(140, 44);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = System.Drawing.Color.FromArgb(0, 100, 60);
            btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnVolver.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnVolver.ForeColor = System.Drawing.Color.White;
            btnVolver.Location = new System.Drawing.Point(338, 599);
            btnVolver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(140, 44);
            btnVolver.TabIndex = 11;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // picLogo
            // 
            picLogo.BackColor = System.Drawing.Color.Transparent;
            picLogo.Image = (System.Drawing.Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new System.Drawing.Point(711, 366);
            picLogo.Margin = new System.Windows.Forms.Padding(4);
            picLogo.Name = "picLogo";
            picLogo.Size = new System.Drawing.Size(280, 277);
            picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 12;
            picLogo.TabStop = false;
            // 
            // frmExpedientes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(10, 60, 120);
            ClientSize = new System.Drawing.Size(1035, 679);
            Controls.Add(picLogo);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(txtTratamiento);
            Controls.Add(txtDiagnostico);
            Controls.Add(lblTratamiento);
            Controls.Add(lblDiagnostico);
            Controls.Add(cboCita);
            Controls.Add(lblCita);
            Controls.Add(btnDeshabilitar);
            Controls.Add(btnHabilitar);
            Controls.Add(lblTitulo);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "frmExpedientes";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Clinica Medica - Alta de Expedientes";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += frmExpedientes_Load;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnHabilitar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Label lblCita;
        private System.Windows.Forms.Label lblDiagnostico;
        private System.Windows.Forms.Label lblTratamiento;
        private System.Windows.Forms.ComboBox cboCita;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.TextBox txtTratamiento;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.PictureBox picLogo;
    }
}
