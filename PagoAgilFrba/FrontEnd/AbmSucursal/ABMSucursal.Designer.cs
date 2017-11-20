namespace PagoAgilFrba.FrontEnd.AbmSucursal
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
            this.sucursal_nombre = new System.Windows.Forms.TextBox();
            this.sucursal_direccion = new System.Windows.Forms.TextBox();
            this.sucursal_codigo_postal = new System.Windows.Forms.TextBox();
            this.habilitado = new System.Windows.Forms.CheckBox();
            this.abmsucursal_but_aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // abmsucursal_lab_nombre
            // 
            this.abmsucursal_lab_nombre.AutoSize = true;
            this.abmsucursal_lab_nombre.Location = new System.Drawing.Point(22, 72);
            this.abmsucursal_lab_nombre.Name = "abmsucursal_lab_nombre";
            this.abmsucursal_lab_nombre.Size = new System.Drawing.Size(91, 13);
            this.abmsucursal_lab_nombre.TabIndex = 0;
            this.abmsucursal_lab_nombre.Text = "Nombre Sucursal:";
            // 
            // ambsucursal_lab_direccion
            // 
            this.ambsucursal_lab_direccion.AutoSize = true;
            this.ambsucursal_lab_direccion.Location = new System.Drawing.Point(22, 119);
            this.ambsucursal_lab_direccion.Name = "ambsucursal_lab_direccion";
            this.ambsucursal_lab_direccion.Size = new System.Drawing.Size(55, 13);
            this.ambsucursal_lab_direccion.TabIndex = 1;
            this.ambsucursal_lab_direccion.Text = "Dirección:";
            this.ambsucursal_lab_direccion.Click += new System.EventHandler(this.label1_Click);
            // 
            // abmsucursal_lab_cp
            // 
            this.abmsucursal_lab_cp.AutoSize = true;
            this.abmsucursal_lab_cp.Location = new System.Drawing.Point(22, 21);
            this.abmsucursal_lab_cp.Name = "abmsucursal_lab_cp";
            this.abmsucursal_lab_cp.Size = new System.Drawing.Size(75, 13);
            this.abmsucursal_lab_cp.TabIndex = 2;
            this.abmsucursal_lab_cp.Text = "Código Postal:";
            // 
            // sucursal_nombre
            // 
            this.sucursal_nombre.Location = new System.Drawing.Point(25, 89);
            this.sucursal_nombre.Name = "sucursal_nombre";
            this.sucursal_nombre.Size = new System.Drawing.Size(247, 20);
            this.sucursal_nombre.TabIndex = 3;
            // 
            // sucursal_direccion
            // 
            this.sucursal_direccion.Location = new System.Drawing.Point(25, 138);
            this.sucursal_direccion.Name = "sucursal_direccion";
            this.sucursal_direccion.Size = new System.Drawing.Size(247, 20);
            this.sucursal_direccion.TabIndex = 4;
            // 
            // sucursal_codigo_postal
            // 
            this.sucursal_codigo_postal.Location = new System.Drawing.Point(25, 37);
            this.sucursal_codigo_postal.Name = "sucursal_codigo_postal";
            this.sucursal_codigo_postal.Size = new System.Drawing.Size(100, 20);
            this.sucursal_codigo_postal.TabIndex = 5;
            // 
            // habilitado
            // 
            this.habilitado.AutoSize = true;
            this.habilitado.Checked = true;
            this.habilitado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.habilitado.Location = new System.Drawing.Point(25, 187);
            this.habilitado.Name = "habilitado";
            this.habilitado.Size = new System.Drawing.Size(73, 17);
            this.habilitado.TabIndex = 10;
            this.habilitado.Text = "Habilitada";
            this.habilitado.UseVisualStyleBackColor = true;
            // 
            // abmsucursal_but_aceptar
            // 
            this.abmsucursal_but_aceptar.Location = new System.Drawing.Point(25, 220);
            this.abmsucursal_but_aceptar.Name = "abmsucursal_but_aceptar";
            this.abmsucursal_but_aceptar.Size = new System.Drawing.Size(75, 23);
            this.abmsucursal_but_aceptar.TabIndex = 11;
            this.abmsucursal_but_aceptar.Text = "Guardar";
            this.abmsucursal_but_aceptar.UseVisualStyleBackColor = true;
            this.abmsucursal_but_aceptar.Click += new System.EventHandler(this.abmsucursal_but_aceptar_Click);
            // 
            // ABMSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.abmsucursal_but_aceptar);
            this.Controls.Add(this.habilitado);
            this.Controls.Add(this.sucursal_codigo_postal);
            this.Controls.Add(this.sucursal_direccion);
            this.Controls.Add(this.sucursal_nombre);
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
        private System.Windows.Forms.TextBox sucursal_nombre;
        private System.Windows.Forms.TextBox sucursal_direccion;
        private System.Windows.Forms.TextBox sucursal_codigo_postal;
        private System.Windows.Forms.CheckBox habilitado;
        private System.Windows.Forms.Button abmsucursal_but_aceptar;
    }
}