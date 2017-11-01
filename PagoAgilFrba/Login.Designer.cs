namespace PagoAgilFrba
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.login_tb_usuario = new System.Windows.Forms.TextBox();
            this.login_btn_ingresar = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.login_tb_pass = new System.Windows.Forms.TextBox();
            this.login_lab_usuario = new System.Windows.Forms.Label();
            this.login_lab_pass = new System.Windows.Forms.Label();
            this.login_lab_bienvenidos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_tb_usuario
            // 
            this.login_tb_usuario.AcceptsReturn = true;
            this.login_tb_usuario.AcceptsTab = true;
            this.login_tb_usuario.AllowDrop = true;
            this.login_tb_usuario.Location = new System.Drawing.Point(81, 89);
            this.login_tb_usuario.Name = "login_tb_usuario";
            this.login_tb_usuario.Size = new System.Drawing.Size(100, 20);
            this.login_tb_usuario.TabIndex = 0;
            // 
            // login_btn_ingresar
            // 
            this.login_btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.login_btn_ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn_ingresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.login_btn_ingresar.Location = new System.Drawing.Point(78, 180);
            this.login_btn_ingresar.Name = "login_btn_ingresar";
            this.login_btn_ingresar.Size = new System.Drawing.Size(103, 28);
            this.login_btn_ingresar.TabIndex = 2;
            this.login_btn_ingresar.Text = "Ingresar";
            this.login_btn_ingresar.UseVisualStyleBackColor = true;
            this.login_btn_ingresar.Click += new System.EventHandler(this.login_btn_ingresar_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // login_tb_pass
            // 
            this.login_tb_pass.AcceptsReturn = true;
            this.login_tb_pass.AcceptsTab = true;
            this.login_tb_pass.Location = new System.Drawing.Point(81, 140);
            this.login_tb_pass.Name = "login_tb_pass";
            this.login_tb_pass.PasswordChar = '*';
            this.login_tb_pass.Size = new System.Drawing.Size(100, 20);
            this.login_tb_pass.TabIndex = 1;
            this.login_tb_pass.UseSystemPasswordChar = true;
            // 
            // login_lab_usuario
            // 
            this.login_lab_usuario.AutoSize = true;
            this.login_lab_usuario.Location = new System.Drawing.Point(78, 73);
            this.login_lab_usuario.Name = "login_lab_usuario";
            this.login_lab_usuario.Size = new System.Drawing.Size(46, 13);
            this.login_lab_usuario.TabIndex = 6;
            this.login_lab_usuario.Text = "Usuario:";
            this.login_lab_usuario.Click += new System.EventHandler(this.login_lab_usuario_Click);
            // 
            // login_lab_pass
            // 
            this.login_lab_pass.AutoSize = true;
            this.login_lab_pass.Location = new System.Drawing.Point(78, 124);
            this.login_lab_pass.Name = "login_lab_pass";
            this.login_lab_pass.Size = new System.Drawing.Size(56, 13);
            this.login_lab_pass.TabIndex = 7;
            this.login_lab_pass.Text = "Password:";
            // 
            // login_lab_bienvenidos
            // 
            this.login_lab_bienvenidos.AutoSize = true;
            this.login_lab_bienvenidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_lab_bienvenidos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.login_lab_bienvenidos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.login_lab_bienvenidos.Location = new System.Drawing.Point(12, 26);
            this.login_lab_bienvenidos.Name = "login_lab_bienvenidos";
            this.login_lab_bienvenidos.Size = new System.Drawing.Size(242, 18);
            this.login_lab_bienvenidos.TabIndex = 8;
            this.login_lab_bienvenidos.Text = "Bienvenidos a Pago Agil FRBA ";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 233);
            this.Controls.Add(this.login_lab_bienvenidos);
            this.Controls.Add(this.login_lab_pass);
            this.Controls.Add(this.login_lab_usuario);
            this.Controls.Add(this.login_tb_pass);
            this.Controls.Add(this.login_btn_ingresar);
            this.Controls.Add(this.login_tb_usuario);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
        }

        #endregion

        private System.Windows.Forms.TextBox login_tb_usuario;
        private System.Windows.Forms.Button login_btn_ingresar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox login_tb_pass;
        private System.Windows.Forms.Label login_lab_usuario;
        private System.Windows.Forms.Label login_lab_pass;
        private System.Windows.Forms.Label login_lab_bienvenidos;

    }
}

