namespace PagoAgilFrba.FrontEnd.ABMFactura
{
    partial class Facturas
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
            this.facturas_but_modificar = new System.Windows.Forms.Button();
            this.facturas_but_buscar = new System.Windows.Forms.Button();
            this.facturas_but_alta = new System.Windows.Forms.Button();
            this.nro_factura = new System.Windows.Forms.TextBox();
            this.facturas_lab_empresa = new System.Windows.Forms.Label();
            this.factura_dgv_listado = new System.Windows.Forms.DataGridView();
            this.cod_empresa = new System.Windows.Forms.ComboBox();
            this.fecha_alta_fac_desde = new System.Windows.Forms.DateTimePicker();
            this.fecha_alta_fac_hasta = new System.Windows.Forms.DateTimePicker();
            this.fecha_vto_fac_desde = new System.Windows.Forms.DateTimePicker();
            this.fecha_vto_fac_hasta = new System.Windows.Forms.DateTimePicker();
            this.lbl_fec_alt_desde = new System.Windows.Forms.Label();
            this.lbl_alt_hasta = new System.Windows.Forms.Label();
            this.lbl_vto_desde = new System.Windows.Forms.Label();
            this.lbl_vt_hasta = new System.Windows.Forms.Label();
            this.lbl_nro_factura = new System.Windows.Forms.Label();
            this.bttn_limpiar = new System.Windows.Forms.Button();
            this.bttnSeleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.factura_dgv_listado)).BeginInit();
            this.SuspendLayout();
            // 
            // facturas_but_modificar
            // 
            this.facturas_but_modificar.Location = new System.Drawing.Point(480, 404);
            this.facturas_but_modificar.Name = "facturas_but_modificar";
            this.facturas_but_modificar.Size = new System.Drawing.Size(75, 23);
            this.facturas_but_modificar.TabIndex = 47;
            this.facturas_but_modificar.Text = "Modificar";
            this.facturas_but_modificar.UseVisualStyleBackColor = true;
            this.facturas_but_modificar.Click += new System.EventHandler(this.facturas_but_modificar_Click);
            // 
            // facturas_but_buscar
            // 
            this.facturas_but_buscar.Location = new System.Drawing.Point(480, 171);
            this.facturas_but_buscar.Name = "facturas_but_buscar";
            this.facturas_but_buscar.Size = new System.Drawing.Size(75, 23);
            this.facturas_but_buscar.TabIndex = 46;
            this.facturas_but_buscar.Text = "Buscar";
            this.facturas_but_buscar.UseVisualStyleBackColor = true;
            this.facturas_but_buscar.Click += new System.EventHandler(this.facturas_but_buscar_Click);
            // 
            // facturas_but_alta
            // 
            this.facturas_but_alta.Location = new System.Drawing.Point(399, 404);
            this.facturas_but_alta.Name = "facturas_but_alta";
            this.facturas_but_alta.Size = new System.Drawing.Size(75, 23);
            this.facturas_but_alta.TabIndex = 45;
            this.facturas_but_alta.Text = "Alta";
            this.facturas_but_alta.UseVisualStyleBackColor = true;
            this.facturas_but_alta.Click += new System.EventHandler(this.facturas_but_alta_Click);
            // 
            // nro_factura
            // 
            this.nro_factura.Location = new System.Drawing.Point(113, 38);
            this.nro_factura.Name = "nro_factura";
            this.nro_factura.Size = new System.Drawing.Size(201, 20);
            this.nro_factura.TabIndex = 50;
            // 
            // facturas_lab_empresa
            // 
            this.facturas_lab_empresa.AutoSize = true;
            this.facturas_lab_empresa.Location = new System.Drawing.Point(18, 19);
            this.facturas_lab_empresa.Name = "facturas_lab_empresa";
            this.facturas_lab_empresa.Size = new System.Drawing.Size(51, 13);
            this.facturas_lab_empresa.TabIndex = 53;
            this.facturas_lab_empresa.Text = "Empresa:";
            // 
            // factura_dgv_listado
            // 
            this.factura_dgv_listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.factura_dgv_listado.Location = new System.Drawing.Point(12, 200);
            this.factura_dgv_listado.Name = "factura_dgv_listado";
            this.factura_dgv_listado.Size = new System.Drawing.Size(543, 198);
            this.factura_dgv_listado.TabIndex = 56;
            // 
            // cod_empresa
            // 
            this.cod_empresa.FormattingEnabled = true;
            this.cod_empresa.Location = new System.Drawing.Point(112, 11);
            this.cod_empresa.Name = "cod_empresa";
            this.cod_empresa.Size = new System.Drawing.Size(201, 21);
            this.cod_empresa.TabIndex = 57;
            // 
            // fecha_alta_fac_desde
            // 
            this.fecha_alta_fac_desde.Location = new System.Drawing.Point(114, 64);
            this.fecha_alta_fac_desde.Name = "fecha_alta_fac_desde";
            this.fecha_alta_fac_desde.Size = new System.Drawing.Size(200, 20);
            this.fecha_alta_fac_desde.TabIndex = 58;
            // 
            // fecha_alta_fac_hasta
            // 
            this.fecha_alta_fac_hasta.Location = new System.Drawing.Point(114, 91);
            this.fecha_alta_fac_hasta.Name = "fecha_alta_fac_hasta";
            this.fecha_alta_fac_hasta.Size = new System.Drawing.Size(200, 20);
            this.fecha_alta_fac_hasta.TabIndex = 59;
            // 
            // fecha_vto_fac_desde
            // 
            this.fecha_vto_fac_desde.Location = new System.Drawing.Point(113, 118);
            this.fecha_vto_fac_desde.Name = "fecha_vto_fac_desde";
            this.fecha_vto_fac_desde.Size = new System.Drawing.Size(200, 20);
            this.fecha_vto_fac_desde.TabIndex = 60;
            // 
            // fecha_vto_fac_hasta
            // 
            this.fecha_vto_fac_hasta.Location = new System.Drawing.Point(113, 145);
            this.fecha_vto_fac_hasta.Name = "fecha_vto_fac_hasta";
            this.fecha_vto_fac_hasta.Size = new System.Drawing.Size(200, 20);
            this.fecha_vto_fac_hasta.TabIndex = 61;
            // 
            // lbl_fec_alt_desde
            // 
            this.lbl_fec_alt_desde.AutoSize = true;
            this.lbl_fec_alt_desde.Location = new System.Drawing.Point(18, 71);
            this.lbl_fec_alt_desde.Name = "lbl_fec_alt_desde";
            this.lbl_fec_alt_desde.Size = new System.Drawing.Size(92, 13);
            this.lbl_fec_alt_desde.TabIndex = 62;
            this.lbl_fec_alt_desde.Text = "Fecha alta desde:";
            this.lbl_fec_alt_desde.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_alt_hasta
            // 
            this.lbl_alt_hasta.AutoSize = true;
            this.lbl_alt_hasta.Location = new System.Drawing.Point(18, 98);
            this.lbl_alt_hasta.Name = "lbl_alt_hasta";
            this.lbl_alt_hasta.Size = new System.Drawing.Size(89, 13);
            this.lbl_alt_hasta.TabIndex = 63;
            this.lbl_alt_hasta.Text = "Fecha alta hasta:";
            // 
            // lbl_vto_desde
            // 
            this.lbl_vto_desde.AutoSize = true;
            this.lbl_vto_desde.Location = new System.Drawing.Point(18, 125);
            this.lbl_vto_desde.Name = "lbl_vto_desde";
            this.lbl_vto_desde.Size = new System.Drawing.Size(91, 13);
            this.lbl_vto_desde.TabIndex = 64;
            this.lbl_vto_desde.Text = "Fecha Vto desde:";
            // 
            // lbl_vt_hasta
            // 
            this.lbl_vt_hasta.AutoSize = true;
            this.lbl_vt_hasta.Location = new System.Drawing.Point(18, 151);
            this.lbl_vt_hasta.Name = "lbl_vt_hasta";
            this.lbl_vt_hasta.Size = new System.Drawing.Size(88, 13);
            this.lbl_vt_hasta.TabIndex = 65;
            this.lbl_vt_hasta.Text = "Fecha Vto hasta:";
            // 
            // lbl_nro_factura
            // 
            this.lbl_nro_factura.AutoSize = true;
            this.lbl_nro_factura.Location = new System.Drawing.Point(18, 45);
            this.lbl_nro_factura.Name = "lbl_nro_factura";
            this.lbl_nro_factura.Size = new System.Drawing.Size(66, 13);
            this.lbl_nro_factura.TabIndex = 66;
            this.lbl_nro_factura.Text = "Nro Factura:";
            // 
            // bttn_limpiar
            // 
            this.bttn_limpiar.Location = new System.Drawing.Point(374, 171);
            this.bttn_limpiar.Name = "bttn_limpiar";
            this.bttn_limpiar.Size = new System.Drawing.Size(100, 23);
            this.bttn_limpiar.TabIndex = 67;
            this.bttn_limpiar.Text = "Limpiar Filtros";
            this.bttn_limpiar.UseVisualStyleBackColor = true;
            this.bttn_limpiar.Click += new System.EventHandler(this.bttn_limpiar_Click);
            this.bttn_limpiar.Paint += new System.Windows.Forms.PaintEventHandler(this.bttn_limpiar_Paint);
            // 
            // bttnSeleccionar
            // 
            this.bttnSeleccionar.Location = new System.Drawing.Point(318, 404);
            this.bttnSeleccionar.Name = "bttnSeleccionar";
            this.bttnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.bttnSeleccionar.TabIndex = 68;
            this.bttnSeleccionar.Text = "Seleccionar";
            this.bttnSeleccionar.UseVisualStyleBackColor = true;
            this.bttnSeleccionar.Visible = false;
            this.bttnSeleccionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 433);
            this.Controls.Add(this.bttnSeleccionar);
            this.Controls.Add(this.bttn_limpiar);
            this.Controls.Add(this.lbl_nro_factura);
            this.Controls.Add(this.lbl_vt_hasta);
            this.Controls.Add(this.lbl_vto_desde);
            this.Controls.Add(this.lbl_alt_hasta);
            this.Controls.Add(this.lbl_fec_alt_desde);
            this.Controls.Add(this.fecha_vto_fac_hasta);
            this.Controls.Add(this.fecha_vto_fac_desde);
            this.Controls.Add(this.fecha_alta_fac_hasta);
            this.Controls.Add(this.fecha_alta_fac_desde);
            this.Controls.Add(this.cod_empresa);
            this.Controls.Add(this.factura_dgv_listado);
            this.Controls.Add(this.facturas_lab_empresa);
            this.Controls.Add(this.nro_factura);
            this.Controls.Add(this.facturas_but_modificar);
            this.Controls.Add(this.facturas_but_buscar);
            this.Controls.Add(this.facturas_but_alta);
            this.Name = "Facturas";
            this.Text = "Facturas";
            this.Shown += new System.EventHandler(this.Facturas_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.factura_dgv_listado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button facturas_but_modificar;
        private System.Windows.Forms.Button facturas_but_buscar;
        private System.Windows.Forms.Button facturas_but_alta;
        private System.Windows.Forms.TextBox nro_factura;
        private System.Windows.Forms.Label facturas_lab_empresa;
        private System.Windows.Forms.DataGridView factura_dgv_listado;
        private System.Windows.Forms.ComboBox cod_empresa;
        private System.Windows.Forms.DateTimePicker fecha_alta_fac_desde;
        private System.Windows.Forms.DateTimePicker fecha_alta_fac_hasta;
        private System.Windows.Forms.DateTimePicker fecha_vto_fac_desde;
        private System.Windows.Forms.DateTimePicker fecha_vto_fac_hasta;
        private System.Windows.Forms.Label lbl_fec_alt_desde;
        private System.Windows.Forms.Label lbl_alt_hasta;
        private System.Windows.Forms.Label lbl_vto_desde;
        private System.Windows.Forms.Label lbl_vt_hasta;
        private System.Windows.Forms.Label lbl_nro_factura;
        private System.Windows.Forms.Button bttn_limpiar;
        private System.Windows.Forms.Button bttnSeleccionar;
    }
}