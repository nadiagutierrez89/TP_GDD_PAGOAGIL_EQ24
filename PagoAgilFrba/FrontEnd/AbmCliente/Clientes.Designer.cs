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
            this.dni_clie = new System.Windows.Forms.TextBox();
            this.apellido_clie = new System.Windows.Forms.TextBox();
            this.nombre_clie = new System.Windows.Forms.TextBox();
            this.cliente_but_buscar = new System.Windows.Forms.Button();
            this.cliente_but_modificar = new System.Windows.Forms.Button();
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.bttnSeleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // clientes_but_alta
            // 
            this.clientes_but_alta.Location = new System.Drawing.Point(552, 244);
            this.clientes_but_alta.Name = "clientes_but_alta";
            this.clientes_but_alta.Size = new System.Drawing.Size(75, 23);
            this.clientes_but_alta.TabIndex = 0;
            this.clientes_but_alta.Text = "Alta";
            this.clientes_but_alta.UseVisualStyleBackColor = true;
            this.clientes_but_alta.Click += new System.EventHandler(this.clientes_but_alta_Click);
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
            // dni_clie
            // 
            this.dni_clie.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dni_clie.Location = new System.Drawing.Point(193, 42);
            this.dni_clie.Name = "dni_clie";
            this.dni_clie.Size = new System.Drawing.Size(79, 20);
            this.dni_clie.TabIndex = 17;
            // 
            // apellido_clie
            // 
            this.apellido_clie.Location = new System.Drawing.Point(109, 42);
            this.apellido_clie.Name = "apellido_clie";
            this.apellido_clie.Size = new System.Drawing.Size(78, 20);
            this.apellido_clie.TabIndex = 16;
            // 
            // nombre_clie
            // 
            this.nombre_clie.Location = new System.Drawing.Point(16, 42);
            this.nombre_clie.Name = "nombre_clie";
            this.nombre_clie.Size = new System.Drawing.Size(87, 20);
            this.nombre_clie.TabIndex = 15;
            // 
            // cliente_but_buscar
            // 
            this.cliente_but_buscar.Location = new System.Drawing.Point(278, 42);
            this.cliente_but_buscar.Name = "cliente_but_buscar";
            this.cliente_but_buscar.Size = new System.Drawing.Size(75, 23);
            this.cliente_but_buscar.TabIndex = 21;
            this.cliente_but_buscar.Text = "Buscar";
            this.cliente_but_buscar.UseVisualStyleBackColor = true;
            this.cliente_but_buscar.Click += new System.EventHandler(this.cliente_but_buscar_Click);
            // 
            // cliente_but_modificar
            // 
            this.cliente_but_modificar.Location = new System.Drawing.Point(633, 244);
            this.cliente_but_modificar.Name = "cliente_but_modificar";
            this.cliente_but_modificar.Size = new System.Drawing.Size(75, 23);
            this.cliente_but_modificar.TabIndex = 26;
            this.cliente_but_modificar.Text = "Modificar";
            this.cliente_but_modificar.UseVisualStyleBackColor = true;
            this.cliente_but_modificar.Click += new System.EventHandler(this.cliente_but_modificar_Click);
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Location = new System.Drawing.Point(16, 83);
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.Size = new System.Drawing.Size(692, 155);
            this.dgv_clientes.TabIndex = 28;
            // 
            // bttnSeleccionar
            // 
            this.bttnSeleccionar.Location = new System.Drawing.Point(471, 243);
            this.bttnSeleccionar.Name = "bttnSeleccionar";
            this.bttnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.bttnSeleccionar.TabIndex = 29;
            this.bttnSeleccionar.Text = "Seleccionar";
            this.bttnSeleccionar.UseVisualStyleBackColor = true;
            this.bttnSeleccionar.Visible = false;
            this.bttnSeleccionar.Click += new System.EventHandler(this.bttnSeleccionar_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 299);
            this.Controls.Add(this.bttnSeleccionar);
            this.Controls.Add(this.dgv_clientes);
            this.Controls.Add(this.cliente_but_modificar);
            this.Controls.Add(this.cliente_but_buscar);
            this.Controls.Add(this.cliente_lab_dni);
            this.Controls.Add(this.cliente_lab_apellido);
            this.Controls.Add(this.cliente_lab_nombre);
            this.Controls.Add(this.dni_clie);
            this.Controls.Add(this.apellido_clie);
            this.Controls.Add(this.nombre_clie);
            this.Controls.Add(this.clientes_but_alta);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.mi_dgv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clientes_but_alta;
        private System.Windows.Forms.Label cliente_lab_dni;
        private System.Windows.Forms.Label cliente_lab_apellido;
        private System.Windows.Forms.Label cliente_lab_nombre;
        private System.Windows.Forms.TextBox dni_clie;
        private System.Windows.Forms.TextBox apellido_clie;
        private System.Windows.Forms.TextBox nombre_clie;
        private System.Windows.Forms.Button cliente_but_buscar;
        private System.Windows.Forms.Button cliente_but_modificar;
        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.Button bttnSeleccionar;
    }
}