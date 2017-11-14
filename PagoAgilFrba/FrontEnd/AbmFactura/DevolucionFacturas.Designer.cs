namespace PagoAgilFrba.FrontEnd.ABMFactura
{
    partial class DevolucionFacturas
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
            this.registropago_tb_nrofac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cod_motivoDevolucion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFacturaSeleccionar = new System.Windows.Forms.Label();
            this.tbSucursal = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.dgv_listado_factura = new System.Windows.Forms.DataGridView();
            this.bttnDevolucion = new System.Windows.Forms.Button();
            this.bttn_agregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listado_factura)).BeginInit();
            this.SuspendLayout();
            // 
            // registropago_tb_nrofac
            // 
            this.registropago_tb_nrofac.Location = new System.Drawing.Point(-279, 45);
            this.registropago_tb_nrofac.Name = "registropago_tb_nrofac";
            this.registropago_tb_nrofac.Size = new System.Drawing.Size(68, 20);
            this.registropago_tb_nrofac.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-285, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 31);
            this.label1.TabIndex = 22;
            this.label1.Text = "Número factura:";
            // 
            // cod_motivoDevolucion
            // 
            this.cod_motivoDevolucion.FormattingEnabled = true;
            this.cod_motivoDevolucion.Location = new System.Drawing.Point(183, 159);
            this.cod_motivoDevolucion.Name = "cod_motivoDevolucion";
            this.cod_motivoDevolucion.Size = new System.Drawing.Size(197, 21);
            this.cod_motivoDevolucion.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "3) Seleccionar motivo devolucion:";
            // 
            // lblFacturaSeleccionar
            // 
            this.lblFacturaSeleccionar.AutoSize = true;
            this.lblFacturaSeleccionar.Location = new System.Drawing.Point(9, 51);
            this.lblFacturaSeleccionar.Name = "lblFacturaSeleccionar";
            this.lblFacturaSeleccionar.Size = new System.Drawing.Size(117, 13);
            this.lblFacturaSeleccionar.TabIndex = 45;
            this.lblFacturaSeleccionar.Text = "1) Seleccionar Factura:";
            // 
            // tbSucursal
            // 
            this.tbSucursal.Enabled = false;
            this.tbSucursal.Location = new System.Drawing.Point(227, 17);
            this.tbSucursal.Name = "tbSucursal";
            this.tbSucursal.Size = new System.Drawing.Size(184, 20);
            this.tbSucursal.TabIndex = 44;
            // 
            // tbUser
            // 
            this.tbUser.Enabled = false;
            this.tbUser.Location = new System.Drawing.Point(63, 17);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(100, 20);
            this.tbUser.TabIndex = 43;
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Location = new System.Drawing.Point(173, 20);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(51, 13);
            this.lblSucursal.TabIndex = 42;
            this.lblSucursal.Text = "Sucursal:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(14, 20);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(46, 13);
            this.lblUser.TabIndex = 41;
            this.lblUser.Text = "Usuario:";
            // 
            // dgv_listado_factura
            // 
            this.dgv_listado_factura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listado_factura.Enabled = false;
            this.dgv_listado_factura.Location = new System.Drawing.Point(12, 75);
            this.dgv_listado_factura.Name = "dgv_listado_factura";
            this.dgv_listado_factura.Size = new System.Drawing.Size(719, 70);
            this.dgv_listado_factura.TabIndex = 40;
            // 
            // bttnDevolucion
            // 
            this.bttnDevolucion.Location = new System.Drawing.Point(581, 183);
            this.bttnDevolucion.Name = "bttnDevolucion";
            this.bttnDevolucion.Size = new System.Drawing.Size(150, 23);
            this.bttnDevolucion.TabIndex = 39;
            this.bttnDevolucion.Text = "Procesar Devolucion";
            this.bttnDevolucion.UseVisualStyleBackColor = true;
            this.bttnDevolucion.Click += new System.EventHandler(this.bttnDevolucion_Click);
            // 
            // bttn_agregar
            // 
            this.bttn_agregar.Location = new System.Drawing.Point(132, 46);
            this.bttn_agregar.Name = "bttn_agregar";
            this.bttn_agregar.Size = new System.Drawing.Size(100, 23);
            this.bttn_agregar.TabIndex = 38;
            this.bttn_agregar.Text = "Agregar factura";
            this.bttn_agregar.UseVisualStyleBackColor = true;
            this.bttn_agregar.Click += new System.EventHandler(this.bttn_agregar_Click);
            // 
            // DevolucionFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 218);
            this.Controls.Add(this.cod_motivoDevolucion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFacturaSeleccionar);
            this.Controls.Add(this.tbSucursal);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.lblSucursal);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.dgv_listado_factura);
            this.Controls.Add(this.bttnDevolucion);
            this.Controls.Add(this.bttn_agregar);
            this.Controls.Add(this.registropago_tb_nrofac);
            this.Controls.Add(this.label1);
            this.Name = "DevolucionFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Devolucion de Factura Pagada";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listado_factura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox registropago_tb_nrofac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cod_motivoDevolucion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFacturaSeleccionar;
        private System.Windows.Forms.TextBox tbSucursal;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.DataGridView dgv_listado_factura;
        private System.Windows.Forms.Button bttnDevolucion;
        private System.Windows.Forms.Button bttn_agregar;

    }
}