using PagoAgilFrba.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Models.BO
{
    public class Empresa
    {
        internal static object buscarSegun(string p)
        {
            List<Empresa> misEmpresas = DAOEmpresa.getEmpresasQueCumplenCon(p);
            return misEmpresas;
        }

        public decimal cod_empresa { get; set; }

        public string nombre_empresa { get; set; }

        public string cuit_empresa { get; set; }

        public string direccion_empresa { get; set; }

        public decimal cod_rubro { get; set; }

        public bool habilitado { get; set; }

        internal static bool existeEmpresaSegun(string p1, string p2)
        {
            return DAOEmpresa.existeEmpresaSegun(p1, p2);
        }

        internal int guardar()
        {
            return DAOEmpresa.guardar(this);
        }
    }
}
