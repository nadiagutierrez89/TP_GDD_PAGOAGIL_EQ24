using PagoAgilFrba.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Models.BO
{
    public class Rol
    {
        private string _nombre;
        private decimal _cod_rol;
        private List<Funcionalidad> _funcionalidades;
        
        public bool habilitado { set; get; }

        // gets and sets
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public decimal cod_rol
        {
            get { return _cod_rol; }
            set { _cod_rol = value; }
        }

        public List<Funcionalidad> funcionalidades
        {
            get { return _funcionalidades; }
            set { _funcionalidades = value; }
        }

        // Metodos  de Clase
        internal static List<Rol> rolesDe(decimal userId)
        {
            return DAORol.getRolesDe(userId);
        }

        // Metodos de instancia
        internal bool funcionalidadValida(string nombreFuncionalidad)
        {
            return this.funcionalidades.Any(func => func.nombre.Equals(nombreFuncionalidad));
        }

        internal void cargarFuncionalidades()
        {
            this.funcionalidades = DAOFuncionalidad.getFuncionalidadesDe(this.cod_rol);
        }

        internal bool existeNombre()
        {
            return DAORol.existeNombreRol(this.nombre);
        }

        internal Rol create()
        {
            return DAORol.crearRol(this);
        }

        internal void cambiarNombre(string nombreViejoRol)
        {
            DAORol.cambiarNombre(this, nombreViejoRol);
        }

        internal static List<Rol> retrieveAll()
        {
            throw new NotImplementedException();
        }

        public string nombre_rol { get; set; }

        internal static void deleteRol(int p)
        {
            throw new NotImplementedException();
        }

        internal static Rol getRolById(int _rol_id)
        {
            throw new NotImplementedException();
        }

        internal static object existeRolFuncionalidad(int _rol_id, int p)
        {
            throw new NotImplementedException();
        }

        internal static void update(Rol rol)
        {
            throw new NotImplementedException();
        }

        internal static void deleteAllFunc(int p)
        {
            throw new NotImplementedException();
        }

        internal static void create(Rol rol)
        {
            throw new NotImplementedException();
        }

        internal static int getLastIdRol()
        {
            throw new NotImplementedException();
        }

        internal static void createRolFuncionalidad(int id_rol, int p)
        {
            throw new NotImplementedException();
        }
    }
}
