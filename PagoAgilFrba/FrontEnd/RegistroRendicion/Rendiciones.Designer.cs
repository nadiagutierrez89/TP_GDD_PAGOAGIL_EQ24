namespace PagoAgilFrba.FrontEnd.RegistroRendicion
{
    partial class Rendiciones
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblSelecEmpresa = new System.Windows.Forms.Label();
            this.bttnSelecEmpresa = new System.Windows.Forms.Button();
            this.tbEmpresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPorcentaje = new System.Windows.Forms.TextBox();
            this.bttnGenerar = new System.Windows.Forms.Button();
            this.lblGenerar = new System.Windows.Forms.Label();
            this.dgvFacturasPagadas = new System.Windows.Forms.DataGridView();
            this.lblCant = new System.Windows.Forms.Label();
            this.tbCant = new System.Windows.Forms.TextBox();
            this.lblImporteComision = new System.Windows.Forms.Label();
            this.tbImporteComision = new System.Windows.Forms.TextBox();
            this.lblImporteRendicion = new System.Windows.Forms.Label();
            this.tbTotalRendicion = new System.Windows.Forms.TextBox();
            this.bttnGuardar = new System.Windows.Forms.Button();
            this.lblGuardar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturasPagadas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(13, 13);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Location = new System.Drawing.Point(60, 13);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 1;
            // 
            // lblSelecEmpresa
            // 
            this.lblSelecEmpresa.AutoSize = true;
            this.lblSelecEmpresa.Location = new System.Drawing.Point(13, 43);
            this.lblSelecEmpresa.Name = "lblSelecEmpresa";
            this.lblSelecEmpresa.Size = new System.Drawing.Size(121, 13);
            this.lblSelecEmpresa.TabIndex = 2;
            this.lblSelecEmpresa.Text = "1) Seleccionar empresa:";
            // 
            // bttnSelecEmpresa
            // 
            this.bttnSelecEmpresa.Location = new System.Drawing.Point(140, 39);
            this.bttnSelecEmpresa.Name = "bttnSelecEmpresa";
            this.bttnSelecEmpresa.Size = new System.Drawing.Size(75, 23);
            this.bttnSelecEmpresa.TabIndex = 3;
            this.bttnSelecEmpresa.Text = "Seleccionar";
            this.bttnSelecEmpresa.UseVisualStyleBackColor = true;
            this.bttnSelecEmpresa.Click += new System.EventHandler(this.bttnSelecEmpresa_Click);
            // 
            // tbEmpresa
            // 
            this.tbEmpresa.Enabled = false;
            this.tbEmpresa.Location = new System.Drawing.Point(222, 41);
            this.tbEmpresa.Name = "tbEmpresa";
            this.tbEmpresa.Size = new System.Drawing.Size(193, 20);
            this.tbEmpresa.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "2) Porcentaje de comision";
            // 
            // tbPorcentaje
            // 
            this.tbPorcentaje.Location = new System.Drawing.Point(149, 84);
            this.tbPorcentaje.Name = "tbPorcentaje";
            this.tbPorcentaje.Size = new System.Drawing.Size(100, 20);
            this.tbPorcentaje.TabIndex = 6;
            this.tbPorcentaje.Text = "10";
            // 
            // bttnGenerar
            // 
            this.bttnGenerar.Location = new System.Drawing.Point(125, 119);
            this.bttnGenerar.Name = "bttnGenerar";
            this.bttnGenerar.Size = new System.Drawing.Size(75, 23);
            this.bttnGenerar.TabIndex = 7;
            this.bttnGenerar.Text = "Generar";
            this.bttnGenerar.UseVisualStyleBackColor = true;
            this.bttnGenerar.Click += new System.EventHandler(this.bttnGenerar_Click);
            // 
            // lblGenerar
            // 
            this.lblGenerar.AutoSize = true;
            this.lblGenerar.Location = new System.Drawing.Point(13, 124);
            this.lblGenerar.Name = "lblGenerar";
            this.lblGenerar.Size = new System.Drawing.Size(106, 13);
            this.lblGenerar.TabIndex = 8;
            this.lblGenerar.Text = "3) Generar rendicion:";
            // 
            // dgvFacturasPagadas
            // 
            this.dgvFacturasPagadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturasPagadas.Location = new System.Drawing.Point(25, 157);
            this.dgvFacturasPagadas.Name = "dgvFacturasPagadas";
            this.dgvFacturasPagadas.ReadOnly = true;
            this.dgvFacturasPagadas.Size = new System.Drawing.Size(781, 254);
            this.dgvFacturasPagadas.TabIndex = 9;
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Location = new System.Drawing.Point(595, 421);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(148, 13);
            this.lblCant.TabIndex = 10;
            this.lblCant.Text = "Cantidad de facturas rendidas";
            // 
            // tbCant
            // 
            this.tbCant.Enabled = false;
            this.tbCant.Location = new System.Drawing.Point(748, 418);
            this.tbCant.Name = "tbCant";
            this.tbCant.Size = new System.Drawing.Size(58, 20);
            this.tbCant.TabIndex = 11;
            // 
            // lblImporteComision
            // 
            this.lblImporteComision.AutoSize = true;
            this.lblImporteComision.Location = new System.Drawing.Point(25, 421);
            this.lblImporteComision.Name = "lblImporteComision";
            this.lblImporteComision.Size = new System.Drawing.Size(209, 13);
            this.lblImporteComision.TabIndex = 12;
            this.lblImporteComision.Text = "Importe – comisión por el cobro de facturas";
            // 
            // tbImporteComision
            // 
            this.tbImporteComision.Enabled = false;
            this.tbImporteComision.Location = new System.Drawing.Point(240, 418);
            this.tbImporteComision.Name = "tbImporteComision";
            this.tbImporteComision.Size = new System.Drawing.Size(100, 20);
            this.tbImporteComision.TabIndex = 13;
            // 
            // lblImporteRendicion
            // 
            this.lblImporteRendicion.AutoSize = true;
            this.lblImporteRendicion.Location = new System.Drawing.Point(346, 421);
            this.lblImporteRendicion.Name = "lblImporteRendicion";
            this.lblImporteRendicion.Size = new System.Drawing.Size(137, 13);
            this.lblImporteRendicion.TabIndex = 14;
            this.lblImporteRendicion.Text = "Importe total de la rendición";
            // 
            // tbTotalRendicion
            // 
            this.tbTotalRendicion.Enabled = false;
            this.tbTotalRendicion.Location = new System.Drawing.Point(489, 418);
            this.tbTotalRendicion.Name = "tbTotalRendicion";
            this.tbTotalRendicion.Size = new System.Drawing.Size(100, 20);
            this.tbTotalRendicion.TabIndex = 15;
            // 
            // bttnGuardar
            // 
            this.bttnGuardar.Location = new System.Drawing.Point(79, 450);
            this.bttnGuardar.Name = "bttnGuardar";
            this.bttnGuardar.Size = new System.Drawing.Size(75, 23);
            this.bttnGuardar.TabIndex = 16;
            this.bttnGuardar.Text = "Guardar";
            this.bttnGuardar.UseVisualStyleBackColor = true;
            this.bttnGuardar.Click += new System.EventHandler(this.bttnGuardar_Click);
            // 
            // lblGuardar
            // 
            this.lblGuardar.AutoSize = true;
            this.lblGuardar.Location = new System.Drawing.Point(13, 455);
            this.lblGuardar.Name = "lblGuardar";
            this.lblGuardar.Size = new System.Drawing.Size(60, 13);
            this.lblGuardar.TabIndex = 17;
            this.lblGuardar.Text = "4) Guardar:";
            // 
            // Rendiciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 500);
            this.Controls.Add(this.lblGuardar);
            this.Controls.Add(this.bttnGuardar);
            this.Controls.Add(this.tbTotalRendicion);
            this.Controls.Add(this.lblImporteRendicion);
            this.Controls.Add(this.tbImporteComision);
            this.Controls.Add(this.lblImporteComision);
            this.Controls.Add(this.tbCant);
            this.Controls.Add(this.lblCant);
            this.Controls.Add(this.dgvFacturasPagadas);
            this.Controls.Add(this.lblGenerar);
            this.Controls.Add(this.bttnGenerar);
            this.Controls.Add(this.tbPorcentaje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEmpresa);
            this.Controls.Add(this.bttnSelecEmpresa);
            this.Controls.Add(this.lblSelecEmpresa);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Name = "Rendiciones";
            this.Text = "Rendición Factura";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturasPagadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblSelecEmpresa;
        private System.Windows.Forms.Button bttnSelecEmpresa;
        private System.Windows.Forms.TextBox tbEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPorcentaje;
        private System.Windows.Forms.Button bttnGenerar;
        private System.Windows.Forms.Label lblGenerar;
        private System.Windows.Forms.DataGridView dgvFacturasPagadas;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.TextBox tbCant;
        private System.Windows.Forms.Label lblImporteComision;
        private System.Windows.Forms.TextBox tbImporteComision;
        private System.Windows.Forms.Label lblImporteRendicion;
        private System.Windows.Forms.TextBox tbTotalRendicion;
        private System.Windows.Forms.Button bttnGuardar;
        private System.Windows.Forms.Label lblGuardar;

    }
}