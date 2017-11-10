using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.FrontEnd.AbmEmpresa
{
    public partial class Empresa : Form
    {
        private Models.BO.Usuario usuarioLogueado;

        public Empresa()
        {
            InitializeComponent();
        }

        public Empresa(Models.BO.Usuario usuarioLogueado) : this()
        {
            this.usuarioLogueado = usuarioLogueado;
        }
    }
}
