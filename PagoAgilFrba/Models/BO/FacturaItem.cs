using PagoAgilFrba.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Models.BO
{
    public class FacturaItem
    {

        internal static List<FacturaItem> getItemsDe(Factura unFactura)
        {
            return DAOFacturaItem.getItemsDe(unFactura);
        }

        public decimal cod_empresa { get; set; }

        public decimal nro_factura { get; set; }

        public decimal nro_item { get; set; }

        public decimal monto_item { get; set; }

        public decimal cantidad_item { get; set; }
    }
}
