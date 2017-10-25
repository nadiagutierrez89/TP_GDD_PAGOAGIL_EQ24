namespace PagoAgilFrba.AbmSucursal
{
    partial class ABMSucursal
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
            this.abmsucursal_lab_nombre = new System.Windows.Forms.Label();
            this.ambsucursal_lab_direccion = new System.Windows.Forms.Label();
            this.abmsucursal_lab_cp = new System.Windows.Forms.Label();
            this.abmsucursal_tb_nombre = new System.Windows.Forms.TextBox();
            this.abmsucursal_tb_direccion = new System.Windows.Forms.TextBox();
            this.abmsucursal_tb_cp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // abmsucursal_lab_nombre
            // 
            this.abmsucursal_lab_nombre.AutoSize = true;
            this.abmsucursal_lab_nombre.Location = new System.Drawing.Point(22, 26);
            this.abmsucursal_lab_nombre.Name = "abmsucursal_lab_nombre";
            this.abmsucursal_lab_nombre.Size = new System.Drawing.Size(91, 13);
            this.abmsucursal_lab_nombre.TabIndex = 0;
            this.abmsucursal_lab_nombre.Text = "Nombre Sucursal:";
            // 
            // ambsucursal_lab_direccion
            // 
            this.ambsucursal_lab_direccion.AutoSize = true;
            this.ambsucursal_lab_direccion.Location = new System.Drawing.Point(22, 73);
            this.ambsucursal_lab_direccion.Name = "ambsucursal_lab_direccion";
            this.ambsucursal_lab_direccion.Size = new System.Drawing.Size(55, 13);
            this.ambsucursal_lab_direccion.TabIndex = 1;
            this.ambsucursal_lab_direccion.Text = "Dirección:";
            this.ambsucursal_lab_direccion.Click += new System.EventHandler(this.label1_Click);
            // 
            // abmsucursal_lab_cp
            // 
            this.abmsucursal_lab_cp.AutoSize = true;
            this.abmsucursal_lab_cp.Location = new System.Drawing.Point(22, 131);
            this.abmsucursal_lab_cp.Name = "abmsucursal_lab_cp";
            this.abmsucursal_lab_cp.Size = new System.Drawing.Size(75, 13);
            this.abmsucursal_lab_cp.TabIndex = 2;
            this.abmsucursal_lab_cp.Text = "Código Postal:";
            // 
            // abmsucursal_tb_nombre
            // 
            this.abmsucursal_tb_nombre.Location = new System.Drawing.Point(25, 43);
            this.abmsucursal_tb_nombre.Name = "abmsucursal_tb_nombre";
            this.abmsucursal_tb_nombre.Size = new System.Drawing.Size(247, 20);
            this.abmsucursal_tb_nombre.TabIndex = 3;
            // 
            // abmsucursal_tb_direccion
            // 
            this.abmsucursal_tb_direccion.Location = new System.Drawing.Point(25, 92);
            this.abmsucursal_tb_direccion.Name = "abmsucursal_tb_direccion";
            this.abmsucursal_tb_direccion.Size = new System.Drawing.Size(247, 20);
            this.abmsucursal_tb_direccion.TabIndex = 4;
            // 
            // abmsucursal_tb_cp
            // 
            this.abmsucursal_tb_cp.Location = new System.Drawing.Point(25, 148);
            this.abmsucursal_tb_cp.Name = "abmsucursal_tb_cp";
            this.abmsucursal_tb_cp.Size = new System.Drawing.Size(100, 20);
            this.abmsucursal_tb_cp.TabIndex = 5;
            // 
            // ABMSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.abmsucursal_tb_cp);
            this.Controls.Add(this.abmsucursal_tb_direccion);
            this.Controls.Add(this.abmsucursal_tb_nombre);
            this.Controls.Add(this.abmsucursal_lab_cp);
            this.Controls.Add(this.ambsucursal_lab_direccion);
            this.Controls.Add(this.abmsucursal_lab_nombre);
            this.Name = "ABMSucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ABM Sucursal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label abmsucursal_lab_nombre;
        private System.Windows.Forms.Label ambsucursal_lab_direccion;
        private System.Windows.Forms.Label abmsucursal_lab_cp;
        private System.Windows.Forms.TextBox abmsucursal_tb_nombre;
        private System.Windows.Forms.TextBox abmsucursal_tb_direccion;
        private System.Windows.Forms.TextBox abmsucursal_tb_cp;
    }
}