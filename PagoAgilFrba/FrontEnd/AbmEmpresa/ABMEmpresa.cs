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
            this.abmempresa_chb_habilitada.Checked = true;
        }

        public ABMEmpresa(Empresa unEmpresa)
            : this()
        {
            this.empresa_a_modificar = unEmpresa;

            this.Text = "Modificacion Empresa";

            this.empresa_nombre.Text = unEmpresa.nombre_empresa;
            this.abmempresa_mtb_cuit.Text = unEmpresa.cuit_empresa;
            this.empresa_direccion.Text = unEmpresa.direccion_empresa;
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

        private bool textboxs_ok()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox && ctrl.Text.Equals(""))
                {
                    MessageBox.Show(ctrl.Name + " no puede ser vacio", ">:o(", MessageBoxButtons.OK);
                    return false;
                }
            }

            if (abmempresa_mtb_cuit.Text.IndexOf(" ") != -1 || abmempresa_mtb_cuit.Text.EndsWith("-"))
            {
                MessageBox.Show("Cuit no valido", ">:o(", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        private void abmempresa_but_aceptar_Click(object sender, EventArgs e)
        {
            if (!textboxs_ok())
                return;

            Empresa empresaModificada = new Empresa();


            empresaModificada.nombre_empresa = this.empresa_nombre.Text;
            empresaModificada.cuit_empresa = this.abmempresa_mtb_cuit.Text;
            empresaModificada.direccion_empresa = this.empresa_direccion.Text;
            empresaModificada.cod_rubro = (decimal)this.cod_rubro.SelectedValue;
            empresaModificada.habilitado = this.abmempresa_chb_habilitada.Checked;
            
            if(this.empresa_a_modificar != null)
                empresaModificada.cod_empresa = this.empresa_a_modificar.cod_empresa;

            Empresa empresaCuitUnique = Empresa.getEmpresaByCuit(empresaModificada.cuit_empresa);
            if (empresaCuitUnique != null && empresaCuitUnique.cod_empresa != empresaModificada.cod_empresa)
            {
                MessageBox.Show("Ya existe una Empresa con cuit " + empresaModificada.cuit_empresa, ":o|", MessageBoxButtons.OK);
                return;
            }

            if (!empresaModificada.habilitado && !empresaModificada.puedoDarmeDeBaja())
            {
                MessageBox.Show("La empresa no se puede desabilitar por que aun tiene facturas impagas y\\o no rendidas", ":o|", MessageBoxButtons.OK);
                return; 
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
