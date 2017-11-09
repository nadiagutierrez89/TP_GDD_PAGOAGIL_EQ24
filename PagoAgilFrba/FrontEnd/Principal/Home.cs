using PagoAgilFrba.FrontEnd.AbmCliente;
using PagoAgilFrba.FrontEnd.AbmEmpresa;
using PagoAgilFrba.FrontEnd.ListadoEstadistico;
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

namespace PagoAgilFrba.FrontEnd.Principal
{
    public partial class Home : Form
    {
        private Usuario usuarioLogueado;

        public Home(Models.BO.Usuario usuarioLogueado)
        {
            InitializeComponent();
            this.usuarioLogueado = usuarioLogueado;
            this.lbl_socursal.Text = this.usuarioLogueado.socursalActual.nombre;
            this.lbl_rol.Text = this.usuarioLogueado.rolActual.nombre;

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
            this.Hide();
            listadoEstadistico winformClientes = new listadoEstadistico(usuarioLogueado);
            winformClientes.ShowDialog();
            this.Show();
        }

        private void home_but_ambrol_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void home_but_abmcliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes winform = new Clientes(usuarioLogueado);
            winform.ShowDialog();
            this.Show();

        }

        private void home_but_abmempresa_Click(object sender, EventArgs e)
        {
            this.Hide();
            Empresas winform = new Empresas(usuarioLogueado);
            winform.ShowDialog();
            this.Show();
        }

    }
}
