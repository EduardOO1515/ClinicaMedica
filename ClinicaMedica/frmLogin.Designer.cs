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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            lblTitulo = new System.Windows.Forms.Label();
            lblUsuario = new System.Windows.Forms.Label();
            lblContrasena = new System.Windows.Forms.Label();
            txtUsuario = new System.Windows.Forms.TextBox();
            txtContrasena = new System.Windows.Forms.TextBox();
            btnEntrar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            picLogo = new System.Windows.Forms.PictureBox();
            imageList1 = new System.Windows.Forms.ImageList(components);
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            lblTitulo.ForeColor = System.Drawing.Color.White;
            lblTitulo.Location = new System.Drawing.Point(32, -1);
            lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(490, 92);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Clinica Medica\nSistema de Gestion";
            lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblUsuario.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            lblUsuario.Location = new System.Drawing.Point(70, 224);
            lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new System.Drawing.Size(67, 20);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario:";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblContrasena.ForeColor = System.Drawing.Color.FromArgb(173, 216, 230);
            lblContrasena.Location = new System.Drawing.Point(70, 316);
            lblContrasena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new System.Drawing.Size(92, 20);
            lblContrasena.TabIndex = 2;
            lblContrasena.Text = "Contrasena:";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = System.Drawing.Color.FromArgb(20, 80, 150);
            txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtUsuario.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtUsuario.ForeColor = System.Drawing.Color.White;
            txtUsuario.Location = new System.Drawing.Point(70, 252);
            txtUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new System.Drawing.Size(373, 29);
            txtUsuario.TabIndex = 3;
            // 
            // txtContrasena
            // 
            txtContrasena.BackColor = System.Drawing.Color.FromArgb(20, 80, 150);
            txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtContrasena.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtContrasena.ForeColor = System.Drawing.Color.White;
            txtContrasena.Location = new System.Drawing.Point(70, 345);
            txtContrasena.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.Size = new System.Drawing.Size(373, 29);
            txtContrasena.TabIndex = 4;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = System.Drawing.Color.FromArgb(0, 168, 232);
            btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEntrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnEntrar.ForeColor = System.Drawing.Color.White;
            btnEntrar.Location = new System.Drawing.Point(70, 415);
            btnEntrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new System.Drawing.Size(373, 58);
            btnEntrar.TabIndex = 5;
            btnEntrar.Text = "  INICIAR SESION";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.Color.FromArgb(180, 30, 30);
            btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnCancelar.ForeColor = System.Drawing.Color.White;
            btnCancelar.Location = new System.Drawing.Point(70, 490);
            btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(373, 52);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "  CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // picLogo
            // 
            picLogo.BackColor = System.Drawing.Color.Transparent;
            picLogo.Image = (System.Drawing.Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new System.Drawing.Point(199, 78);
            picLogo.Margin = new System.Windows.Forms.Padding(4);
            picLogo.Name = "picLogo";
            picLogo.Size = new System.Drawing.Size(136, 166);
            picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 7;
            picLogo.TabStop = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            imageList1.ImageSize = new System.Drawing.Size(16, 16);
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(10, 60, 120);
            ClientSize = new System.Drawing.Size(560, 669);
            Controls.Add(picLogo);
            Controls.Add(btnCancelar);
            Controls.Add(btnEntrar);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(lblContrasena);
            Controls.Add(lblUsuario);
            Controls.Add(lblTitulo);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "frmLogin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Clinica Medica - Iniciar Sesion";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.ImageList imageList1;
    }
}
