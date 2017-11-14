using PagoAgilFrba.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Models.BO
{
    public class Devolucion
    {
        internal int guardar()
        {
            return DAODevolucion.procesar(this);
        }

        public decimal cod_user { get; set; }

        public decimal nro_factura { get; set; }

        public decimal cod_empresa { get; set; }

        public DateTime fecha_devolucion { get; set; }

        public decimal cod_motivoDevolucion { get; set; }

        public Factura factura { get; set; }
    }
}
