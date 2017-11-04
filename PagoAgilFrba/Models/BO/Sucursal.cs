using PagoAgilFrba.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Models.BO
{
    public class Sucursal
    {
        // Metodos  de Clase
        internal static List<Sucursal> sucursalesDe(decimal p)
        {
            return DAOSocursal.getSocursalesDe(p);
        }

        public string nombre { get; set; }

        public string direccion { get; set; }

        public decimal codigo_postal { get; set; }

        public bool habilitado { get; set; }
    }
}
