namespace PagoAgilFrba.FrontEnd.AbmRol
{
    partial class Roles
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
            this.roles_but_alta = new System.Windows.Forms.Button();
            this.roles_but_baja = new System.Windows.Forms.Button();
            this.roles_but_modificacion = new System.Windows.Forms.Button();
            this.roles_label_rol = new System.Windows.Forms.Label();
            this.roles_lab_funcionalidades = new System.Windows.Forms.Label();
            this.rol_dgv_listado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.rol_dgv_listado)).BeginInit();
            this.SuspendLayout();
            // 
            // roles_but_alta
            // 
            this.roles_but_alta.Location = new System.Drawing.Point(26, 207);
            this.roles_but_alta.Name = "roles_but_alta";
            this.roles_but_alta.Size = new System.Drawing.Size(75, 23);
            this.roles_but_alta.TabIndex = 1;
            this.roles_but_alta.Text = "Alta";
            this.roles_but_alta.UseVisualStyleBackColor = true;
            // 
            // roles_but_baja
            // 
            this.roles_but_baja.Location = new System.Drawing.Point(197, 207);
            this.roles_but_baja.Name = "roles_but_baja";
            this.roles_but_baja.Size = new System.Drawing.Size(75, 23);
            this.roles_but_baja.TabIndex = 2;
            this.roles_but_baja.Text = "Baja";
            this.roles_but_baja.UseVisualStyleBackColor = true;
            // 
            // roles_but_modificacion
            // 
            this.roles_but_modificacion.Location = new System.Drawing.Point(108, 206);
            this.roles_but_modificacion.Name = "roles_but_modificacion";
            this.roles_but_modificacion.Size = new System.Drawing.Size(75, 23);
            this.roles_but_modificacion.TabIndex = 3;
            this.roles_but_modificacion.Text = "Modificación";
            this.roles_but_modificacion.UseVisualStyleBackColor = true;
            // 
            // roles_label_rol
            // 
            this.roles_label_rol.AutoSize = true;
            this.roles_label_rol.Location = new System.Drawing.Point(13, 13);
            this.roles_label_rol.Name = "roles_label_rol";
            this.roles_label_rol.Size = new System.Drawing.Size(23, 13);
            this.roles_label_rol.TabIndex = 4;
            this.roles_label_rol.Text = "Rol";
            // 
            // roles_lab_funcionalidades
            // 
            this.roles_lab_funcionalidades.AutoSize = true;
            this.roles_lab_funcionalidades.Location = new System.Drawing.Point(89, 13);
            this.roles_lab_funcionalidades.Name = "roles_lab_funcionalidades";
            this.roles_lab_funcionalidades.Size = new System.Drawing.Size(84, 13);
            this.roles_lab_funcionalidades.TabIndex = 5;
            this.roles_lab_funcionalidades.Text = "Funcionalidades";
            // 
            // rol_dgv_listado
            // 
            this.rol_dgv_listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rol_dgv_listado.Location = new System.Drawing.Point(13, 30);
            this.rol_dgv_listado.Name = "rol_dgv_listado";
            this.rol_dgv_listado.Size = new System.Drawing.Size(240, 150);
            this.rol_dgv_listado.TabIndex = 6;
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rol_dgv_listado);
            this.Controls.Add(this.roles_lab_funcionalidades);
            this.Controls.Add(this.roles_label_rol);
            this.Controls.Add(this.roles_but_modificacion);
            this.Controls.Add(this.roles_but_baja);
            this.Controls.Add(this.roles_but_alta);
            this.Name = "Roles";
            this.Text = "Rol";
            ((System.ComponentModel.ISupportInitialize)(this.rol_dgv_listado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button roles_but_alta;
        private System.Windows.Forms.Button roles_but_baja;
        private System.Windows.Forms.Button roles_but_modificacion;
        private System.Windows.Forms.Label roles_label_rol;
        private System.Windows.Forms.Label roles_lab_funcionalidades;
        private System.Windows.Forms.DataGridView rol_dgv_listado;
    }
}