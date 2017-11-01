using PagoAgilFrba.Models.BO;
using PagoAgilFrba.Models.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

        private void login_btn_ingresar_Click(object sender, EventArgs e)
        {
            Usuario miUsuario = DAOusuario.getUsuario(login_tb_usuario.Text);
            if (miUsuario != null )
            { //Verifico Password contra la BD hasheandolo
                UTF8Encoding encoderHash = new UTF8Encoding();
               SHA256Managed hasher = new SHA256Managed();
               byte[] bytesDeHasheo = hasher.ComputeHash(encoderHash.GetBytes(login_tb_pass.Text));
               String password = transformarHasheoaString(bytesDeHasheo);
                if( miUsuario.pass == password)
                    {
                        MessageBox.Show("Bienvenido " + login_tb_usuario.Text + "!"); }
                else
                 { MessageBox.Show("Contraseña invalida","Error!", MessageBoxButtons.OK);
                            login_tb_pass.Text = ""; }
            }
           else{ MessageBox.Show("Usuario invalido","Error!", MessageBoxButtons.OK);
                            login_tb_pass.Text = ""; }
        }

        // Transformar lo hasheado a string
        private string transformarHasheoaString(byte[] array)
        {
            StringBuilder salida = new StringBuilder("");
            for (int i = 0; i < array.Length; i++)
                salida.Append(array[i].ToString("X2"));
            return salida.ToString();
        }

        private void login_lab_usuario_Click(object sender, EventArgs e)
        {

        }
    }
}
