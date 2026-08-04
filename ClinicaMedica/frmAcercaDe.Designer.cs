namespace ClinicaMedica
{
    partial class frmAcercaDe
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo = new System.Windows.Forms.Label();
            lblIntegrantes = new System.Windows.Forms.Label();
            btnCerrar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTitulo.ForeColor = System.Drawing.Color.White;
            lblTitulo.Location = new System.Drawing.Point(23, 23);
            lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(420, 46);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Clínica Médica — Sistema de Gestión";
            lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIntegrantes
            // 
            lblIntegrantes.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblIntegrantes.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            lblIntegrantes.Location = new System.Drawing.Point(23, 92);
            lblIntegrantes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblIntegrantes.Name = "lblIntegrantes";
            lblIntegrantes.Size = new System.Drawing.Size(420, 173);
            lblIntegrantes.TabIndex = 1;
            lblIntegrantes.Text = "Integrantes:\nIsma\nLogan\nRosembert\nEduardo Paulino\nRhyan Duquesne";
            lblIntegrantes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = System.Drawing.Color.FromArgb(0, 168, 232);
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnCerrar.ForeColor = System.Drawing.Color.White;
            btnCerrar.Location = new System.Drawing.Point(163, 288);
            btnCerrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new System.Drawing.Size(140, 46);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // frmAcercaDe
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(10, 60, 120);
            ClientSize = new System.Drawing.Size(467, 358);
            Controls.Add(btnCerrar);
            Controls.Add(lblIntegrantes);
            Controls.Add(lblTitulo);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAcercaDe";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Acerca de";
            ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblIntegrantes;
        private System.Windows.Forms.Button btnCerrar;
    }
}