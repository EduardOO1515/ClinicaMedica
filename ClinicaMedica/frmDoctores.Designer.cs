namespace ClinicaMedica
{
    partial class frmDoctores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoctores));
            lblTitulo = new System.Windows.Forms.Label();
            btnHabilitar = new System.Windows.Forms.Button();
            btnDeshabilitar = new System.Windows.Forms.Button();
            lblCedula = new System.Windows.Forms.Label();
            lblNombre = new System.Windows.Forms.Label();
            lblApellido = new System.Windows.Forms.Label();
            lblTelefono = new System.Windows.Forms.Label();
            lblEmail = new System.Windows.Forms.Label();
            lblEspecialidad = new System.Windows.Forms.Label();
            txtCedula = new System.Windows.Forms.TextBox();
            txtNombre = new System.Windows.Forms.TextBox();
            txtApellido = new System.Windows.Forms.TextBox();
            txtTelefono = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            cmbEspecialidad = new System.Windows.Forms.ComboBox();
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
            lblTitulo.Text = "Alta de Doctores";
            lblTitulo.Click += lblTitulo_Click;
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
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblCedula.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            lblCedula.Location = new System.Drawing.Point(35, 150);
            lblCedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new System.Drawing.Size(47, 15);
            lblCedula.TabIndex = 3;
            lblCedula.Text = "Cedula:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblNombre.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            lblNombre.Location = new System.Drawing.Point(268, 150);
            lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(56, 15);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblApellido.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            lblApellido.Location = new System.Drawing.Point(502, 150);
            lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new System.Drawing.Size(55, 15);
            lblApellido.TabIndex = 5;
            lblApellido.Text = "Apellido:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblTelefono.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            lblTelefono.Location = new System.Drawing.Point(268, 236);
            lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new System.Drawing.Size(59, 15);
            lblTelefono.TabIndex = 6;
            lblTelefono.Text = "Telefono:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblEmail.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            lblEmail.Location = new System.Drawing.Point(35, 237);
            lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(39, 15);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "Email:";
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblEspecialidad.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            lblEspecialidad.Location = new System.Drawing.Point(502, 237);
            lblEspecialidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new System.Drawing.Size(76, 15);
            lblEspecialidad.TabIndex = 12;
            lblEspecialidad.Text = "Especialidad:";
            // 
            // txtCedula
            // 
            txtCedula.BackColor = System.Drawing.Color.FromArgb(20, 80, 150);
            txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtCedula.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtCedula.ForeColor = System.Drawing.Color.White;
            txtCedula.Location = new System.Drawing.Point(35, 179);
            txtCedula.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtCedula.MaxLength = 11;
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new System.Drawing.Size(210, 25);
            txtCedula.TabIndex = 7;
            txtCedula.TextChanged += txtCedula_TextChanged;
            txtCedula.KeyPress += txtCedula_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = System.Drawing.Color.FromArgb(20, 80, 150);
            txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtNombre.ForeColor = System.Drawing.Color.White;
            txtNombre.Location = new System.Drawing.Point(268, 179);
            txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(210, 25);
            txtNombre.TabIndex = 8;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtApellido
            // 
            txtApellido.BackColor = System.Drawing.Color.FromArgb(20, 80, 150);
            txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtApellido.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtApellido.ForeColor = System.Drawing.Color.White;
            txtApellido.Location = new System.Drawing.Point(502, 179);
            txtApellido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtApellido.MaxLength = 100;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new System.Drawing.Size(210, 25);
            txtApellido.TabIndex = 9;
            txtApellido.KeyPress += txtApellido_KeyPress;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = System.Drawing.Color.FromArgb(20, 80, 150);
            txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtTelefono.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtTelefono.ForeColor = System.Drawing.Color.White;
            txtTelefono.Location = new System.Drawing.Point(268, 265);
            txtTelefono.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtTelefono.MaxLength = 10;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new System.Drawing.Size(210, 25);
            txtTelefono.TabIndex = 10;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = System.Drawing.Color.FromArgb(20, 80, 150);
            txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtEmail.ForeColor = System.Drawing.Color.White;
            txtEmail.Location = new System.Drawing.Point(35, 265);
            txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(210, 25);
            txtEmail.TabIndex = 13;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.BackColor = System.Drawing.Color.White;
            cmbEspecialidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmbEspecialidad.Font = new System.Drawing.Font("Segoe UI", 10F);
            cmbEspecialidad.ForeColor = System.Drawing.Color.FromArgb(10, 60, 120);
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Location = new System.Drawing.Point(502, 265);
            cmbEspecialidad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new System.Drawing.Size(233, 25);
            cmbEspecialidad.TabIndex = 14;
            cmbEspecialidad.KeyPress += cmbEspecialidad_KeyPress;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = System.Drawing.Color.FromArgb(0, 168, 232);
            btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnGuardar.ForeColor = System.Drawing.Color.White;
            btnGuardar.Location = new System.Drawing.Point(35, 350);
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
            btnLimpiar.Location = new System.Drawing.Point(183, 350);
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
            btnVolver.Location = new System.Drawing.Point(338, 350);
            btnVolver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(140, 44);
            btnVolver.TabIndex = 17;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // picLogo
            // 
            picLogo.BackColor = System.Drawing.Color.Transparent;
            picLogo.Image = (System.Drawing.Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new System.Drawing.Point(594, 334);
            picLogo.Margin = new System.Windows.Forms.Padding(4);
            picLogo.Name = "picLogo";
            picLogo.Size = new System.Drawing.Size(345, 320);
            picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 18;
            picLogo.TabStop = false;
            picLogo.Click += picLogo_Click;
            // 
            // frmDoctores
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            BackColor = System.Drawing.Color.FromArgb(10, 60, 120);
            ClientSize = new System.Drawing.Size(1035, 679);
            Controls.Add(picLogo);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbEspecialidad);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtCedula);
            Controls.Add(lblEspecialidad);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefono);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblCedula);
            Controls.Add(btnDeshabilitar);
            Controls.Add(btnHabilitar);
            Controls.Add(lblTitulo);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "frmDoctores";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Clinica Medica - Alta de Doctores";
            Load += frmDoctores_Load;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnHabilitar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.PictureBox picLogo;
    }
}
