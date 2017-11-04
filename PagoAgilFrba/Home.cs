using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba
{
    public partial class Home : Form
    {
        private Models.BO.Usuario usuarioLogueado;

        public Home(Models.BO.Usuario usuarioLogueado)
        {
            InitializeComponent();
            this.usuarioLogueado = usuarioLogueado;


            this.usuarioLogueado = usuarioLogueado;
            foreach (Control boton in this.Controls)
            {
                if (boton is Button)
                {
                    boton.Enabled = false;
                    if (usuarioLogueado.FuncionalidadValida(boton.Text))
                    {
                        boton.Enabled = true;
                    }
                }
            }

        }

        private void home_but_abmfactura_Click(object sender, EventArgs e)
        {

        }

        private void home_but_estadisticas_Click(object sender, EventArgs e)
        {

        }

        private void home_but_ambrol_Click(object sender, EventArgs e)
        {

        }

    }
}
