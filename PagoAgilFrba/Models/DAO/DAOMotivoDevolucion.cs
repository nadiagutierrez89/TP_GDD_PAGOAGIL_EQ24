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
    class DAOMotivoDevolucion
    {
        internal static List<MotivoDevolucion> getAll()
        {
            List<MotivoDevolucion> lista = new List<MotivoDevolucion>();
            SqlDataReader lector = DBAcess.GetDataReader("SELECT  R.cod_motivoDevolucion, R.descripcion FROM MARGINADOS.MotivoDevolucion R", "T", new List<SqlParameter>());
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    MotivoDevolucion unMotivo = new MotivoDevolucion();
                    unMotivo.cod_motivoDevolucion = (Decimal)lector["cod_motivoDevolucion"];
                    unMotivo.descripcion = (String)lector["descripcion"];

                    lista.Add(unMotivo);
                }
                lector.Close();
            }
            return lista;
        }
    }
}
