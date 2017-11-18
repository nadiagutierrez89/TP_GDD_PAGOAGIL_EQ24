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
    public partial class Sucursales : Form
    {
        private Usuario usuarioLogueado;

        public Sucursales()
        {
            InitializeComponent();
        }

        public Sucursales(Usuario usuarioLogueado) : this()
        {
            this.usuarioLogueado = usuarioLogueado;
        }

        private void sucursales_dgv_listado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sucursal_but_buscar_Click(object sender, EventArgs e)
        {
            this.sucursales_dgv_listado.DataSource = Sucursal.buscarSucursales(this.armarFiltro());
        }

        private string armarFiltro()
        {
            string filtro = "1 = 1";
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox && !ctrl.Text.Equals(""))
                {
                    filtro = filtro + " and " + ctrl.Name + " like '%" + ctrl.Text + "%'";
                }
            }

            return filtro;
        }

        private void sucursal_but_alta_Click(object sender, EventArgs e)
        {
            ABMSucursal altaSucursal = new ABMSucursal();
            altaSucursal.ShowDialog();
            this.sucursal_but_buscar.PerformClick();
        }

        private bool ItemSelccionado(DataGridView dataGridView)
        {
            return dataGridView.SelectedRows.Count != 0;
        }

        private void sucursal_but_modificar_Click(object sender, EventArgs e)
        {
            if (this.ItemSelccionado(this.sucursales_dgv_listado))
            {
                Sucursal unaSocursal = (Sucursal)this.sucursales_dgv_listado.CurrentRow.DataBoundItem;
                ABMSucursal altaModifClie = new ABMSucursal(unaSocursal);
                altaModifClie.ShowDialog();
                this.sucursal_but_buscar.PerformClick();
            }
            else
            {
                MessageBox.Show("Seleccione algun elemento", "Error!", MessageBoxButtons.OK);
            }
        }
    }
}
