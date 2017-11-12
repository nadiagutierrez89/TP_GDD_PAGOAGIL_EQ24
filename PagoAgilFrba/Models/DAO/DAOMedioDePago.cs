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
    class DAOMedioDePago
    {
        public static List<MedioDePago> obtenerLosTiposDeMediosDePago()
        {
            List<MedioDePago> lista = new List<MedioDePago>();
            SqlDataReader lector = DBAcess.GetDataReader("SELECT * FROM MARGINADOS.MedioDePago R", "T", new List<SqlParameter>());
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    MedioDePago unMedio = new MedioDePago();
                    unMedio.cod_medioDePago = (decimal)lector["cod_medioDePago"];
                    unMedio.descripcion_MP = (string)lector["descripcion_MP"];
                    lista.Add(unMedio);
                }
                lector.Close();
            }
            return lista;
        }

        internal static int guardar(MedioDePago medioDePago)
        {
            string noQuery = "";

            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@nro_pago", medioDePago.nro_pago));
            ListaParametros.Add(new SqlParameter("@cod_pago_MP", medioDePago.cod_medioDePago));
            ListaParametros.Add(new SqlParameter("@importe", medioDePago.importe));

            noQuery = "INSERT INTO MARGINADOS.PagoMedioDePago " +
               "(nro_pago " +
               ",cod_pago_MP " +
               ",importe ) " +
         "VALUES " +
               "(@nro_pago " +
               ",@cod_pago_MP " +
               ",@importe ) ";

            return DBAcess.WriteInBase(noQuery, "T", ListaParametros);
        }
    }
}
