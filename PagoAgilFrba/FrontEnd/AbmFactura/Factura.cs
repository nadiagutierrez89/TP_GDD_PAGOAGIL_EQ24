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
    public partial class Factura : Form
    {
        private Models.BO.Usuario usuarioLogueado;

        public Factura()
        {
            InitializeComponent();
        }

        public Factura(Models.BO.Usuario usuarioLogueado)
        {
            this.usuarioLogueado = usuarioLogueado;
        }
    }
}
