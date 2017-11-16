using PagoAgilFrba.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Models.BO
{
    public class Factura
    {
        internal static List<Factura> buscarSegun(string filtro)
        {
            return DAOFactura.getLosQueCumplenCon(filtro);
        }

        internal static List<decimal> allYears()
        {
            return DAOFactura.allYears();
        }
        public decimal nro_factura { get; set; }

        public decimal cod_empresa { get; set; }

        public decimal dni_cliente { get; set; }

        public DateTime fecha_alta_fac { get; set; }

        public DateTime fecha_vto_fac { get; set; }

        public decimal importe_total_fac { get; set; }

        public decimal ? nro_pago { get; set; }

        public decimal ? nro_rendicion { get; set; }

        internal int guardar()
        {
            return DAOFactura.guardar(this);
        }

        internal static bool yaExiste(Factura facturaNueva)
        {
            string filtro = "nro_factura = " + facturaNueva.nro_factura + " and cod_empresa = " + facturaNueva.cod_empresa + "";
            return DAOFactura.getLosQueCumplenCon(filtro).Count > 0;
        }

        public List<FacturaItem> facturaItems { get; set; }

        internal void getItems()
        {
            this.facturaItems = FacturaItem.getItemsDe(this);
        }

        internal int guardarItems()
        {
            this.facturaItems.ForEach(i => i.cod_empresa = this.cod_empresa);
            this.facturaItems.ForEach(i => i.nro_factura = this.nro_factura);
            return DAOFacturaItem.guardar(this);
        }
    }
}
