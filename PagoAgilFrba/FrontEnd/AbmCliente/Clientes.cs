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

        private void mi_dgv_Load(object sender, EventArgs e)
        {
            cargarGrilla(dgv_clientes);
        }

        private void cargarGrilla(DataGridView un_dgv)
        {
            un_dgv.AutoGenerateColumns = false;
            un_dgv.MultiSelect = false;

            DataGridViewTextBoxColumn col_dni_clie = new DataGridViewTextBoxColumn();
            col_dni_clie.DataPropertyName = "dni";
            col_dni_clie.HeaderText = "DNI";
            col_dni_clie.Width = 60;
            DataGridViewTextBoxColumn col_nombre_clie = new DataGridViewTextBoxColumn();
            col_nombre_clie.DataPropertyName = "nombre";
            col_nombre_clie.HeaderText = "Nombre";
            col_nombre_clie.Width = 120;
            DataGridViewTextBoxColumn col_apellido_clie = new DataGridViewTextBoxColumn();
            col_apellido_clie.DataPropertyName = "apellido";
            col_apellido_clie.HeaderText = "Apellido";
            col_apellido_clie.Width = 120;
            DataGridViewTextBoxColumn col_mail_clie = new DataGridViewTextBoxColumn();
            col_mail_clie.DataPropertyName = "mail";
            col_mail_clie.HeaderText = "Mail";
            col_mail_clie.Width = 120;
            DataGridViewTextBoxColumn col_fecha_nac_clie = new DataGridViewTextBoxColumn();
            col_fecha_nac_clie.DataPropertyName = "fecha_nac";
            col_fecha_nac_clie.HeaderText = "Nacimiento";
            col_mail_clie.Width = 120;
            DataGridViewTextBoxColumn col_fecha_baja = new DataGridViewTextBoxColumn();
            col_fecha_baja.DataPropertyName = "fecha_baja";
            col_fecha_baja.HeaderText = "Fecha baja";
            col_fecha_baja.Width = 120;

            un_dgv.Columns.Add(col_dni_clie);
            un_dgv.Columns.Add(col_nombre_clie);
            un_dgv.Columns.Add(col_apellido_clie);
            un_dgv.Columns.Add(col_mail_clie);
            un_dgv.Columns.Add(col_fecha_nac_clie);
            un_dgv.Columns.Add(col_fecha_baja);
        }

        public Clientes(Usuario usuarioLogueado) : this()
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

        private bool ItemSelccionado(DataGridView dataGridView)
        {
            return dataGridView.SelectedRows.Count != 0;
        }

        private void cliente_but_modificar_Click(object sender, EventArgs e)
        {
            if (this.ItemSelccionado(this.dgv_clientes))
            {
                Cliente unCliente = (Cliente)this.dgv_clientes.CurrentRow.DataBoundItem;
                ABMCliente altaModifClie = new ABMCliente(unCliente);
                altaModifClie.ShowDialog();
                this.cliente_but_buscar.PerformClick();

            }
            else
            {
                MessageBox.Show("Seleccione algun elemento", "Error!", MessageBoxButtons.OK);
            }
        }

        private void clientes_but_alta_Click(object sender, EventArgs e)
        {
            ABMCliente altaModifClie = new ABMCliente();
            altaModifClie.ShowDialog();
            this.cliente_but_buscar.PerformClick();
        }

    }
}
