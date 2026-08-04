namespace ClinicaMedica
{
    partial class frmMedicamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedicamentos));
            lblTitulo = new System.Windows.Forms.Label();
            btnHabilitar = new System.Windows.Forms.Button();
            btnDeshabilitar = new System.Windows.Forms.Button();
            lblNombre = new System.Windows.Forms.Label();
            lblPresentacion = new System.Windows.Forms.Label();
            lblConcentracion = new System.Windows.Forms.Label();
            lblStock = new System.Windows.Forms.Label();
            lblPrecio = new System.Windows.Forms.Label();
            lblFechaVencimiento = new System.Windows.Forms.Label();
            lblProveedor = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
            txtPresentacion = new System.Windows.Forms.TextBox();
            txtConcentracion = new System.Windows.Forms.TextBox();
            txtStock = new System.Windows.Forms.TextBox();
            txtPrecio = new System.Windows.Forms.TextBox();
            dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            cboProveedor = new System.Windows.Forms.ComboBox();
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
            lblTitulo.Text = "Alta de Medicamentos";
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
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblNombre.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            lblNombre.Location = new System.Drawing.Point(327, 150);
            lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(56, 15);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre:";
            // 
            // lblPresentacion
            // 
            lblPresentacion.AutoSize = true;
            lblPresentacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblPresentacion.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            lblPresentacion.Location = new System.Drawing.Point(35, 309);
            lblPresentacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPresentacion.Name = "lblPresentacion";
            lblPresentacion.Size = new System.Drawing.Size(82, 15);
            lblPresentacion.TabIndex = 5;
            lblPresentacion.Text = "Presentacion:";
            // 
            // lblConcentracion
            // 
            lblConcentracion.AutoSize = true;
            lblConcentracion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblConcentracion.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            lblConcentracion.Location = new System.Drawing.Point(327, 309);
            lblConcentracion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblConcentracion.Name = "lblConcentracion";
            lblConcentracion.Size = new System.Drawing.Size(90, 15);
            lblConcentracion.TabIndex = 6;
            lblConcentracion.Text = "Concentracion:";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblStock.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            lblStock.Location = new System.Drawing.Point(35, 237);
            lblStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new System.Drawing.Size(42, 15);
            lblStock.TabIndex = 11;
            lblStock.Text = "Stock:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblPrecio.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            lblPrecio.Location = new System.Drawing.Point(327, 237);
            lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new System.Drawing.Size(80, 15);
            lblPrecio.TabIndex = 12;
            lblPrecio.Text = "Precio (RD$):";
            // 
            // lblFechaVencimiento
            // 
            lblFechaVencimiento.AutoSize = true;
            lblFechaVencimiento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblFechaVencimiento.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            lblFechaVencimiento.Location = new System.Drawing.Point(657, 151);
            lblFechaVencimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFechaVencimiento.Name = "lblFechaVencimiento";
            lblFechaVencimiento.Size = new System.Drawing.Size(115, 15);
            lblFechaVencimiento.TabIndex = 13;
            lblFechaVencimiento.Text = "Fecha Vencimiento:";
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblProveedor.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            lblProveedor.Location = new System.Drawing.Point(35, 150);
            lblProveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new System.Drawing.Size(69, 15);
            lblProveedor.TabIndex = 3;
            lblProveedor.Text = "Proveedor:";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = System.Drawing.Color.FromArgb(20, 80, 150);
            txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtNombre.ForeColor = System.Drawing.Color.White;
            txtNombre.Location = new System.Drawing.Point(327, 179);
            txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(268, 25);
            txtNombre.TabIndex = 8;
            // 
            // txtPresentacion
            // 
            txtPresentacion.BackColor = System.Drawing.Color.FromArgb(20, 80, 150);
            txtPresentacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtPresentacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtPresentacion.ForeColor = System.Drawing.Color.White;
            txtPresentacion.Location = new System.Drawing.Point(35, 338);
            txtPresentacion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtPresentacion.MaxLength = 100;
            txtPresentacion.Name = "txtPresentacion";
            txtPresentacion.Size = new System.Drawing.Size(268, 25);
            txtPresentacion.TabIndex = 9;
            // 
            // txtConcentracion
            // 
            txtConcentracion.BackColor = System.Drawing.Color.FromArgb(20, 80, 150);
            txtConcentracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtConcentracion.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtConcentracion.ForeColor = System.Drawing.Color.White;
            txtConcentracion.Location = new System.Drawing.Point(327, 338);
            txtConcentracion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtConcentracion.MaxLength = 50;
            txtConcentracion.Name = "txtConcentracion";
            txtConcentracion.Size = new System.Drawing.Size(268, 25);
            txtConcentracion.TabIndex = 10;
            // 
            // txtStock
            // 
            txtStock.BackColor = System.Drawing.Color.FromArgb(20, 80, 150);
            txtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtStock.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtStock.ForeColor = System.Drawing.Color.White;
            txtStock.Location = new System.Drawing.Point(35, 265);
            txtStock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtStock.MaxLength = 10;
            txtStock.Name = "txtStock";
            txtStock.Size = new System.Drawing.Size(268, 25);
            txtStock.TabIndex = 14;
            txtStock.KeyPress += txtNumerico_KeyPress;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = System.Drawing.Color.FromArgb(20, 80, 150);
            txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtPrecio.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtPrecio.ForeColor = System.Drawing.Color.White;
            txtPrecio.Location = new System.Drawing.Point(327, 265);
            txtPrecio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtPrecio.MaxLength = 12;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new System.Drawing.Size(268, 25);
            txtPrecio.TabIndex = 15;
            txtPrecio.KeyPress += txtDecimal_KeyPress;
            // 
            // dtpFechaVencimiento
            // 
            dtpFechaVencimiento.Font = new System.Drawing.Font("Segoe UI", 10F);
            dtpFechaVencimiento.Location = new System.Drawing.Point(657, 179);
            dtpFechaVencimiento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            dtpFechaVencimiento.Size = new System.Drawing.Size(268, 25);
            dtpFechaVencimiento.TabIndex = 16;
            // 
            // cboProveedor
            // 
            cboProveedor.BackColor = System.Drawing.Color.White;
            cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboProveedor.Font = new System.Drawing.Font("Segoe UI", 10F);
            cboProveedor.ForeColor = System.Drawing.Color.FromArgb(10, 60, 120);
            cboProveedor.FormattingEnabled = true;
            cboProveedor.Location = new System.Drawing.Point(35, 179);
            cboProveedor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboProveedor.Name = "cboProveedor";
            cboProveedor.Size = new System.Drawing.Size(268, 25);
            cboProveedor.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = System.Drawing.Color.FromArgb(160, 40, 60);
            btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnGuardar.ForeColor = System.Drawing.Color.White;
            btnGuardar.Location = new System.Drawing.Point(24, 440);
            btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(140, 44);
            btnGuardar.TabIndex = 17;
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
            btnLimpiar.Location = new System.Drawing.Point(176, 440);
            btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(140, 44);
            btnLimpiar.TabIndex = 18;
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
            btnVolver.Location = new System.Drawing.Point(327, 440);
            btnVolver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(140, 44);
            btnVolver.TabIndex = 19;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // picLogo
            // 
            picLogo.BackColor = System.Drawing.Color.Transparent;
            picLogo.Image = (System.Drawing.Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new System.Drawing.Point(657, 360);
            picLogo.Margin = new System.Windows.Forms.Padding(4);
            picLogo.Name = "picLogo";
            picLogo.Size = new System.Drawing.Size(311, 296);
            picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 20;
            picLogo.TabStop = false;
            // 
            // frmMedicamentos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(10, 60, 120);
            ClientSize = new System.Drawing.Size(1035, 679);
            Controls.Add(picLogo);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(dtpFechaVencimiento);
            Controls.Add(txtPrecio);
            Controls.Add(txtStock);
            Controls.Add(lblFechaVencimiento);
            Controls.Add(lblPrecio);
            Controls.Add(lblStock);
            Controls.Add(txtConcentracion);
            Controls.Add(txtPresentacion);
            Controls.Add(txtNombre);
            Controls.Add(cboProveedor);
            Controls.Add(lblConcentracion);
            Controls.Add(lblPresentacion);
            Controls.Add(lblNombre);
            Controls.Add(lblProveedor);
            Controls.Add(btnDeshabilitar);
            Controls.Add(btnHabilitar);
            Controls.Add(lblTitulo);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "frmMedicamentos";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Clinica Medica - Alta de Medicamentos";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += frmMedicamentos_Load;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnHabilitar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPresentacion;
        private System.Windows.Forms.Label lblConcentracion;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPresentacion;
        private System.Windows.Forms.TextBox txtConcentracion;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.ComboBox cboProveedor;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.PictureBox picLogo;
    }
}
