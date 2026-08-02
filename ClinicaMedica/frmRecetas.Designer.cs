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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnHabilitar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.lblCita = new System.Windows.Forms.Label();
            this.cboCita = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblIndicaciones = new System.Windows.Forms.Label();
            this.txtIndicaciones = new System.Windows.Forms.TextBox();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.colMedicamento = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colDosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFrecuencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDuracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObservaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarLinea = new System.Windows.Forms.Button();
            this.btnEliminarLinea = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
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
            this.lblTitulo.Text = "Alta de Recetas";
            //
            // btnHabilitar
            //
            this.btnHabilitar.BackColor = System.Drawing.Color.FromArgb(0, 160, 80);
            this.btnHabilitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHabilitar.FlatAppearance.BorderSize = 0;
            this.btnHabilitar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHabilitar.ForeColor = System.Drawing.Color.White;
            this.btnHabilitar.Location = new System.Drawing.Point(30, 65);
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
            this.btnDeshabilitar.Enabled = false;
            this.btnDeshabilitar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeshabilitar.ForeColor = System.Drawing.Color.White;
            this.btnDeshabilitar.Location = new System.Drawing.Point(200, 65);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(180, 38);
            this.btnDeshabilitar.TabIndex = 2;
            this.btnDeshabilitar.Text = "Deshabilitar Ingreso";
            this.btnDeshabilitar.UseVisualStyleBackColor = false;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            //
            // lblCita
            //
            this.lblCita.AutoSize = true;
            this.lblCita.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCita.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            this.lblCita.Location = new System.Drawing.Point(30, 120);
            this.lblCita.Name = "lblCita";
            this.lblCita.TabIndex = 3;
            this.lblCita.Text = "Cita:";
            //
            // cboCita
            //
            this.cboCita.BackColor = System.Drawing.Color.White;
            this.cboCita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCita.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboCita.ForeColor = System.Drawing.Color.FromArgb(10, 60, 120);
            this.cboCita.FormattingEnabled = true;
            this.cboCita.Location = new System.Drawing.Point(30, 145);
            this.cboCita.Name = "cboCita";
            this.cboCita.Size = new System.Drawing.Size(500, 32);
            this.cboCita.TabIndex = 4;
            //
            // lblFecha
            //
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            this.lblFecha.Location = new System.Drawing.Point(550, 120);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha:";
            //
            // dtpFecha
            //
            this.dtpFecha.CalendarForeColor = System.Drawing.Color.FromArgb(10, 60, 120);
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(550, 145);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 30);
            this.dtpFecha.TabIndex = 6;
            //
            // lblIndicaciones
            //
            this.lblIndicaciones.AutoSize = true;
            this.lblIndicaciones.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIndicaciones.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            this.lblIndicaciones.Location = new System.Drawing.Point(30, 195);
            this.lblIndicaciones.Name = "lblIndicaciones";
            this.lblIndicaciones.TabIndex = 7;
            this.lblIndicaciones.Text = "Indicaciones generales:";
            //
            // txtIndicaciones
            //
            this.txtIndicaciones.BackColor = System.Drawing.Color.FromArgb(20, 80, 150);
            this.txtIndicaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIndicaciones.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtIndicaciones.ForeColor = System.Drawing.Color.White;
            this.txtIndicaciones.Location = new System.Drawing.Point(30, 220);
            this.txtIndicaciones.MaxLength = 500;
            this.txtIndicaciones.Multiline = true;
            this.txtIndicaciones.Name = "txtIndicaciones";
            this.txtIndicaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIndicaciones.Size = new System.Drawing.Size(720, 60);
            this.txtIndicaciones.TabIndex = 8;
            //
            // lblDetalle
            //
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDetalle.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            this.lblDetalle.Location = new System.Drawing.Point(30, 295);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.TabIndex = 9;
            this.lblDetalle.Text = "Detalle de medicamentos:";
            //
            // dgvDetalle
            //
            this.dgvDetalle.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetalle.ColumnHeadersHeight = 38;
            this.dgvDetalle.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(100, 60, 180);
            this.dgvDetalle.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDetalle.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvDetalle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvDetalle.Location = new System.Drawing.Point(30, 320);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.RowTemplate.Height = 32;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(1220, 200);
            this.dgvDetalle.TabIndex = 10;
            this.dgvDetalle.Columns.Add(this.colMedicamento);
            this.dgvDetalle.Columns.Add(this.colDosis);
            this.dgvDetalle.Columns.Add(this.colFrecuencia);
            this.dgvDetalle.Columns.Add(this.colDuracion);
            this.dgvDetalle.Columns.Add(this.colObservaciones);
            //
            // colMedicamento
            //
            this.colMedicamento.HeaderText = "Medicamento";
            this.colMedicamento.Name = "colMedicamento";
            this.colMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colMedicamento.Width = 300;
            //
            // colDosis
            //
            this.colDosis.HeaderText = "Dosis";
            this.colDosis.Name = "colDosis";
            this.colDosis.Width = 120;
            //
            // colFrecuencia
            //
            this.colFrecuencia.HeaderText = "Frecuencia";
            this.colFrecuencia.Name = "colFrecuencia";
            this.colFrecuencia.Width = 150;
            //
            // colDuracion
            //
            this.colDuracion.HeaderText = "Duracion";
            this.colDuracion.Name = "colDuracion";
            this.colDuracion.Width = 120;
            //
            // colObservaciones
            //
            this.colObservaciones.HeaderText = "Observaciones";
            this.colObservaciones.Name = "colObservaciones";
            this.colObservaciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            //
            // btnAgregarLinea
            //
            this.btnAgregarLinea.BackColor = System.Drawing.Color.FromArgb(0, 140, 70);
            this.btnAgregarLinea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarLinea.FlatAppearance.BorderSize = 0;
            this.btnAgregarLinea.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAgregarLinea.ForeColor = System.Drawing.Color.White;
            this.btnAgregarLinea.Location = new System.Drawing.Point(30, 530);
            this.btnAgregarLinea.Name = "btnAgregarLinea";
            this.btnAgregarLinea.Size = new System.Drawing.Size(160, 38);
            this.btnAgregarLinea.TabIndex = 11;
            this.btnAgregarLinea.Text = "+ Agregar linea";
            this.btnAgregarLinea.UseVisualStyleBackColor = false;
            this.btnAgregarLinea.Click += new System.EventHandler(this.btnAgregarLinea_Click);
            //
            // btnEliminarLinea
            //
            this.btnEliminarLinea.BackColor = System.Drawing.Color.FromArgb(160, 30, 30);
            this.btnEliminarLinea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarLinea.FlatAppearance.BorderSize = 0;
            this.btnEliminarLinea.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminarLinea.ForeColor = System.Drawing.Color.White;
            this.btnEliminarLinea.Location = new System.Drawing.Point(200, 530);
            this.btnEliminarLinea.Name = "btnEliminarLinea";
            this.btnEliminarLinea.Size = new System.Drawing.Size(160, 38);
            this.btnEliminarLinea.TabIndex = 12;
            this.btnEliminarLinea.Text = "- Eliminar linea";
            this.btnEliminarLinea.UseVisualStyleBackColor = false;
            this.btnEliminarLinea.Click += new System.EventHandler(this.btnEliminarLinea_Click);
            //
            // btnGuardar
            //
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(100, 60, 180);
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(30, 580);
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
            this.btnLimpiar.Location = new System.Drawing.Point(160, 580);
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
            this.btnVolver.Location = new System.Drawing.Point(290, 580);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(120, 38);
            this.btnVolver.TabIndex = 15;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            //
            // frmRecetas
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(10, 60, 120);
            this.ClientSize = new System.Drawing.Size(1280, 640);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminarLinea);
            this.Controls.Add(this.btnAgregarLinea);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.txtIndicaciones);
            this.Controls.Add(this.lblIndicaciones);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.cboCita);
            this.Controls.Add(this.lblCita);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnHabilitar);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmRecetas";
            this.Text = "Clinica Medica - Alta de Recetas";
            this.Load += new System.EventHandler(this.frmRecetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
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
