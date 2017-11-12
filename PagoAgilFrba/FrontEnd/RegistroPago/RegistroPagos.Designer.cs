namespace PagoAgilFrba.FrontEnd.RegistroPago
{
    partial class RegistroPagos
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
            this.registropago_lab_total = new System.Windows.Forms.Label();
            this.registropago_but_agregar = new System.Windows.Forms.Button();
            this.registropago_but_pagar = new System.Windows.Forms.Button();
            this.registroPago_dgv_listado = new System.Windows.Forms.DataGridView();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbSucursal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnQuitar = new System.Windows.Forms.Button();
            this.lblseleccionCliente = new System.Windows.Forms.Label();
            this.bttnSeleccionCliente = new System.Windows.Forms.Button();
            this.tbCliente = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvMediosDePago = new System.Windows.Forms.DataGridView();
            this.bttnQuitarFormaPago = new System.Windows.Forms.Button();
            this.bttnAgregarFormaPago = new System.Windows.Forms.Button();
            this.tbTotalMediosDePago = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.registroPago_dgv_listado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMediosDePago)).BeginInit();
            this.SuspendLayout();
            // 
            // registropago_lab_total
            // 
            this.registropago_lab_total.AutoSize = true;
            this.registropago_lab_total.Location = new System.Drawing.Point(513, 255);
            this.registropago_lab_total.Name = "registropago_lab_total";
            this.registropago_lab_total.Size = new System.Drawing.Size(34, 13);
            this.registropago_lab_total.TabIndex = 20;
            this.registropago_lab_total.Text = "Total:";
            // 
            // registropago_but_agregar
            // 
            this.registropago_but_agregar.Location = new System.Drawing.Point(553, 41);
            this.registropago_but_agregar.Name = "registropago_but_agregar";
            this.registropago_but_agregar.Size = new System.Drawing.Size(100, 23);
            this.registropago_but_agregar.TabIndex = 21;
            this.registropago_but_agregar.Text = "Agregar factura";
            this.registropago_but_agregar.UseVisualStyleBackColor = true;
            this.registropago_but_agregar.Click += new System.EventHandler(this.registropago_but_agregar_Click);
            // 
            // registropago_but_pagar
            // 
            this.registropago_but_pagar.Location = new System.Drawing.Point(279, 521);
            this.registropago_but_pagar.Name = "registropago_but_pagar";
            this.registropago_but_pagar.Size = new System.Drawing.Size(61, 23);
            this.registropago_but_pagar.TabIndex = 22;
            this.registropago_but_pagar.Text = "Pagar";
            this.registropago_but_pagar.UseVisualStyleBackColor = true;
            this.registropago_but_pagar.Click += new System.EventHandler(this.registropago_but_pagar_Click);
            // 
            // registroPago_dgv_listado
            // 
            this.registroPago_dgv_listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registroPago_dgv_listado.Location = new System.Drawing.Point(18, 70);
            this.registroPago_dgv_listado.Name = "registroPago_dgv_listado";
            this.registroPago_dgv_listado.Size = new System.Drawing.Size(635, 176);
            this.registroPago_dgv_listado.TabIndex = 24;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(20, 15);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(46, 13);
            this.lblUser.TabIndex = 25;
            this.lblUser.Text = "Usuario:";
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Location = new System.Drawing.Point(179, 15);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(51, 13);
            this.lblSucursal.TabIndex = 26;
            this.lblSucursal.Text = "Sucursal:";
            // 
            // tbUser
            // 
            this.tbUser.Enabled = false;
            this.tbUser.Location = new System.Drawing.Point(69, 12);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(100, 20);
            this.tbUser.TabIndex = 27;
            // 
            // tbSucursal
            // 
            this.tbSucursal.Enabled = false;
            this.tbSucursal.Location = new System.Drawing.Point(233, 12);
            this.tbSucursal.Name = "tbSucursal";
            this.tbSucursal.Size = new System.Drawing.Size(184, 20);
            this.tbSucursal.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "1) Facturas a pagar:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bttnQuitar
            // 
            this.bttnQuitar.Location = new System.Drawing.Point(447, 41);
            this.bttnQuitar.Name = "bttnQuitar";
            this.bttnQuitar.Size = new System.Drawing.Size(100, 23);
            this.bttnQuitar.TabIndex = 30;
            this.bttnQuitar.Text = "Quitar Factura";
            this.bttnQuitar.UseVisualStyleBackColor = true;
            this.bttnQuitar.Click += new System.EventHandler(this.bttnQuitar_Click);
            // 
            // lblseleccionCliente
            // 
            this.lblseleccionCliente.AutoSize = true;
            this.lblseleccionCliente.Location = new System.Drawing.Point(15, 286);
            this.lblseleccionCliente.Name = "lblseleccionCliente";
            this.lblseleccionCliente.Size = new System.Drawing.Size(109, 13);
            this.lblseleccionCliente.TabIndex = 31;
            this.lblseleccionCliente.Text = "2) Seleccione cliente:";
            // 
            // bttnSeleccionCliente
            // 
            this.bttnSeleccionCliente.Location = new System.Drawing.Point(130, 281);
            this.bttnSeleccionCliente.Name = "bttnSeleccionCliente";
            this.bttnSeleccionCliente.Size = new System.Drawing.Size(100, 23);
            this.bttnSeleccionCliente.TabIndex = 32;
            this.bttnSeleccionCliente.Text = "Seleccionar";
            this.bttnSeleccionCliente.UseVisualStyleBackColor = true;
            this.bttnSeleccionCliente.Click += new System.EventHandler(this.bttnSeleccionCliente_Click);
            // 
            // tbCliente
            // 
            this.tbCliente.Enabled = false;
            this.tbCliente.Location = new System.Drawing.Point(237, 283);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.Size = new System.Drawing.Size(284, 20);
            this.tbCliente.TabIndex = 33;
            // 
            // tbTotal
            // 
            this.tbTotal.Enabled = false;
            this.tbTotal.Location = new System.Drawing.Point(553, 252);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(100, 20);
            this.tbTotal.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "3) Forma de pago:";
            // 
            // dgvMediosDePago
            // 
            this.dgvMediosDePago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMediosDePago.Location = new System.Drawing.Point(18, 343);
            this.dgvMediosDePago.Name = "dgvMediosDePago";
            this.dgvMediosDePago.Size = new System.Drawing.Size(635, 150);
            this.dgvMediosDePago.TabIndex = 36;
            // 
            // bttnQuitarFormaPago
            // 
            this.bttnQuitarFormaPago.Location = new System.Drawing.Point(346, 316);
            this.bttnQuitarFormaPago.Name = "bttnQuitarFormaPago";
            this.bttnQuitarFormaPago.Size = new System.Drawing.Size(150, 23);
            this.bttnQuitarFormaPago.TabIndex = 38;
            this.bttnQuitarFormaPago.Text = "Quitar Forma De Pago";
            this.bttnQuitarFormaPago.UseVisualStyleBackColor = true;
            this.bttnQuitarFormaPago.Click += new System.EventHandler(this.bttnQuitarFormaPago_Click);
            // 
            // bttnAgregarFormaPago
            // 
            this.bttnAgregarFormaPago.Location = new System.Drawing.Point(502, 316);
            this.bttnAgregarFormaPago.Name = "bttnAgregarFormaPago";
            this.bttnAgregarFormaPago.Size = new System.Drawing.Size(150, 23);
            this.bttnAgregarFormaPago.TabIndex = 37;
            this.bttnAgregarFormaPago.Text = "Agregar Forma De Pago";
            this.bttnAgregarFormaPago.UseVisualStyleBackColor = true;
            this.bttnAgregarFormaPago.Click += new System.EventHandler(this.bttnAgregarFormaPago_Click);
            // 
            // tbTotalMediosDePago
            // 
            this.tbTotalMediosDePago.Enabled = false;
            this.tbTotalMediosDePago.Location = new System.Drawing.Point(553, 499);
            this.tbTotalMediosDePago.Name = "tbTotalMediosDePago";
            this.tbTotalMediosDePago.Size = new System.Drawing.Size(100, 20);
            this.tbTotalMediosDePago.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(513, 502);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Total:";
            // 
            // RegistroPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 581);
            this.Controls.Add(this.tbTotalMediosDePago);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bttnQuitarFormaPago);
            this.Controls.Add(this.bttnAgregarFormaPago);
            this.Controls.Add(this.dgvMediosDePago);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.tbCliente);
            this.Controls.Add(this.bttnSeleccionCliente);
            this.Controls.Add(this.lblseleccionCliente);
            this.Controls.Add(this.bttnQuitar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSucursal);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.lblSucursal);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.registroPago_dgv_listado);
            this.Controls.Add(this.registropago_but_pagar);
            this.Controls.Add(this.registropago_but_agregar);
            this.Controls.Add(this.registropago_lab_total);
            this.Name = "RegistroPagos";
            this.Text = "Registrar Pago";
            ((System.ComponentModel.ISupportInitialize)(this.registroPago_dgv_listado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMediosDePago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label registropago_lab_total;
        private System.Windows.Forms.Button registropago_but_agregar;
        private System.Windows.Forms.Button registropago_but_pagar;
        private System.Windows.Forms.DataGridView registroPago_dgv_listado;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbSucursal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnQuitar;
        private System.Windows.Forms.Label lblseleccionCliente;
        private System.Windows.Forms.Button bttnSeleccionCliente;
        private System.Windows.Forms.TextBox tbCliente;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvMediosDePago;
        private System.Windows.Forms.Button bttnQuitarFormaPago;
        private System.Windows.Forms.Button bttnAgregarFormaPago;
        private System.Windows.Forms.TextBox tbTotalMediosDePago;
        private System.Windows.Forms.Label label3;
    }
}