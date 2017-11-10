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

        public decimal nro_factura { get; set; }

        public decimal cod_empresa { get; set; }

        public decimal dni_cliente { get; set; }

        public DateTime fecha_alta_fac { get; set; }

        public DateTime fecha_vto_fac { get; set; }

        public decimal Importe_total_fac { get; set; }

        public decimal ? nro_pago { get; set; }

        public decimal ? nro_rendicion { get; set; }
    }
}
