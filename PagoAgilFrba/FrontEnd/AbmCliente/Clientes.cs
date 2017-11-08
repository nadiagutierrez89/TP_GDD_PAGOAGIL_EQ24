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

namespace PagoAgilFrba.FrontEnd.AbmCliente
{
    public partial class Clientes : Form
    {
        private Usuario usuarioLogueado;

        public Clientes()
        {
            InitializeComponent();
        }

        public Clientes(Models.BO.Usuario usuarioLogueado) : this()
        {
            this.usuarioLogueado = usuarioLogueado;
        }

        private void cliente_but_buscar_Click(object sender, EventArgs e)
        {
            this.dgv_clientes.DataSource = Cliente.buscarClientes(this.armarFiltro());
        }

        private string armarFiltro()
        {
            string filtro = "1 = 1";
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox && !ctrl.Text.Equals(""))
                {
                    filtro = filtro + " and " + ctrl.Name + " like '%" + ctrl.Text + "%'";
                }
            }

            return filtro;
        }
    }
}
