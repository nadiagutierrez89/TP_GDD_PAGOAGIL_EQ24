namespace PagoAgilFrba.FrontEnd.AbmFactura
{
    partial class abmfactura
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
            this.abmfactura_lab_items = new System.Windows.Forms.Label();
            this.abmfactura_lab_monto = new System.Windows.Forms.Label();
            this.abmfactura_lab_cantidad = new System.Windows.Forms.Label();
            this.ambfactura_tb_dni = new System.Windows.Forms.TextBox();
            this.abmfactura_lab_empresa = new System.Windows.Forms.Label();
            this.abmfactura_tb_empresa = new System.Windows.Forms.ComboBox();
            this.ambfactura_tb_nrofac = new System.Windows.Forms.TextBox();
            this.abmfactura_mtb_fecalta = new System.Windows.Forms.MaskedTextBox();
            this.abmfactura_mtb_fecvto = new System.Windows.Forms.MaskedTextBox();
            this.abmfactura_tb_total = new System.Windows.Forms.TextBox();
            this.abmfactura_tb_items = new System.Windows.Forms.TextBox();
            this.abmfactura_tb_monto = new System.Windows.Forms.TextBox();
            this.abmfactura_tb_cantidad = new System.Windows.Forms.TextBox();
            this.abmfactura_but_aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // abmcliente_lab_cliente
            // 
            this.abmcliente_lab_cliente.AutoSize = true;
            this.abmcliente_lab_cliente.Location = new System.Drawing.Point(13, 25);
            this.abmcliente_lab_cliente.Name = "abmcliente_lab_cliente";
            this.abmcliente_lab_cliente.Size = new System.Drawing.Size(64, 13);
            this.abmcliente_lab_cliente.TabIndex = 0;
            this.abmcliente_lab_cliente.Text = "DNI Cliente:";
            // 
            // abmfactura_lab_nrofactura
            // 
            this.abmfactura_lab_nrofactura.AutoSize = true;
            this.abmfactura_lab_nrofactura.Location = new System.Drawing.Point(13, 70);
            this.abmfactura_lab_nrofactura.Name = "abmfactura_lab_nrofactura";
            this.abmfactura_lab_nrofactura.Size = new System.Drawing.Size(86, 13);
            this.abmfactura_lab_nrofactura.TabIndex = 2;
            this.abmfactura_lab_nrofactura.Text = "Número Factura:";
            // 
            // ambfactura_lab_fechaalta
            // 
            this.ambfactura_lab_fechaalta.AutoSize = true;
            this.ambfactura_lab_fechaalta.Location = new System.Drawing.Point(13, 111);
            this.ambfactura_lab_fechaalta.Name = "ambfactura_lab_fechaalta";
            this.ambfactura_lab_fechaalta.Size = new System.Drawing.Size(61, 13);
            this.ambfactura_lab_fechaalta.TabIndex = 3;
            this.ambfactura_lab_fechaalta.Text = "Fecha Alta:";
            // 
            // abmempresa_lab_fechavto
            // 
            this.abmempresa_lab_fechavto.AutoSize = true;
            this.abmempresa_lab_fechavto.Location = new System.Drawing.Point(13, 153);
            this.abmempresa_lab_fechavto.Name = "abmempresa_lab_fechavto";
            this.abmempresa_lab_fechavto.Size = new System.Drawing.Size(101, 13);
            this.abmempresa_lab_fechavto.TabIndex = 4;
            this.abmempresa_lab_fechavto.Text = "Fecha Vencimiento:";
            // 
            // abmfactura_lab_total
            // 
            this.abmfactura_lab_total.AutoSize = true;
            this.abmfactura_lab_total.Location = new System.Drawing.Point(13, 193);
            this.abmfactura_lab_total.Name = "abmfactura_lab_total";
            this.abmfactura_lab_total.Size = new System.Drawing.Size(34, 13);
            this.abmfactura_lab_total.TabIndex = 5;
            this.abmfactura_lab_total.Text = "Total:";
            // 
            // abmfactura_lab_items
            // 
            this.abmfactura_lab_items.AutoSize = true;
            this.abmfactura_lab_items.Location = new System.Drawing.Point(13, 232);
            this.abmfactura_lab_items.Name = "abmfactura_lab_items";
            this.abmfactura_lab_items.Size = new System.Drawing.Size(35, 13);
            this.abmfactura_lab_items.TabIndex = 6;
            this.abmfactura_lab_items.Text = "Items:";
            // 
            // abmfactura_lab_monto
            // 
            this.abmfactura_lab_monto.AutoSize = true;
            this.abmfactura_lab_monto.Location = new System.Drawing.Point(74, 233);
            this.abmfactura_lab_monto.Name = "abmfactura_lab_monto";
            this.abmfactura_lab_monto.Size = new System.Drawing.Size(40, 13);
            this.abmfactura_lab_monto.TabIndex = 7;
            this.abmfactura_lab_monto.Text = "Monto:";
            this.abmfactura_lab_monto.Click += new System.EventHandler(this.abmfactura_lab_monto_Click);
            // 
            // abmfactura_lab_cantidad
            // 
            this.abmfactura_lab_cantidad.AutoSize = true;
            this.abmfactura_lab_cantidad.Location = new System.Drawing.Point(143, 233);
            this.abmfactura_lab_cantidad.Name = "abmfactura_lab_cantidad";
            this.abmfactura_lab_cantidad.Size = new System.Drawing.Size(52, 13);
            this.abmfactura_lab_cantidad.TabIndex = 8;
            this.abmfactura_lab_cantidad.Text = "Cantidad:";
            // 
            // ambfactura_tb_dni
            // 
            this.ambfactura_tb_dni.Location = new System.Drawing.Point(13, 42);
            this.ambfactura_tb_dni.Name = "ambfactura_tb_dni";
            this.ambfactura_tb_dni.Size = new System.Drawing.Size(100, 20);
            this.ambfactura_tb_dni.TabIndex = 9;
            // 
            // abmfactura_lab_empresa
            // 
            this.abmfactura_lab_empresa.AutoSize = true;
            this.abmfactura_lab_empresa.Location = new System.Drawing.Point(119, 25);
            this.abmfactura_lab_empresa.Name = "abmfactura_lab_empresa";
            this.abmfactura_lab_empresa.Size = new System.Drawing.Size(51, 13);
            this.abmfactura_lab_empresa.TabIndex = 1;
            this.abmfactura_lab_empresa.Text = "Empresa:";
            // 
            // abmfactura_tb_empresa
            // 
            this.abmfactura_tb_empresa.FormattingEnabled = true;
            this.abmfactura_tb_empresa.Location = new System.Drawing.Point(122, 41);
            this.abmfactura_tb_empresa.Name = "abmfactura_tb_empresa";
            this.abmfactura_tb_empresa.Size = new System.Drawing.Size(121, 21);
            this.abmfactura_tb_empresa.TabIndex = 10;
            // 
            // ambfactura_tb_nrofac
            // 
            this.ambfactura_tb_nrofac.Location = new System.Drawing.Point(13, 85);
            this.ambfactura_tb_nrofac.Name = "ambfactura_tb_nrofac";
            this.ambfactura_tb_nrofac.Size = new System.Drawing.Size(139, 20);
            this.ambfactura_tb_nrofac.TabIndex = 11;
            // 
            // abmfactura_mtb_fecalta
            // 
            this.abmfactura_mtb_fecalta.Location = new System.Drawing.Point(13, 126);
            this.abmfactura_mtb_fecalta.Mask = "00/00/0000";
            this.abmfactura_mtb_fecalta.Name = "abmfactura_mtb_fecalta";
            this.abmfactura_mtb_fecalta.Size = new System.Drawing.Size(100, 20);
            this.abmfactura_mtb_fecalta.TabIndex = 12;
            this.abmfactura_mtb_fecalta.ValidatingType = typeof(System.DateTime);
            // 
            // abmfactura_mtb_fecvto
            // 
            this.abmfactura_mtb_fecvto.Location = new System.Drawing.Point(13, 166);
            this.abmfactura_mtb_fecvto.Mask = "00/00/0000";
            this.abmfactura_mtb_fecvto.Name = "abmfactura_mtb_fecvto";
            this.abmfactura_mtb_fecvto.Size = new System.Drawing.Size(100, 20);
            this.abmfactura_mtb_fecvto.TabIndex = 13;
            this.abmfactura_mtb_fecvto.ValidatingType = typeof(System.DateTime);
            // 
            // abmfactura_tb_total
            // 
            this.abmfactura_tb_total.Location = new System.Drawing.Point(13, 207);
            this.abmfactura_tb_total.Name = "abmfactura_tb_total";
            this.abmfactura_tb_total.Size = new System.Drawing.Size(100, 20);
            this.abmfactura_tb_total.TabIndex = 14;
            // 
            // abmfactura_tb_items
            // 
            this.abmfactura_tb_items.Location = new System.Drawing.Point(13, 249);
            this.abmfactura_tb_items.Name = "abmfactura_tb_items";
            this.abmfactura_tb_items.Size = new System.Drawing.Size(50, 20);
            this.abmfactura_tb_items.TabIndex = 15;
            // 
            // abmfactura_tb_monto
            // 
            this.abmfactura_tb_monto.Location = new System.Drawing.Point(77, 249);
            this.abmfactura_tb_monto.Name = "abmfactura_tb_monto";
            this.abmfactura_tb_monto.Size = new System.Drawing.Size(55, 20);
            this.abmfactura_tb_monto.TabIndex = 16;
            // 
            // abmfactura_tb_cantidad
            // 
            this.abmfactura_tb_cantidad.Location = new System.Drawing.Point(146, 249);
            this.abmfactura_tb_cantidad.Name = "abmfactura_tb_cantidad";
            this.abmfactura_tb_cantidad.Size = new System.Drawing.Size(62, 20);
            this.abmfactura_tb_cantidad.TabIndex = 17;
            // 
            // abmfactura_but_aceptar
            // 
            this.abmfactura_but_aceptar.Location = new System.Drawing.Point(180, 277);
            this.abmfactura_but_aceptar.Name = "abmfactura_but_aceptar";
            this.abmfactura_but_aceptar.Size = new System.Drawing.Size(75, 23);
            this.abmfactura_but_aceptar.TabIndex = 18;
            this.abmfactura_but_aceptar.Text = "Aceptar";
            this.abmfactura_but_aceptar.UseVisualStyleBackColor = true;
            // 
            // abmfactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 312);
            this.Controls.Add(this.abmfactura_but_aceptar);
            this.Controls.Add(this.abmfactura_tb_cantidad);
            this.Controls.Add(this.abmfactura_tb_monto);
            this.Controls.Add(this.abmfactura_tb_items);
            this.Controls.Add(this.abmfactura_tb_total);
            this.Controls.Add(this.abmfactura_mtb_fecvto);
            this.Controls.Add(this.abmfactura_mtb_fecalta);
            this.Controls.Add(this.ambfactura_tb_nrofac);
            this.Controls.Add(this.abmfactura_tb_empresa);
            this.Controls.Add(this.ambfactura_tb_dni);
            this.Controls.Add(this.abmfactura_lab_cantidad);
            this.Controls.Add(this.abmfactura_lab_monto);
            this.Controls.Add(this.abmfactura_lab_items);
            this.Controls.Add(this.abmfactura_lab_total);
            this.Controls.Add(this.abmempresa_lab_fechavto);
            this.Controls.Add(this.ambfactura_lab_fechaalta);
            this.Controls.Add(this.abmfactura_lab_nrofactura);
            this.Controls.Add(this.abmfactura_lab_empresa);
            this.Controls.Add(this.abmcliente_lab_cliente);
            this.Name = "abmfactura";
            this.Text = "ABM Factura";
            this.Load += new System.EventHandler(this.abmfactura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label abmcliente_lab_cliente;
        private System.Windows.Forms.Label abmfactura_lab_nrofactura;
        private System.Windows.Forms.Label ambfactura_lab_fechaalta;
        private System.Windows.Forms.Label abmempresa_lab_fechavto;
        private System.Windows.Forms.Label abmfactura_lab_total;
        private System.Windows.Forms.Label abmfactura_lab_items;
        private System.Windows.Forms.Label abmfactura_lab_monto;
        private System.Windows.Forms.Label abmfactura_lab_cantidad;
        private System.Windows.Forms.TextBox ambfactura_tb_dni;
        private System.Windows.Forms.Label abmfactura_lab_empresa;
        private System.Windows.Forms.ComboBox abmfactura_tb_empresa;
        private System.Windows.Forms.TextBox ambfactura_tb_nrofac;
        private System.Windows.Forms.MaskedTextBox abmfactura_mtb_fecalta;
        private System.Windows.Forms.MaskedTextBox abmfactura_mtb_fecvto;
        private System.Windows.Forms.TextBox abmfactura_tb_total;
        private System.Windows.Forms.TextBox abmfactura_tb_items;
        private System.Windows.Forms.TextBox abmfactura_tb_monto;
        private System.Windows.Forms.TextBox abmfactura_tb_cantidad;
        private System.Windows.Forms.Button abmfactura_but_aceptar;
    }
}