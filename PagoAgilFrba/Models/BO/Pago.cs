using PagoAgilFrba.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Models.BO
{
    class Pago
    {
        public DateTime fecha_pago { get; set; }

        public decimal dni_cliente { get; set; }

        public decimal importe_total_pago { get; set; }

        public decimal codigo_postal_suc { get; set; }

        public decimal cod_user { get; set; }

        public List<Factura> facturas { get; set; }

        public List<MedioDePago> mediosDePago { get; set; }

        internal decimal importe_total()
        {
            return this.facturas.Sum(f => f.importe_total_fac);
        }
        internal decimal importe_total_mediosDePago()
        {
            return this.mediosDePago.Sum(m => m.importe);
        }

        internal int guardar()
        {
            return DAOPago.guardar(this);
        }

        public decimal nro_pago { get; set; }
    }
}
