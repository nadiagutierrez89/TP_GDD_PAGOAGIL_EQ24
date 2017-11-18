using PagoAgilFrba.Models.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.FrontEnd.AbmSucursal
{
    public partial class ABMSucursal : Form
    {
        private Sucursal socursalSeleted;

        public ABMSucursal()
        {
            InitializeComponent();
            this.Text = "Alta Nuevo Cliente";
        }

        public ABMSucursal(Sucursal unaSocursal) : this()
        {
            this.socursalSeleted = unaSocursal;
            
            this.sucursal_nombre.Text = unaSocursal.nombre_suc;
            this.sucursal_direccion.Text = unaSocursal.direccion_suc;
            this.habilitado.Checked = unaSocursal.habilitado;
            this.sucursal_codigo_postal.Text = unaSocursal.codigo_postal_suc.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

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

            return true;
        }

        private void abmsucursal_but_aceptar_Click(object sender, EventArgs e)
        {
            if (!textboxs_ok())
                return;

            Sucursal sucursal_modificada = new Sucursal();
            decimal unDecimal;

            sucursal_modificada.nombre_suc = this.sucursal_nombre.Text;
            sucursal_modificada.direccion_suc = this.sucursal_direccion.Text;
            sucursal_modificada.habilitado = this.habilitado.Checked;

            if (Decimal.TryParse(this.sucursal_codigo_postal.Text, out unDecimal))
            {
                sucursal_modificada.codigo_postal_suc = unDecimal;
            }
            else
            {
                MessageBox.Show("Codigo postal no es un numero valido", ">:o(", MessageBoxButtons.OK);
                return; 
            }

            if (this.socursalSeleted == null && Sucursal.existeSocursalSegun("codigo_postal_suc", sucursal_modificada.codigo_postal_suc.ToString()))
            {
                MessageBox.Show("Ya existe una socursal con codigo postal " + sucursal_modificada.codigo_postal_suc, ":o|", MessageBoxButtons.OK);
                return;
            }

            if (sucursal_modificada.guardar() > 0)
            {
                MessageBox.Show("Se han guardado los cambios.", ":o)", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("No se han guardado los cambios!", ":o(", MessageBoxButtons.OK);
            }
        }
    }
}
