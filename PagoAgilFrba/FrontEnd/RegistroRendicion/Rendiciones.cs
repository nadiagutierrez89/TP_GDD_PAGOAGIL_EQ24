using PagoAgilFrba.FrontEnd.AbmEmpresa;
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

namespace PagoAgilFrba.FrontEnd.RegistroRendicion
{
    public partial class Rendiciones : Form
    {
        private Usuario usuarioLogueado;
        private Empresa empresaSelected = null;
        private Rendicion rendicionSelect = null;
        private DateTime hoy = Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"]);

        public Rendiciones()
        {
            InitializeComponent();
            this.dtpFecha.Value = hoy;
        }

        public Rendiciones(Usuario usuarioLogueado)
            : this()
        {
            // TODO: Complete member initialization
            this.usuarioLogueado = usuarioLogueado;
        }

        private void bttnSelecEmpresa_Click(object sender, EventArgs e)
        {
            this.Hide();
            List<Empresa> lista_empresas = new List<Empresa>();
            Empresas winform = new Empresas(lista_empresas, 2);
            winform.ShowDialog();

            if (lista_empresas.Count > 0)
            {
                this.empresaSelected = lista_empresas.ElementAt(0);
                if (this.empresaSelected.habilitado)
                {
                    this.tbEmpresa.Text = this.empresaSelected.cod_empresa.ToString() + " - " + this.empresaSelected.nombre_empresa;
                }
                else
                {
                    this.empresaSelected = null;
                    MessageBox.Show("No se puede rendir a empresas deshabilitadas", "Error!", MessageBoxButtons.OK);
                }
                
            }
            this.Show();
        }

        private void bttnGenerar_Click(object sender, EventArgs e)
        {
            if (this.empresaSelected == null)
            {
                MessageBox.Show("Seleccione alguna empresa", "Error!", MessageBoxButtons.OK);
                return;
            }

            Rendicion unRendicion = new Rendicion();
            decimal unDecimal;
            Decimal.TryParse(this.tbPorcentaje.Text, out unDecimal);

            unRendicion.porcentaje_comision = unDecimal;

            string filtro = "cod_empresa = " + this.empresaSelected.cod_empresa + " and nro_pago is not null and nro_rendicion is null";

            unRendicion.facturas = Factura.buscarSegun(filtro);
            /*
               Tipo de valor -> Condición
                Menor que cero -> t1 es anterior a t2.
                Cero -> t1 es igual que t2.
                Mayor que cero -> t1 es posterior a t2.
             */
            unRendicion.facturas = unRendicion.facturas.FindAll(f => DateTime.Compare(f.fecha_alta_fac, hoy.AddDays(1)) < 0);
            unRendicion.cant_facturas_rendidas = unRendicion.facturas.Count();
            unRendicion.importe_total_rendicion = unRendicion.facturas.Sum(f => f.importe_total_fac);
            unRendicion.importe_comision = ((unRendicion.porcentaje_comision * unRendicion.importe_total_rendicion) / 100);
            unRendicion.fecha_rendicion = hoy;
            unRendicion.cod_empresa = this.empresaSelected.cod_empresa;

            this.tbCant.Text = unRendicion.cant_facturas_rendidas.ToString();
            this.tbTotalRendicion.Text = unRendicion.importe_total_rendicion.ToString();
            this.tbImporteComision.Text = unRendicion.importe_comision.ToString();
            this.dgvFacturasPagadas.DataSource = unRendicion.facturas;
            this.rendicionSelect = unRendicion;
        }

        private void bttnGuardar_Click(object sender, EventArgs e)
        {
            if (this.rendicionSelect == null)
            {
                MessageBox.Show("Por favor genere una rendicion, antes de guarar", "Error!", MessageBoxButtons.OK);
                return;
            }
            if (this.rendicionSelect.cant_facturas_rendidas < 1)
            {
                MessageBox.Show("No hay facturas que rendir", "Error!", MessageBoxButtons.OK);
                return;
            }

            if (this.rendicionSelect.guardar() > 0)
            {
                MessageBox.Show("Se han guardado los cambios.", ":o)", MessageBoxButtons.OK);
                this.rendicionSelect = null;
            }
            else
            {
                MessageBox.Show("No se han guardado los cambios!", ":o(", MessageBoxButtons.OK);
            }


        }


    }
}
