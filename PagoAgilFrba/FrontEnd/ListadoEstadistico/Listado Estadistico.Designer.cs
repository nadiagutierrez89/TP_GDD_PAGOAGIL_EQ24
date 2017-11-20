namespace PagoAgilFrba.FrontEnd.ListadoEstadistico
{
    partial class listadoEstadistico
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
            this.estadistica_but_consultar = new System.Windows.Forms.Button();
            this.estadistca_lab_timestre = new System.Windows.Forms.Label();
            this.estadistica_dgv_listaResultados = new System.Windows.Forms.DataGridView();
            this.estadistica_cb_trimestre = new System.Windows.Forms.ComboBox();
            this.estadistica_cb_anio = new System.Windows.Forms.ComboBox();
            this.estadistica_cb_listado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.estadistica_dgv_listaResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // estadistica_but_consultar
            // 
            this.estadistica_but_consultar.Location = new System.Drawing.Point(531, 41);
            this.estadistica_but_consultar.Name = "estadistica_but_consultar";
            this.estadistica_but_consultar.Size = new System.Drawing.Size(75, 21);
            this.estadistica_but_consultar.TabIndex = 0;
            this.estadistica_but_consultar.Text = "Consultar";
            this.estadistica_but_consultar.UseVisualStyleBackColor = true;
            this.estadistica_but_consultar.Click += new System.EventHandler(this.estadistica_but_consultar_click);
            // 
            // estadistca_lab_timestre
            // 
            this.estadistca_lab_timestre.AutoSize = true;
            this.estadistca_lab_timestre.Location = new System.Drawing.Point(12, 13);
            this.estadistca_lab_timestre.Name = "estadistca_lab_timestre";
            this.estadistca_lab_timestre.Size = new System.Drawing.Size(252, 13);
            this.estadistca_lab_timestre.TabIndex = 13;
            this.estadistca_lab_timestre.Text = "Por favor ingrese trimestre, año y listado a consultar:";
            // 
            // estadistica_dgv_listaResultados
            // 
            this.estadistica_dgv_listaResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.estadistica_dgv_listaResultados.Location = new System.Drawing.Point(12, 68);
            this.estadistica_dgv_listaResultados.Name = "estadistica_dgv_listaResultados";
            this.estadistica_dgv_listaResultados.Size = new System.Drawing.Size(594, 177);
            this.estadistica_dgv_listaResultados.TabIndex = 14;
            // 
            // estadistica_cb_trimestre
            // 
            this.estadistica_cb_trimestre.FormattingEnabled = true;
            this.estadistica_cb_trimestre.Location = new System.Drawing.Point(12, 41);
            this.estadistica_cb_trimestre.Name = "estadistica_cb_trimestre";
            this.estadistica_cb_trimestre.Size = new System.Drawing.Size(59, 21);
            this.estadistica_cb_trimestre.TabIndex = 15;
            // 
            // estadistica_cb_anio
            // 
            this.estadistica_cb_anio.FormattingEnabled = true;
            this.estadistica_cb_anio.Location = new System.Drawing.Point(77, 41);
            this.estadistica_cb_anio.Name = "estadistica_cb_anio";
            this.estadistica_cb_anio.Size = new System.Drawing.Size(67, 21);
            this.estadistica_cb_anio.TabIndex = 16;
            // 
            // estadistica_cb_listado
            // 
            this.estadistica_cb_listado.FormattingEnabled = true;
            this.estadistica_cb_listado.Location = new System.Drawing.Point(150, 41);
            this.estadistica_cb_listado.Name = "estadistica_cb_listado";
            this.estadistica_cb_listado.Size = new System.Drawing.Size(375, 21);
            this.estadistica_cb_listado.TabIndex = 17;
            // 
            // listadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 261);
            this.Controls.Add(this.estadistica_cb_listado);
            this.Controls.Add(this.estadistica_cb_anio);
            this.Controls.Add(this.estadistica_cb_trimestre);
            this.Controls.Add(this.estadistica_dgv_listaResultados);
            this.Controls.Add(this.estadistca_lab_timestre);
            this.Controls.Add(this.estadistica_but_consultar);
            this.Name = "listadoEstadistico";
            this.Text = "Listado Estadístico ";
            ((System.ComponentModel.ISupportInitialize)(this.estadistica_dgv_listaResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button estadistica_but_consultar;
        private System.Windows.Forms.Label estadistca_lab_timestre;
        private System.Windows.Forms.DataGridView estadistica_dgv_listaResultados;
        private System.Windows.Forms.ComboBox estadistica_cb_trimestre;
        private System.Windows.Forms.ComboBox estadistica_cb_anio;
        private System.Windows.Forms.ComboBox estadistica_cb_listado;
    }
}