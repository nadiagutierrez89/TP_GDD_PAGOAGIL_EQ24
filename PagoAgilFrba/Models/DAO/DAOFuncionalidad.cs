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
    class DAOFuncionalidad
    {
        internal static List<Funcionalidad> getFuncionalidadesDe(decimal cod_rol)
        {
            List<Funcionalidad> funcionesDe = new List<Funcionalidad>();
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@cod_rol", cod_rol));

            SqlDataReader lector = DBAcess.GetDataReader("MARGINADOS.sp_funcionalidadesDe", "SP", paramList);
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Funcionalidad unaFuncion = new Funcionalidad();
                    unaFuncion.nombre_func = (string)lector["nombre_func"];
                    unaFuncion.cod_funcionalidad = (decimal)lector["cod_funcionalidad"];
                    funcionesDe.Add(unaFuncion);
                }
                lector.Close();
            }
            return funcionesDe;
        }

        public static List<Funcionalidad> buscarFuncionalidades()
        {
            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();
            SqlDataReader lector = DBAcess.GetDataReader("SELECT * FROM MARGINADOS.Funcionalidad", "T", new List<SqlParameter>());
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Funcionalidad func = new Funcionalidad();
                    func.cod_funcionalidad = (decimal)lector["cod_funcionalidad"];
                    func.nombre_func = (string)lector["nombre_func"];
                    funcionalidades.Add(func);
                }
                lector.Close();
            }
            return funcionalidades;
        }
    }
}
