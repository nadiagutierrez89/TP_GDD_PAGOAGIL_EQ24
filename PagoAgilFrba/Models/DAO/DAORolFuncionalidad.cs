using PagoAgilFrba.Models.BO;
using PagoAgilFrba.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Models.DAO
{
    class DAORolFuncionalidad
    {

        internal static bool existeRolFuncionalidad(Rol rol, Funcionalidad funcionalidad)
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();

            ListaParametros.Add(new SqlParameter("@cod_rol", rol.cod_rol));
            ListaParametros.Add(new SqlParameter("@cod_funcionalidad", funcionalidad.cod_funcionalidad));

            SqlDataReader lector = DBAcess.GetDataReader("SELECT cod_rol FROM MARGINADOS.RolFuncionalidad WHERE COD_ROL=@cod_rol AND COD_FUNCIONALIDAD=@cod_funcionalidad", "T", ListaParametros);

            return lector.HasRows;
        }


        internal static void agregateA(Rol rol, Funcionalidad funcionalidad)
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();

            ListaParametros.Add(new SqlParameter("@cod_rol", rol.cod_rol));
            ListaParametros.Add(new SqlParameter("@cod_funcionalidad", funcionalidad.cod_funcionalidad));

            DBAcess.WriteInBase("insert into MARGINADOS.RolFuncionalidad (COD_ROL, COD_FUNCIONALIDAD) VALUES(@cod_rol, @cod_funcionalidad)", "T", ListaParametros);
        }

        internal static void eliminateDe(Rol rol, Funcionalidad funcionalidad)
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();

            ListaParametros.Add(new SqlParameter("@cod_funcionalidad", funcionalidad.cod_funcionalidad));

            ListaParametros.Add(new SqlParameter("@cod_rol", rol.cod_rol));

            DBAcess.WriteInBase("DELETE FROM MARGINADOS.RolFuncionalidad WHERE COD_ROL=@cod_rol AND COD_FUNCIONALIDAD=@cod_funcionalidad", "T", ListaParametros);
        }
    }
}
