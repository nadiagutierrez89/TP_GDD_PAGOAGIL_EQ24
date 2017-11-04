using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.FrontEnd.AbmCliente
{
    public partial class Clientes : Form
    {
        private Models.BO.Usuario usuarioLogueado;

        public Clientes()
        {
            InitializeComponent();
        }

        public Clientes(Models.BO.Usuario usuarioLogueado) : this()
        {
            this.usuarioLogueado = usuarioLogueado;
        }
    }
}
