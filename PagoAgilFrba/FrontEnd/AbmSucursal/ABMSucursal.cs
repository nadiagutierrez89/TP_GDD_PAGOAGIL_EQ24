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
            
            this.abmsucursal_tb_nombre.Text = unaSocursal.nombre_suc;
            this.abmsucursal_tb_direccion.Text = unaSocursal.direccion_suc;
            this.habilitado.Checked = unaSocursal.habilitado;
            this.abmsucursal_tb_cp.Text = unaSocursal.codigo_postal_suc.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void abmsucursal_but_aceptar_Click(object sender, EventArgs e)
        {
            Sucursal sucursal_modificada = new Sucursal();
            decimal unDecimal;

            sucursal_modificada.nombre_suc = this.abmsucursal_tb_nombre.Text;
            sucursal_modificada.direccion_suc = this.abmsucursal_tb_direccion.Text;
            sucursal_modificada.habilitado = this.habilitado.Checked;

            if (Decimal.TryParse(this.abmsucursal_tb_cp.Text, out unDecimal))
                sucursal_modificada.codigo_postal_suc = unDecimal;

            if (this.socursalSeleted == null && Sucursal.existeSocursalSegun("codigo_postal_suc", sucursal_modificada.codigo_postal_suc.ToString()))
            {
                MessageBox.Show("Ya existe una socursal con codigo postal " + sucursal_modificada.codigo_postal_suc, ":o|", MessageBoxButtons.OK);
                return;
            }

            if (sucursal_modificada.guardar() > 0)
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
