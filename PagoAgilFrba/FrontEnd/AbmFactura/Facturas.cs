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

namespace PagoAgilFrba.FrontEnd.ABMFactura
{
    public partial class Facturas : Form
    {
        private Usuario usuarioLogueado;

        public Facturas()
        {
            InitializeComponent();
        }

        public Facturas(Usuario usuarioLogueado) : this ()
        {
            this.usuarioLogueado = usuarioLogueado;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void facturas_but_buscar_Click(object sender, EventArgs e)
        {
            this.factura_dgv_listado.DataSource = Factura.buscarSegun(this.armarFiltro());
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

            Empresa empresaSelected = (Empresa)this.cod_empresa.SelectedItem;
            if (empresaSelected != null && empresaSelected.cod_empresa != 0)
                filtro = filtro + " and cod_empresa = " + empresaSelected.cod_empresa;

            if (this.fecha_alta_fac_desde.Checked)
                filtro = filtro + " and fecha_alta_fac >= CONVERT (datetime, '" + this.fecha_alta_fac_desde.Value.Date + "', 103)";

            if(this.fecha_alta_fac_hasta.Checked)
                filtro = filtro + " and fecha_alta_fac <= CONVERT (datetime, '" + this.fecha_alta_fac_hasta.Value.Date + "', 103)";

            if(this.fecha_vto_fac_desde.Checked)
                filtro = filtro + " and fecha_vto_fac >= CONVERT (datetime, '" + this.fecha_vto_fac_desde.Value.Date + "', 103)";

            if (this.fecha_vto_fac_hasta.Checked)
                filtro = filtro + " and fecha_vto_fac <= CONVERT (datetime, '" + this.fecha_vto_fac_hasta.Value.Date + "', 103)";

            return filtro;
        }

        private void limpiar()
        {
            this.fecha_alta_fac_desde.Value = Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"]);
            this.fecha_alta_fac_hasta.Value = Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"]);
            this.fecha_vto_fac_desde.Value = Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"]);
            this.fecha_vto_fac_hasta.Value = Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"]);

            this.fecha_alta_fac_desde.Checked = false;
            this.fecha_alta_fac_hasta.Checked = false;
            this.fecha_vto_fac_desde.Checked = false;
            this.fecha_vto_fac_hasta.Checked = false;

            Empresa empresaNull = new Empresa();

            List<Empresa> list = new List<Empresa>();
            list.Add(empresaNull);
            list.AddRange(Empresa.todas());

            this.cod_empresa.DataSource = list;
            this.cod_empresa.ValueMember = "cod_empresa";
            this.cod_empresa.DisplayMember = "nombre_empresa";

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }
        }

        private void bttn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void bttn_limpiar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Facturas_Shown(object sender, EventArgs e)
        {
            limpiar();
        }

        private bool ItemSelccionado(DataGridView dataGridView)
        {
            return dataGridView.SelectedRows.Count != 0;
        }

        private void facturas_but_modificar_Click(object sender, EventArgs e)
        {
            if (this.ItemSelccionado(this.factura_dgv_listado))
            {
                Factura unaFactura = (Factura)this.factura_dgv_listado.CurrentRow.DataBoundItem;

                if(unaFactura.nro_pago != null || unaFactura.nro_rendicion != null)
                {
                    MessageBox.Show("Las facturas no se podrán dar de baja ni modificarlas si estas fueron pagadas, y/o rendidas", "Error!", MessageBoxButtons.OK);
                    return;
                }               

                ABMFactura altaModifEmpresa = new ABMFactura(unaFactura);
                altaModifEmpresa.ShowDialog();
                this.facturas_but_buscar.PerformClick();

            }
            else
            {
                MessageBox.Show("Seleccione algun elemento", "Error!", MessageBoxButtons.OK);
            }
        }

        private void facturas_but_alta_Click(object sender, EventArgs e)
        {
            ABMFactura altaModifEmpresa = new ABMFactura();
            altaModifEmpresa.ShowDialog();
            this.facturas_but_buscar.PerformClick();
        }
    }
}
