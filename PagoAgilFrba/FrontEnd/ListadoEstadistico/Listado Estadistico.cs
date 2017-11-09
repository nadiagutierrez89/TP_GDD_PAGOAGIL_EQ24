using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagoAgilFrba.Models.DataBase;
using PagoAgilFrba.Models.DAO;
using PagoAgilFRBA.Models.DAO;


namespace PagoAgilFrba.FrontEnd.ListadoEstadistico
{
    
    public partial class listadoEstadistico : Form
    {
        private Models.BO.Usuario usuarioLogueado;

        public listadoEstadistico()
        {
            InitializeComponent();
        }

        public listadoEstadistico(Models.BO.Usuario usuarioLogueado) : this()
        {
            this.usuarioLogueado = usuarioLogueado;
        }

        private void ListadoEstadistico_Load(object sender, EventArgs e)
        {
            fillestadistica_cb_trimestre();
            fillestadistica_cb_anio();
            estadistica_cb_anio.SelectedIndex = 0;
            fillestadistica_cb_listado();
        }

        private void fillestadistica_cb_trimestre()
        {
            Dictionary<int, string> trimestres = new Dictionary<int, string>();
            trimestres.Add(1, "1er");
            trimestres.Add(2, "2do");
            trimestres.Add(3, "3ro");
            trimestres.Add(4, "4to");
            estadistica_cb_trimestre.DataSource = new BindingSource(trimestres, null);
            estadistica_cb_trimestre.DisplayMember = "Value";
            estadistica_cb_trimestre.ValueMember = "Key";
        }

        private void fillestadistica_cb_anio()
        {
            for (int i = 2000; i < 2030; i++)
                estadistica_cb_anio.Items.Add(i);
        }

        private void fillestadistica_cb_listado()
        {
            Dictionary<int, string> listados = new Dictionary<int, string>();
            listados.Add(1, "Porcentaje de facturas cobradas por empresa");
            listados.Add(2, "Empresas con mayor monto rendido");
            listados.Add(3, "Clientes con más pagos");
            listados.Add(4, "Clientes con mayor porcentaje de facturas pagadas");
            estadistica_cb_listado.DataSource = new BindingSource(listados, null);
            estadistica_cb_listado.DisplayMember = "Value";
            estadistica_cb_listado.ValueMember = "Key";
        }

        private void estadistica_but_consultar_click(object sender, EventArgs e)
        {
            int trim=0, anio=0;
            DAOListadoEstadistico daoListadoEstadistico = new DAOListadoEstadistico();

            
            switch (Convert.ToInt32(estadistica_cb_listado.SelectedValue))
            {
                case 1:
                    estadistica_dgv_listaResultados.DataSource = daoListadoEstadistico.PorcentajeFacturasCobradasXEmpresa(trim, anio);
                    break;

                case 2:
                    estadistica_dgv_listaResultados.DataSource = daoListadoEstadistico.EmpresasConMatorMontoRendido(trim, anio);
                    break;

                case 3:
                    estadistica_dgv_listaResultados.DataSource = daoListadoEstadistico.clientesConMAsPagos(trim, anio);
                    break;

                case 4:
                    estadistica_dgv_listaResultados.DataSource = daoListadoEstadistico.clientesCumplidores(trim, anio);
                    break;
        
            }
        }
    }
}
