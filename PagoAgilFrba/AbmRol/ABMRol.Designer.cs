namespace PagoAgilFrba.AbmRol
{
    partial class ABMRol
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
            this.abmrol_cb_funcionalidades = new System.Windows.Forms.ComboBox();
            this.abmrol_lab_funcionalidades = new System.Windows.Forms.Label();
            this.abmrol_lab_nombre = new System.Windows.Forms.Label();
            this.abmrol_tb_nombre = new System.Windows.Forms.TextBox();
            this.abmrol_chb_inhabilitar = new System.Windows.Forms.CheckBox();
            this.abmrol_but_aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // abmrol_cb_funcionalidades
            // 
            this.abmrol_cb_funcionalidades.FormattingEnabled = true;
            this.abmrol_cb_funcionalidades.Location = new System.Drawing.Point(154, 52);
            this.abmrol_cb_funcionalidades.Name = "abmrol_cb_funcionalidades";
            this.abmrol_cb_funcionalidades.Size = new System.Drawing.Size(121, 21);
            this.abmrol_cb_funcionalidades.TabIndex = 0;
            // 
            // abmrol_lab_funcionalidades
            // 
            this.abmrol_lab_funcionalidades.AutoSize = true;
            this.abmrol_lab_funcionalidades.Location = new System.Drawing.Point(154, 33);
            this.abmrol_lab_funcionalidades.Name = "abmrol_lab_funcionalidades";
            this.abmrol_lab_funcionalidades.Size = new System.Drawing.Size(87, 13);
            this.abmrol_lab_funcionalidades.TabIndex = 1;
            this.abmrol_lab_funcionalidades.Text = "Funcionalidades:";
            // 
            // abmrol_lab_nombre
            // 
            this.abmrol_lab_nombre.AutoSize = true;
            this.abmrol_lab_nombre.Location = new System.Drawing.Point(13, 32);
            this.abmrol_lab_nombre.Name = "abmrol_lab_nombre";
            this.abmrol_lab_nombre.Size = new System.Drawing.Size(61, 13);
            this.abmrol_lab_nombre.TabIndex = 2;
            this.abmrol_lab_nombre.Text = "Nombre rol:";
            // 
            // abmrol_tb_nombre
            // 
            this.abmrol_tb_nombre.Location = new System.Drawing.Point(16, 52);
            this.abmrol_tb_nombre.Name = "abmrol_tb_nombre";
            this.abmrol_tb_nombre.Size = new System.Drawing.Size(100, 20);
            this.abmrol_tb_nombre.TabIndex = 3;
            // 
            // abmrol_chb_inhabilitar
            // 
            this.abmrol_chb_inhabilitar.AutoSize = true;
            this.abmrol_chb_inhabilitar.Location = new System.Drawing.Point(16, 128);
            this.abmrol_chb_inhabilitar.Name = "abmrol_chb_inhabilitar";
            this.abmrol_chb_inhabilitar.Size = new System.Drawing.Size(71, 17);
            this.abmrol_chb_inhabilitar.TabIndex = 4;
            this.abmrol_chb_inhabilitar.Text = "Inhabilitar";
            this.abmrol_chb_inhabilitar.UseVisualStyleBackColor = true;
            // 
            // abmrol_but_aceptar
            // 
            this.abmrol_but_aceptar.Location = new System.Drawing.Point(16, 226);
            this.abmrol_but_aceptar.Name = "abmrol_but_aceptar";
            this.abmrol_but_aceptar.Size = new System.Drawing.Size(75, 23);
            this.abmrol_but_aceptar.TabIndex = 5;
            this.abmrol_but_aceptar.Text = "Aceptar";
            this.abmrol_but_aceptar.UseVisualStyleBackColor = true;
            // 
            // ABMRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.abmrol_but_aceptar);
            this.Controls.Add(this.abmrol_chb_inhabilitar);
            this.Controls.Add(this.abmrol_tb_nombre);
            this.Controls.Add(this.abmrol_lab_nombre);
            this.Controls.Add(this.abmrol_lab_funcionalidades);
            this.Controls.Add(this.abmrol_cb_funcionalidades);
            this.Name = "ABMRol";
            this.Text = "ABM Rol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox abmrol_cb_funcionalidades;
        private System.Windows.Forms.Label abmrol_lab_funcionalidades;
        private System.Windows.Forms.Label abmrol_lab_nombre;
        private System.Windows.Forms.TextBox abmrol_tb_nombre;
        private System.Windows.Forms.CheckBox abmrol_chb_inhabilitar;
        private System.Windows.Forms.Button abmrol_but_aceptar;
    }
}