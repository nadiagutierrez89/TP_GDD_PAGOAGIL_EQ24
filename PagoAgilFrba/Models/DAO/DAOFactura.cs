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
                    unFactura.Importe_total_fac = (decimal)lector["Importe_total_fac"];

                    if (lector["nro_pago"] != DBNull.Value)
                        unFactura.nro_pago = (decimal)lector["nro_pago"];

                    if (lector["nro_rendicion"] != DBNull.Value)
                        unFactura.nro_pago = (decimal)lector["nro_rendicion"];

                    mi_lista_return.Add(unFactura);
                }
            }
            return mi_lista_return;
        }
    }
}
