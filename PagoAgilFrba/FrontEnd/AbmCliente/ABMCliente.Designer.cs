namespace PagoAgilFrba.FrontEnd.AbmCliente
{
    partial class ABMCliente
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
            this.abmcliente_tb_nombre = new System.Windows.Forms.TextBox();
            this.abmcliente_tb_apellido = new System.Windows.Forms.TextBox();
            this.abmcliente_tb_dni = new System.Windows.Forms.TextBox();
            this.abmcliente_mtb_email = new System.Windows.Forms.MaskedTextBox();
            this.abmcliente_tb_calle = new System.Windows.Forms.TextBox();
            this.abmcliente_tb_piso = new System.Windows.Forms.TextBox();
            this.abmcliente_tb_dto = new System.Windows.Forms.TextBox();
            this.abmcliente_tb_cp = new System.Windows.Forms.TextBox();
            this.abmcliente_tb_localidad = new System.Windows.Forms.TextBox();
            this.abmcliente_mtb_telefono = new System.Windows.Forms.MaskedTextBox();
            this.abmcliente_lab_nombre = new System.Windows.Forms.Label();
            this.abmcliente_lab_apellido = new System.Windows.Forms.Label();
            this.abmcliente_lab_dni = new System.Windows.Forms.Label();
            this.abmcliente_lab_fechNac = new System.Windows.Forms.Label();
            this.abmcliente_lab_mail = new System.Windows.Forms.Label();
            this.abmcliente_lab_calle = new System.Windows.Forms.Label();
            this.abmcliente_lab_piso = new System.Windows.Forms.Label();
            this.abmcliente_lab_dto = new System.Windows.Forms.Label();
            this.abmcliente_lab_localidad = new System.Windows.Forms.Label();
            this.abmcliente_lab_codPostal = new System.Windows.Forms.Label();
            this.abmcliente_lab_telefono = new System.Windows.Forms.Label();
            this.abmcliente_chb_baja = new System.Windows.Forms.CheckBox();
            this.abmcliente_but_aceptar = new System.Windows.Forms.Button();
            this.dtp_fec_nac = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // abmcliente_tb_nombre
            // 
            this.abmcliente_tb_nombre.Location = new System.Drawing.Point(13, 42);
            this.abmcliente_tb_nombre.Name = "abmcliente_tb_nombre";
            this.abmcliente_tb_nombre.Size = new System.Drawing.Size(100, 20);
            this.abmcliente_tb_nombre.TabIndex = 0;
            // 
            // abmcliente_tb_apellido
            // 
            this.abmcliente_tb_apellido.Location = new System.Drawing.Point(140, 42);
            this.abmcliente_tb_apellido.Name = "abmcliente_tb_apellido";
            this.abmcliente_tb_apellido.Size = new System.Drawing.Size(200, 20);
            this.abmcliente_tb_apellido.TabIndex = 1;
            // 
            // abmcliente_tb_dni
            // 
            this.abmcliente_tb_dni.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.abmcliente_tb_dni.Location = new System.Drawing.Point(12, 83);
            this.abmcliente_tb_dni.Name = "abmcliente_tb_dni";
            this.abmcliente_tb_dni.Size = new System.Drawing.Size(100, 20);
            this.abmcliente_tb_dni.TabIndex = 2;
            this.abmcliente_tb_dni.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // abmcliente_mtb_email
            // 
            this.abmcliente_mtb_email.Location = new System.Drawing.Point(13, 124);
            this.abmcliente_mtb_email.Name = "abmcliente_mtb_email";
            this.abmcliente_mtb_email.Size = new System.Drawing.Size(327, 20);
            this.abmcliente_mtb_email.TabIndex = 3;
            this.abmcliente_mtb_email.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // abmcliente_tb_calle
            // 
            this.abmcliente_tb_calle.Location = new System.Drawing.Point(12, 164);
            this.abmcliente_tb_calle.Name = "abmcliente_tb_calle";
            this.abmcliente_tb_calle.Size = new System.Drawing.Size(328, 20);
            this.abmcliente_tb_calle.TabIndex = 5;
            // 
            // abmcliente_tb_piso
            // 
            this.abmcliente_tb_piso.Location = new System.Drawing.Point(12, 204);
            this.abmcliente_tb_piso.Name = "abmcliente_tb_piso";
            this.abmcliente_tb_piso.Size = new System.Drawing.Size(44, 20);
            this.abmcliente_tb_piso.TabIndex = 7;
            this.abmcliente_tb_piso.TextChanged += new System.EventHandler(this.abmcliente_tb_piso_TextChanged);
            // 
            // abmcliente_tb_dto
            // 
            this.abmcliente_tb_dto.Location = new System.Drawing.Point(62, 203);
            this.abmcliente_tb_dto.Name = "abmcliente_tb_dto";
            this.abmcliente_tb_dto.Size = new System.Drawing.Size(42, 20);
            this.abmcliente_tb_dto.TabIndex = 8;
            // 
            // abmcliente_tb_cp
            // 
            this.abmcliente_tb_cp.Location = new System.Drawing.Point(12, 246);
            this.abmcliente_tb_cp.Name = "abmcliente_tb_cp";
            this.abmcliente_tb_cp.Size = new System.Drawing.Size(66, 20);
            this.abmcliente_tb_cp.TabIndex = 9;
            this.abmcliente_tb_cp.TextChanged += new System.EventHandler(this.abmcliente_tb_cp_TextChanged);
            // 
            // abmcliente_tb_localidad
            // 
            this.abmcliente_tb_localidad.Location = new System.Drawing.Point(110, 202);
            this.abmcliente_tb_localidad.Name = "abmcliente_tb_localidad";
            this.abmcliente_tb_localidad.Size = new System.Drawing.Size(130, 20);
            this.abmcliente_tb_localidad.TabIndex = 10;
            // 
            // abmcliente_mtb_telefono
            // 
            this.abmcliente_mtb_telefono.Location = new System.Drawing.Point(84, 245);
            this.abmcliente_mtb_telefono.Mask = "(999)000-0000";
            this.abmcliente_mtb_telefono.Name = "abmcliente_mtb_telefono";
            this.abmcliente_mtb_telefono.Size = new System.Drawing.Size(156, 20);
            this.abmcliente_mtb_telefono.TabIndex = 11;
            this.abmcliente_mtb_telefono.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.abmcliente_mtb_telefono_MaskInputRejected);
            // 
            // abmcliente_lab_nombre
            // 
            this.abmcliente_lab_nombre.AutoSize = true;
            this.abmcliente_lab_nombre.Location = new System.Drawing.Point(9, 23);
            this.abmcliente_lab_nombre.Name = "abmcliente_lab_nombre";
            this.abmcliente_lab_nombre.Size = new System.Drawing.Size(47, 13);
            this.abmcliente_lab_nombre.TabIndex = 12;
            this.abmcliente_lab_nombre.Text = "Nombre:";
            // 
            // abmcliente_lab_apellido
            // 
            this.abmcliente_lab_apellido.AutoSize = true;
            this.abmcliente_lab_apellido.Location = new System.Drawing.Point(137, 23);
            this.abmcliente_lab_apellido.Name = "abmcliente_lab_apellido";
            this.abmcliente_lab_apellido.Size = new System.Drawing.Size(47, 13);
            this.abmcliente_lab_apellido.TabIndex = 13;
            this.abmcliente_lab_apellido.Text = "Apellido:";
            // 
            // abmcliente_lab_dni
            // 
            this.abmcliente_lab_dni.AutoSize = true;
            this.abmcliente_lab_dni.Location = new System.Drawing.Point(12, 67);
            this.abmcliente_lab_dni.Name = "abmcliente_lab_dni";
            this.abmcliente_lab_dni.Size = new System.Drawing.Size(29, 13);
            this.abmcliente_lab_dni.TabIndex = 14;
            this.abmcliente_lab_dni.Text = "DNI:";
            // 
            // abmcliente_lab_fechNac
            // 
            this.abmcliente_lab_fechNac.AutoSize = true;
            this.abmcliente_lab_fechNac.Location = new System.Drawing.Point(137, 67);
            this.abmcliente_lab_fechNac.Name = "abmcliente_lab_fechNac";
            this.abmcliente_lab_fechNac.Size = new System.Drawing.Size(93, 13);
            this.abmcliente_lab_fechNac.TabIndex = 15;
            this.abmcliente_lab_fechNac.Text = "Fecha Nacimiento";
            // 
            // abmcliente_lab_mail
            // 
            this.abmcliente_lab_mail.AutoSize = true;
            this.abmcliente_lab_mail.Location = new System.Drawing.Point(12, 108);
            this.abmcliente_lab_mail.Name = "abmcliente_lab_mail";
            this.abmcliente_lab_mail.Size = new System.Drawing.Size(32, 13);
            this.abmcliente_lab_mail.TabIndex = 16;
            this.abmcliente_lab_mail.Text = "Email";
            this.abmcliente_lab_mail.Click += new System.EventHandler(this.label1_Click);
            // 
            // abmcliente_lab_calle
            // 
            this.abmcliente_lab_calle.AutoSize = true;
            this.abmcliente_lab_calle.Location = new System.Drawing.Point(12, 149);
            this.abmcliente_lab_calle.Name = "abmcliente_lab_calle";
            this.abmcliente_lab_calle.Size = new System.Drawing.Size(30, 13);
            this.abmcliente_lab_calle.TabIndex = 17;
            this.abmcliente_lab_calle.Text = "Calle";
            this.abmcliente_lab_calle.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // abmcliente_lab_piso
            // 
            this.abmcliente_lab_piso.AutoSize = true;
            this.abmcliente_lab_piso.Location = new System.Drawing.Point(12, 187);
            this.abmcliente_lab_piso.Name = "abmcliente_lab_piso";
            this.abmcliente_lab_piso.Size = new System.Drawing.Size(27, 13);
            this.abmcliente_lab_piso.TabIndex = 19;
            this.abmcliente_lab_piso.Text = "Piso";
            // 
            // abmcliente_lab_dto
            // 
            this.abmcliente_lab_dto.AutoSize = true;
            this.abmcliente_lab_dto.Location = new System.Drawing.Point(62, 187);
            this.abmcliente_lab_dto.Name = "abmcliente_lab_dto";
            this.abmcliente_lab_dto.Size = new System.Drawing.Size(24, 13);
            this.abmcliente_lab_dto.TabIndex = 20;
            this.abmcliente_lab_dto.Text = "Dto";
            // 
            // abmcliente_lab_localidad
            // 
            this.abmcliente_lab_localidad.AutoSize = true;
            this.abmcliente_lab_localidad.Location = new System.Drawing.Point(107, 187);
            this.abmcliente_lab_localidad.Name = "abmcliente_lab_localidad";
            this.abmcliente_lab_localidad.Size = new System.Drawing.Size(53, 13);
            this.abmcliente_lab_localidad.TabIndex = 21;
            this.abmcliente_lab_localidad.Text = "Localidad";
            // 
            // abmcliente_lab_codPostal
            // 
            this.abmcliente_lab_codPostal.AutoSize = true;
            this.abmcliente_lab_codPostal.Location = new System.Drawing.Point(12, 228);
            this.abmcliente_lab_codPostal.Name = "abmcliente_lab_codPostal";
            this.abmcliente_lab_codPostal.Size = new System.Drawing.Size(72, 13);
            this.abmcliente_lab_codPostal.TabIndex = 22;
            this.abmcliente_lab_codPostal.Text = "Código Postal";
            // 
            // abmcliente_lab_telefono
            // 
            this.abmcliente_lab_telefono.AutoSize = true;
            this.abmcliente_lab_telefono.Location = new System.Drawing.Point(81, 228);
            this.abmcliente_lab_telefono.Name = "abmcliente_lab_telefono";
            this.abmcliente_lab_telefono.Size = new System.Drawing.Size(49, 13);
            this.abmcliente_lab_telefono.TabIndex = 23;
            this.abmcliente_lab_telefono.Text = "Teléfono";
            // 
            // abmcliente_chb_baja
            // 
            this.abmcliente_chb_baja.AutoSize = true;
            this.abmcliente_chb_baja.Location = new System.Drawing.Point(15, 282);
            this.abmcliente_chb_baja.Name = "abmcliente_chb_baja";
            this.abmcliente_chb_baja.Size = new System.Drawing.Size(47, 17);
            this.abmcliente_chb_baja.TabIndex = 24;
            this.abmcliente_chb_baja.Text = "Baja";
            this.abmcliente_chb_baja.UseVisualStyleBackColor = true;
            // 
            // abmcliente_but_aceptar
            // 
            this.abmcliente_but_aceptar.Location = new System.Drawing.Point(265, 276);
            this.abmcliente_but_aceptar.Name = "abmcliente_but_aceptar";
            this.abmcliente_but_aceptar.Size = new System.Drawing.Size(75, 23);
            this.abmcliente_but_aceptar.TabIndex = 26;
            this.abmcliente_but_aceptar.Text = "Guardar";
            this.abmcliente_but_aceptar.UseVisualStyleBackColor = true;
            this.abmcliente_but_aceptar.Click += new System.EventHandler(this.abmcliente_but_aceptar_Click);
            // 
            // dtp_fec_nac
            // 
            this.dtp_fec_nac.Location = new System.Drawing.Point(140, 82);
            this.dtp_fec_nac.Name = "dtp_fec_nac";
            this.dtp_fec_nac.Size = new System.Drawing.Size(200, 20);
            this.dtp_fec_nac.TabIndex = 27;
            // 
            // ABMCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 304);
            this.Controls.Add(this.dtp_fec_nac);
            this.Controls.Add(this.abmcliente_but_aceptar);
            this.Controls.Add(this.abmcliente_chb_baja);
            this.Controls.Add(this.abmcliente_lab_telefono);
            this.Controls.Add(this.abmcliente_lab_codPostal);
            this.Controls.Add(this.abmcliente_lab_localidad);
            this.Controls.Add(this.abmcliente_lab_dto);
            this.Controls.Add(this.abmcliente_lab_piso);
            this.Controls.Add(this.abmcliente_lab_calle);
            this.Controls.Add(this.abmcliente_lab_mail);
            this.Controls.Add(this.abmcliente_lab_fechNac);
            this.Controls.Add(this.abmcliente_lab_dni);
            this.Controls.Add(this.abmcliente_lab_apellido);
            this.Controls.Add(this.abmcliente_lab_nombre);
            this.Controls.Add(this.abmcliente_mtb_telefono);
            this.Controls.Add(this.abmcliente_tb_localidad);
            this.Controls.Add(this.abmcliente_tb_cp);
            this.Controls.Add(this.abmcliente_tb_dto);
            this.Controls.Add(this.abmcliente_tb_piso);
            this.Controls.Add(this.abmcliente_tb_calle);
            this.Controls.Add(this.abmcliente_mtb_email);
            this.Controls.Add(this.abmcliente_tb_dni);
            this.Controls.Add(this.abmcliente_tb_apellido);
            this.Controls.Add(this.abmcliente_tb_nombre);
            this.Name = "ABMCliente";
            this.Text = "AMB Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox abmcliente_tb_nombre;
        private System.Windows.Forms.TextBox abmcliente_tb_apellido;
        private System.Windows.Forms.TextBox abmcliente_tb_dni;
        private System.Windows.Forms.MaskedTextBox abmcliente_mtb_email;
        private System.Windows.Forms.TextBox abmcliente_tb_calle;
        private System.Windows.Forms.TextBox abmcliente_tb_piso;
        private System.Windows.Forms.TextBox abmcliente_tb_dto;
        private System.Windows.Forms.TextBox abmcliente_tb_cp;
        private System.Windows.Forms.TextBox abmcliente_tb_localidad;
        private System.Windows.Forms.MaskedTextBox abmcliente_mtb_telefono;
        private System.Windows.Forms.Label abmcliente_lab_nombre;
        private System.Windows.Forms.Label abmcliente_lab_apellido;
        private System.Windows.Forms.Label abmcliente_lab_dni;
        public System.Windows.Forms.Label abmcliente_lab_fechNac;
        private System.Windows.Forms.Label abmcliente_lab_mail;
        private System.Windows.Forms.Label abmcliente_lab_calle;
        private System.Windows.Forms.Label abmcliente_lab_piso;
        private System.Windows.Forms.Label abmcliente_lab_dto;
        private System.Windows.Forms.Label abmcliente_lab_localidad;
        private System.Windows.Forms.Label abmcliente_lab_codPostal;
        private System.Windows.Forms.Label abmcliente_lab_telefono;
        private System.Windows.Forms.CheckBox abmcliente_chb_baja;
        private System.Windows.Forms.Button abmcliente_but_aceptar;
        private System.Windows.Forms.DateTimePicker dtp_fec_nac;
    }
}