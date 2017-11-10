using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.FrontEnd.RegistroPago
{
    public partial class RegistroPago : Form
    {
        private Models.BO.Usuario usuarioLogueado;

        public RegistroPago()
        {
            InitializeComponent();
        }

        public RegistroPago(Models.BO.Usuario usuarioLogueado)
        {           
            this.usuarioLogueado = usuarioLogueado;
        }
    }
}
