using PagoAgilFrba.Models.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.FrontEnd.AbmCliente
{
    public partial class ABMCliente : Form
    {
        private Cliente clienteSeleted;
        bool invalid = false;

        public ABMCliente()
        {
            InitializeComponent();
            this.Text = "Alta Nuevo Cliente";
            this.dtp_fec_nac.Value = Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"]);
            this.abmcliente_chb_baja.Enabled = false;
        }

        public ABMCliente(Cliente unCliente) : this ()
        {
            this.clienteSeleted = unCliente;
            
            this.Text = "Modificacion Cliente";

            this.nombre.Text = unCliente.nombre;
            this.apellido.Text = unCliente.apellido;
            this.dni.Text = unCliente.dni.ToString();
            this.dtp_fec_nac.Value = unCliente.fecha_nac;
            this.email.Text = unCliente.mail;
            this.calle.Text = unCliente.calle;
            this.piso.Text = unCliente.nro_piso;
            this.departamento.Text = unCliente.depto;
            this.localidad.Text = unCliente.localidad;
            this.codigo_postal.Text = unCliente.cod_postal;
            this.telefono.Text = unCliente.telefono;
            this.abmcliente_chb_baja.Enabled = true;

            if (unCliente.fecha_baja == null)
            {
                this.abmcliente_chb_baja.Checked = false;
            }
            else
            {
                this.abmcliente_chb_baja.Checked = true;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ABMCliente_tb_mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void abmcliente_mtb_telefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void abmcliente_tb_cp_TextChanged(object sender, EventArgs e)
        {

        }

        private void abmcliente_tb_piso_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void abmcliente_but_aceptar_Click(object sender, EventArgs e)
        {
            Cliente clienete_modificado = new Cliente();
            int unInt;

            if (!textboxs_ok())
                return;

            if (Int32.TryParse(this.dni.Text, out unInt) && unInt >= 0)
            {
                clienete_modificado.dni = (decimal)unInt;
            }
            else
            {
                MessageBox.Show("dni no es un numero valido!", ">:o(", MessageBoxButtons.OK);
                return;
            }

            clienete_modificado.nombre = this.nombre.Text;
            clienete_modificado.apellido = this.apellido.Text;
            clienete_modificado.fecha_nac = (DateTime)this.dtp_fec_nac.Value;
            clienete_modificado.mail = this.email.Text;
            clienete_modificado.calle = this.calle.Text;
            clienete_modificado.nro_piso = this.piso.Text;
            clienete_modificado.depto = this.departamento.Text;
            clienete_modificado.localidad = this.localidad.Text;
            clienete_modificado.cod_postal = this.codigo_postal.Text;
            clienete_modificado.telefono = this.telefono.Text;

            if (this.abmcliente_chb_baja.Checked)
            {
                clienete_modificado.fecha_baja = Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"]);
            }
            else
            {
                clienete_modificado.fecha_baja = null;
            }
        
            if(this.clienteSeleted == null && Cliente.existeClienteSegun("dni_clie", clienete_modificado.dni.ToString()) )
            {
                MessageBox.Show("Ya existe un cliente con DNI " + clienete_modificado.dni , ":o|", MessageBoxButtons.OK);
                return;
            }

            Cliente clienteEmailUnique = Cliente.getClienteByEmail(clienete_modificado.mail);
            if (clienteEmailUnique.mail != null && clienteEmailUnique.dni != clienete_modificado.dni)
            {
                MessageBox.Show("Ya existe un cliente con email " + clienete_modificado.mail, ":o|", MessageBoxButtons.OK);
                return;
            }

            if (clienete_modificado.guardar() > 0)
            {
                MessageBox.Show("Se han guardado los cambios.", ":o)", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("No se han guardado los cambios!", ":o(", MessageBoxButtons.OK);
            }
        }

        private bool textboxs_ok()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox && ctrl.Text.Equals(""))
                {
                    MessageBox.Show(ctrl.Name + " no puede ser vacio", ">:o(", MessageBoxButtons.OK);
                    return false;
                }
            }

            if ( ! IsValidEmail(this.email.Text))
            {
                MessageBox.Show("formato de mail invalid ", ">:o(", MessageBoxButtons.OK);
                return false;
            }
            

            return true;
        }

        private string DomainMapper(Match match)
        {
            // IdnMapping class with default property values.
            IdnMapping idn = new IdnMapping();

            string domainName = match.Groups[2].Value;
            try
            {
                domainName = idn.GetAscii(domainName);
            }
            catch (ArgumentException)
            {
                invalid = true;
            }
            return match.Groups[1].Value + domainName;
        }

        private bool IsValidEmail(string strIn)
        {
            invalid = false;
            if (String.IsNullOrEmpty(strIn))
                return false;

            // Use IdnMapping class to convert Unicode domain names.
            try
            {
                strIn = Regex.Replace(strIn, @"(@)(.+)$", this.DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

            if (invalid)
                return false;

            // Return true if strIn is in valid e-mail format.
            try
            {
                return Regex.IsMatch(strIn,
                      @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                      @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                      RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
    }
}
