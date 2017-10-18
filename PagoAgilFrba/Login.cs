using PagoAgilFrba.Models.BO;
using PagoAgilFrba.Models.DAO;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_btn_ingresar_Click(object sender, EventArgs e)
        {
            Usuario miUsuario = DAOusuario.getUsuario(login_tb_usuario.Text);
            if (miUsuario != null && miUsuario.pass == login_tb_pass.Text)
            { MessageBox.Show("Bienvenido " + login_tb_usuario.Text + "!"); }
            else
            { MessageBox.Show("Usuario o contraseña invalida"); }
        }
    }
}
