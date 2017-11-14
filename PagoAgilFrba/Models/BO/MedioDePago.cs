using PagoAgilFrba.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Models.BO
{
    public class MedioDePago
    {
        public decimal cod_medioDePago { get; set; }

        public string descripcion_MP { get; set; }

        public static List<MedioDePago> obtenerLosTiposDeMediosDePago()
        {
            return DAOMedioDePago.obtenerLosTiposDeMediosDePago();
        }
    }
}
