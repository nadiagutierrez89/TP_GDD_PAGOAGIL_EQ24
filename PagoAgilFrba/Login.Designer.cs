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
            this.login_tb_usuario = new System.Windows.Forms.TextBox();
            this.login_tb_pass = new System.Windows.Forms.TextBox();
            this.login_btn_ingresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_tb_usuario
            // 
            this.login_tb_usuario.Location = new System.Drawing.Point(73, 148);
            this.login_tb_usuario.Name = "login_tb_usuario";
            this.login_tb_usuario.Size = new System.Drawing.Size(100, 20);
            this.login_tb_usuario.TabIndex = 0;
            this.login_tb_usuario.Text = "Usuario";
            // 
            // login_tb_pass
            // 
            this.login_tb_pass.Location = new System.Drawing.Point(73, 188);
            this.login_tb_pass.Name = "login_tb_pass";
            this.login_tb_pass.Size = new System.Drawing.Size(100, 20);
            this.login_tb_pass.TabIndex = 1;
            this.login_tb_pass.Text = "Password";
            // 
            // login_btn_ingresar
            // 
            this.login_btn_ingresar.Location = new System.Drawing.Point(134, 215);
            this.login_btn_ingresar.Name = "login_btn_ingresar";
            this.login_btn_ingresar.Size = new System.Drawing.Size(75, 23);
            this.login_btn_ingresar.TabIndex = 2;
            this.login_btn_ingresar.Text = "Ingresar";
            this.login_btn_ingresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.login_btn_ingresar.UseVisualStyleBackColor = true;
            this.login_btn_ingresar.Click += new System.EventHandler(this.login_btn_ingresar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 261);
            this.Controls.Add(this.login_btn_ingresar);
            this.Controls.Add(this.login_tb_pass);
            this.Controls.Add(this.login_tb_usuario);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login_tb_usuario;
        private System.Windows.Forms.TextBox login_tb_pass;
        private System.Windows.Forms.Button login_btn_ingresar;

    }
}

