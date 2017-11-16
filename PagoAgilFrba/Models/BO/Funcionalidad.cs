using PagoAgilFrba.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Models.BO
{
    public class Funcionalidad
    {
        private String _nombre;
        private decimal _cod_funcionalidad;

        // gets and sets
        public String nombre_func
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public decimal cod_funcionalidad
        {
            get { return _cod_funcionalidad; }
            set { _cod_funcionalidad = value; }
        }

        internal bool existeEnRol(Rol rol)
        {
            return DAORolFuncionalidad.existeRolFuncionalidad(rol, this);
        }

        internal void agregateA(Rol rol)
        {
            DAORolFuncionalidad.agregateA(rol, this);
        }

        internal void eliminateDe(Rol rol)
        {
            DAORolFuncionalidad.eliminateDe(rol, this);
        }

        internal static List<Funcionalidad> retrieveAll()
        {
            return DAOFuncionalidad.buscarFuncionalidades();
        }
    }
}
