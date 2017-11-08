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
    class DAOCliente
    {
        internal static List<Cliente> getClienteQueCumplenCon(string filtro)
        {
            List<Cliente> misClientes = new List<Cliente>();
            List<SqlParameter> paramList = new List<SqlParameter>();

            SqlDataReader lector = DBAcess.GetDataReader("SELECT * FROM MARGINADOS.Cliente WHERE " + filtro, "T", paramList);
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Cliente unCliente = new Cliente();
                    unCliente.dni = (decimal)lector["dni_clie"];
                    unCliente.nombre = (string)lector["nombre_clie"];
                    unCliente.apellido = (string)lector["apellido_clie"];
                    unCliente.mail = (string)lector["mail_clie"];
                    unCliente.telefono = (string)lector["telefeno_clie"];
                    unCliente.calle = (string)lector["calle_clie"];
                    unCliente.nro_piso = (string)lector["nro_piso_clie"];
                    unCliente.depto = (string)lector["depto_clie"];
                    unCliente.localidad = (string)lector["localidad_clie"];
                    unCliente.cod_postal = (string)lector["cod_postal_clie"];
                    unCliente.fecha_nac = (DateTime)lector["fecha_nac_clie"];
                    Verificar que sea valor nulll
                    if (lector["fecha_nac_clie"] != DBNull.Value)
                    {
                        unCliente.fecha_baja = (DateTime)lector["fecha_baja"];
                    }

                    misClientes.Add(unCliente);
                }
            }
            return misClientes;
        }

    }
}
