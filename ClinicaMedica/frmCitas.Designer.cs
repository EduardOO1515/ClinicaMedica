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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.cmbPaciente = new System.Windows.Forms.ComboBox();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.dtpFechaCita = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblCostoOriginal = new System.Windows.Forms.Label();
            this.lblValorOriginal = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblValorDescuento = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
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
            this.lblTitulo.Text = "Gestion de Citas";
            //
            // dgvCitas
            //
            this.dgvCitas.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dgvCitas.BackgroundColor = System.Drawing.Color.White;
            this.dgvCitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCitas.ColumnHeadersHeight = 38;
            this.dgvCitas.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(200, 120, 0);
            this.dgvCitas.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCitas.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvCitas.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 245, 220);
            this.dgvCitas.GridColor = System.Drawing.Color.FromArgb(200, 180, 150);
            this.dgvCitas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvCitas.Location = new System.Drawing.Point(30, 65);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.ReadOnly = true;
            this.dgvCitas.RowHeadersVisible = false;
            this.dgvCitas.RowTemplate.Height = 32;
            this.dgvCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCitas.Size = new System.Drawing.Size(1220, 240);
            this.dgvCitas.TabIndex = 7;
            this.dgvCitas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCitas_CellClick);
            //
            // lblPaciente
            //
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPaciente.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            this.lblPaciente.Location = new System.Drawing.Point(30, 320);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.TabIndex = 1;
            this.lblPaciente.Text = "Paciente:";
            //
            // lblDoctor
            //
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDoctor.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            this.lblDoctor.Location = new System.Drawing.Point(280, 320);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.TabIndex = 2;
            this.lblDoctor.Text = "Doctor:";
            //
            // lblFecha
            //
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            this.lblFecha.Location = new System.Drawing.Point(530, 320);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha Cita:";
            //
            // lblEstado
            //
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            this.lblEstado.Location = new System.Drawing.Point(30, 390);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado:";
            //
            // lblTipo
            //
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            this.lblTipo.Location = new System.Drawing.Point(280, 390);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.TabIndex = 5;
            this.lblTipo.Text = "Tipo Consulta:";
            //
            // lblCosto
            //
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCosto.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            this.lblCosto.Location = new System.Drawing.Point(530, 390);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.TabIndex = 6;
            this.lblCosto.Text = "Costo:";
            //
            // cmbPaciente
            //
            this.cmbPaciente.BackColor = System.Drawing.Color.White;
            this.cmbPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPaciente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPaciente.ForeColor = System.Drawing.Color.FromArgb(10, 60, 120);
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.Location = new System.Drawing.Point(30, 343);
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(230, 32);
            this.cmbPaciente.TabIndex = 8;
            //
            // cmbDoctor
            //
            this.cmbDoctor.BackColor = System.Drawing.Color.White;
            this.cmbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDoctor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDoctor.ForeColor = System.Drawing.Color.FromArgb(10, 60, 120);
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(280, 343);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(230, 32);
            this.cmbDoctor.TabIndex = 9;
            //
            // dtpFechaCita
            //
            this.dtpFechaCita.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFechaCita.Location = new System.Drawing.Point(530, 343);
            this.dtpFechaCita.Name = "dtpFechaCita";
            this.dtpFechaCita.Size = new System.Drawing.Size(250, 32);
            this.dtpFechaCita.TabIndex = 13;
            //
            // cmbEstado
            //
            this.cmbEstado.BackColor = System.Drawing.Color.White;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEstado.ForeColor = System.Drawing.Color.FromArgb(10, 60, 120);
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] { "Pendiente", "Completada", "Cancelada" });
            this.cmbEstado.Location = new System.Drawing.Point(30, 413);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(230, 32);
            this.cmbEstado.TabIndex = 11;
            this.cmbEstado.SelectedIndex = 0;
            //
            // cmbTipo
            //
            this.cmbTipo.BackColor = System.Drawing.Color.White;
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTipo.ForeColor = System.Drawing.Color.FromArgb(10, 60, 120);
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] { "General", "Especialidad", "Emergencia", "Control", "Laboratorio" });
            this.cmbTipo.Location = new System.Drawing.Point(280, 413);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(230, 32);
            this.cmbTipo.TabIndex = 10;
            this.cmbTipo.SelectedIndex = 0;
            //
            // txtCosto
            //
            this.txtCosto.BackColor = System.Drawing.Color.FromArgb(20, 80, 150);
            this.txtCosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCosto.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCosto.ForeColor = System.Drawing.Color.White;
            this.txtCosto.Location = new System.Drawing.Point(530, 413);
            this.txtCosto.MaxLength = 10;
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(200, 32);
            this.txtCosto.TabIndex = 12;
            //
            // btnGuardar
            //
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(0, 168, 232);
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(30, 460);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 38);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            //
            // btnEliminar
            //
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(180, 30, 30);
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(160, 460);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 38);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            //
            // btnLimpiar
            //
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(70, 130, 180);
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(290, 460);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 38);
            this.btnLimpiar.TabIndex = 16;
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
            this.btnVolver.Location = new System.Drawing.Point(420, 460);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(120, 38);
            this.btnVolver.TabIndex = 17;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            //
            // lblCostoOriginal
            //
            this.lblCostoOriginal.AutoSize = true;
            this.lblCostoOriginal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCostoOriginal.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            this.lblCostoOriginal.Location = new System.Drawing.Point(30, 515);
            this.lblCostoOriginal.Name = "lblCostoOriginal";
            this.lblCostoOriginal.TabIndex = 18;
            this.lblCostoOriginal.Text = "Costo Original:";
            //
            // lblValorOriginal
            //
            this.lblValorOriginal.AutoSize = true;
            this.lblValorOriginal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblValorOriginal.ForeColor = System.Drawing.Color.White;
            this.lblValorOriginal.Location = new System.Drawing.Point(200, 515);
            this.lblValorOriginal.Name = "lblValorOriginal";
            this.lblValorOriginal.TabIndex = 19;
            this.lblValorOriginal.Text = "RD$0.00";
            //
            // lblDescuento
            //
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescuento.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            this.lblDescuento.Location = new System.Drawing.Point(30, 545);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.TabIndex = 20;
            this.lblDescuento.Text = "Descuento:";
            //
            // lblValorDescuento
            //
            this.lblValorDescuento.AutoSize = true;
            this.lblValorDescuento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblValorDescuento.ForeColor = System.Drawing.Color.FromArgb(0, 200, 100);
            this.lblValorDescuento.Location = new System.Drawing.Point(200, 545);
            this.lblValorDescuento.Name = "lblValorDescuento";
            this.lblValorDescuento.TabIndex = 21;
            this.lblValorDescuento.Text = "RD$0.00";
            //
            // lblTotal
            //
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            this.lblTotal.Location = new System.Drawing.Point(30, 575);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.TabIndex = 22;
            this.lblTotal.Text = "Total a Pagar:";
            //
            // lblValorTotal
            //
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblValorTotal.ForeColor = System.Drawing.Color.FromArgb(0, 230, 118);
            this.lblValorTotal.Location = new System.Drawing.Point(200, 575);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.TabIndex = 23;
            this.lblValorTotal.Text = "RD$0.00";
            //
            // frmCitas
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(10, 60, 120);
            this.ClientSize = new System.Drawing.Size(1280, 780);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblValorDescuento);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblValorOriginal);
            this.Controls.Add(this.lblCostoOriginal);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dtpFechaCita);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.cmbDoctor);
            this.Controls.Add(this.cmbPaciente);
            this.Controls.Add(this.dgvCitas);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmCitas";
            this.Text = "Clinica Medica - Citas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.ComboBox cmbPaciente;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.DateTimePicker dtpFechaCita;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblCostoOriginal;
        private System.Windows.Forms.Label lblValorOriginal;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblValorDescuento;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblValorTotal;
    }
}
