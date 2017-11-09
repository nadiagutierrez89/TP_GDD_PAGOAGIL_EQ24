using PagoAgilFrba.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Models.BO
{
    public class Rubro
    {
        public decimal cod_rubro { get; set; }

        public string descripcion_rubro { get; set; }

        internal static List<Rubro> todos()
        {
            return DAORubro.devolverTodos();
        }
    }
}
