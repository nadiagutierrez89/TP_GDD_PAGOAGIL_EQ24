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

        internal static List<Empresa> todas()
        {
            return DAOEmpresa.devolverTodas();
        }

        internal bool puedoDarmeDeBaja()
        {
            List<Factura> misFacturas = Factura.buscarSegun("cod_empresa = " + this.cod_empresa + " and (nro_pago is null or nro_rendicion is null)");
            return misFacturas.Count == 0;
        }

        internal static Empresa getEmpresaByCuit(string p)
        {
            List<Empresa> empresas = DAOEmpresa.getEmpresasQueCumplenCon(" cuit_empresa = '" + p +"'");
            if (empresas.Count != 0)
            {
                return empresas.ElementAt(0);
            }
            else
            {
                return null;
            }
        }

        internal static Empresa getEmpresa(Decimal p)
        {
            List<Empresa> empresas = DAOEmpresa.getEmpresasQueCumplenCon(" cod_empresa = " + p );
            if (empresas.Count != 0)
            {
                return empresas.ElementAt(0);
            }
            else
            {
                return null;
            }
        }
    }
}
