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
            this.nombre = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.dni = new System.Windows.Forms.TextBox();
            this.calle = new System.Windows.Forms.TextBox();
            this.piso = new System.Windows.Forms.TextBox();
            this.departamento = new System.Windows.Forms.TextBox();
            this.codigo_postal = new System.Windows.Forms.TextBox();
            this.localidad = new System.Windows.Forms.TextBox();
            this.telefono = new System.Windows.Forms.MaskedTextBox();
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
            this.email = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(13, 42);
            this.nombre.MaxLength = 255;
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 20);
            this.nombre.TabIndex = 0;
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(140, 42);
            this.apellido.MaxLength = 255;
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(200, 20);
            this.apellido.TabIndex = 1;
            // 
            // dni
            // 
            this.dni.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dni.Location = new System.Drawing.Point(12, 83);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(100, 20);
            this.dni.TabIndex = 2;
            this.dni.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // calle
            // 
            this.calle.Location = new System.Drawing.Point(12, 164);
            this.calle.MaxLength = 100;
            this.calle.Name = "calle";
            this.calle.Size = new System.Drawing.Size(328, 20);
            this.calle.TabIndex = 5;
            // 
            // piso
            // 
            this.piso.Location = new System.Drawing.Point(12, 204);
            this.piso.MaxLength = 2;
            this.piso.Name = "piso";
            this.piso.Size = new System.Drawing.Size(44, 20);
            this.piso.TabIndex = 7;
            this.piso.TextChanged += new System.EventHandler(this.abmcliente_tb_piso_TextChanged);
            // 
            // departamento
            // 
            this.departamento.Location = new System.Drawing.Point(62, 203);
            this.departamento.MaxLength = 3;
            this.departamento.Name = "departamento";
            this.departamento.Size = new System.Drawing.Size(42, 20);
            this.departamento.TabIndex = 8;
            // 
            // codigo_postal
            // 
            this.codigo_postal.Location = new System.Drawing.Point(12, 246);
            this.codigo_postal.MaxLength = 255;
            this.codigo_postal.Name = "codigo_postal";
            this.codigo_postal.Size = new System.Drawing.Size(66, 20);
            this.codigo_postal.TabIndex = 9;
            this.codigo_postal.TextChanged += new System.EventHandler(this.abmcliente_tb_cp_TextChanged);
            // 
            // localidad
            // 
            this.localidad.Location = new System.Drawing.Point(110, 202);
            this.localidad.MaxLength = 50;
            this.localidad.Name = "localidad";
            this.localidad.Size = new System.Drawing.Size(130, 20);
            this.localidad.TabIndex = 10;
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(84, 245);
            this.telefono.Mask = "(999)000-0000";
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(156, 20);
            this.telefono.TabIndex = 11;
            this.telefono.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.abmcliente_mtb_telefono_MaskInputRejected);
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
            // email
            // 
            this.email.Location = new System.Drawing.Point(12, 125);
            this.email.MaxLength = 255;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(328, 20);
            this.email.TabIndex = 28;
            // 
            // ABMCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 304);
            this.Controls.Add(this.email);
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
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.localidad);
            this.Controls.Add(this.codigo_postal);
            this.Controls.Add(this.departamento);
            this.Controls.Add(this.piso);
            this.Controls.Add(this.calle);
            this.Controls.Add(this.dni);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.nombre);
            this.Name = "ABMCliente";
            this.Text = "AMB Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.TextBox calle;
        private System.Windows.Forms.TextBox piso;
        private System.Windows.Forms.TextBox departamento;
        private System.Windows.Forms.TextBox codigo_postal;
        private System.Windows.Forms.TextBox localidad;
        private System.Windows.Forms.MaskedTextBox telefono;
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
        private System.Windows.Forms.TextBox email;
    }
}