namespace PagoAgilFrba.FrontEnd.AbmSucursal
{
    partial class Sucursal
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
            this.sucursal_tb_cp = new System.Windows.Forms.TextBox();
            this.sucursal_tb_direccion = new System.Windows.Forms.TextBox();
            this.sucursal_tb_nombre = new System.Windows.Forms.TextBox();
            this.sucursal_lab_cp = new System.Windows.Forms.Label();
            this.sucursal_lab_direccion = new System.Windows.Forms.Label();
            this.sucursal_lab_nombre = new System.Windows.Forms.Label();
            this.sucursal_but_baja = new System.Windows.Forms.Button();
            this.sucursal_but_modificar = new System.Windows.Forms.Button();
            this.sucursal_but_buscar = new System.Windows.Forms.Button();
            this.sucursal_but_alta = new System.Windows.Forms.Button();
            this.sucursales_dgv_listado = new System.Windows.Forms.DataGridView();
            this.NombreSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sucursales_dgv_listado)).BeginInit();
            this.SuspendLayout();
            // 
            // sucursal_tb_cp
            // 
            this.sucursal_tb_cp.Location = new System.Drawing.Point(225, 38);
            this.sucursal_tb_cp.Name = "sucursal_tb_cp";
            this.sucursal_tb_cp.Size = new System.Drawing.Size(53, 20);
            this.sucursal_tb_cp.TabIndex = 11;
            // 
            // sucursal_tb_direccion
            // 
            this.sucursal_tb_direccion.Location = new System.Drawing.Point(119, 38);
            this.sucursal_tb_direccion.Name = "sucursal_tb_direccion";
            this.sucursal_tb_direccion.Size = new System.Drawing.Size(100, 20);
            this.sucursal_tb_direccion.TabIndex = 10;
            // 
            // sucursal_tb_nombre
            // 
            this.sucursal_tb_nombre.Location = new System.Drawing.Point(15, 38);
            this.sucursal_tb_nombre.Name = "sucursal_tb_nombre";
            this.sucursal_tb_nombre.Size = new System.Drawing.Size(98, 20);
            this.sucursal_tb_nombre.TabIndex = 9;
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
            // sucursal_but_baja
            // 
            this.sucursal_but_baja.Location = new System.Drawing.Point(295, 158);
            this.sucursal_but_baja.Name = "sucursal_but_baja";
            this.sucursal_but_baja.Size = new System.Drawing.Size(75, 23);
            this.sucursal_but_baja.TabIndex = 43;
            this.sucursal_but_baja.Text = "Baja";
            this.sucursal_but_baja.UseVisualStyleBackColor = true;
            // 
            // sucursal_but_modificar
            // 
            this.sucursal_but_modificar.Location = new System.Drawing.Point(295, 120);
            this.sucursal_but_modificar.Name = "sucursal_but_modificar";
            this.sucursal_but_modificar.Size = new System.Drawing.Size(75, 23);
            this.sucursal_but_modificar.TabIndex = 42;
            this.sucursal_but_modificar.Text = "Modificar";
            this.sucursal_but_modificar.UseVisualStyleBackColor = true;
            // 
            // sucursal_but_buscar
            // 
            this.sucursal_but_buscar.Location = new System.Drawing.Point(295, 35);
            this.sucursal_but_buscar.Name = "sucursal_but_buscar";
            this.sucursal_but_buscar.Size = new System.Drawing.Size(75, 23);
            this.sucursal_but_buscar.TabIndex = 41;
            this.sucursal_but_buscar.Text = "Buscar";
            this.sucursal_but_buscar.UseVisualStyleBackColor = true;
            // 
            // sucursal_but_alta
            // 
            this.sucursal_but_alta.Location = new System.Drawing.Point(295, 82);
            this.sucursal_but_alta.Name = "sucursal_but_alta";
            this.sucursal_but_alta.Size = new System.Drawing.Size(75, 23);
            this.sucursal_but_alta.TabIndex = 40;
            this.sucursal_but_alta.Text = "Alta";
            this.sucursal_but_alta.UseVisualStyleBackColor = true;
            // 
            // sucursales_dgv_listado
            // 
            this.sucursales_dgv_listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sucursales_dgv_listado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreSucursal,
            this.Direccion,
            this.CodigoPostal});
            this.sucursales_dgv_listado.Location = new System.Drawing.Point(13, 65);
            this.sucursales_dgv_listado.Name = "sucursales_dgv_listado";
            this.sucursales_dgv_listado.Size = new System.Drawing.Size(265, 188);
            this.sucursales_dgv_listado.TabIndex = 44;
            this.sucursales_dgv_listado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sucursales_dgv_listado_CellContentClick);
            // 
            // NombreSucursal
            // 
            this.NombreSucursal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NombreSucursal.HeaderText = "Nombre";
            this.NombreSucursal.MinimumWidth = 4;
            this.NombreSucursal.Name = "NombreSucursal";
            this.NombreSucursal.Width = 69;
            // 
            // Direccion
            // 
            this.Direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            this.Direccion.Width = 77;
            // 
            // CodigoPostal
            // 
            this.CodigoPostal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CodigoPostal.HeaderText = "C.P.";
            this.CodigoPostal.Name = "CodigoPostal";
            this.CodigoPostal.Width = 52;
            // 
            // Sucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 265);
            this.Controls.Add(this.sucursales_dgv_listado);
            this.Controls.Add(this.sucursal_but_baja);
            this.Controls.Add(this.sucursal_but_modificar);
            this.Controls.Add(this.sucursal_but_buscar);
            this.Controls.Add(this.sucursal_but_alta);
            this.Controls.Add(this.sucursal_tb_cp);
            this.Controls.Add(this.sucursal_tb_direccion);
            this.Controls.Add(this.sucursal_tb_nombre);
            this.Controls.Add(this.sucursal_lab_cp);
            this.Controls.Add(this.sucursal_lab_direccion);
            this.Controls.Add(this.sucursal_lab_nombre);
            this.Name = "Sucursal";
            this.Text = "Sucursales";
            ((System.ComponentModel.ISupportInitialize)(this.sucursales_dgv_listado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sucursal_tb_cp;
        private System.Windows.Forms.TextBox sucursal_tb_direccion;
        private System.Windows.Forms.TextBox sucursal_tb_nombre;
        private System.Windows.Forms.Label sucursal_lab_cp;
        private System.Windows.Forms.Label sucursal_lab_direccion;
        private System.Windows.Forms.Label sucursal_lab_nombre;
        private System.Windows.Forms.Button sucursal_but_baja;
        private System.Windows.Forms.Button sucursal_but_modificar;
        private System.Windows.Forms.Button sucursal_but_buscar;
        private System.Windows.Forms.Button sucursal_but_alta;
        private System.Windows.Forms.DataGridView sucursales_dgv_listado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPostal;
    }
}