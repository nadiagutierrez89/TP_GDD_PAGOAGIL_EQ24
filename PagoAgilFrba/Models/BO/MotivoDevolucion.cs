using PagoAgilFrba.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Models.BO
{
    public class MotivoDevolucion
    {
        internal static List<MotivoDevolucion> getAll()
        {
            return DAOMotivoDevolucion.getAll();
        }

        public string descripcion { get; set; }

        public decimal cod_motivoDevolucion { get; set; }
    }
}
