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
    class DAOFacturaItem
    {

        internal static List<FacturaItem> getItemsDe(BO.Factura unFactura)
        {
            return getLosQueCumplenCon("cod_empresa = " + unFactura.cod_empresa + " and nro_factura = " + unFactura.nro_factura);
        }

        internal static List<FacturaItem> getLosQueCumplenCon(string filtro)
        {
            List<FacturaItem> mi_lista_return = new List<FacturaItem>();
            List<SqlParameter> paramList = new List<SqlParameter>();

            SqlDataReader lector = DBAcess.GetDataReader("SELECT * FROM MARGINADOS.FacturaItem WHERE " + filtro, "T", paramList);
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    FacturaItem unFacturaItem = new FacturaItem();

                    unFacturaItem.cod_empresa = (decimal)lector["cod_empresa"];
                    unFacturaItem.nro_factura = (decimal)lector["nro_factura"];
                    unFacturaItem.nro_item = (decimal)lector["nro_item"];
                    unFacturaItem.monto_item = (decimal)lector["monto_item"];
                    unFacturaItem.cantidad_item = (decimal)lector["cantidad_item"];

                    mi_lista_return.Add(unFacturaItem);
                }
            }
            return mi_lista_return;
        }

        internal static int guardar(Factura unafactura)
        {
            int intReturn = 0;
            string noQuery = "";

            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@nro_factura", unafactura.nro_factura));
            ListaParametros.Add(new SqlParameter("@cod_empresa", unafactura.cod_empresa));

            noQuery = "Delete MARGINADOS.FacturaItem WHERE nro_factura = @nro_factura and cod_empresa = @cod_empresa";
            DBAcess.WriteInBase(noQuery, "T", ListaParametros);

            unafactura.facturaItems.ForEach(i => intReturn = insertar(i));

            return intReturn;
        }

        private static int insertar(FacturaItem i)
        {                          
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@cod_empresa", i.cod_empresa));
            ListaParametros.Add(new SqlParameter("@nro_factura", i.nro_factura));
            ListaParametros.Add(new SqlParameter("@nro_item", i.nro_item));
            ListaParametros.Add(new SqlParameter("@monto_item", i.monto_item));
            ListaParametros.Add(new SqlParameter("@cantidad_item", i.cantidad_item));

            string noQuery = "INSERT INTO MARGINADOS.FacturaItem " +
               "(cod_empresa " +
               ",nro_factura " +
               ",nro_item " +
               ",monto_item " +
               ",cantidad_item ) " +
         "VALUES " +
               "(@cod_empresa " +
               ",@nro_factura " +
               ",@nro_item " +
               ",@monto_item " +
               ",@cantidad_item ) ";
            
            return DBAcess.WriteInBase(noQuery, "T", ListaParametros);
        }
    }
}
