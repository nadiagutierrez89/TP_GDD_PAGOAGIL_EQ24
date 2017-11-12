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

        public string nombre_suc { get; set; }

        public string direccion_suc { get; set; }

        public decimal codigo_postal_suc { get; set; }

        public bool habilitado { get; set; }

        internal static List<Sucursal> buscarSucursales(string filtro)
        {
            List<Sucursal> mi_lista = DAOSocursal.getLosQueCumplenCon(filtro);
            return mi_lista;
        }

        internal static bool existeSocursalSegun(string p1, string p2)
        {
            return DAOSocursal.existeSocursalSegun(p1, p2);
        }

        internal int guardar()
        {
            return DAOSocursal.guardar(this);
        }
    }
}
