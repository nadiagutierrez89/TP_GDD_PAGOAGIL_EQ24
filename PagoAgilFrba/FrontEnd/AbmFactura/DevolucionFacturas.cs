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
    public partial class DevolucionFacturas : Form
    {
        private Models.BO.Usuario usuarioLogueado;

        public DevolucionFacturas()
        {
            InitializeComponent();
        }

        public DevolucionFacturas(Models.BO.Usuario usuarioLogueado)
        {
            // TODO: Complete member initialization
            this.usuarioLogueado = usuarioLogueado;
        }
    }
}
