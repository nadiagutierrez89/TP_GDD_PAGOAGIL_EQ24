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

namespace PagoAgilFrba.FrontEnd.RegistroPago
{
    public partial class MediosDePago : Form
    {
        private List<MedioDePago> mediosDePagosDelPago;

        public MediosDePago()
        {
            InitializeComponent();

            List<MedioDePago> miLista = MedioDePago.obtenerLosTiposDeMediosDePago();
            this.cbMediosDePago.DataSource = miLista;
            this.cbMediosDePago.ValueMember = "cod_medioDePago";
            this.cbMediosDePago.DisplayMember = "descripcion_MP";
        }

        public MediosDePago(List<MedioDePago> mediosDePagosDelPago) : this ()
        {
            this.mediosDePagosDelPago = mediosDePagosDelPago;
        }

        private void bttnAgregar_Click(object sender, EventArgs e)
        {
            MedioDePago unMP = new MedioDePago();
            MedioDePago unMPActual = (MedioDePago)cbMediosDePago.SelectedItem;
            decimal unDecimal;

            if (Decimal.TryParse(this.tbImporte.Text, out unDecimal))
                 unMP.importe = unDecimal;

            unMP.cod_medioDePago = unMPActual.cod_medioDePago;
            unMP.descripcion_MP = unMPActual.descripcion_MP;

            this.mediosDePagosDelPago.Add(unMP);

            this.Close();
           
        }

    }
}
