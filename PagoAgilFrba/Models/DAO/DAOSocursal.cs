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
    class DAOSocursal
    {
        internal static List<Sucursal> getSocursalesDe(decimal cod_user)
        {
            List<Sucursal> sucursalesDe = new List<Sucursal>();
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@cod_user", cod_user));
            string query = 
"select s.codigo_postal_suc, " +
	"s.direccion_suc, " +
	"s.habilitado, " +
    "s.nombre_suc " + 
"from [MARGINADOS].[Sucursal] s " + 
	"inner join [MARGINADOS].[UsuarioSucursal]  us " + 
	"on s.codigo_postal_suc = us.codigo_postal_suc " +
    "and us.cod_user = @cod_user ";

            SqlDataReader lector = DBAcess.GetDataReader(query, "T", paramList);

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Sucursal unaSocursal = new Sucursal();
                    unaSocursal.habilitado = (bool)lector["habilitado"];
                    unaSocursal.nombre_suc = (string)lector["nombre_suc"];
                    unaSocursal.direccion_suc = (string)lector["direccion_suc"];                    
                    unaSocursal.codigo_postal_suc = (decimal)lector["codigo_postal_suc"];
                    sucursalesDe.Add(unaSocursal);
                }
                lector.Close();
            }
            return sucursalesDe.FindAll(sucur => sucur.habilitado);
        }

        internal static List<Sucursal> getLosQueCumplenCon(string filtro)
        {
            List<Sucursal> mi_lista_return = new List<Sucursal>();
            List<SqlParameter> paramList = new List<SqlParameter>();

            SqlDataReader lector = DBAcess.GetDataReader("SELECT * FROM MARGINADOS.Sucursal WHERE " + filtro, "T", paramList);
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Sucursal unSucursal = new Sucursal();

                    unSucursal.codigo_postal_suc = (decimal)lector["codigo_postal_suc"];
                    unSucursal.nombre_suc = (string)lector["nombre_suc"];
                    unSucursal.direccion_suc = (string)lector["direccion_suc"];
                    unSucursal.habilitado = (bool)lector["habilitado"];

                    mi_lista_return.Add(unSucursal);
                }
            }
            return mi_lista_return;
        }

        internal static int guardar(Sucursal sucursal)
        {
            string noQuery = "";

            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@codigo_postal_suc", sucursal.codigo_postal_suc));
            ListaParametros.Add(new SqlParameter("@nombre_suc", sucursal.nombre_suc));
            ListaParametros.Add(new SqlParameter("@direccion_suc", sucursal.direccion_suc));
            ListaParametros.Add(new SqlParameter("@habilitado", sucursal.habilitado));

            if (existeSocursalSegun("codigo_postal_suc", sucursal.codigo_postal_suc.ToString()))
            {
                noQuery = "UPDATE MARGINADOS.Sucursal " +
                       "SET nombre_suc = @nombre_suc " +
                          ",direccion_suc = @direccion_suc " +
                          ",habilitado = @habilitado " +
                     "WHERE codigo_postal_suc = @codigo_postal_suc ";
            }
            else
            {
                noQuery = "INSERT INTO MARGINADOS.Sucursal " +
               "(nombre_suc " +
               ",direccion_suc " +
               ",codigo_postal_suc " +
               ",habilitado ) " +
         "VALUES " +
               "(@nombre_suc " +
               ",@direccion_suc " +
               ",@codigo_postal_suc " +
               ",@habilitado ) ";

            }
            return DBAcess.WriteInBase(noQuery, "T", ListaParametros);
        }

        internal static bool existeSocursalSegun(string campo, string valor)
        {
            List<Sucursal> empresa_lis = getLosQueCumplenCon(campo + " = " + valor);
            return empresa_lis.Count > 0;
        }
    }
}
