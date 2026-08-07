namespace ClinicaMedica
{
    partial class frmReportes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            lblTitulo = new System.Windows.Forms.Label();
            lblFiltro = new System.Windows.Forms.Label();
            lblInfo = new System.Windows.Forms.Label();
            cmbFiltro = new System.Windows.Forms.ComboBox();
            btnFiltrar = new System.Windows.Forms.Button();
            btnTodos = new System.Windows.Forms.Button();
            btnVolver = new System.Windows.Forms.Button();
            dgvReportes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
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
            lblTitulo.Text = "Reportes del Sistema";
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblFiltro.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            lblFiltro.Location = new System.Drawing.Point(35, 617);
            lblFiltro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new System.Drawing.Size(129, 19);
            lblFiltro.TabIndex = 1;
            lblFiltro.Text = "Filtrar por Estado:";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            lblInfo.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            lblInfo.Location = new System.Drawing.Point(502, 617);
            lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new System.Drawing.Size(0, 20);
            lblInfo.TabIndex = 2;
            // 
            // cmbFiltro
            // 
            cmbFiltro.BackColor = System.Drawing.Color.White;
            cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmbFiltro.Font = new System.Drawing.Font("Segoe UI", 10F);
            cmbFiltro.ForeColor = System.Drawing.Color.FromArgb(10, 60, 120);
            cmbFiltro.FormattingEnabled = true;
            cmbFiltro.Items.AddRange(new object[] { "Pendiente", "Completada", "Cancelada" });
            cmbFiltro.Location = new System.Drawing.Point(233, 614);
            cmbFiltro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmbFiltro.Name = "cmbFiltro";
            cmbFiltro.Size = new System.Drawing.Size(233, 25);
            cmbFiltro.TabIndex = 3;
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = System.Drawing.Color.FromArgb(100, 50, 160);
            btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnFiltrar.FlatAppearance.BorderSize = 0;
            btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFiltrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnFiltrar.ForeColor = System.Drawing.Color.White;
            btnFiltrar.Location = new System.Drawing.Point(500, 614);
            btnFiltrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new System.Drawing.Size(142, 25);
            btnFiltrar.TabIndex = 4;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // btnTodos
            // 
            btnTodos.BackColor = System.Drawing.Color.FromArgb(0, 140, 70);
            btnTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            btnTodos.FlatAppearance.BorderSize = 0;
            btnTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTodos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnTodos.ForeColor = System.Drawing.Color.White;
            btnTodos.Location = new System.Drawing.Point(652, 614);
            btnTodos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new System.Drawing.Size(142, 25);
            btnTodos.TabIndex = 5;
            btnTodos.Text = "Ver Todos";
            btnTodos.UseVisualStyleBackColor = false;
            btnTodos.Click += btnTodos_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = System.Drawing.Color.FromArgb(180, 30, 30);
            btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnVolver.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnVolver.ForeColor = System.Drawing.Color.White;
            btnVolver.Location = new System.Drawing.Point(803, 614);
            btnVolver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(142, 25);
            btnVolver.TabIndex = 7;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // dgvReportes
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(240, 230, 255);
            dgvReportes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvReportes.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvReportes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvReportes.BackgroundColor = System.Drawing.Color.White;
            dgvReportes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(100, 50, 160);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvReportes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvReportes.ColumnHeadersHeight = 38;
            dgvReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvReportes.Font = new System.Drawing.Font("Segoe UI", 10F);
            dgvReportes.GridColor = System.Drawing.Color.FromArgb(200, 180, 230);
            dgvReportes.Location = new System.Drawing.Point(35, 75);
            dgvReportes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvReportes.Name = "dgvReportes";
            dgvReportes.ReadOnly = true;
            dgvReportes.RowHeadersVisible = false;
            dgvReportes.RowTemplate.Height = 32;
            dgvReportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvReportes.Size = new System.Drawing.Size(1423, 519);
            dgvReportes.TabIndex = 6;
            dgvReportes.CellContentClick += dgvReportes_CellClick;
            // 
            // frmReportes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(10, 60, 120);
            ClientSize = new System.Drawing.Size(1493, 662);
            Controls.Add(btnVolver);
            Controls.Add(dgvReportes);
            Controls.Add(btnTodos);
            Controls.Add(btnFiltrar);
            Controls.Add(cmbFiltro);
            Controls.Add(lblInfo);
            Controls.Add(lblFiltro);
            Controls.Add(lblTitulo);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "frmReportes";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Clinica Medica - Reportes";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.DataGridView dgvReportes;
        private System.Windows.Forms.Button btnVolver;
    }
}
