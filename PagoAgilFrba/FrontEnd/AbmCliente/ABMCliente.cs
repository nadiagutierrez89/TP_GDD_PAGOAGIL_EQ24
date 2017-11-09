using PagoAgilFrba.Models.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.FrontEnd.AbmCliente
{
    public partial class ABMCliente : Form
    {
        private Models.BO.Cliente clienteSeleted;

        public ABMCliente()
        {
            InitializeComponent();
            this.Text = "Alta Nuevo Cliente";
            this.dtp_fec_nac.Value = Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"]);
        }

        public ABMCliente(Cliente unCliente) : this ()
        {
            this.clienteSeleted = unCliente;
            
            this.Text = "Modificacion Cliente";

            this.abmcliente_tb_nombre.Text = unCliente.nombre;
            this.abmcliente_tb_apellido.Text = unCliente.apellido;
            this.abmcliente_tb_dni.Text = unCliente.dni.ToString();
            this.dtp_fec_nac.Value = unCliente.fecha_nac;
            this.abmcliente_mtb_email.Text = unCliente.mail;
            this.abmcliente_tb_calle.Text = unCliente.calle;
            this.abmcliente_tb_piso.Text = unCliente.nro_piso;
            this.abmcliente_tb_dto.Text = unCliente.depto;
            this.abmcliente_tb_localidad.Text = unCliente.localidad;
            this.abmcliente_tb_cp.Text = unCliente.cod_postal;
            this.abmcliente_mtb_telefono.Text = unCliente.telefono;

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
            decimal unDecimal;

            clienete_modificado.nombre = this.abmcliente_tb_nombre.Text;
            clienete_modificado.apellido = this.abmcliente_tb_apellido.Text;
            clienete_modificado.fecha_nac = (DateTime)this.dtp_fec_nac.Value;
            clienete_modificado.mail = this.abmcliente_mtb_email.Text;
            clienete_modificado.calle = this.abmcliente_tb_calle.Text;
            clienete_modificado.nro_piso = this.abmcliente_tb_piso.Text;
            clienete_modificado.depto = this.abmcliente_tb_dto.Text;
            clienete_modificado.localidad = this.abmcliente_tb_localidad.Text;
            clienete_modificado.cod_postal = this.abmcliente_tb_cp.Text;
            clienete_modificado.telefono = this.abmcliente_mtb_telefono.Text;

            if (Decimal.TryParse(this.abmcliente_tb_dni.Text, out unDecimal))
                clienete_modificado.dni = unDecimal;

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

            if (clienete_modificado.guardar() > 0)
            {
                MessageBox.Show("Se han guardado los cambios.", ":o)", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("No se han guardado los cambios!", ":o(", MessageBoxButtons.OK);
            }
        }
    }
}
