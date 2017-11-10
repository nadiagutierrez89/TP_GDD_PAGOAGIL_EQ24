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
    public partial class ABMEmpresa : Form
    {
        private Empresa empresa_a_modificar;

        public ABMEmpresa()
        {
            InitializeComponent();
            this.Text = "Alta Nuevo Empresa";

            List<Rubro> list = Rubro.todos();
            this.cod_rubro.DataSource = list;
            this.cod_rubro.ValueMember = "cod_rubro";
            this.cod_rubro.DisplayMember = "descripcion_rubro";
        }

        public ABMEmpresa(Empresa unEmpresa)
            : this()
        {
            this.empresa_a_modificar = unEmpresa;

            this.Text = "Modificacion Empresa";

            this.abmEmpresa_tb_nombre.Text = unEmpresa.nombre_empresa;
            this.abmempresa_mtb_cuit.Text = unEmpresa.cuit_empresa;
            this.abmempresa_tb_direccion.Text = unEmpresa.direccion_empresa;
            this.cod_rubro.SelectedValue = unEmpresa.cod_rubro;
            this.abmempresa_chb_habilitada.Checked = unEmpresa.habilitado;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ambempresa_cb_rubro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void abmempresa_chb_habilitada_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void abmempresa_but_aceptar_Click(object sender, EventArgs e)
        {
            Empresa empresaModificada = new Empresa();


            empresaModificada.nombre_empresa = this.abmEmpresa_tb_nombre.Text;
            empresaModificada.cuit_empresa = this.abmempresa_mtb_cuit.Text;
            empresaModificada.direccion_empresa = this.abmempresa_tb_direccion.Text;
            empresaModificada.cod_rubro = (decimal)this.cod_rubro.SelectedValue;
            empresaModificada.habilitado = this.abmempresa_chb_habilitada.Checked;

            if (this.empresa_a_modificar == null)
            {
                if (Empresa.existeEmpresaSegun("cuit_empresa", "'" + empresaModificada.cuit_empresa +"'"))
                {
                    MessageBox.Show("Ya existe una Empresa con cuit " + empresaModificada.cuit_empresa, ":o|", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                empresaModificada.cod_empresa = this.empresa_a_modificar.cod_empresa;
            }

            if (empresaModificada.guardar() > 0)
            {
                MessageBox.Show("Se han guardado los cambios.", ":o)", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("No se han guardado los cambios!", ":o(", MessageBoxButtons.OK);
            }
        }
    }
}
