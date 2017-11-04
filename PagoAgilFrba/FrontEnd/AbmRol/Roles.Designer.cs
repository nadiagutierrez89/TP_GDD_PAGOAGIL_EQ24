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
            this.roles_tab_rolFuncionalidades = new System.Windows.Forms.TableLayoutPanel();
            this.roles_but_alta = new System.Windows.Forms.Button();
            this.roles_but_baja = new System.Windows.Forms.Button();
            this.roles_but_modificacion = new System.Windows.Forms.Button();
            this.roles_label_rol = new System.Windows.Forms.Label();
            this.roles_but_funcionalidades = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // roles_tab_rolFuncionalidades
            // 
            this.roles_tab_rolFuncionalidades.ColumnCount = 2;
            this.roles_tab_rolFuncionalidades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.30769F));
            this.roles_tab_rolFuncionalidades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.69231F));
            this.roles_tab_rolFuncionalidades.Location = new System.Drawing.Point(12, 33);
            this.roles_tab_rolFuncionalidades.Name = "roles_tab_rolFuncionalidades";
            this.roles_tab_rolFuncionalidades.RowCount = 3;
            this.roles_tab_rolFuncionalidades.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.roles_tab_rolFuncionalidades.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.roles_tab_rolFuncionalidades.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83F));
            this.roles_tab_rolFuncionalidades.Size = new System.Drawing.Size(260, 108);
            this.roles_tab_rolFuncionalidades.TabIndex = 0;
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
            // roles_but_funcionalidades
            // 
            this.roles_but_funcionalidades.AutoSize = true;
            this.roles_but_funcionalidades.Location = new System.Drawing.Point(89, 13);
            this.roles_but_funcionalidades.Name = "roles_but_funcionalidades";
            this.roles_but_funcionalidades.Size = new System.Drawing.Size(84, 13);
            this.roles_but_funcionalidades.TabIndex = 5;
            this.roles_but_funcionalidades.Text = "Funcionalidades";
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.roles_but_funcionalidades);
            this.Controls.Add(this.roles_label_rol);
            this.Controls.Add(this.roles_but_modificacion);
            this.Controls.Add(this.roles_but_baja);
            this.Controls.Add(this.roles_but_alta);
            this.Controls.Add(this.roles_tab_rolFuncionalidades);
            this.Name = "Roles";
            this.Text = "Rol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel roles_tab_rolFuncionalidades;
        private System.Windows.Forms.Button roles_but_alta;
        private System.Windows.Forms.Button roles_but_baja;
        private System.Windows.Forms.Button roles_but_modificacion;
        private System.Windows.Forms.Label roles_label_rol;
        private System.Windows.Forms.Label roles_but_funcionalidades;
    }
}