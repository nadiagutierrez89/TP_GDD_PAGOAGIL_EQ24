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

namespace PagoAgilFrba.FrontEnd.AbmEmpresa
{
    public partial class Empresas : Form
    {
        private Models.BO.Usuario usuarioLogueado;
        private List<Empresa> lista_empresas;
        private int modo = 1;

        public Empresas()
        {
            InitializeComponent();
            Rubro rubroNull = new Rubro();

            List<Rubro> list = new List<Rubro>();
            list.Add(rubroNull);
            list.AddRange(Rubro.todos());

            this.cod_rubro.DataSource = list;
            this.cod_rubro.ValueMember = "cod_rubro";
            this.cod_rubro.DisplayMember = "descripcion_rubro";
        }

        public Empresas(Models.BO.Usuario usuarioLogueado)
            : this()
        {
            this.usuarioLogueado = usuarioLogueado;
        }

        public Empresas(List<Empresa> lista_empresas, int unModo)
            : this()
        {
            // TODO: Complete member initialization
            this.lista_empresas = lista_empresas;
            this.modo = unModo;
            this.empresa_but_modificar.Visible = false;
            this.empresa_but_alta.Visible = false;
            this.bttnSeleccionar.Visible = true;
            //1 = alta y modificacion de Empresa
            //2 = Empresas rendir

        }

        private void empresa_but_buscar_Click(object sender, EventArgs e)
        {
            this.empresa_dgv_listado.DataSource = Empresa.buscarSegun(this.armarFiltro());
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

            filtro = filtro + " and cuit_empresa like '%" + this.cuit_empresa.Text.Replace(" ", "_") + "%'"; 

            Rubro rubroSelected = (Rubro)this.cod_rubro.SelectedItem;
            if (rubroSelected != null && rubroSelected.cod_rubro != 0)
                filtro = filtro + " and cod_rubro = " + rubroSelected.cod_rubro;

            filtro = filtro + completarFiltroSegunModo();

            return filtro;
        }

        private string completarFiltroSegunModo()
        {
            string mifiltro = "";
            //2 = Empresas rendir
            if (this.modo == 2)
            {// si es para el rendir la empresa tiene que estar habiliada
                mifiltro = mifiltro + " and habilitado = 1";
            }

            return mifiltro;
        }

        private bool ItemSelccionado(DataGridView dataGridView)
        {
            return dataGridView.SelectedRows.Count != 0;
        }

        private void empresa_but_modificar_Click(object sender, EventArgs e)
        {
            if (this.ItemSelccionado(this.empresa_dgv_listado))
            {
                Empresa unEmpresa = (Empresa)this.empresa_dgv_listado.CurrentRow.DataBoundItem;
                ABMEmpresa altaModifEmpresa = new ABMEmpresa(unEmpresa);
                altaModifEmpresa.ShowDialog();
                this.empresa_but_buscar.PerformClick();

            }
            else
            {
                MessageBox.Show("Seleccione algun elemento", "Error!", MessageBoxButtons.OK);
            }

        }

        private void empresa_but_alta_Click(object sender, EventArgs e)
        {
            ABMEmpresa altaModifEmpresa = new ABMEmpresa();
            altaModifEmpresa.ShowDialog();
            this.empresa_but_buscar.PerformClick();
        }

        private void bttnSeleccionar_Click(object sender, EventArgs e)
        {
            if (this.ItemSelccionado(this.empresa_dgv_listado))
            {
                this.lista_empresas.Add((Empresa)this.empresa_dgv_listado.CurrentRow.DataBoundItem);
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione algun elemento", "Error!", MessageBoxButtons.OK);
            }
        }
    }
}
