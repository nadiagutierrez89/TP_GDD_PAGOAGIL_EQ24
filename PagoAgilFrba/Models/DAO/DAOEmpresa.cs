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
    class DAOEmpresa
    {
        internal static List<Empresa> getEmpresasQueCumplenCon(string filtro)
        {
            List<Empresa> misEmpresas = new List<Empresa>();
            List<SqlParameter> paramList = new List<SqlParameter>();

            SqlDataReader lector = DBAcess.GetDataReader("SELECT * FROM MARGINADOS.Empresa WHERE " + filtro, "T", paramList);
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Empresa unaEmpresa = new Empresa();
                    unaEmpresa.cod_empresa = (decimal)lector["cod_empresa"];
                    unaEmpresa.nombre_empresa = (string)lector["nombre_empresa"];
                    unaEmpresa.cuit_empresa = (string)lector["cuit_empresa"];
                    unaEmpresa.direccion_empresa = (string)lector["direccion_empresa"];
                    unaEmpresa.cod_rubro = (decimal)lector["cod_rubro"];
                    unaEmpresa.habilitado = (bool)lector["habilitado"];

                    misEmpresas.Add(unaEmpresa);
                }
            }
            return misEmpresas;
        }

        internal static bool existeEmpresaSegun(string campo, string valor)
        {
            List<Empresa> empresa_lis = getEmpresasQueCumplenCon(campo + " = " + valor);
            return empresa_lis.Count > 0;
        }

        internal static int guardar(Empresa empresa)
        {
            string noQuery = "";


            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@cod_empresa", empresa.cod_empresa));
            ListaParametros.Add(new SqlParameter("@nombre_empresa", empresa.nombre_empresa));
            ListaParametros.Add(new SqlParameter("@cuit_empresa", empresa.cuit_empresa));
            ListaParametros.Add(new SqlParameter("@cod_rubro", empresa.cod_rubro));
            ListaParametros.Add(new SqlParameter("@habilitado", empresa.habilitado));

            if (existeEmpresaSegun("cod_empresa", empresa.cod_empresa.ToString()))
            {
                noQuery = "UPDATE MARGINADOS.Empresa " +
                       "SET nombre_empresa = @nombre_empresa " +
                          ",cuit_empresa = @cuit_empresa " +
                          ",cod_rubro = @cod_rubro " +
                          ",habilitado = @habilitado " +
                     "WHERE cod_empresa = @cod_empresa ";
            }
            else
            {
                noQuery = "INSERT INTO MARGINADOS.Empresa " +
               "(nombre_empresa " +
               ",cuit_empresa " +
               ",cod_rubro " +
               ",habilitado ) " +
         "VALUES " +
               "(@nombre_empresa " +
               ",@cuit_empresa " +
               ",@cod_rubro " +
               ",@habilitado ) ";

            }
            return DBAcess.WriteInBase(noQuery, "T", ListaParametros);
        }

        internal static List<Empresa> devolverTodas()
        {
            return getEmpresasQueCumplenCon("1 = 1");
        }

    }
}
