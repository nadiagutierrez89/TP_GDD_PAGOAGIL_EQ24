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
    class DAOPago
    {
        internal static int guardar(Pago pago)
        {
            int returnint;
            string noQuery = "";

            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@fecha_pago", pago.fecha_pago));
            ListaParametros.Add(new SqlParameter("@dni_cliente", pago.dni_cliente));
            ListaParametros.Add(new SqlParameter("@importe_total_pago", pago.importe_total_pago));
            ListaParametros.Add(new SqlParameter("@codigo_postal_suc", pago.codigo_postal_suc));
            ListaParametros.Add(new SqlParameter("@cod_user", pago.cod_user));

            noQuery = "INSERT INTO MARGINADOS.Pago " +
               "(fecha_pago " +
               ",dni_cliente " +
               ",importe_total_pago " +
               ",codigo_postal_suc " +
               ",cod_user) " +
         "VALUES " +
               "(@fecha_pago " +
               ",@dni_cliente " +
               ",@importe_total_pago " +
               ",@codigo_postal_suc " +
               ",@cod_user ) ";

            returnint = DBAcess.WriteInBase(noQuery, "T", ListaParametros);

            pago.nro_pago = lastIdentity();

            pago.facturas.ForEach(f => f.nro_pago = pago.nro_pago);
            pago.facturas.ForEach(f => returnint = f.guardar());

            pago.mediosDePago.ForEach(p => p.nro_pago = pago.nro_pago);
            pago.mediosDePago.ForEach(p => returnint = p.guardar());


            return returnint;
        }

        internal static decimal lastIdentity()
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            decimal id = 0;

            SqlDataReader lector = DBAcess.GetDataReader("select IDENT_CURRENT('MARGINADOS.Pago') as id", "T", paramList);
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    id = (decimal)lector["id"];
                }
            }

            return id;
        }

        public static SqlParameter ListaParametros { get; set; }
    }
}
