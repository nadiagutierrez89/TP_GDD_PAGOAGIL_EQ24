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
    public partial class DevolucionFacturas : Form
    {
        private Usuario usuarioLogueado;
        private List<Factura> factuasDevolver = new List<Factura>();
        private DateTime hoy = Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"]);

        public DevolucionFacturas()
        {
            InitializeComponent();
            List<MotivoDevolucion> motivos = MotivoDevolucion.getAll();
            this.cod_motivoDevolucion.DataSource = motivos;
            this.cod_motivoDevolucion.ValueMember = "cod_motivoDevolucion";
            this.cod_motivoDevolucion.DisplayMember = "descripcion";
        }

        public DevolucionFacturas(Usuario usuarioLogueado) : this ()
        {
            this.usuarioLogueado = usuarioLogueado;
            this.tbUser.Text = usuarioLogueado.username;
            this.tbSucursal.Text = usuarioLogueado.socursalActual.codigo_postal_suc + " - " + usuarioLogueado.socursalActual.nombre_suc;
        }

        private bool ItemSelccionado(DataGridView dataGridView)
        {
            return dataGridView.SelectedRows.Count != 0;
        }


        private void bttnDevolucion_Click(object sender, EventArgs e)
        {
            if (this.factuasDevolver.Count < 1)
            {
                MessageBox.Show("No se selecciono factura a devolver", "Error!", MessageBoxButtons.OK);
                return;
            }
            Factura unFactura = this.factuasDevolver.ElementAt(0);
            Devolucion unaDevolucion = new Devolucion();

            unaDevolucion.cod_user = this.usuarioLogueado.cod_user;
            unaDevolucion.factura = unFactura;
            unaDevolucion.cod_motivoDevolucion = ((MotivoDevolucion)this.cod_motivoDevolucion.SelectedItem).cod_motivoDevolucion;
            unaDevolucion.fecha_devolucion = hoy;

            if (unaDevolucion.guardar() > 0)
            {
                MessageBox.Show("Se han guardado los cambios.", ":o)", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("No se han guardado los cambios!", ":o(", MessageBoxButtons.OK);
            }

            this.Close();

        }

        private void bttn_agregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.factuasDevolver = new List<Factura>();
            Facturas winform = new Facturas(factuasDevolver, 3);
            winform.ShowDialog();
            this.dgv_listado_factura.DataSource = null;
            this.dgv_listado_factura.DataSource = factuasDevolver;
            this.Show();
        }

    }
}
