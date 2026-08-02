namespace ClinicaMedica
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = false;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Location = new System.Drawing.Point(30, 40);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(420, 80);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Clinica Medica\nSistema de Gestion";
            //
            // lblUsuario
            //
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            this.lblUsuario.Location = new System.Drawing.Point(60, 160);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario:";
            //
            // lblContrasena
            //
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblContrasena.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            this.lblContrasena.Location = new System.Drawing.Point(60, 240);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.TabIndex = 2;
            this.lblContrasena.Text = "Contrasena:";
            //
            // txtUsuario
            //
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUsuario.Size = new System.Drawing.Size(320, 35);
            this.txtUsuario.Location = new System.Drawing.Point(60, 185);
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(20, 80, 150);
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.TabIndex = 3;
            //
            // txtContrasena
            //
            this.txtContrasena.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtContrasena.Size = new System.Drawing.Size(320, 35);
            this.txtContrasena.Location = new System.Drawing.Point(60, 265);
            this.txtContrasena.BackColor = System.Drawing.Color.FromArgb(20, 80, 150);
            this.txtContrasena.ForeColor = System.Drawing.Color.White;
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.TabIndex = 4;
            //
            // btnEntrar
            //
            this.btnEntrar.Text = "  INICIAR SESION";
            this.btnEntrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnEntrar.Size = new System.Drawing.Size(320, 50);
            this.btnEntrar.Location = new System.Drawing.Point(60, 360);
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(0, 168, 232);
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.TabIndex = 5;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            //
            // btnCancelar
            //
            this.btnCancelar.Text = "  CANCELAR";
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Size = new System.Drawing.Size(320, 45);
            this.btnCancelar.Location = new System.Drawing.Point(60, 425);
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(180, 30, 30);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            //
            // frmLogin
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(10, 60, 120);
            this.ClientSize = new System.Drawing.Size(480, 580);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmLogin";
            this.Text = "Clinica Medica - Iniciar Sesion";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
