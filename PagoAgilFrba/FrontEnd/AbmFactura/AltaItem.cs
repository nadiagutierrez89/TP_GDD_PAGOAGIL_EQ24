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

namespace PagoAgilFrba.FrontEnd.AbmFactura
{
    public partial class AltaItem : Form
    {
        private List<FacturaItem> list;

        public AltaItem()
        {
            InitializeComponent();
        }

        public AltaItem(List<FacturaItem> list)
            : this()
        {
            // TODO: Complete member initialization
            this.list = list;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.tbCantidad.Text == "")
            {
                MessageBox.Show("Ingrese una cantidad", "Error!", MessageBoxButtons.OK);
                return;
            }

            if (this.tbMonto.Text == "")
            {
                MessageBox.Show("Ingrese un monto", "Error!", MessageBoxButtons.OK);
                return;
            }

            FacturaItem unItem = new FacturaItem();
            
            int unInt;
            if (Int32.TryParse(this.tbCantidad.Text, out unInt) && unInt >= 0)
            {
                unItem.cantidad_item = (decimal) unInt;
            }
            else
            {
                MessageBox.Show("Cantidad no es un numero valido", "Error!", MessageBoxButtons.OK);
                return;
            }

            Decimal unDecimal;
            if (Decimal.TryParse(this.tbMonto.Text, out unDecimal) && unDecimal >= 0)
            {
                unItem.monto_item = unDecimal;
            }
            else
            {
                MessageBox.Show("Monto no es un numero valido", "Error!", MessageBoxButtons.OK);
                return;
            }


            if (list.Count == 0)
            {
                unItem.nro_item = 1;
            }
            else
            {
                unItem.nro_item = list.Max(x => x.nro_item) + 1;
            }

            this.list.Add(unItem);

            this.Close();
        }
    }
}
