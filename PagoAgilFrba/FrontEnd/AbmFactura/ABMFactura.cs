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

namespace PagoAgilFrba.FrontEnd.ABMFactura
{
    public partial class ABMFactura : Form
    {
        private Factura unaFactura;


        public ABMFactura()
        {
            InitializeComponent();
        }

        public ABMFactura(Factura unaFactura) : this()
        {
            this.unaFactura = unaFactura;
        }       

        private void abmfactura_Load(object sender, EventArgs e)
        {

        }

        private void abmfactura_lab_monto_Click(object sender, EventArgs e)
        {

        }
    }
}
