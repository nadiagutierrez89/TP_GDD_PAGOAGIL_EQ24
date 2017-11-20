using PagoAgilFrba.FrontEnd.AbmCliente;
using PagoAgilFrba.FrontEnd.AbmFactura;
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
        private Factura factura_a_modificar = new Factura();
        private Cliente clientePagador;
        private int modo = 1;// 1 es modo alta

        public ABMFactura()
        {
            InitializeComponent();

            cargarGrilla(this.dgvFacturaItems);

            this.Text = "Alta Nueva Factura";

            DateTime fecha_hoy = Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"]);
            this.fecha_alta_fac.Value = fecha_hoy;
            this.fecha_vto_fac.Value = fecha_hoy.AddDays(10);

            List<Empresa> list = Empresa.todas().FindAll(f => f.habilitado);
            this.cod_empresa.DataSource = list;
            this.cod_empresa.ValueMember = "cod_empresa";
            this.cod_empresa.DisplayMember = "nombre_empresa";

            this.factura_a_modificar.facturaItems = new List<FacturaItem>();

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

        public ABMFactura(Factura unaFactura)
            : this()
        {
            this.Text = "Modificacion de Factura";
            this.factura_a_modificar = unaFactura;

            this.nro_factura.Text = factura_a_modificar.nro_factura.ToString();
            this.importe_total_fac.Text = factura_a_modificar.importe_total_fac.ToString();
            this.cod_empresa.SelectedValue = factura_a_modificar.cod_empresa;
            this.fecha_alta_fac.Value = factura_a_modificar.fecha_alta_fac;
            this.fecha_vto_fac.Value = factura_a_modificar.fecha_vto_fac;

            this.clientePagador = Cliente.getCliente(factura_a_modificar.dni_cliente);
            this.actualizarTxtNombreCliente();
            factura_a_modificar.getItems();

            this.dgvFacturaItems.DataSource = unaFactura.facturaItems;
            this.modo = 2; // modo modificacion de factura

        }

        private void abmfactura_Load(object sender, EventArgs e)
        {

        }

        private void abmfactura_lab_monto_Click(object sender, EventArgs e)
        {

        }

        private void abmfactura_but_aceptar_Click(object sender, EventArgs e)
        {
            int unInt;
            Decimal unDecimal;
            Factura facturaNueva = new Factura();
            facturaNueva.cod_empresa = (decimal)this.cod_empresa.SelectedValue;

            if (this.nro_factura.Text == "")
            {
                MessageBox.Show("Falta cargar numero de factura", ":o|", MessageBoxButtons.OK);
                return;
            }

            if (this.clientePagador == null)
            {
                MessageBox.Show("Seleccione algun cliente", ":o|", MessageBoxButtons.OK);
                return;
            }            

            if (Int32.TryParse(this.nro_factura.Text, out unInt) && unInt > 0)
            {
                facturaNueva.nro_factura =  (decimal)unInt;
            }
            else
            {
                MessageBox.Show("Numero de factura no es un numero valido", "Error!", MessageBoxButtons.OK);
                return;
            }

            if (this.modo == 1) // modo alta de factura
            {
                if (Factura.yaExiste(facturaNueva))
                {
                    MessageBox.Show("Ya existe una factura nro: " + facturaNueva.nro_factura + " de la empresa (cod): " + facturaNueva.cod_empresa, ":o|", MessageBoxButtons.OK);
                    return;
                }
            }

            if (this.factura_a_modificar.facturaItems == null || this.factura_a_modificar.facturaItems.Count < 1)
            {
                MessageBox.Show("La factura no tiene itmes", ":o|", MessageBoxButtons.OK);
                return;
            }

            if (Decimal.TryParse(this.importe_total_fac.Text, out unDecimal))
                facturaNueva.importe_total_fac = unDecimal;

            facturaNueva.facturaItems = factura_a_modificar.facturaItems;
            facturaNueva.fecha_alta_fac = (DateTime)this.fecha_alta_fac.Value;
            facturaNueva.fecha_vto_fac = (DateTime)this.fecha_vto_fac.Value;
            facturaNueva.nro_pago = null;
            facturaNueva.nro_rendicion = null;

            facturaNueva.dni_cliente = this.clientePagador.dni;
            
            if (facturaNueva.guardar() > 0)
            {
                if (facturaNueva.guardarItems() > 0)
                {
                    MessageBox.Show("Se han guardado los cambios.", ":o)", MessageBoxButtons.OK);
                    if (modo == 1)// alta factura
                        this.Close();
                }
                else
                {
                    MessageBox.Show("No se han guardado los cambios en los items.", ":o)", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("No se han guardado los cambios!", ":o(", MessageBoxButtons.OK);
            }

        }

        private void bttnSeleccionar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes winform = new Clientes(clientePagador);
            winform.ShowDialog();
            clientePagador = winform.clientePagador;

            if (clientePagador != null)
                this.actualizarTxtNombreCliente();

            this.Show();
        }

        private void actualizarTxtNombreCliente()
        {
            this.tbCliente.Text = clientePagador.nombre + " " + clientePagador.apellido + " " + clientePagador.dni;
        }

        private void bttnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            AltaItem winform = new AltaItem(factura_a_modificar.facturaItems);
            winform.ShowDialog();
            this.dgvFacturaItems.DataSource = null;
            this.dgvFacturaItems.DataSource = factura_a_modificar.facturaItems;
            this.actualizarTotalDeFactura();
            this.Show();
        }

        private void actualizarTotalDeFactura()
        {
            this.importe_total_fac.Text = factura_a_modificar.facturaItems.Sum(i => i.monto_item).ToString();
        }

        private bool ItemSelccionado(DataGridView dataGridView)
        {
            return dataGridView.SelectedRows.Count != 0;
        }

        private void bttnQuitar_Click(object sender, EventArgs e)
        {
            if (this.ItemSelccionado(this.dgvFacturaItems))
            {
                FacturaItem itemBorrar = (FacturaItem)this.dgvFacturaItems.CurrentRow.DataBoundItem;
                if (itemBorrar == null)
                    return;
                
                factura_a_modificar.facturaItems.Remove(itemBorrar);

                this.dgvFacturaItems.DataSource = null;
                this.dgvFacturaItems.DataSource = factura_a_modificar.facturaItems;

                this.actualizarTotalDeFactura();
            }
            else
            {
                MessageBox.Show("Seleccione algun elemento", "Error!", MessageBoxButtons.OK);
            }
        }
    }
}
