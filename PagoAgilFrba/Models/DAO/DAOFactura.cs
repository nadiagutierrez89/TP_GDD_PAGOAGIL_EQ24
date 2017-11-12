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
    class DAOFactura
    {
        internal static List<Factura> getLosQueCumplenCon(string filtro)
        {
            List<Factura> mi_lista_return = new List<Factura>();
            List<SqlParameter> paramList = new List<SqlParameter>();

            SqlDataReader lector = DBAcess.GetDataReader("SELECT * FROM MARGINADOS.Factura WHERE " + filtro, "T", paramList);
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Factura unFactura = new Factura();
                    unFactura.nro_pago = null;
                    unFactura.nro_rendicion = null;

                    unFactura.nro_factura = (decimal)lector["nro_factura"];
                    unFactura.cod_empresa = (decimal)lector["cod_empresa"];
                    unFactura.dni_cliente = (decimal)lector["dni_cliente"];
                    unFactura.fecha_alta_fac = (DateTime)lector["fecha_alta_fac"];
                    unFactura.fecha_vto_fac = (DateTime)lector["fecha_vto_fac"];
                    unFactura.importe_total_fac = (decimal)lector["importe_total_fac"];

                    if (lector["nro_pago"] != DBNull.Value)
                        unFactura.nro_pago = (decimal)lector["nro_pago"];

                    if (lector["nro_rendicion"] != DBNull.Value)
                        unFactura.nro_rendicion = (decimal)lector["nro_rendicion"];

                    mi_lista_return.Add(unFactura);
                }
            }
            return mi_lista_return;
        }

        internal static int guardar(Factura unafactura)
        {
            string noQuery = "";

            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@nro_factura", unafactura.nro_factura));
            ListaParametros.Add(new SqlParameter("@cod_empresa", unafactura.cod_empresa));
            ListaParametros.Add(new SqlParameter("@dni_cliente", unafactura.dni_cliente));
            ListaParametros.Add(new SqlParameter("@fecha_alta_fac", unafactura.fecha_alta_fac));
            ListaParametros.Add(new SqlParameter("@fecha_vto_fac", unafactura.fecha_vto_fac));
            ListaParametros.Add(new SqlParameter("@importe_total_fac", unafactura.importe_total_fac));

            if (unafactura.nro_pago != null)
            {
                ListaParametros.Add(new SqlParameter("@nro_pago", unafactura.nro_pago));
            }
            else
            {
                ListaParametros.Add(new SqlParameter("@nro_pago", DBNull.Value));
            }


            if (unafactura.nro_rendicion != null)
            {
                ListaParametros.Add(new SqlParameter("@nro_rendicion", unafactura.nro_rendicion));
            }
            else
            {
                ListaParametros.Add(new SqlParameter("@nro_rendicion", DBNull.Value));
            }
                

            if (Factura.yaExiste(unafactura))
            {
                noQuery = "UPDATE MARGINADOS.Factura " +
                       "SET nro_factura = @nro_factura " +
                          ",dni_cliente = @dni_cliente " +
                          ",fecha_alta_fac = @fecha_alta_fac " +
                          ",fecha_vto_fac = @fecha_vto_fac " +
                          ",importe_total_fac = @importe_total_fac " +
                          ",nro_pago = @nro_pago " +
                          ",nro_rendicion = @nro_rendicion " +
                     "WHERE nro_factura = @nro_factura and cod_empresa = @cod_empresa";
                
            }
            else
            {
                noQuery = "INSERT INTO MARGINADOS.Factura " +
               "(nro_factura " +
               ",cod_empresa " +
               ",dni_cliente " +
               ",fecha_alta_fac " +
               ",fecha_vto_fac " +
               ",importe_total_fac " +
               ",nro_pago " +
               ",nro_rendicion  ) " +
         "VALUES " +
               "(@nro_factura " +
               ",@cod_empresa " +
               ",@dni_cliente " +
               ",@fecha_alta_fac " +
               ",@fecha_vto_fac " +
               ",@importe_total_fac " +
               ",@nro_pago " +
               ",@nro_rendicion  ) ";

            }
            return DBAcess.WriteInBase(noQuery, "T", ListaParametros);
        }
    }
}
