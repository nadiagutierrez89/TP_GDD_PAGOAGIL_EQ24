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
    }
}
