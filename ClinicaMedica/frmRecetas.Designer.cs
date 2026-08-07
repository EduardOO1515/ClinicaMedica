namespace ClinicaMedica
{
    partial class frmRecetas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            lblTitulo = new System.Windows.Forms.Label();
            btnHabilitar = new System.Windows.Forms.Button();
            btnDeshabilitar = new System.Windows.Forms.Button();
            lblCita = new System.Windows.Forms.Label();
            cboCita = new System.Windows.Forms.ComboBox();
            lblFecha = new System.Windows.Forms.Label();
            dtpFecha = new System.Windows.Forms.DateTimePicker();
            lblIndicaciones = new System.Windows.Forms.Label();
            txtIndicaciones = new System.Windows.Forms.TextBox();
            lblDetalle = new System.Windows.Forms.Label();
            dgvDetalle = new System.Windows.Forms.DataGridView();
            colMedicamento = new System.Windows.Forms.DataGridViewComboBoxColumn();
            colDosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colFrecuencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDuracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colObservaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnAgregarLinea = new System.Windows.Forms.Button();
            btnEliminarLinea = new System.Windows.Forms.Button();
            btnGuardar = new System.Windows.Forms.Button();
            btnLimpiar = new System.Windows.Forms.Button();
            btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
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
            lblTitulo.Text = "Alta de Recetas";
            // 
            // btnHabilitar
            // 
            btnHabilitar.BackColor = System.Drawing.Color.FromArgb(0, 160, 80);
            btnHabilitar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnHabilitar.FlatAppearance.BorderSize = 0;
            btnHabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHabilitar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnHabilitar.ForeColor = System.Drawing.Color.White;
            btnHabilitar.Location = new System.Drawing.Point(35, 75);
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
            btnDeshabilitar.Location = new System.Drawing.Point(233, 75);
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
            lblCita.Location = new System.Drawing.Point(35, 138);
            lblCita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCita.Name = "lblCita";
            lblCita.Size = new System.Drawing.Size(31, 15);
            lblCita.TabIndex = 3;
            lblCita.Text = "Cita:";
            // 
            // cboCita
            // 
            cboCita.BackColor = System.Drawing.Color.White;
            cboCita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboCita.Font = new System.Drawing.Font("Segoe UI", 10F);
            cboCita.ForeColor = System.Drawing.Color.FromArgb(10, 60, 120);
            cboCita.FormattingEnabled = true;
            cboCita.Location = new System.Drawing.Point(35, 167);
            cboCita.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboCita.Name = "cboCita";
            cboCita.Size = new System.Drawing.Size(583, 25);
            cboCita.TabIndex = 4;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblFecha.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            lblFecha.Location = new System.Drawing.Point(642, 138);
            lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new System.Drawing.Size(42, 15);
            lblFecha.TabIndex = 5;
            lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            dtpFecha.CalendarForeColor = System.Drawing.Color.FromArgb(10, 60, 120);
            dtpFecha.Font = new System.Drawing.Font("Segoe UI", 10F);
            dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpFecha.Location = new System.Drawing.Point(642, 167);
            dtpFecha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new System.Drawing.Size(233, 25);
            dtpFecha.TabIndex = 6;
            // 
            // lblIndicaciones
            // 
            lblIndicaciones.AutoSize = true;
            lblIndicaciones.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblIndicaciones.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            lblIndicaciones.Location = new System.Drawing.Point(35, 225);
            lblIndicaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblIndicaciones.Name = "lblIndicaciones";
            lblIndicaciones.Size = new System.Drawing.Size(135, 15);
            lblIndicaciones.TabIndex = 7;
            lblIndicaciones.Text = "Indicaciones generales:";
            // 
            // txtIndicaciones
            // 
            txtIndicaciones.BackColor = System.Drawing.Color.FromArgb(20, 80, 150);
            txtIndicaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtIndicaciones.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtIndicaciones.ForeColor = System.Drawing.Color.White;
            txtIndicaciones.Location = new System.Drawing.Point(35, 254);
            txtIndicaciones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtIndicaciones.MaxLength = 500;
            txtIndicaciones.Multiline = true;
            txtIndicaciones.Name = "txtIndicaciones";
            txtIndicaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtIndicaciones.Size = new System.Drawing.Size(840, 69);
            txtIndicaciones.TabIndex = 8;
            // 
            // lblDetalle
            // 
            lblDetalle.AutoSize = true;
            lblDetalle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblDetalle.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            lblDetalle.Location = new System.Drawing.Point(35, 340);
            lblDetalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDetalle.Name = "lblDetalle";
            lblDetalle.Size = new System.Drawing.Size(152, 15);
            lblDetalle.TabIndex = 9;
            lblDetalle.Text = "Detalle de medicamentos:";
            // 
            // dgvDetalle
            // 
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvDetalle.BackgroundColor = System.Drawing.Color.White;
            dgvDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(100, 60, 180);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDetalle.ColumnHeadersHeight = 38;
            dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colMedicamento, colDosis, colFrecuencia, colDuracion, colObservaciones });
            dgvDetalle.Font = new System.Drawing.Font("Segoe UI", 10F);
            dgvDetalle.Location = new System.Drawing.Point(35, 369);
            dgvDetalle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.RowHeadersVisible = false;
            dgvDetalle.RowTemplate.Height = 32;
            dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.Size = new System.Drawing.Size(1423, 231);
            dgvDetalle.TabIndex = 10;
            // 
            // colMedicamento
            // 
            colMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            colMedicamento.HeaderText = "Medicamento";
            colMedicamento.Name = "colMedicamento";
            colMedicamento.Width = 300;
            // 
            // colDosis
            // 
            colDosis.HeaderText = "Dosis";
            colDosis.Name = "colDosis";
            colDosis.Width = 120;
            // 
            // colFrecuencia
            // 
            colFrecuencia.HeaderText = "Frecuencia";
            colFrecuencia.Name = "colFrecuencia";
            colFrecuencia.Width = 150;
            // 
            // colDuracion
            // 
            colDuracion.HeaderText = "Duracion";
            colDuracion.Name = "colDuracion";
            colDuracion.Width = 120;
            // 
            // colObservaciones
            // 
            colObservaciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            colObservaciones.HeaderText = "Observaciones";
            colObservaciones.Name = "colObservaciones";
            // 
            // btnAgregarLinea
            // 
            btnAgregarLinea.BackColor = System.Drawing.Color.FromArgb(0, 140, 70);
            btnAgregarLinea.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAgregarLinea.FlatAppearance.BorderSize = 0;
            btnAgregarLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAgregarLinea.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnAgregarLinea.ForeColor = System.Drawing.Color.White;
            btnAgregarLinea.Location = new System.Drawing.Point(35, 612);
            btnAgregarLinea.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAgregarLinea.Name = "btnAgregarLinea";
            btnAgregarLinea.Size = new System.Drawing.Size(187, 44);
            btnAgregarLinea.TabIndex = 11;
            btnAgregarLinea.Text = "+ Agregar linea";
            btnAgregarLinea.UseVisualStyleBackColor = false;
            btnAgregarLinea.Click += btnAgregarLinea_Click;
            // 
            // btnEliminarLinea
            // 
            btnEliminarLinea.BackColor = System.Drawing.Color.FromArgb(160, 30, 30);
            btnEliminarLinea.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEliminarLinea.FlatAppearance.BorderSize = 0;
            btnEliminarLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEliminarLinea.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnEliminarLinea.ForeColor = System.Drawing.Color.White;
            btnEliminarLinea.Location = new System.Drawing.Point(233, 612);
            btnEliminarLinea.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnEliminarLinea.Name = "btnEliminarLinea";
            btnEliminarLinea.Size = new System.Drawing.Size(187, 44);
            btnEliminarLinea.TabIndex = 12;
            btnEliminarLinea.Text = "- Eliminar linea";
            btnEliminarLinea.UseVisualStyleBackColor = false;
            btnEliminarLinea.Click += btnEliminarLinea_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = System.Drawing.Color.FromArgb(100, 60, 180);
            btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnGuardar.ForeColor = System.Drawing.Color.White;
            btnGuardar.Location = new System.Drawing.Point(465, 612);
            btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(146, 44);
            btnGuardar.TabIndex = 13;
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
            btnLimpiar.Location = new System.Drawing.Point(617, 612);
            btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(146, 44);
            btnLimpiar.TabIndex = 14;
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
            btnVolver.Location = new System.Drawing.Point(768, 612);
            btnVolver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(146, 44);
            btnVolver.TabIndex = 15;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmRecetas
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(10, 60, 120);
            ClientSize = new System.Drawing.Size(1493, 738);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminarLinea);
            Controls.Add(btnAgregarLinea);
            Controls.Add(dgvDetalle);
            Controls.Add(lblDetalle);
            Controls.Add(txtIndicaciones);
            Controls.Add(lblIndicaciones);
            Controls.Add(dtpFecha);
            Controls.Add(lblFecha);
            Controls.Add(cboCita);
            Controls.Add(lblCita);
            Controls.Add(btnDeshabilitar);
            Controls.Add(btnHabilitar);
            Controls.Add(lblTitulo);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "frmRecetas";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Clinica Medica - Alta de Recetas";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += frmRecetas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnHabilitar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Label lblCita;
        private System.Windows.Forms.ComboBox cboCita;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblIndicaciones;
        private System.Windows.Forms.TextBox txtIndicaciones;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFrecuencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObservaciones;
        private System.Windows.Forms.Button btnAgregarLinea;
        private System.Windows.Forms.Button btnEliminarLinea;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
    }
}
