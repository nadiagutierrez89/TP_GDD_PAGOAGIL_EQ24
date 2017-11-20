using PagoAgilFrba.FrontEnd.AbmCliente;
using PagoAgilFrba.FrontEnd.AbmEmpresa;
using PagoAgilFrba.FrontEnd.ABMFactura;
using PagoAgilFrba.FrontEnd.ListadoEstadistico;
using PagoAgilFrba.FrontEnd.AbmRol;
using PagoAgilFrba.FrontEnd.AbmSucursal;
using PagoAgilFrba.FrontEnd.RegistroRendicion;
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
using PagoAgilFrba.FrontEnd.RegistroPago;


namespace PagoAgilFrba.FrontEnd.Principal
{
    public partial class Home : Form
    {
        private Usuario usuarioLogueado;

        public Home(Models.BO.Usuario usuarioLogueado)
        {
            InitializeComponent();
            this.usuarioLogueado = usuarioLogueado;
            this.lbl_socursal.Text = this.usuarioLogueado.socursalActual.nombre_suc;
            this.lbl_rol.Text = this.usuarioLogueado.rolActual.nombre_rol;

            this.usuarioLogueado = usuarioLogueado;
            activarBotonesSegunFuncionalidades(usuarioLogueado);

        }

        private void activarBotonesSegunFuncionalidades(Usuario usuarioLogueado)
        {
            foreach (Control boton in this.Controls)
            {
                if (boton is Button)
                {
                    boton.Visible = false;
                    if (usuarioLogueado.FuncionalidadValida(boton.Text))
                    {
                        boton.Visible = true;
                    }
                }
            }
        }

        private void home_but_abmfactura_Click(object sender, EventArgs e)
        {
            this.Hide();
            Facturas winform = new Facturas(usuarioLogueado);
            winform.ShowDialog();
            this.Show();
        }

        private void home_but_estadisticas_Click(object sender, EventArgs e)
        {
            this.Hide();
            listadoEstadistico winformEstadistica = new listadoEstadistico(usuarioLogueado);
            winformEstadistica.ShowDialog();
            this.Show();
        }

        private void home_but_ambrol_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABMRol abmRol = new ABMRol();
            abmRol.ShowDialog();

            //valido que si se dio de baja el actual rol se salga del programa
            if (!(Rol.rolesDe(usuarioLogueado.cod_user).Any(r => r.cod_rol == usuarioLogueado.rolActual.cod_rol && r.habilitado)))
                this.Close();

            usuarioLogueado.rolActual.cargarFuncionalidades();
            activarBotonesSegunFuncionalidades(usuarioLogueado);
            this.Show();
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


        private void home_but_abmsucursal_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Sucursales winformSucursal = new Sucursales(usuarioLogueado);
            winformSucursal.ShowDialog();

            //valido que si se dio de baja la actual sucursal se salga del programa
            if (! (Sucursal.buscarSucursales( "1 = 1" ).Any(s => s.codigo_postal_suc == usuarioLogueado.socursalActual.codigo_postal_suc && s.habilitado)))
                this.Close();

            usuarioLogueado.rolActual.cargarFuncionalidades();

            this.Show();
        }

        private void home_but_regpagf_Click(object sender, EventArgs e)
        {
            this.Hide();
            do
            {
                RegistroPagos winformRegPago = new RegistroPagos(usuarioLogueado);
                winformRegPago.ShowDialog();
            } while (MessageBox.Show("Quiere ingresar otro pago?", "PROCESAR OTRO PAGO?", MessageBoxButtons.YesNo) == DialogResult.Yes);
            this.Show();
        }

        private void home_but_rendirf_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rendiciones winformRendicion = new Rendiciones(usuarioLogueado);
            winformRendicion.ShowDialog();
            this.Show();
        }

        private void home_but_devolverf_Click(object sender, EventArgs e)
        {
            this.Hide();
            do
            {
                DevolucionFacturas winformDevolverF = new DevolucionFacturas(usuarioLogueado);
                winformDevolverF.ShowDialog();
            } while (MessageBox.Show("Quiere ingresar otra devolucion?", "DEVOLVER OTRA FACTURA PAGADA?", MessageBoxButtons.YesNo) == DialogResult.Yes);            
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
