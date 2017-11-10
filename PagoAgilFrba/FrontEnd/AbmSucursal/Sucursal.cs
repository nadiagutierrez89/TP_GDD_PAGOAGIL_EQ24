using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.FrontEnd.AbmSucursal
{
    public partial class Sucursal : Form
    {
        private Models.BO.Usuario usuarioLogueado;

        public Sucursal()
        {
            InitializeComponent();
        }

        public Sucursal(Models.BO.Usuario usuarioLogueado)
        {
            this.usuarioLogueado = usuarioLogueado;
        }

        private void sucursales_dgv_listado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
