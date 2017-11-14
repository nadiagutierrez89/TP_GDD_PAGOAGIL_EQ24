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
            ListaParametros.Add(new SqlParameter("@cod_medioDePago", pago.cod_medioDePago));

            if (pago.nro_pago != null)
            {
                ListaParametros.Add(new SqlParameter("@nro_pago", pago.nro_pago));

                noQuery = "UPDATE MARGINADOS.Pago " +
                       "SET fecha_pago = @fecha_pago " +
                          ",dni_cliente = @dni_cliente " +
                          ",importe_total_pago = @importe_total_pago " +
                          ",codigo_postal_suc = @codigo_postal_suc " +
                          ",cod_user = @cod_user " +
                          ",cod_medioDePago = @cod_medioDePago " +
                     "WHERE nro_pago = @nro_pago ";
            }
            else
            {
                noQuery = "INSERT INTO MARGINADOS.Pago " +
                   "(fecha_pago " +
                   ",dni_cliente " +
                   ",importe_total_pago " +
                   ",codigo_postal_suc " +
                   ",cod_medioDePago " +
                   ",cod_user) " +
                "VALUES " +
                   "(@fecha_pago " +
                   ",@dni_cliente " +
                   ",@importe_total_pago " +
                   ",@codigo_postal_suc " +
                   ",@cod_medioDePago " +
                   ",@cod_user ) ";
            }


            returnint = DBAcess.WriteInBase(noQuery, "T", ListaParametros);

            if (pago.nro_pago == null)
            {
                pago.nro_pago = lastIdentity();
                pago.facturas.ForEach(f => f.nro_pago = pago.nro_pago);
                pago.facturas.ForEach(f => returnint = f.guardar());
            }
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

        internal static Pago get(decimal nro_pago)
        {
            Pago returnPago = new Pago();
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@nro_pago", nro_pago));

            SqlDataReader lector = DBAcess.GetDataReader("SELECT  * FROM MARGINADOS.Pago where nro_pago = @nro_pago", "T", paramList);
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    returnPago.nro_pago = (decimal)lector["nro_pago"];
                    returnPago.fecha_pago = (DateTime)lector["fecha_pago"];
                    returnPago.dni_cliente = (decimal)lector["dni_cliente"];
                    returnPago.importe_total_pago = (decimal)lector["importe_total_pago"];
                    returnPago.codigo_postal_suc = (decimal)lector["codigo_postal_suc"];
                    returnPago.cod_medioDePago = (decimal)lector["cod_medioDePago"];
                }
                lector.Close();
            }
            return returnPago;
        }
    }
}
