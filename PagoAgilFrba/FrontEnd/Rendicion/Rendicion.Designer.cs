namespace PagoAgilFrba.FrontEnd.Rendicion
{
    partial class Rendicion
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
            this.rendicion_cb_empresas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // rendicion_cb_empresas
            // 
            this.rendicion_cb_empresas.FormattingEnabled = true;
            this.rendicion_cb_empresas.Location = new System.Drawing.Point(13, 34);
            this.rendicion_cb_empresas.Name = "rendicion_cb_empresas";
            this.rendicion_cb_empresas.Size = new System.Drawing.Size(121, 21);
            this.rendicion_cb_empresas.TabIndex = 0;
            // 
            // Rendicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rendicion_cb_empresas);
            this.Name = "Rendicion";
            this.Text = "Rendición Factura";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox rendicion_cb_empresas;
    }
}