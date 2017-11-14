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
        int modo = 1;
        private Usuario usuarioLogueado;
        private DateTime hoy = Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"]);
        private List<Factura> facturas_a_pagar;
        public Factura factSelect { get; set; }

        public Facturas()
        {
            InitializeComponent();
        }

        public Facturas(Usuario usuarioLogueado) : this()
        {
            this.usuarioLogueado = usuarioLogueado;
            this.modo = 1;
        }

        public Facturas(List<Factura> factuasPagar, int un_modo) : this()
        {

            this.facturas_a_pagar = factuasPagar;
            this.facturas_but_alta.Visible = false;
            this.facturas_but_modificar.Visible = false;
            this.bttnSeleccionar.Visible = true;
            //1 = alta y modificacion de fatura
            //2 = facturas a pagar
            //3 = facturas a devolver pago
            this.modo = un_modo;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void facturas_but_buscar_Click(object sender, EventArgs e)
        {
            List<Factura> lista_a_mostrar = Factura.buscarSegun(this.armarFiltro());

            if (this.bttnSeleccionar.Visible)
            {//saco los elementos ya elejidos 
                lista_a_mostrar.RemoveAll(f => facturas_a_pagar.Any(fap => fap.nro_factura == f.nro_factura && fap.cod_empresa == fap.cod_empresa));
            }

            this.factura_dgv_listado.DataSource = lista_a_mostrar;
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

            if (this.fecha_alta_fac_hasta.Checked)
                filtro = filtro + " and fecha_alta_fac <= CONVERT (datetime, '" + this.fecha_alta_fac_hasta.Value.Date + "', 103)";

            if (this.fecha_vto_fac_desde.Checked)
                filtro = filtro + " and fecha_vto_fac >= CONVERT (datetime, '" + this.fecha_vto_fac_desde.Value.Date + "', 103)";

            if (this.fecha_vto_fac_hasta.Checked)
                filtro = filtro + " and fecha_vto_fac <= CONVERT (datetime, '" + this.fecha_vto_fac_hasta.Value.Date + "', 103)";

            filtro = filtro + completarFiltroSegunModo();

            return filtro;
        }

        private string completarFiltroSegunModo()
        {
            string mifiltro = "";
            //1 = alta y modificacion de fatura
            if (this.modo == 1)
            {
                mifiltro = mifiltro + " and nro_rendicion is null ";
                mifiltro = mifiltro + " and nro_pago is null ";
            }
            //2 = facturas a pagar
            if (this.modo == 2)
            {// si es para el registro de pagos no traigo las facturas vencidas ni pagadas
                mifiltro = mifiltro + " and fecha_vto_fac >= CONVERT (datetime, '" + hoy + "', 103)";
                mifiltro = mifiltro + " and nro_pago is null ";
            }
            //3 = facturas a devolver pago
            if (this.modo == 3)
            {// si es para devoluciones traigo las facturas pagas pero no rendidas 
                mifiltro = mifiltro + " and nro_rendicion is null ";
                mifiltro = mifiltro + " and nro_pago IS NOT NULL ";
            }

            return mifiltro;
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
            this.bttn_limpiar.PerformClick();
        }

        private void limpiar()
        {
            this.fecha_alta_fac_desde.Value = hoy;
            this.fecha_alta_fac_hasta.Value = hoy;
            this.fecha_vto_fac_desde.Value = hoy;
            this.fecha_vto_fac_hasta.Value = hoy;

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

        private bool ItemSelccionado(DataGridView dataGridView)
        {
            return dataGridView.SelectedRows.Count != 0;
        }

        private void facturas_but_modificar_Click(object sender, EventArgs e)
        {
            if (this.ItemSelccionado(this.factura_dgv_listado))
            {
                Factura unaFactura = (Factura)this.factura_dgv_listado.CurrentRow.DataBoundItem;

                if (unaFactura.nro_pago != null || unaFactura.nro_rendicion != null)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.ItemSelccionado(this.factura_dgv_listado))
            {
                this.facturas_a_pagar.Add((Factura)this.factura_dgv_listado.CurrentRow.DataBoundItem);
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione algun elemento", "Error!", MessageBoxButtons.OK);
            }

        }

    }
}
