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

        public string nombre_rol { get; set; }
        public bool habilitado { set; get; }

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
            return this.funcionalidades.Any(func => func.nombre_func.Equals(nombreFuncionalidad));
        }

        internal void cargarFuncionalidades()
        {
            this.funcionalidades = DAOFuncionalidad.getFuncionalidadesDe(this.cod_rol);
        }

        internal bool existeNombre()
        {
            return DAORol.existeNombreRol(this.nombre_rol);
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
            return DAORol.buscarRoles();
        }

        internal static void deleteRol(int p)
        {
            throw new NotImplementedException();
        }

        internal static Rol getRolById(int _rol_id)
        {
            return retrieveAll().Find(r => r.cod_rol == _rol_id);
        }

        internal static bool existeRolFuncionalidad(int _rol_id, int cod_func)
        {
            Rol unRol = getRolById(_rol_id);
            unRol.cargarFuncionalidades();

            return unRol.funcionalidades.Any(f => f.cod_funcionalidad == cod_func);
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
            return DAORol.getLastIdRol();
        }

        internal static void createRolFuncionalidad(int id_rol, int p)
        {
            throw new NotImplementedException();
        }
    }
}
