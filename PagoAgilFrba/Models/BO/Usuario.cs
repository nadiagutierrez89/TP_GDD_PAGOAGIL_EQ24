using PagoAgilFrba.Models.DAO;
using PagoAgilFrba.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Models.BO
{
    public class Usuario
    {
        private decimal _cod_user;
        public string username { get; set; }
        public string pass { get; set; }
        private List<Rol> _roles;
        private List<Sucursal> _sucursales;
        public bool habilitado { get; set; }
        public decimal nro_intentos { get; set; }
        private Rol _rolActual;
        private Sucursal _socursalActual;

        public Usuario()
        {
        }

        public decimal cod_user
        {
            get { return _cod_user; }
            set { _cod_user = value; }
        }

        public List<Rol> roles
        {
            get { return _roles; }
            set { _roles = value; }
        }

        public Rol rolActual
        {
            get { return _rolActual; }
            set { _rolActual = value; }
        }

        public List<Sucursal> sucursales
        {
            get { return _sucursales; }
            set { _sucursales = value; }
        }

        public Sucursal socursalActual
        {
            get { return _socursalActual; }
            set { _socursalActual = value; }
        }

        internal void ReiniciarFallidos()
        {  
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@nombre", username));
            DBAcess.WriteInBase("UPDATE MARGINADOS.Usuario SET nro_intentos=0 WHERE username=@nombre", "T", paramList);
        }    
        
        internal void ActualizarFallidos()
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@intentos_login", nro_intentos + 1));
            paramList.Add(new SqlParameter("@nombre", username));
            DBAcess.ExecStoredProcedure("MARGINADOS.sp_ActualizaIntentos", paramList);
          }

        internal bool FuncionalidadValida(string nombreFuncionalidad)
        {
            return this.rolActual.funcionalidadValida(nombreFuncionalidad);
        }
    }
}
