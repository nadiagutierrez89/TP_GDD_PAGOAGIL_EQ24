namespace PagoAgilFrba.FrontEnd.AbmCliente
{
    partial class Clientes
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
            this.clientes_but_alta = new System.Windows.Forms.Button();
            this.cliente_lab_dni = new System.Windows.Forms.Label();
            this.cliente_lab_apellido = new System.Windows.Forms.Label();
            this.cliente_lab_nombre = new System.Windows.Forms.Label();
            this.cliente_tb_dni = new System.Windows.Forms.TextBox();
            this.cliente_tb_apellido = new System.Windows.Forms.TextBox();
            this.cliente_tb_nombre = new System.Windows.Forms.TextBox();
            this.cliente_but_buscar = new System.Windows.Forms.Button();
            this.cliente_but_modificar = new System.Windows.Forms.Button();
            this.cliente_but_baja = new System.Windows.Forms.Button();
            this.clientes_dgv_listado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.clientes_dgv_listado)).BeginInit();
            this.SuspendLayout();
            // 
            // clientes_but_alta
            // 
            this.clientes_but_alta.Location = new System.Drawing.Point(278, 97);
            this.clientes_but_alta.Name = "clientes_but_alta";
            this.clientes_but_alta.Size = new System.Drawing.Size(75, 23);
            this.clientes_but_alta.TabIndex = 0;
            this.clientes_but_alta.Text = "Alta";
            this.clientes_but_alta.UseVisualStyleBackColor = true;
            // 
            // cliente_lab_dni
            // 
            this.cliente_lab_dni.AutoSize = true;
            this.cliente_lab_dni.Location = new System.Drawing.Point(193, 23);
            this.cliente_lab_dni.Name = "cliente_lab_dni";
            this.cliente_lab_dni.Size = new System.Drawing.Size(29, 13);
            this.cliente_lab_dni.TabIndex = 20;
            this.cliente_lab_dni.Text = "DNI:";
            // 
            // cliente_lab_apellido
            // 
            this.cliente_lab_apellido.AutoSize = true;
            this.cliente_lab_apellido.Location = new System.Drawing.Point(106, 23);
            this.cliente_lab_apellido.Name = "cliente_lab_apellido";
            this.cliente_lab_apellido.Size = new System.Drawing.Size(47, 13);
            this.cliente_lab_apellido.TabIndex = 19;
            this.cliente_lab_apellido.Text = "Apellido:";
            // 
            // cliente_lab_nombre
            // 
            this.cliente_lab_nombre.AutoSize = true;
            this.cliente_lab_nombre.Location = new System.Drawing.Point(12, 23);
            this.cliente_lab_nombre.Name = "cliente_lab_nombre";
            this.cliente_lab_nombre.Size = new System.Drawing.Size(47, 13);
            this.cliente_lab_nombre.TabIndex = 18;
            this.cliente_lab_nombre.Text = "Nombre:";
            // 
            // cliente_tb_dni
            // 
            this.cliente_tb_dni.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cliente_tb_dni.Location = new System.Drawing.Point(193, 42);
            this.cliente_tb_dni.Name = "cliente_tb_dni";
            this.cliente_tb_dni.Size = new System.Drawing.Size(79, 20);
            this.cliente_tb_dni.TabIndex = 17;
            // 
            // cliente_tb_apellido
            // 
            this.cliente_tb_apellido.Location = new System.Drawing.Point(109, 42);
            this.cliente_tb_apellido.Name = "cliente_tb_apellido";
            this.cliente_tb_apellido.Size = new System.Drawing.Size(78, 20);
            this.cliente_tb_apellido.TabIndex = 16;
            // 
            // cliente_tb_nombre
            // 
            this.cliente_tb_nombre.Location = new System.Drawing.Point(16, 42);
            this.cliente_tb_nombre.Name = "cliente_tb_nombre";
            this.cliente_tb_nombre.Size = new System.Drawing.Size(87, 20);
            this.cliente_tb_nombre.TabIndex = 15;
            // 
            // cliente_but_buscar
            // 
            this.cliente_but_buscar.Location = new System.Drawing.Point(278, 42);
            this.cliente_but_buscar.Name = "cliente_but_buscar";
            this.cliente_but_buscar.Size = new System.Drawing.Size(75, 23);
            this.cliente_but_buscar.TabIndex = 21;
            this.cliente_but_buscar.Text = "Buscar";
            this.cliente_but_buscar.UseVisualStyleBackColor = true;
            // 
            // cliente_but_modificar
            // 
            this.cliente_but_modificar.Location = new System.Drawing.Point(278, 126);
            this.cliente_but_modificar.Name = "cliente_but_modificar";
            this.cliente_but_modificar.Size = new System.Drawing.Size(75, 23);
            this.cliente_but_modificar.TabIndex = 26;
            this.cliente_but_modificar.Text = "Modificar";
            this.cliente_but_modificar.UseVisualStyleBackColor = true;
            // 
            // cliente_but_baja
            // 
            this.cliente_but_baja.Location = new System.Drawing.Point(278, 155);
            this.cliente_but_baja.Name = "cliente_but_baja";
            this.cliente_but_baja.Size = new System.Drawing.Size(75, 23);
            this.cliente_but_baja.TabIndex = 27;
            this.cliente_but_baja.Text = "Baja";
            this.cliente_but_baja.UseVisualStyleBackColor = true;
            // 
            // clientes_dgv_listado
            // 
            this.clientes_dgv_listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientes_dgv_listado.Location = new System.Drawing.Point(16, 69);
            this.clientes_dgv_listado.Name = "clientes_dgv_listado";
            this.clientes_dgv_listado.Size = new System.Drawing.Size(256, 180);
            this.clientes_dgv_listado.TabIndex = 28;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 261);
            this.Controls.Add(this.clientes_dgv_listado);
            this.Controls.Add(this.cliente_but_baja);
            this.Controls.Add(this.cliente_but_modificar);
            this.Controls.Add(this.cliente_but_buscar);
            this.Controls.Add(this.cliente_lab_dni);
            this.Controls.Add(this.cliente_lab_apellido);
            this.Controls.Add(this.cliente_lab_nombre);
            this.Controls.Add(this.cliente_tb_dni);
            this.Controls.Add(this.cliente_tb_apellido);
            this.Controls.Add(this.cliente_tb_nombre);
            this.Controls.Add(this.clientes_but_alta);
            this.Name = "Clientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.clientes_dgv_listado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clientes_but_alta;
        private System.Windows.Forms.Label cliente_lab_dni;
        private System.Windows.Forms.Label cliente_lab_apellido;
        private System.Windows.Forms.Label cliente_lab_nombre;
        private System.Windows.Forms.TextBox cliente_tb_dni;
        private System.Windows.Forms.TextBox cliente_tb_apellido;
        private System.Windows.Forms.TextBox cliente_tb_nombre;
        private System.Windows.Forms.Button cliente_but_buscar;
        private System.Windows.Forms.Button cliente_but_modificar;
        private System.Windows.Forms.Button cliente_but_baja;
        private System.Windows.Forms.DataGridView clientes_dgv_listado;
    }
}