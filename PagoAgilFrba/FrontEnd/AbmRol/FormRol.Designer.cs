namespace PagoAgilFrba.FrontEnd.AbmRol
{
    partial class FormRol
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvFuncionalidades = new System.Windows.Forms.DataGridView();
            this.txtNombreRol = new System.Windows.Forms.TextBox();
            this.lblNombreRol = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cbHabilitado = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(330, 392);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvFuncionalidades
            // 
            this.dgvFuncionalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionalidades.Location = new System.Drawing.Point(12, 109);
            this.dgvFuncionalidades.Name = "dgvFuncionalidades";
            this.dgvFuncionalidades.Size = new System.Drawing.Size(393, 277);
            this.dgvFuncionalidades.TabIndex = 11;
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Location = new System.Drawing.Point(13, 60);
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(216, 20);
            this.txtNombreRol.TabIndex = 9;
            // 
            // lblNombreRol
            // 
            this.lblNombreRol.AutoSize = true;
            this.lblNombreRol.Location = new System.Drawing.Point(10, 44);
            this.lblNombreRol.Name = "lblNombreRol";
            this.lblNombreRol.Size = new System.Drawing.Size(66, 13);
            this.lblNombreRol.TabIndex = 8;
            this.lblNombreRol.Text = "Nombre Rol:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(8, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(98, 24);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Crear Rol";
            // 
            // cbHabilitado
            // 
            this.cbHabilitado.AutoSize = true;
            this.cbHabilitado.Location = new System.Drawing.Point(13, 86);
            this.cbHabilitado.Name = "cbHabilitado";
            this.cbHabilitado.Size = new System.Drawing.Size(73, 17);
            this.cbHabilitado.TabIndex = 14;
            this.cbHabilitado.Text = "Habilitado";
            this.cbHabilitado.UseVisualStyleBackColor = true;
            // 
            // FormRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 425);
            this.Controls.Add(this.cbHabilitado);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvFuncionalidades);
            this.Controls.Add(this.txtNombreRol);
            this.Controls.Add(this.lblNombreRol);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormRol";
            this.Text = "FormRol";
            this.Load += new System.EventHandler(this.FormRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionalidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvFuncionalidades;
        private System.Windows.Forms.TextBox txtNombreRol;
        private System.Windows.Forms.Label lblNombreRol;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.CheckBox cbHabilitado;
    }
}