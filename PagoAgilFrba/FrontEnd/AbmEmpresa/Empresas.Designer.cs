namespace PagoAgilFrba.FrontEnd.AbmEmpresa
{
    partial class Empresas
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
            this.empresa_but_modificar = new System.Windows.Forms.Button();
            this.empresa_but_buscar = new System.Windows.Forms.Button();
            this.empresa_lab_rubro = new System.Windows.Forms.Label();
            this.emrpesa_lab_cuit = new System.Windows.Forms.Label();
            this.empresa_lab_nombre = new System.Windows.Forms.Label();
            this.nombre_empresa = new System.Windows.Forms.TextBox();
            this.empresa_but_alta = new System.Windows.Forms.Button();
            this.cuit_empresa = new System.Windows.Forms.MaskedTextBox();
            this.cod_rubro = new System.Windows.Forms.ComboBox();
            this.empresa_dgv_listado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.empresa_dgv_listado)).BeginInit();
            this.SuspendLayout();
            // 
            // empresa_but_modificar
            // 
            this.empresa_but_modificar.Location = new System.Drawing.Point(564, 267);
            this.empresa_but_modificar.Name = "empresa_but_modificar";
            this.empresa_but_modificar.Size = new System.Drawing.Size(75, 23);
            this.empresa_but_modificar.TabIndex = 37;
            this.empresa_but_modificar.Text = "Modificar";
            this.empresa_but_modificar.UseVisualStyleBackColor = true;
            this.empresa_but_modificar.Click += new System.EventHandler(this.empresa_but_modificar_Click);
            // 
            // empresa_but_buscar
            // 
            this.empresa_but_buscar.Location = new System.Drawing.Point(300, 31);
            this.empresa_but_buscar.Name = "empresa_but_buscar";
            this.empresa_but_buscar.Size = new System.Drawing.Size(54, 23);
            this.empresa_but_buscar.TabIndex = 36;
            this.empresa_but_buscar.Text = "Buscar";
            this.empresa_but_buscar.UseVisualStyleBackColor = true;
            this.empresa_but_buscar.Click += new System.EventHandler(this.empresa_but_buscar_Click);
            // 
            // empresa_lab_rubro
            // 
            this.empresa_lab_rubro.AutoSize = true;
            this.empresa_lab_rubro.Location = new System.Drawing.Point(211, 15);
            this.empresa_lab_rubro.Name = "empresa_lab_rubro";
            this.empresa_lab_rubro.Size = new System.Drawing.Size(39, 13);
            this.empresa_lab_rubro.TabIndex = 35;
            this.empresa_lab_rubro.Text = "Rubro:";
            // 
            // emrpesa_lab_cuit
            // 
            this.emrpesa_lab_cuit.AutoSize = true;
            this.emrpesa_lab_cuit.Location = new System.Drawing.Point(102, 15);
            this.emrpesa_lab_cuit.Name = "emrpesa_lab_cuit";
            this.emrpesa_lab_cuit.Size = new System.Drawing.Size(35, 13);
            this.emrpesa_lab_cuit.TabIndex = 34;
            this.emrpesa_lab_cuit.Text = "CUIT:";
            // 
            // empresa_lab_nombre
            // 
            this.empresa_lab_nombre.AutoSize = true;
            this.empresa_lab_nombre.Location = new System.Drawing.Point(8, 15);
            this.empresa_lab_nombre.Name = "empresa_lab_nombre";
            this.empresa_lab_nombre.Size = new System.Drawing.Size(47, 13);
            this.empresa_lab_nombre.TabIndex = 33;
            this.empresa_lab_nombre.Text = "Nombre:";
            // 
            // nombre_empresa
            // 
            this.nombre_empresa.Location = new System.Drawing.Point(12, 34);
            this.nombre_empresa.Name = "nombre_empresa";
            this.nombre_empresa.Size = new System.Drawing.Size(82, 20);
            this.nombre_empresa.TabIndex = 30;
            // 
            // empresa_but_alta
            // 
            this.empresa_but_alta.Location = new System.Drawing.Point(483, 267);
            this.empresa_but_alta.Name = "empresa_but_alta";
            this.empresa_but_alta.Size = new System.Drawing.Size(75, 23);
            this.empresa_but_alta.TabIndex = 29;
            this.empresa_but_alta.Text = "Alta";
            this.empresa_but_alta.UseVisualStyleBackColor = true;
            this.empresa_but_alta.Click += new System.EventHandler(this.empresa_but_alta_Click);
            // 
            // cuit_empresa
            // 
            this.cuit_empresa.AllowDrop = true;
            this.cuit_empresa.Location = new System.Drawing.Point(100, 34);
            this.cuit_empresa.Mask = "00-00000000-00";
            this.cuit_empresa.Name = "cuit_empresa";
            this.cuit_empresa.Size = new System.Drawing.Size(100, 20);
            this.cuit_empresa.TabIndex = 40;
            // 
            // cod_rubro
            // 
            this.cod_rubro.FormattingEnabled = true;
            this.cod_rubro.Location = new System.Drawing.Point(209, 33);
            this.cod_rubro.Name = "cod_rubro";
            this.cod_rubro.Size = new System.Drawing.Size(85, 21);
            this.cod_rubro.TabIndex = 8;
            // 
            // empresa_dgv_listado
            // 
            this.empresa_dgv_listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empresa_dgv_listado.Location = new System.Drawing.Point(11, 61);
            this.empresa_dgv_listado.Name = "empresa_dgv_listado";
            this.empresa_dgv_listado.Size = new System.Drawing.Size(629, 200);
            this.empresa_dgv_listado.TabIndex = 41;
            // 
            // Empresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 302);
            this.Controls.Add(this.empresa_dgv_listado);
            this.Controls.Add(this.cod_rubro);
            this.Controls.Add(this.cuit_empresa);
            this.Controls.Add(this.empresa_but_modificar);
            this.Controls.Add(this.empresa_but_buscar);
            this.Controls.Add(this.empresa_lab_rubro);
            this.Controls.Add(this.emrpesa_lab_cuit);
            this.Controls.Add(this.empresa_lab_nombre);
            this.Controls.Add(this.nombre_empresa);
            this.Controls.Add(this.empresa_but_alta);
            this.Name = "Empresas";
            this.Text = "Empresas";
            ((System.ComponentModel.ISupportInitialize)(this.empresa_dgv_listado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button empresa_but_modificar;
        private System.Windows.Forms.Button empresa_but_buscar;
        private System.Windows.Forms.Label empresa_lab_rubro;
        private System.Windows.Forms.Label emrpesa_lab_cuit;
        private System.Windows.Forms.Label empresa_lab_nombre;
        private System.Windows.Forms.TextBox nombre_empresa;
        private System.Windows.Forms.Button empresa_but_alta;
        private System.Windows.Forms.MaskedTextBox cuit_empresa;
        private System.Windows.Forms.ComboBox cod_rubro;
        private System.Windows.Forms.DataGridView empresa_dgv_listado;
    }
}