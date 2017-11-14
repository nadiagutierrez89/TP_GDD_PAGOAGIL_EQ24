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
    class DAODevolucion
    {
        internal static int procesar(Devolucion devolucion)
        {
            int returnint;
            string noQuery = "";
            Factura unFactura = devolucion.factura;
            Pago unPago = Pago.get(unFactura.nro_pago);

            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@cod_user", devolucion.cod_user));
            ListaParametros.Add(new SqlParameter("@nro_factura", unFactura.nro_factura));
            ListaParametros.Add(new SqlParameter("@cod_empresa", unFactura.cod_empresa));
            ListaParametros.Add(new SqlParameter("@cod_motivoDevolucion", devolucion.cod_motivoDevolucion));
            ListaParametros.Add(new SqlParameter("@fecha_devolucion", devolucion.fecha_devolucion));

            noQuery = "INSERT INTO MARGINADOS.Devolucion " +
               "(cod_user " +
               ",nro_factura " +
               ",cod_empresa " +
               ",cod_motivoDevolucion " +
               ",fecha_devolucion ) " +
         "VALUES " +
               "(@cod_user " +
               ",@nro_factura " +
               ",@cod_empresa " +
               ",@cod_motivoDevolucion " +
               ",@fecha_devolucion ) ";

            returnint = DBAcess.WriteInBase(noQuery, "T", ListaParametros);

            unPago.importe_total_pago = unPago.importe_total_pago - unFactura.importe_total_fac; ;
            returnint = unPago.guardar();

            unFactura.nro_pago = null;
            returnint = unFactura.guardar();
            
            return returnint;
        }

        internal static decimal lastIdentity()
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            decimal id = 0;

            SqlDataReader lector = DBAcess.GetDataReader("select IDENT_CURRENT('MARGINADOS.Devolucion') as id", "T", paramList);
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
