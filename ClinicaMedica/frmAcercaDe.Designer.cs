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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblIntegrantes = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblTitulo
            //
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Location = new System.Drawing.Point(20, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(360, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Clínica Médica — Sistema de Gestión";
            //
            // lblIntegrantes
            //
            this.lblIntegrantes.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblIntegrantes.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            this.lblIntegrantes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIntegrantes.Location = new System.Drawing.Point(20, 80);
            this.lblIntegrantes.Name = "lblIntegrantes";
            this.lblIntegrantes.Size = new System.Drawing.Size(360, 150);
            this.lblIntegrantes.TabIndex = 1;
            this.lblIntegrantes.Text = "Integrantes:\nIsma\nLogan\nRosembert\nEduardo Paulino\nRhyan Duquesne";
            //
            // btnCerrar
            //
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(0, 168, 232);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.Location = new System.Drawing.Point(140, 250);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(120, 40);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            //
            // frmAcercaDe
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(10, 60, 120);
            this.ClientSize = new System.Drawing.Size(400, 310);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblIntegrantes);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAcercaDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Acerca de";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblIntegrantes;
        private System.Windows.Forms.Button btnCerrar;
    }
}