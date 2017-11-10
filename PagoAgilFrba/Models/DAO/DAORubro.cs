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
    class DAORubro
    {
        public static List<Rubro> devolverTodos()
        {
            List<Rubro> rubros = new List<Rubro>();
            SqlDataReader lector = DBAcess.GetDataReader("SELECT  R.cod_rubro, R.descripcion_rubro FROM MARGINADOS.Rubro R", "T", new List<SqlParameter>());
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Rubro rubro = new Rubro();
                    rubro.cod_rubro = (Decimal)lector["cod_rubro"];
                    rubro.descripcion_rubro = (String)lector["descripcion_rubro"];

                    rubros.Add(rubro);
                }
                lector.Close();
            }
            return rubros;

        }
    }
}
