namespace PagoAgilFrba.FrontEnd.RegistroPago
{
    partial class MediosDePago
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
            this.cbMediosDePago = new System.Windows.Forms.ComboBox();
            this.tbImporte = new System.Windows.Forms.TextBox();
            this.bttnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbMediosDePago
            // 
            this.cbMediosDePago.FormattingEnabled = true;
            this.cbMediosDePago.Location = new System.Drawing.Point(39, 12);
            this.cbMediosDePago.Name = "cbMediosDePago";
            this.cbMediosDePago.Size = new System.Drawing.Size(152, 21);
            this.cbMediosDePago.TabIndex = 0;
            // 
            // tbImporte
            // 
            this.tbImporte.Location = new System.Drawing.Point(39, 40);
            this.tbImporte.Name = "tbImporte";
            this.tbImporte.Size = new System.Drawing.Size(152, 20);
            this.tbImporte.TabIndex = 1;
            // 
            // bttnAgregar
            // 
            this.bttnAgregar.Location = new System.Drawing.Point(83, 66);
            this.bttnAgregar.Name = "bttnAgregar";
            this.bttnAgregar.Size = new System.Drawing.Size(75, 23);
            this.bttnAgregar.TabIndex = 2;
            this.bttnAgregar.Text = "Agregar";
            this.bttnAgregar.UseVisualStyleBackColor = true;
            this.bttnAgregar.Click += new System.EventHandler(this.bttnAgregar_Click);
            // 
            // MediosDePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 97);
            this.Controls.Add(this.bttnAgregar);
            this.Controls.Add(this.tbImporte);
            this.Controls.Add(this.cbMediosDePago);
            this.Name = "MediosDePago";
            this.Text = "MediosDePago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMediosDePago;
        private System.Windows.Forms.TextBox tbImporte;
        private System.Windows.Forms.Button bttnAgregar;
    }
}