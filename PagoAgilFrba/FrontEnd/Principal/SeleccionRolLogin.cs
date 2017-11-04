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
    public partial class SeleccionRolLogin : Form
    {
        private Models.BO.Usuario usuarioLogueado;

        public SeleccionRolLogin()
        {
            InitializeComponent();
        }

        public SeleccionRolLogin(Models.BO.Usuario usuarioLogueado) : this()
        {

            this.usuarioLogueado = usuarioLogueado;
            this.lbl_bienvenido.Text = this.lbl_bienvenido.Text + usuarioLogueado.username + "!!!";
            List<Rol> list = usuarioLogueado.roles;
            this.seleccionRol_cb_roles.DataSource = list;
            this.seleccionRol_cb_roles.ValueMember = "cod_rol";
            this.seleccionRol_cb_roles.DisplayMember = "nombre";

            List<Sucursal> misSucursales = usuarioLogueado.sucursales;
            this.cb_sucursal.DataSource = misSucursales;
            this.cb_sucursal.ValueMember = "codigo_postal";
            this.cb_sucursal.DisplayMember = "nombre";

        }

        private void seleccionRol_lab_roles_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuarioLogueado.rolActual = (Rol)seleccionRol_cb_roles.SelectedItem;
            usuarioLogueado.rolActual.cargarFuncionalidades();

            usuarioLogueado.socursalActual = (Sucursal) this.cb_sucursal.SelectedItem;
            this.Close();

        }

        private void lbl_bienvenido_Click(object sender, EventArgs e)
        {

        }
    }
}
