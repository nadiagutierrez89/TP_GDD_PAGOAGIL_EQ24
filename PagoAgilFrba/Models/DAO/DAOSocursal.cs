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
                    unaSocursal.nombre = (string)lector["nombre_suc"];
                    unaSocursal.direccion = (string)lector["direccion_suc"];                    
                    unaSocursal.codigo_postal = (decimal)lector["codigo_postal_suc"];
                    sucursalesDe.Add(unaSocursal);
                }
                lector.Close();
            }
            return sucursalesDe.FindAll(sucur => sucur.habilitado);
        }
    }
}
