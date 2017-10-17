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
    class DAOusuario
    {
        public static Usuario getUsuario(string username)
        {
            Usuario miUsuario = new Usuario();
            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@username", username));
            
            SqlDataReader lector = DBAcess.GetDataReader("SELECT * from MARGINADOS.Usuario where username=@username", "T", parameterList);
            
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    miUsuario.username = (string)lector["username"];
                    miUsuario.pass = (string)lector["pass"];

                }
            }

            return miUsuario;
        }
    }
}
