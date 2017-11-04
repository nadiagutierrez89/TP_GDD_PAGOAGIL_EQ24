namespace PagoAgilFrba.FrontEnd.RegistroPago
{
    partial class RegistroPago
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
            this.registropago_lab_numeroF = new System.Windows.Forms.Label();
            this.registropago_lab_empresa = new System.Windows.Forms.Label();
            this.registropago_lab_importe = new System.Windows.Forms.Label();
            this.registropago_lab_sucursal = new System.Windows.Forms.Label();
            this.registropago_lab_fechaCobro = new System.Windows.Forms.Label();
            this.registropago_lab_dniCliente = new System.Windows.Forms.Label();
            this.registropago_lab_fechaVto = new System.Windows.Forms.Label();
            this.registropago_mtb_fecvto = new System.Windows.Forms.MaskedTextBox();
            this.registropago_tb_nrofac = new System.Windows.Forms.TextBox();
            this.registropago_tb_empresa = new System.Windows.Forms.ComboBox();
            this.registropago_tb_dni = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.registropago_tab_facturasPagar = new System.Windows.Forms.TableLayoutPanel();
            this.registropago_lab_total = new System.Windows.Forms.Label();
            this.registropago_but_agregar = new System.Windows.Forms.Button();
            this.registropago_but_pagar = new System.Windows.Forms.Button();
            this.registropago_tb_total = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // registropago_lab_numeroF
            // 
            this.registropago_lab_numeroF.Location = new System.Drawing.Point(12, 21);
            this.registropago_lab_numeroF.Name = "registropago_lab_numeroF";
            this.registropago_lab_numeroF.Size = new System.Drawing.Size(48, 31);
            this.registropago_lab_numeroF.TabIndex = 0;
            this.registropago_lab_numeroF.Text = "Número factura:";
            // 
            // registropago_lab_empresa
            // 
            this.registropago_lab_empresa.AutoSize = true;
            this.registropago_lab_empresa.Location = new System.Drawing.Point(160, 27);
            this.registropago_lab_empresa.Name = "registropago_lab_empresa";
            this.registropago_lab_empresa.Size = new System.Drawing.Size(51, 13);
            this.registropago_lab_empresa.TabIndex = 1;
            this.registropago_lab_empresa.Text = "Empresa:";
            // 
            // registropago_lab_importe
            // 
            this.registropago_lab_importe.AutoSize = true;
            this.registropago_lab_importe.Location = new System.Drawing.Point(396, 27);
            this.registropago_lab_importe.Name = "registropago_lab_importe";
            this.registropago_lab_importe.Size = new System.Drawing.Size(45, 13);
            this.registropago_lab_importe.TabIndex = 2;
            this.registropago_lab_importe.Text = "Importe:";
            // 
            // registropago_lab_sucursal
            // 
            this.registropago_lab_sucursal.AutoSize = true;
            this.registropago_lab_sucursal.Location = new System.Drawing.Point(453, 27);
            this.registropago_lab_sucursal.Name = "registropago_lab_sucursal";
            this.registropago_lab_sucursal.Size = new System.Drawing.Size(51, 13);
            this.registropago_lab_sucursal.TabIndex = 3;
            this.registropago_lab_sucursal.Text = "Sucursal:";
            // 
            // registropago_lab_fechaCobro
            // 
            this.registropago_lab_fechaCobro.Location = new System.Drawing.Point(85, 21);
            this.registropago_lab_fechaCobro.Name = "registropago_lab_fechaCobro";
            this.registropago_lab_fechaCobro.Size = new System.Drawing.Size(44, 31);
            this.registropago_lab_fechaCobro.TabIndex = 4;
            this.registropago_lab_fechaCobro.Text = "Fecha cobro:";
            // 
            // registropago_lab_dniCliente
            // 
            this.registropago_lab_dniCliente.AutoSize = true;
            this.registropago_lab_dniCliente.Location = new System.Drawing.Point(245, 27);
            this.registropago_lab_dniCliente.Name = "registropago_lab_dniCliente";
            this.registropago_lab_dniCliente.Size = new System.Drawing.Size(64, 13);
            this.registropago_lab_dniCliente.TabIndex = 5;
            this.registropago_lab_dniCliente.Text = "DNI Cliente:";
            // 
            // registropago_lab_fechaVto
            // 
            this.registropago_lab_fechaVto.Location = new System.Drawing.Point(323, 21);
            this.registropago_lab_fechaVto.Name = "registropago_lab_fechaVto";
            this.registropago_lab_fechaVto.Size = new System.Drawing.Size(57, 38);
            this.registropago_lab_fechaVto.TabIndex = 6;
            this.registropago_lab_fechaVto.Text = "Fecha vto factura:";
            // 
            // registropago_mtb_fecvto
            // 
            this.registropago_mtb_fecvto.Location = new System.Drawing.Point(326, 54);
            this.registropago_mtb_fecvto.Mask = "00/00/0000";
            this.registropago_mtb_fecvto.Name = "registropago_mtb_fecvto";
            this.registropago_mtb_fecvto.Size = new System.Drawing.Size(67, 20);
            this.registropago_mtb_fecvto.TabIndex = 17;
            this.registropago_mtb_fecvto.ValidatingType = typeof(System.DateTime);
            // 
            // registropago_tb_nrofac
            // 
            this.registropago_tb_nrofac.Location = new System.Drawing.Point(18, 54);
            this.registropago_tb_nrofac.Name = "registropago_tb_nrofac";
            this.registropago_tb_nrofac.Size = new System.Drawing.Size(68, 20);
            this.registropago_tb_nrofac.TabIndex = 16;
            // 
            // registropago_tb_empresa
            // 
            this.registropago_tb_empresa.FormattingEnabled = true;
            this.registropago_tb_empresa.Location = new System.Drawing.Point(160, 54);
            this.registropago_tb_empresa.Name = "registropago_tb_empresa";
            this.registropago_tb_empresa.Size = new System.Drawing.Size(81, 21);
            this.registropago_tb_empresa.TabIndex = 15;
            // 
            // registropago_tb_dni
            // 
            this.registropago_tb_dni.Location = new System.Drawing.Point(247, 54);
            this.registropago_tb_dni.Name = "registropago_tb_dni";
            this.registropago_tb_dni.Size = new System.Drawing.Size(70, 20);
            this.registropago_tb_dni.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(399, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(53, 20);
            this.textBox1.TabIndex = 18;
            // 
            // registropago_tab_facturasPagar
            // 
            this.registropago_tab_facturasPagar.ColumnCount = 7;
            this.registropago_tab_facturasPagar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.28467F));
            this.registropago_tab_facturasPagar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.71533F));
            this.registropago_tab_facturasPagar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.registropago_tab_facturasPagar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.registropago_tab_facturasPagar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.registropago_tab_facturasPagar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.registropago_tab_facturasPagar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.registropago_tab_facturasPagar.Location = new System.Drawing.Point(15, 81);
            this.registropago_tab_facturasPagar.Name = "registropago_tab_facturasPagar";
            this.registropago_tab_facturasPagar.RowCount = 9;
            this.registropago_tab_facturasPagar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.registropago_tab_facturasPagar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.registropago_tab_facturasPagar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.registropago_tab_facturasPagar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.registropago_tab_facturasPagar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.registropago_tab_facturasPagar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.registropago_tab_facturasPagar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.registropago_tab_facturasPagar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.registropago_tab_facturasPagar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.registropago_tab_facturasPagar.Size = new System.Drawing.Size(489, 183);
            this.registropago_tab_facturasPagar.TabIndex = 19;
            // 
            // registropago_lab_total
            // 
            this.registropago_lab_total.AutoSize = true;
            this.registropago_lab_total.Location = new System.Drawing.Point(15, 271);
            this.registropago_lab_total.Name = "registropago_lab_total";
            this.registropago_lab_total.Size = new System.Drawing.Size(34, 13);
            this.registropago_lab_total.TabIndex = 20;
            this.registropago_lab_total.Text = "Total:";
            // 
            // registropago_but_agregar
            // 
            this.registropago_but_agregar.Location = new System.Drawing.Point(527, 54);
            this.registropago_but_agregar.Name = "registropago_but_agregar";
            this.registropago_but_agregar.Size = new System.Drawing.Size(61, 23);
            this.registropago_but_agregar.TabIndex = 21;
            this.registropago_but_agregar.Text = "Agregar";
            this.registropago_but_agregar.UseVisualStyleBackColor = true;
            // 
            // registropago_but_pagar
            // 
            this.registropago_but_pagar.Location = new System.Drawing.Point(527, 265);
            this.registropago_but_pagar.Name = "registropago_but_pagar";
            this.registropago_but_pagar.Size = new System.Drawing.Size(61, 23);
            this.registropago_but_pagar.TabIndex = 22;
            this.registropago_but_pagar.Text = "Pagar";
            this.registropago_but_pagar.UseVisualStyleBackColor = true;
            // 
            // registropago_tb_total
            // 
            this.registropago_tb_total.Location = new System.Drawing.Point(399, 268);
            this.registropago_tb_total.Name = "registropago_tb_total";
            this.registropago_tb_total.ReadOnly = true;
            this.registropago_tb_total.Size = new System.Drawing.Size(53, 20);
            this.registropago_tb_total.TabIndex = 23;
            // 
            // RegistroPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 302);
            this.Controls.Add(this.registropago_tb_total);
            this.Controls.Add(this.registropago_but_pagar);
            this.Controls.Add(this.registropago_but_agregar);
            this.Controls.Add(this.registropago_lab_total);
            this.Controls.Add(this.registropago_tab_facturasPagar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.registropago_mtb_fecvto);
            this.Controls.Add(this.registropago_tb_nrofac);
            this.Controls.Add(this.registropago_tb_empresa);
            this.Controls.Add(this.registropago_tb_dni);
            this.Controls.Add(this.registropago_lab_fechaVto);
            this.Controls.Add(this.registropago_lab_dniCliente);
            this.Controls.Add(this.registropago_lab_fechaCobro);
            this.Controls.Add(this.registropago_lab_sucursal);
            this.Controls.Add(this.registropago_lab_importe);
            this.Controls.Add(this.registropago_lab_empresa);
            this.Controls.Add(this.registropago_lab_numeroF);
            this.Name = "RegistroPago";
            this.Text = "Registrar Pago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label registropago_lab_numeroF;
        private System.Windows.Forms.Label registropago_lab_empresa;
        private System.Windows.Forms.Label registropago_lab_importe;
        private System.Windows.Forms.Label registropago_lab_sucursal;
        private System.Windows.Forms.Label registropago_lab_fechaCobro;
        private System.Windows.Forms.Label registropago_lab_dniCliente;
        private System.Windows.Forms.Label registropago_lab_fechaVto;
        private System.Windows.Forms.MaskedTextBox registropago_mtb_fecvto;
        private System.Windows.Forms.TextBox registropago_tb_nrofac;
        private System.Windows.Forms.ComboBox registropago_tb_empresa;
        private System.Windows.Forms.TextBox registropago_tb_dni;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel registropago_tab_facturasPagar;
        private System.Windows.Forms.Label registropago_lab_total;
        private System.Windows.Forms.Button registropago_but_agregar;
        private System.Windows.Forms.Button registropago_but_pagar;
        private System.Windows.Forms.TextBox registropago_tb_total;
    }
}