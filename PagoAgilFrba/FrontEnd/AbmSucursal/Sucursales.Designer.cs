namespace PagoAgilFrba.FrontEnd.AbmSucursal
{
    partial class Sucursales
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
            this.codigo_postal_suc = new System.Windows.Forms.TextBox();
            this.direccion_suc = new System.Windows.Forms.TextBox();
            this.nombre_suc = new System.Windows.Forms.TextBox();
            this.sucursal_lab_cp = new System.Windows.Forms.Label();
            this.sucursal_lab_direccion = new System.Windows.Forms.Label();
            this.sucursal_lab_nombre = new System.Windows.Forms.Label();
            this.sucursal_but_modificar = new System.Windows.Forms.Button();
            this.sucursal_but_buscar = new System.Windows.Forms.Button();
            this.sucursal_but_alta = new System.Windows.Forms.Button();
            this.sucursales_dgv_listado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.sucursales_dgv_listado)).BeginInit();
            this.SuspendLayout();
            // 
            // codigo_postal_suc
            // 
            this.codigo_postal_suc.Location = new System.Drawing.Point(225, 38);
            this.codigo_postal_suc.Name = "codigo_postal_suc";
            this.codigo_postal_suc.Size = new System.Drawing.Size(53, 20);
            this.codigo_postal_suc.TabIndex = 11;
            // 
            // direccion_suc
            // 
            this.direccion_suc.Location = new System.Drawing.Point(119, 38);
            this.direccion_suc.Name = "direccion_suc";
            this.direccion_suc.Size = new System.Drawing.Size(100, 20);
            this.direccion_suc.TabIndex = 10;
            // 
            // nombre_suc
            // 
            this.nombre_suc.Location = new System.Drawing.Point(15, 38);
            this.nombre_suc.Name = "nombre_suc";
            this.nombre_suc.Size = new System.Drawing.Size(98, 20);
            this.nombre_suc.TabIndex = 9;
            // 
            // sucursal_lab_cp
            // 
            this.sucursal_lab_cp.Location = new System.Drawing.Point(222, 9);
            this.sucursal_lab_cp.Name = "sucursal_lab_cp";
            this.sucursal_lab_cp.Size = new System.Drawing.Size(56, 26);
            this.sucursal_lab_cp.TabIndex = 8;
            this.sucursal_lab_cp.Text = "Código Postal:";
            // 
            // sucursal_lab_direccion
            // 
            this.sucursal_lab_direccion.AutoSize = true;
            this.sucursal_lab_direccion.Location = new System.Drawing.Point(116, 22);
            this.sucursal_lab_direccion.Name = "sucursal_lab_direccion";
            this.sucursal_lab_direccion.Size = new System.Drawing.Size(55, 13);
            this.sucursal_lab_direccion.TabIndex = 7;
            this.sucursal_lab_direccion.Text = "Dirección:";
            // 
            // sucursal_lab_nombre
            // 
            this.sucursal_lab_nombre.Location = new System.Drawing.Point(13, 9);
            this.sucursal_lab_nombre.Name = "sucursal_lab_nombre";
            this.sucursal_lab_nombre.Size = new System.Drawing.Size(86, 26);
            this.sucursal_lab_nombre.TabIndex = 6;
            this.sucursal_lab_nombre.Text = "Nombre Sucursal:";
            // 
            // sucursal_but_modificar
            // 
            this.sucursal_but_modificar.Location = new System.Drawing.Point(409, 221);
            this.sucursal_but_modificar.Name = "sucursal_but_modificar";
            this.sucursal_but_modificar.Size = new System.Drawing.Size(75, 23);
            this.sucursal_but_modificar.TabIndex = 42;
            this.sucursal_but_modificar.Text = "Modificar";
            this.sucursal_but_modificar.UseVisualStyleBackColor = true;
            this.sucursal_but_modificar.Click += new System.EventHandler(this.sucursal_but_modificar_Click);
            // 
            // sucursal_but_buscar
            // 
            this.sucursal_but_buscar.Location = new System.Drawing.Point(295, 35);
            this.sucursal_but_buscar.Name = "sucursal_but_buscar";
            this.sucursal_but_buscar.Size = new System.Drawing.Size(75, 23);
            this.sucursal_but_buscar.TabIndex = 41;
            this.sucursal_but_buscar.Text = "Buscar";
            this.sucursal_but_buscar.UseVisualStyleBackColor = true;
            this.sucursal_but_buscar.Click += new System.EventHandler(this.sucursal_but_buscar_Click);
            // 
            // sucursal_but_alta
            // 
            this.sucursal_but_alta.Location = new System.Drawing.Point(328, 221);
            this.sucursal_but_alta.Name = "sucursal_but_alta";
            this.sucursal_but_alta.Size = new System.Drawing.Size(75, 23);
            this.sucursal_but_alta.TabIndex = 40;
            this.sucursal_but_alta.Text = "Alta";
            this.sucursal_but_alta.UseVisualStyleBackColor = true;
            this.sucursal_but_alta.Click += new System.EventHandler(this.sucursal_but_alta_Click);
            // 
            // sucursales_dgv_listado
            // 
            this.sucursales_dgv_listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sucursales_dgv_listado.Location = new System.Drawing.Point(15, 65);
            this.sucursales_dgv_listado.Name = "sucursales_dgv_listado";
            this.sucursales_dgv_listado.Size = new System.Drawing.Size(468, 150);
            this.sucursales_dgv_listado.TabIndex = 44;
            // 
            // Sucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 265);
            this.Controls.Add(this.sucursales_dgv_listado);
            this.Controls.Add(this.sucursal_but_modificar);
            this.Controls.Add(this.sucursal_but_buscar);
            this.Controls.Add(this.sucursal_but_alta);
            this.Controls.Add(this.codigo_postal_suc);
            this.Controls.Add(this.direccion_suc);
            this.Controls.Add(this.nombre_suc);
            this.Controls.Add(this.sucursal_lab_cp);
            this.Controls.Add(this.sucursal_lab_direccion);
            this.Controls.Add(this.sucursal_lab_nombre);
            this.Name = "Sucursales";
            this.Text = "Sucursales";
            ((System.ComponentModel.ISupportInitialize)(this.sucursales_dgv_listado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codigo_postal_suc;
        private System.Windows.Forms.TextBox direccion_suc;
        private System.Windows.Forms.TextBox nombre_suc;
        private System.Windows.Forms.Label sucursal_lab_cp;
        private System.Windows.Forms.Label sucursal_lab_direccion;
        private System.Windows.Forms.Label sucursal_lab_nombre;
        private System.Windows.Forms.Button sucursal_but_modificar;
        private System.Windows.Forms.Button sucursal_but_buscar;
        private System.Windows.Forms.Button sucursal_but_alta;
        private System.Windows.Forms.DataGridView sucursales_dgv_listado;
    }
}