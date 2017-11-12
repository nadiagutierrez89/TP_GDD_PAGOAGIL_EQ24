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
    public partial class ABMFactura : Form
    {
        private Factura factura_a_modificar;

        public ABMFactura()
        {
            InitializeComponent();

            cargarGrilla(this.dgvFacturaItems);

            this.Text = "Alta Nueva Factura";

            DateTime fecha_hoy = Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"]);
            this.fecha_alta_fac.Value = fecha_hoy;
            this.fecha_vto_fac.Value = fecha_hoy.AddDays(10);

            List<Empresa> list = Empresa.todas();
            this.cod_empresa.DataSource = list;
            this.cod_empresa.ValueMember = "cod_empresa";
            this.cod_empresa.DisplayMember = "nombre_empresa";

        }

        private void cargarGrilla(DataGridView un_dgv)
        {
            un_dgv.AutoGenerateColumns = false;
            un_dgv.MultiSelect = false;

            DataGridViewTextBoxColumn col_nro_item = new DataGridViewTextBoxColumn();
            col_nro_item.DataPropertyName = "nro_item";
            col_nro_item.HeaderText = "nro_item";
            col_nro_item.Width = 60;
            DataGridViewTextBoxColumn col_monto_item = new DataGridViewTextBoxColumn();
            col_monto_item.DataPropertyName = "monto_item";
            col_monto_item.HeaderText = "monto_item";
            col_monto_item.Width = 80;
            DataGridViewTextBoxColumn col_cantidad_item = new DataGridViewTextBoxColumn();
            col_cantidad_item.DataPropertyName = "cantidad_item";
            col_cantidad_item.HeaderText = "cantidad_item";
            col_cantidad_item.Width = 80;

            un_dgv.Columns.Add(col_nro_item);
            un_dgv.Columns.Add(col_monto_item);
            un_dgv.Columns.Add(col_cantidad_item);

        }

        public ABMFactura(Factura unaFactura) : this()
        {
            this.Text = "Modificacion de Factura";
            this.factura_a_modificar = unaFactura;
            
            this.nro_factura.Text = factura_a_modificar.nro_factura.ToString();
            this.dni_cliente.Text = factura_a_modificar.dni_cliente.ToString();
            this.importe_total_fac.Text = factura_a_modificar.importe_total_fac.ToString();
            this.cod_empresa.SelectedValue = factura_a_modificar.cod_empresa;
            this.fecha_alta_fac.Value = factura_a_modificar.fecha_alta_fac;
            this.fecha_vto_fac.Value = factura_a_modificar.fecha_vto_fac;

            factura_a_modificar.getItems();

            this.dgvFacturaItems.DataSource = unaFactura.facturaItems;

        }       

        private void abmfactura_Load(object sender, EventArgs e)
        {

        }

        private void abmfactura_lab_monto_Click(object sender, EventArgs e)
        {

        }

        private void abmfactura_but_aceptar_Click(object sender, EventArgs e)
        {
            Factura facturaNueva = new Factura();
            decimal unDecimal;

            if (Decimal.TryParse(this.nro_factura.Text, out unDecimal))
                facturaNueva.nro_factura = unDecimal;
            if (Decimal.TryParse(this.dni_cliente.Text, out unDecimal))
                facturaNueva.dni_cliente = unDecimal;
            if (Decimal.TryParse(this.importe_total_fac.Text, out unDecimal))
                facturaNueva.importe_total_fac = unDecimal;

            facturaNueva.cod_empresa = (decimal)this.cod_empresa.SelectedValue;
            facturaNueva.fecha_alta_fac = (DateTime)this.fecha_alta_fac.Value;
            facturaNueva.fecha_vto_fac = (DateTime)this.fecha_vto_fac.Value;
            facturaNueva.nro_pago = null;
            facturaNueva.nro_rendicion = null;


            if (this.factura_a_modificar == null)
            {
                if (Factura.yaExiste(facturaNueva))
                {
                    MessageBox.Show("Ya existe una factura nro: " + facturaNueva.nro_factura + " de la empresa (cod): " + facturaNueva.cod_empresa, ":o|", MessageBoxButtons.OK);
                    return;
                }
            }

            if (facturaNueva.guardar() > 0)
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
