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
    class DAORendicion
    {
        internal static int guardar(Rendicion rendicion)
        {
            int returnint;
            string noQuery = "";

            List<SqlParameter> ListaParametros = new List<SqlParameter>();

            ListaParametros.Add(new SqlParameter("@fecha_rendicion", rendicion.fecha_rendicion));
            ListaParametros.Add(new SqlParameter("@cant_facturas_rendidas", rendicion.cant_facturas_rendidas));
            ListaParametros.Add(new SqlParameter("@importe_comision", rendicion.importe_comision));
            ListaParametros.Add(new SqlParameter("@cod_empresa", rendicion.cod_empresa));
            ListaParametros.Add(new SqlParameter("@porcentaje_comision", rendicion.porcentaje_comision));
            ListaParametros.Add(new SqlParameter("@importe_total_rendicion", rendicion.importe_total_rendicion));

            if (rendicion.nro_rendicion != null)
            {
                ListaParametros.Add(new SqlParameter("@nro_rendicion", rendicion.nro_rendicion));

                noQuery = "UPDATE MARGINADOS.Rendicion " +
                       "SET fecha_rendicion = @fecha_rendicion " +
                          ",cant_facturas_rendidas = @cant_facturas_rendidas " +
                          ",importe_comision = @importe_comision " +
                          ",cod_empresa = @cod_empresa " +
                          ",porcentaje_comision = @porcentaje_comision " +
                          ",importe_total_rendicion = @importe_total_rendicion " +
                     "WHERE nro_rendicion = @nro_rendicion ";
            }
            else
            {
                noQuery = "INSERT INTO MARGINADOS.Rendicion " +
                   "(fecha_rendicion " +
                   ",cant_facturas_rendidas " +
                   ",importe_comision " +
                   ",cod_empresa " +
                   ",porcentaje_comision " +
                   ",importe_total_rendicion) " +
                "VALUES " +
                   "(@fecha_rendicion " +
                   ",@cant_facturas_rendidas " +
                   ",@importe_comision " +
                   ",@cod_empresa " +
                   ",@porcentaje_comision " +
                   ",@importe_total_rendicion ) ";
            }

            try
            {
                returnint = DBAcess.WriteInBase(noQuery, "T", ListaParametros);
            }
            catch
            {
                return 0;
            }

            if (rendicion.nro_rendicion == null)
            {
                rendicion.nro_rendicion = lastIdentity();
                rendicion.facturas.ForEach(f => f.nro_rendicion = rendicion.nro_rendicion);
                rendicion.facturas.ForEach(f => returnint = f.guardar());
            }
            return returnint;
        }

        internal static decimal lastIdentity()
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            decimal id = 0;

            SqlDataReader lector = DBAcess.GetDataReader("select IDENT_CURRENT('MARGINADOS.Rendicion') as id", "T", paramList);
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    id = (decimal)lector["id"];
                }
            }

            return id;
        }
    }
}
