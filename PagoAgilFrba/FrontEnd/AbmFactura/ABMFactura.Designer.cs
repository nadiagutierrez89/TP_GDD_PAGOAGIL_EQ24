namespace PagoAgilFrba.FrontEnd.ABMFactura
{
    partial class ABMFactura
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
            this.abmcliente_lab_cliente = new System.Windows.Forms.Label();
            this.abmfactura_lab_nrofactura = new System.Windows.Forms.Label();
            this.ambfactura_lab_fechaalta = new System.Windows.Forms.Label();
            this.abmempresa_lab_fechavto = new System.Windows.Forms.Label();
            this.abmfactura_lab_total = new System.Windows.Forms.Label();
            this.tbCliente = new System.Windows.Forms.TextBox();
            this.abmfactura_lab_empresa = new System.Windows.Forms.Label();
            this.cod_empresa = new System.Windows.Forms.ComboBox();
            this.nro_factura = new System.Windows.Forms.TextBox();
            this.importe_total_fac = new System.Windows.Forms.TextBox();
            this.abmfactura_but_aceptar = new System.Windows.Forms.Button();
            this.fecha_alta_fac = new System.Windows.Forms.DateTimePicker();
            this.fecha_vto_fac = new System.Windows.Forms.DateTimePicker();
            this.dgvFacturaItems = new System.Windows.Forms.DataGridView();
            this.bttnSeleccionar = new System.Windows.Forms.Button();
            this.bttnQuitar = new System.Windows.Forms.Button();
            this.bttnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturaItems)).BeginInit();
            this.SuspendLayout();
            // 
            // abmcliente_lab_cliente
            // 
            this.abmcliente_lab_cliente.AutoSize = true;
            this.abmcliente_lab_cliente.Location = new System.Drawing.Point(16, 53);
            this.abmcliente_lab_cliente.Name = "abmcliente_lab_cliente";
            this.abmcliente_lab_cliente.Size = new System.Drawing.Size(42, 13);
            this.abmcliente_lab_cliente.TabIndex = 0;
            this.abmcliente_lab_cliente.Text = "Cliente:";
            // 
            // abmfactura_lab_nrofactura
            // 
            this.abmfactura_lab_nrofactura.AutoSize = true;
            this.abmfactura_lab_nrofactura.Location = new System.Drawing.Point(13, 96);
            this.abmfactura_lab_nrofactura.Name = "abmfactura_lab_nrofactura";
            this.abmfactura_lab_nrofactura.Size = new System.Drawing.Size(86, 13);
            this.abmfactura_lab_nrofactura.TabIndex = 2;
            this.abmfactura_lab_nrofactura.Text = "Número Factura:";
            // 
            // ambfactura_lab_fechaalta
            // 
            this.ambfactura_lab_fechaalta.AutoSize = true;
            this.ambfactura_lab_fechaalta.Location = new System.Drawing.Point(13, 137);
            this.ambfactura_lab_fechaalta.Name = "ambfactura_lab_fechaalta";
            this.ambfactura_lab_fechaalta.Size = new System.Drawing.Size(61, 13);
            this.ambfactura_lab_fechaalta.TabIndex = 3;
            this.ambfactura_lab_fechaalta.Text = "Fecha Alta:";
            // 
            // abmempresa_lab_fechavto
            // 
            this.abmempresa_lab_fechavto.AutoSize = true;
            this.abmempresa_lab_fechavto.Location = new System.Drawing.Point(13, 179);
            this.abmempresa_lab_fechavto.Name = "abmempresa_lab_fechavto";
            this.abmempresa_lab_fechavto.Size = new System.Drawing.Size(101, 13);
            this.abmempresa_lab_fechavto.TabIndex = 4;
            this.abmempresa_lab_fechavto.Text = "Fecha Vencimiento:";
            // 
            // abmfactura_lab_total
            // 
            this.abmfactura_lab_total.AutoSize = true;
            this.abmfactura_lab_total.Location = new System.Drawing.Point(156, 423);
            this.abmfactura_lab_total.Name = "abmfactura_lab_total";
            this.abmfactura_lab_total.Size = new System.Drawing.Size(34, 13);
            this.abmfactura_lab_total.TabIndex = 5;
            this.abmfactura_lab_total.Text = "Total:";
            // 
            // tbCliente
            // 
            this.tbCliente.Enabled = false;
            this.tbCliente.Location = new System.Drawing.Point(16, 70);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.Size = new System.Drawing.Size(204, 20);
            this.tbCliente.TabIndex = 9;
            // 
            // abmfactura_lab_empresa
            // 
            this.abmfactura_lab_empresa.AutoSize = true;
            this.abmfactura_lab_empresa.Location = new System.Drawing.Point(13, 12);
            this.abmfactura_lab_empresa.Name = "abmfactura_lab_empresa";
            this.abmfactura_lab_empresa.Size = new System.Drawing.Size(51, 13);
            this.abmfactura_lab_empresa.TabIndex = 1;
            this.abmfactura_lab_empresa.Text = "Empresa:";
            // 
            // cod_empresa
            // 
            this.cod_empresa.FormattingEnabled = true;
            this.cod_empresa.Location = new System.Drawing.Point(16, 28);
            this.cod_empresa.Name = "cod_empresa";
            this.cod_empresa.Size = new System.Drawing.Size(121, 21);
            this.cod_empresa.TabIndex = 10;
            // 
            // nro_factura
            // 
            this.nro_factura.Location = new System.Drawing.Point(13, 111);
            this.nro_factura.Name = "nro_factura";
            this.nro_factura.Size = new System.Drawing.Size(139, 20);
            this.nro_factura.TabIndex = 11;
            // 
            // importe_total_fac
            // 
            this.importe_total_fac.Enabled = false;
            this.importe_total_fac.Location = new System.Drawing.Point(196, 420);
            this.importe_total_fac.Name = "importe_total_fac";
            this.importe_total_fac.Size = new System.Drawing.Size(100, 20);
            this.importe_total_fac.TabIndex = 14;
            // 
            // abmfactura_but_aceptar
            // 
            this.abmfactura_but_aceptar.Location = new System.Drawing.Point(123, 455);
            this.abmfactura_but_aceptar.Name = "abmfactura_but_aceptar";
            this.abmfactura_but_aceptar.Size = new System.Drawing.Size(75, 23);
            this.abmfactura_but_aceptar.TabIndex = 18;
            this.abmfactura_but_aceptar.Text = "Guardar";
            this.abmfactura_but_aceptar.UseVisualStyleBackColor = true;
            this.abmfactura_but_aceptar.Click += new System.EventHandler(this.abmfactura_but_aceptar_Click);
            // 
            // fecha_alta_fac
            // 
            this.fecha_alta_fac.Location = new System.Drawing.Point(13, 154);
            this.fecha_alta_fac.Name = "fecha_alta_fac";
            this.fecha_alta_fac.Size = new System.Drawing.Size(200, 20);
            this.fecha_alta_fac.TabIndex = 19;
            // 
            // fecha_vto_fac
            // 
            this.fecha_vto_fac.Location = new System.Drawing.Point(13, 196);
            this.fecha_vto_fac.Name = "fecha_vto_fac";
            this.fecha_vto_fac.Size = new System.Drawing.Size(200, 20);
            this.fecha_vto_fac.TabIndex = 20;
            // 
            // dgvFacturaItems
            // 
            this.dgvFacturaItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturaItems.Location = new System.Drawing.Point(16, 264);
            this.dgvFacturaItems.Name = "dgvFacturaItems";
            this.dgvFacturaItems.ReadOnly = true;
            this.dgvFacturaItems.Size = new System.Drawing.Size(280, 150);
            this.dgvFacturaItems.TabIndex = 21;
            // 
            // bttnSeleccionar
            // 
            this.bttnSeleccionar.Location = new System.Drawing.Point(226, 69);
            this.bttnSeleccionar.Name = "bttnSeleccionar";
            this.bttnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.bttnSeleccionar.TabIndex = 22;
            this.bttnSeleccionar.Text = "Seleccionar";
            this.bttnSeleccionar.UseVisualStyleBackColor = true;
            this.bttnSeleccionar.Click += new System.EventHandler(this.bttnSeleccionar_Click);
            // 
            // bttnQuitar
            // 
            this.bttnQuitar.Location = new System.Drawing.Point(138, 235);
            this.bttnQuitar.Name = "bttnQuitar";
            this.bttnQuitar.Size = new System.Drawing.Size(75, 23);
            this.bttnQuitar.TabIndex = 23;
            this.bttnQuitar.Text = "Quitar Item";
            this.bttnQuitar.UseVisualStyleBackColor = true;
            this.bttnQuitar.Click += new System.EventHandler(this.bttnQuitar_Click);
            // 
            // bttnAgregar
            // 
            this.bttnAgregar.Location = new System.Drawing.Point(221, 235);
            this.bttnAgregar.Name = "bttnAgregar";
            this.bttnAgregar.Size = new System.Drawing.Size(75, 23);
            this.bttnAgregar.TabIndex = 24;
            this.bttnAgregar.Text = "Agregar Item";
            this.bttnAgregar.UseVisualStyleBackColor = true;
            this.bttnAgregar.Click += new System.EventHandler(this.bttnAgregar_Click);
            // 
            // ABMFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 490);
            this.Controls.Add(this.bttnAgregar);
            this.Controls.Add(this.bttnQuitar);
            this.Controls.Add(this.bttnSeleccionar);
            this.Controls.Add(this.dgvFacturaItems);
            this.Controls.Add(this.fecha_vto_fac);
            this.Controls.Add(this.fecha_alta_fac);
            this.Controls.Add(this.abmfactura_but_aceptar);
            this.Controls.Add(this.importe_total_fac);
            this.Controls.Add(this.nro_factura);
            this.Controls.Add(this.cod_empresa);
            this.Controls.Add(this.tbCliente);
            this.Controls.Add(this.abmfactura_lab_total);
            this.Controls.Add(this.abmempresa_lab_fechavto);
            this.Controls.Add(this.ambfactura_lab_fechaalta);
            this.Controls.Add(this.abmfactura_lab_nrofactura);
            this.Controls.Add(this.abmfactura_lab_empresa);
            this.Controls.Add(this.abmcliente_lab_cliente);
            this.Name = "ABMFactura";
            this.Text = "ABM Factura";
            this.Load += new System.EventHandler(this.abmfactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturaItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label abmcliente_lab_cliente;
        private System.Windows.Forms.Label abmfactura_lab_nrofactura;
        private System.Windows.Forms.Label ambfactura_lab_fechaalta;
        private System.Windows.Forms.Label abmempresa_lab_fechavto;
        private System.Windows.Forms.Label abmfactura_lab_total;
        private System.Windows.Forms.TextBox tbCliente;
        private System.Windows.Forms.Label abmfactura_lab_empresa;
        private System.Windows.Forms.ComboBox cod_empresa;
        private System.Windows.Forms.TextBox nro_factura;
        private System.Windows.Forms.TextBox importe_total_fac;
        private System.Windows.Forms.Button abmfactura_but_aceptar;
        private System.Windows.Forms.DateTimePicker fecha_alta_fac;
        private System.Windows.Forms.DateTimePicker fecha_vto_fac;
        private System.Windows.Forms.DataGridView dgvFacturaItems;
        private System.Windows.Forms.Button bttnSeleccionar;
        private System.Windows.Forms.Button bttnQuitar;
        private System.Windows.Forms.Button bttnAgregar;
    }
}