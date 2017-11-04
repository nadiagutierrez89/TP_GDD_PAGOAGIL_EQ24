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
        public Usuario usuarioLogueado;
        public Login()
        {
            InitializeComponent();
        }

        private void login_btn_ingresar_Click(object sender, EventArgs e)
        {
            Usuario miUsuario = DAOUsuario.getUsuario(login_tb_usuario.Text);
            if (miUsuario != null)
            {
                //Verifico Password contra la BD hasheandolo
                UTF8Encoding encoderHash = new UTF8Encoding();
                SHA256Managed hasher = new SHA256Managed();
                byte[] bytesDeHasheo = hasher.ComputeHash(encoderHash.GetBytes(login_tb_pass.Text));
                String password = transformarHasheoaString(bytesDeHasheo);
                if (miUsuario.pass == password)
                {
                    if (!miUsuario.habilitado)
                        MessageBox.Show("Usuario inactivo para acceder al sistema", "Error!");
                    else
                    {

                        miUsuario.ReiniciarFallidos();
                        // Paso al form Principal (requiere user siempre)
                        this.usuarioLogueado = miUsuario;
                        this.Hide();
                        SeleccionRolLogin elegRol = new SeleccionRolLogin(usuarioLogueado);
                        elegRol.ShowDialog();
                        Home inicio = new Home(usuarioLogueado);
                        inicio.ShowDialog();
                        this.Show();

                    }
                }
                else
                {
                    MessageBox.Show("Contraseña incorrectos", "Error!", MessageBoxButtons.OK);
                    miUsuario.ActualizarFallidos();
                    login_tb_pass.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error!", MessageBoxButtons.OK);
                login_tb_pass.Text = "";
            }
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
