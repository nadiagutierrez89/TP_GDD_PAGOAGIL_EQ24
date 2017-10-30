namespace PagoAgilFrba
{
    partial class SeleccionRolLogin
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
            this.seleccionRol_cb_roles = new System.Windows.Forms.ComboBox();
            this.seleccionRol_lab_roles = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // seleccionRol_cb_roles
            // 
            this.seleccionRol_cb_roles.FormattingEnabled = true;
            this.seleccionRol_cb_roles.Location = new System.Drawing.Point(44, 125);
            this.seleccionRol_cb_roles.Name = "seleccionRol_cb_roles";
            this.seleccionRol_cb_roles.Size = new System.Drawing.Size(190, 21);
            this.seleccionRol_cb_roles.TabIndex = 0;
            // 
            // seleccionRol_lab_roles
            // 
            this.seleccionRol_lab_roles.Location = new System.Drawing.Point(50, 69);
            this.seleccionRol_lab_roles.Name = "seleccionRol_lab_roles";
            this.seleccionRol_lab_roles.Size = new System.Drawing.Size(177, 38);
            this.seleccionRol_lab_roles.TabIndex = 1;
            this.seleccionRol_lab_roles.Text = "Por favor seleccione el rol con el cual quiere ingresar al sitio:";
            this.seleccionRol_lab_roles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.seleccionRol_lab_roles.Click += new System.EventHandler(this.seleccionRol_lab_roles_Click);
            // 
            // SeleccionRolLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.seleccionRol_lab_roles);
            this.Controls.Add(this.seleccionRol_cb_roles);
            this.Name = "SeleccionRolLogin";
            this.Text = "Seleccionar Rol";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox seleccionRol_cb_roles;
        private System.Windows.Forms.Label seleccionRol_lab_roles;
    }
}