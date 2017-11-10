namespace PagoAgilFrba.FrontEnd.AbmEmpresa
{
    partial class ABMEmpresa
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
            this.abmEmpresa_tb_nombre = new System.Windows.Forms.TextBox();
            this.abmempresa_tb_direccion = new System.Windows.Forms.TextBox();
            this.abmempresa_mtb_cuit = new System.Windows.Forms.MaskedTextBox();
            this.abmempresa_lab_nombre = new System.Windows.Forms.Label();
            this.abmempresa_lab_cuit = new System.Windows.Forms.Label();
            this.abmempresa_lab_direccion = new System.Windows.Forms.Label();
            this.cod_rubro = new System.Windows.Forms.ComboBox();
            this.ambempresa_lab_rubro = new System.Windows.Forms.Label();
            this.abmempresa_chb_habilitada = new System.Windows.Forms.CheckBox();
            this.abmempresa_but_aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // abmEmpresa_tb_nombre
            // 
            this.abmEmpresa_tb_nombre.Location = new System.Drawing.Point(13, 39);
            this.abmEmpresa_tb_nombre.Name = "abmEmpresa_tb_nombre";
            this.abmEmpresa_tb_nombre.Size = new System.Drawing.Size(259, 20);
            this.abmEmpresa_tb_nombre.TabIndex = 0;
            // 
            // abmempresa_tb_direccion
            // 
            this.abmempresa_tb_direccion.Location = new System.Drawing.Point(13, 130);
            this.abmempresa_tb_direccion.Name = "abmempresa_tb_direccion";
            this.abmempresa_tb_direccion.Size = new System.Drawing.Size(259, 20);
            this.abmempresa_tb_direccion.TabIndex = 1;
            // 
            // abmempresa_mtb_cuit
            // 
            this.abmempresa_mtb_cuit.AllowDrop = true;
            this.abmempresa_mtb_cuit.Location = new System.Drawing.Point(12, 84);
            this.abmempresa_mtb_cuit.Mask = "00-00000000-00";
            this.abmempresa_mtb_cuit.Name = "abmempresa_mtb_cuit";
            this.abmempresa_mtb_cuit.Size = new System.Drawing.Size(100, 20);
            this.abmempresa_mtb_cuit.TabIndex = 2;
            this.abmempresa_mtb_cuit.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // abmempresa_lab_nombre
            // 
            this.abmempresa_lab_nombre.AutoSize = true;
            this.abmempresa_lab_nombre.Location = new System.Drawing.Point(13, 23);
            this.abmempresa_lab_nombre.Name = "abmempresa_lab_nombre";
            this.abmempresa_lab_nombre.Size = new System.Drawing.Size(116, 13);
            this.abmempresa_lab_nombre.TabIndex = 3;
            this.abmempresa_lab_nombre.Text = "Nombre de la empresa:";
            // 
            // abmempresa_lab_cuit
            // 
            this.abmempresa_lab_cuit.AutoSize = true;
            this.abmempresa_lab_cuit.Location = new System.Drawing.Point(12, 68);
            this.abmempresa_lab_cuit.Name = "abmempresa_lab_cuit";
            this.abmempresa_lab_cuit.Size = new System.Drawing.Size(32, 13);
            this.abmempresa_lab_cuit.TabIndex = 4;
            this.abmempresa_lab_cuit.Text = "CUIT";
            this.abmempresa_lab_cuit.Click += new System.EventHandler(this.label1_Click);
            // 
            // abmempresa_lab_direccion
            // 
            this.abmempresa_lab_direccion.AutoSize = true;
            this.abmempresa_lab_direccion.Location = new System.Drawing.Point(12, 114);
            this.abmempresa_lab_direccion.Name = "abmempresa_lab_direccion";
            this.abmempresa_lab_direccion.Size = new System.Drawing.Size(52, 13);
            this.abmempresa_lab_direccion.TabIndex = 5;
            this.abmempresa_lab_direccion.Text = "Dirección";
            // 
            // cod_rubro
            // 
            this.cod_rubro.FormattingEnabled = true;
            this.cod_rubro.Location = new System.Drawing.Point(12, 170);
            this.cod_rubro.Name = "cod_rubro";
            this.cod_rubro.Size = new System.Drawing.Size(121, 21);
            this.cod_rubro.TabIndex = 7;
            this.cod_rubro.SelectedIndexChanged += new System.EventHandler(this.ambempresa_cb_rubro_SelectedIndexChanged);
            // 
            // ambempresa_lab_rubro
            // 
            this.ambempresa_lab_rubro.AutoSize = true;
            this.ambempresa_lab_rubro.Location = new System.Drawing.Point(13, 157);
            this.ambempresa_lab_rubro.Name = "ambempresa_lab_rubro";
            this.ambempresa_lab_rubro.Size = new System.Drawing.Size(36, 13);
            this.ambempresa_lab_rubro.TabIndex = 8;
            this.ambempresa_lab_rubro.Text = "Rubro";
            // 
            // abmempresa_chb_habilitada
            // 
            this.abmempresa_chb_habilitada.AutoSize = true;
            this.abmempresa_chb_habilitada.Location = new System.Drawing.Point(12, 218);
            this.abmempresa_chb_habilitada.Name = "abmempresa_chb_habilitada";
            this.abmempresa_chb_habilitada.Size = new System.Drawing.Size(73, 17);
            this.abmempresa_chb_habilitada.TabIndex = 9;
            this.abmempresa_chb_habilitada.Text = "Habilitada";
            this.abmempresa_chb_habilitada.UseVisualStyleBackColor = true;
            this.abmempresa_chb_habilitada.CheckedChanged += new System.EventHandler(this.abmempresa_chb_habilitada_CheckedChanged);
            // 
            // abmempresa_but_aceptar
            // 
            this.abmempresa_but_aceptar.Location = new System.Drawing.Point(180, 218);
            this.abmempresa_but_aceptar.Name = "abmempresa_but_aceptar";
            this.abmempresa_but_aceptar.Size = new System.Drawing.Size(75, 23);
            this.abmempresa_but_aceptar.TabIndex = 12;
            this.abmempresa_but_aceptar.Text = "Aceptar";
            this.abmempresa_but_aceptar.UseVisualStyleBackColor = true;
            this.abmempresa_but_aceptar.Click += new System.EventHandler(this.abmempresa_but_aceptar_Click);
            // 
            // ABMEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.abmempresa_but_aceptar);
            this.Controls.Add(this.abmempresa_chb_habilitada);
            this.Controls.Add(this.ambempresa_lab_rubro);
            this.Controls.Add(this.cod_rubro);
            this.Controls.Add(this.abmempresa_lab_direccion);
            this.Controls.Add(this.abmempresa_lab_cuit);
            this.Controls.Add(this.abmempresa_lab_nombre);
            this.Controls.Add(this.abmempresa_mtb_cuit);
            this.Controls.Add(this.abmempresa_tb_direccion);
            this.Controls.Add(this.abmEmpresa_tb_nombre);
            this.Name = "ABMEmpresa";
            this.Text = "ABM Empresa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox abmEmpresa_tb_nombre;
        private System.Windows.Forms.TextBox abmempresa_tb_direccion;
        private System.Windows.Forms.MaskedTextBox abmempresa_mtb_cuit;
        private System.Windows.Forms.Label abmempresa_lab_nombre;
        private System.Windows.Forms.Label abmempresa_lab_cuit;
        private System.Windows.Forms.Label abmempresa_lab_direccion;
        private System.Windows.Forms.ComboBox cod_rubro;
        private System.Windows.Forms.Label ambempresa_lab_rubro;
        private System.Windows.Forms.CheckBox abmempresa_chb_habilitada;
        private System.Windows.Forms.Button abmempresa_but_aceptar;
    }
}