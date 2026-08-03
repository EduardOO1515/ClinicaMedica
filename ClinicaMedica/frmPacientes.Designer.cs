namespace ClinicaMedica
{
    partial class frmPacientes
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnHabilitar = new System.Windows.Forms.Button();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.chkSeguro = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = false;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(30, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(500, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Alta de Pacientes";
            //
            // btnHabilitar
            //
            this.btnHabilitar.BackColor = System.Drawing.Color.FromArgb(0, 160, 80);
            this.btnHabilitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHabilitar.FlatAppearance.BorderSize = 0;
            this.btnHabilitar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHabilitar.ForeColor = System.Drawing.Color.White;
            this.btnHabilitar.Location = new System.Drawing.Point(30, 70);
            this.btnHabilitar.Name = "btnHabilitar";
            this.btnHabilitar.Size = new System.Drawing.Size(160, 38);
            this.btnHabilitar.TabIndex = 1;
            this.btnHabilitar.Text = "Habilitar Ingreso";
            this.btnHabilitar.UseVisualStyleBackColor = false;
            this.btnHabilitar.Click += new System.EventHandler(this.btnHabilitar_Click);
            //
            // btnDeshabilitar
            //
            this.btnDeshabilitar.BackColor = System.Drawing.Color.FromArgb(180, 90, 0);
            this.btnDeshabilitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeshabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeshabilitar.FlatAppearance.BorderSize = 0;
            this.btnDeshabilitar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeshabilitar.ForeColor = System.Drawing.Color.White;
            this.btnDeshabilitar.Location = new System.Drawing.Point(200, 70);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(180, 38);
            this.btnDeshabilitar.TabIndex = 16;
            this.btnDeshabilitar.Text = "Deshabilitar Ingreso";
            this.btnDeshabilitar.Enabled = false;
            this.btnDeshabilitar.UseVisualStyleBackColor = false;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            //
            // lblCedula
            //
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCedula.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            this.lblCedula.Location = new System.Drawing.Point(30, 130);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.TabIndex = 2;
            this.lblCedula.Text = "Cedula:";
            //
            // lblNombre
            //
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            this.lblNombre.Location = new System.Drawing.Point(230, 130);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            //
            // lblApellido
            //
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblApellido.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            this.lblApellido.Location = new System.Drawing.Point(430, 130);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido:";
            //
            // lblTelefono
            //
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            this.lblTelefono.Location = new System.Drawing.Point(630, 130);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Telefono:";
            //
            // txtCedula
            //
            this.txtCedula.BackColor = System.Drawing.Color.FromArgb(20, 80, 150);
            this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCedula.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCedula.ForeColor = System.Drawing.Color.White;
            this.txtCedula.Location = new System.Drawing.Point(30, 155);
            this.txtCedula.MaxLength = 11;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(180, 30);
            this.txtCedula.TabIndex = 6;
            this.txtCedula.TextChanged += new System.EventHandler(this.txtCedula_TextChanged);
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            //
            // txtNombre
            //
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(20, 80, 150);
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(230, 155);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 30);
            this.txtNombre.TabIndex = 7;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            //
            // txtApellido
            //
            this.txtApellido.BackColor = System.Drawing.Color.FromArgb(20, 80, 150);
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtApellido.ForeColor = System.Drawing.Color.White;
            this.txtApellido.Location = new System.Drawing.Point(430, 155);
            this.txtApellido.MaxLength = 100;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(180, 30);
            this.txtApellido.TabIndex = 8;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            //
            // txtTelefono
            //
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(20, 80, 150);
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTelefono.ForeColor = System.Drawing.Color.White;
            this.txtTelefono.Location = new System.Drawing.Point(630, 155);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(180, 30);
            this.txtTelefono.TabIndex = 9;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            //
            // lblFechaNac
            //
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFechaNac.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            this.lblFechaNac.Location = new System.Drawing.Point(30, 205);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.TabIndex = 10;
            this.lblFechaNac.Text = "Fecha Nacimiento:";
            //
            // dtpFechaNac
            //
            this.dtpFechaNac.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFechaNac.Location = new System.Drawing.Point(30, 228);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(280, 32);
            this.dtpFechaNac.TabIndex = 11;
            //
            // chkSeguro
            //
            this.chkSeguro.AutoSize = true;
            this.chkSeguro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.chkSeguro.ForeColor = System.Drawing.Color.White;
            this.chkSeguro.Location = new System.Drawing.Point(320, 231);
            this.chkSeguro.Name = "chkSeguro";
            this.chkSeguro.Size = new System.Drawing.Size(100, 23);
            this.chkSeguro.TabIndex = 12;
            this.chkSeguro.Text = "Tiene Seguro";
            this.chkSeguro.UseVisualStyleBackColor = false;
            //
            // btnGuardar
            //
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(0, 168, 232);
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(30, 285);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 38);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            //
            // btnLimpiar
            //
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(70, 130, 180);
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(160, 285);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 38);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            //
            // btnVolver
            //
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(0, 100, 60);
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(290, 285);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(120, 38);
            this.btnVolver.TabIndex = 15;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            //
            // frmPacientes
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(10, 60, 120);
            this.ClientSize = new System.Drawing.Size(1280, 380);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.chkSeguro);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnHabilitar);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmPacientes";
            this.Text = "Clinica Medica - Alta de Pacientes";
            this.Load += new System.EventHandler(this.frmPacientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnHabilitar;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.CheckBox chkSeguro;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
    }
}
