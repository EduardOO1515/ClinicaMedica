namespace ClinicaMedica
{
    partial class frmCitas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCitas));
            lblTitulo = new System.Windows.Forms.Label();
            btnHabilitar = new System.Windows.Forms.Button();
            btnDeshabilitar = new System.Windows.Forms.Button();
            lblPaciente = new System.Windows.Forms.Label();
            lblDoctor = new System.Windows.Forms.Label();
            lblFecha = new System.Windows.Forms.Label();
            lblEstado = new System.Windows.Forms.Label();
            lblTipo = new System.Windows.Forms.Label();
            lblCosto = new System.Windows.Forms.Label();
            cmbPaciente = new System.Windows.Forms.ComboBox();
            cmbDoctor = new System.Windows.Forms.ComboBox();
            cmbEstado = new System.Windows.Forms.ComboBox();
            cmbTipo = new System.Windows.Forms.ComboBox();
            txtCosto = new System.Windows.Forms.TextBox();
            dtpFechaCita = new System.Windows.Forms.DateTimePicker();
            btnGuardar = new System.Windows.Forms.Button();
            btnLimpiar = new System.Windows.Forms.Button();
            btnVolver = new System.Windows.Forms.Button();
            lblCostoOriginal = new System.Windows.Forms.Label();
            lblValorOriginal = new System.Windows.Forms.Label();
            lblDescuento = new System.Windows.Forms.Label();
            lblValorDescuento = new System.Windows.Forms.Label();
            lblTotal = new System.Windows.Forms.Label();
            lblValorTotal = new System.Windows.Forms.Label();
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
            lblTitulo.Text = "Alta de Citas";
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
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblPaciente.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            lblPaciente.Location = new System.Drawing.Point(35, 150);
            lblPaciente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new System.Drawing.Size(58, 15);
            lblPaciente.TabIndex = 3;
            lblPaciente.Text = "Paciente:";
            // 
            // lblDoctor
            // 
            lblDoctor.AutoSize = true;
            lblDoctor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblDoctor.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            lblDoctor.Location = new System.Drawing.Point(327, 150);
            lblDoctor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new System.Drawing.Size(49, 15);
            lblDoctor.TabIndex = 4;
            lblDoctor.Text = "Doctor:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblFecha.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            lblFecha.Location = new System.Drawing.Point(618, 150);
            lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new System.Drawing.Size(66, 15);
            lblFecha.TabIndex = 5;
            lblFecha.Text = "Fecha Cita:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblEstado.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            lblEstado.Location = new System.Drawing.Point(35, 237);
            lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new System.Drawing.Size(46, 15);
            lblEstado.TabIndex = 9;
            lblEstado.Text = "Estado:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblTipo.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            lblTipo.Location = new System.Drawing.Point(327, 237);
            lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new System.Drawing.Size(84, 15);
            lblTipo.TabIndex = 10;
            lblTipo.Text = "Tipo Consulta:";
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblCosto.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            lblCosto.Location = new System.Drawing.Point(618, 237);
            lblCosto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new System.Drawing.Size(41, 15);
            lblCosto.TabIndex = 11;
            lblCosto.Text = "Costo:";
            // 
            // cmbPaciente
            // 
            cmbPaciente.BackColor = System.Drawing.Color.White;
            cmbPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmbPaciente.Font = new System.Drawing.Font("Segoe UI", 10F);
            cmbPaciente.ForeColor = System.Drawing.Color.FromArgb(10, 60, 120);
            cmbPaciente.FormattingEnabled = true;
            cmbPaciente.Location = new System.Drawing.Point(35, 179);
            cmbPaciente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmbPaciente.Name = "cmbPaciente";
            cmbPaciente.Size = new System.Drawing.Size(268, 25);
            cmbPaciente.TabIndex = 6;
            // 
            // cmbDoctor
            // 
            cmbDoctor.BackColor = System.Drawing.Color.White;
            cmbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmbDoctor.Font = new System.Drawing.Font("Segoe UI", 10F);
            cmbDoctor.ForeColor = System.Drawing.Color.FromArgb(10, 60, 120);
            cmbDoctor.FormattingEnabled = true;
            cmbDoctor.Location = new System.Drawing.Point(327, 179);
            cmbDoctor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmbDoctor.Name = "cmbDoctor";
            cmbDoctor.Size = new System.Drawing.Size(268, 25);
            cmbDoctor.TabIndex = 7;
            // 
            // cmbEstado
            // 
            cmbEstado.BackColor = System.Drawing.Color.White;
            cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmbEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            cmbEstado.ForeColor = System.Drawing.Color.FromArgb(10, 60, 120);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Pendiente", "Confirmada", "Cancelada", "Completada" });
            cmbEstado.Location = new System.Drawing.Point(35, 265);
            cmbEstado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new System.Drawing.Size(268, 25);
            cmbEstado.TabIndex = 12;
            // 
            // cmbTipo
            // 
            cmbTipo.BackColor = System.Drawing.Color.White;
            cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmbTipo.Font = new System.Drawing.Font("Segoe UI", 10F);
            cmbTipo.ForeColor = System.Drawing.Color.FromArgb(10, 60, 120);
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "General", "Especialista", "Control", "Emergencia", "Laboratorio" });
            cmbTipo.Location = new System.Drawing.Point(327, 265);
            cmbTipo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new System.Drawing.Size(268, 25);
            cmbTipo.TabIndex = 13;
            // 
            // txtCosto
            // 
            txtCosto.BackColor = System.Drawing.Color.FromArgb(20, 80, 150);
            txtCosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtCosto.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtCosto.ForeColor = System.Drawing.Color.White;
            txtCosto.Location = new System.Drawing.Point(618, 265);
            txtCosto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtCosto.MaxLength = 10;
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new System.Drawing.Size(233, 27);
            txtCosto.TabIndex = 14;
            // 
            // dtpFechaCita
            // 
            dtpFechaCita.Font = new System.Drawing.Font("Segoe UI", 10F);
            dtpFechaCita.Location = new System.Drawing.Point(618, 179);
            dtpFechaCita.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dtpFechaCita.Name = "dtpFechaCita";
            dtpFechaCita.Size = new System.Drawing.Size(291, 25);
            dtpFechaCita.TabIndex = 8;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = System.Drawing.Color.FromArgb(0, 168, 232);
            btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnGuardar.ForeColor = System.Drawing.Color.White;
            btnGuardar.Location = new System.Drawing.Point(35, 329);
            btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(140, 44);
            btnGuardar.TabIndex = 15;
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
            btnLimpiar.Location = new System.Drawing.Point(187, 329);
            btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(140, 44);
            btnLimpiar.TabIndex = 16;
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
            btnVolver.Location = new System.Drawing.Point(338, 329);
            btnVolver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(140, 44);
            btnVolver.TabIndex = 17;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblCostoOriginal
            // 
            lblCostoOriginal.AutoSize = true;
            lblCostoOriginal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblCostoOriginal.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            lblCostoOriginal.Location = new System.Drawing.Point(35, 398);
            lblCostoOriginal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCostoOriginal.Name = "lblCostoOriginal";
            lblCostoOriginal.Size = new System.Drawing.Size(109, 19);
            lblCostoOriginal.TabIndex = 18;
            lblCostoOriginal.Text = "Costo Original:";
            // 
            // lblValorOriginal
            // 
            lblValorOriginal.AutoSize = true;
            lblValorOriginal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblValorOriginal.ForeColor = System.Drawing.Color.White;
            lblValorOriginal.Location = new System.Drawing.Point(233, 398);
            lblValorOriginal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblValorOriginal.Name = "lblValorOriginal";
            lblValorOriginal.Size = new System.Drawing.Size(64, 19);
            lblValorOriginal.TabIndex = 19;
            lblValorOriginal.Text = "RD$0.00";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblDescuento.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            lblDescuento.Location = new System.Drawing.Point(35, 433);
            lblDescuento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new System.Drawing.Size(82, 19);
            lblDescuento.TabIndex = 20;
            lblDescuento.Text = "Descuento:";
            // 
            // lblValorDescuento
            // 
            lblValorDescuento.AutoSize = true;
            lblValorDescuento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblValorDescuento.ForeColor = System.Drawing.Color.FromArgb(0, 200, 100);
            lblValorDescuento.Location = new System.Drawing.Point(233, 433);
            lblValorDescuento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblValorDescuento.Name = "lblValorDescuento";
            lblValorDescuento.Size = new System.Drawing.Size(64, 19);
            lblValorDescuento.TabIndex = 21;
            lblValorDescuento.Text = "RD$0.00";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblTotal.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            lblTotal.Location = new System.Drawing.Point(35, 471);
            lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new System.Drawing.Size(114, 21);
            lblTotal.TabIndex = 22;
            lblTotal.Text = "Total a Pagar:";
            // 
            // lblValorTotal
            // 
            lblValorTotal.AutoSize = true;
            lblValorTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblValorTotal.ForeColor = System.Drawing.Color.FromArgb(0, 230, 118);
            lblValorTotal.Location = new System.Drawing.Point(233, 471);
            lblValorTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.Size = new System.Drawing.Size(72, 21);
            lblValorTotal.TabIndex = 23;
            lblValorTotal.Text = "RD$0.00";
            // 
            // picLogo
            // 
            picLogo.BackColor = System.Drawing.Color.Transparent;
            picLogo.Image = (System.Drawing.Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new System.Drawing.Point(607, 329);
            picLogo.Margin = new System.Windows.Forms.Padding(4);
            picLogo.Name = "picLogo";
            picLogo.Size = new System.Drawing.Size(318, 327);
            picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 24;
            picLogo.TabStop = false;
            // 
            // frmCitas
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.Color.FromArgb(10, 60, 120);
            ClientSize = new System.Drawing.Size(1035, 679);
            Controls.Add(picLogo);
            Controls.Add(lblValorTotal);
            Controls.Add(lblTotal);
            Controls.Add(lblValorDescuento);
            Controls.Add(lblDescuento);
            Controls.Add(lblValorOriginal);
            Controls.Add(lblCostoOriginal);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(dtpFechaCita);
            Controls.Add(txtCosto);
            Controls.Add(cmbEstado);
            Controls.Add(cmbTipo);
            Controls.Add(cmbDoctor);
            Controls.Add(cmbPaciente);
            Controls.Add(lblCosto);
            Controls.Add(lblTipo);
            Controls.Add(lblEstado);
            Controls.Add(lblFecha);
            Controls.Add(lblDoctor);
            Controls.Add(lblPaciente);
            Controls.Add(btnDeshabilitar);
            Controls.Add(btnHabilitar);
            Controls.Add(lblTitulo);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "frmCitas";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Clinica Medica - Alta de Citas";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += frmCitas_Load;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnHabilitar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.ComboBox cmbPaciente;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.DateTimePicker dtpFechaCita;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblCostoOriginal;
        private System.Windows.Forms.Label lblValorOriginal;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblValorDescuento;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.PictureBox picLogo;
    }
}
