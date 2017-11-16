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
        internal static List<Cliente> getClientesQueCumplenCon(string filtro)
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
                    if (lector["fecha_baja"] == DBNull.Value)
                    {
                        unCliente.fecha_baja = null;
                    }
                    else
                    {
                        unCliente.fecha_baja = (DateTime)lector["fecha_baja"];
                    }
                    

                    misClientes.Add(unCliente);
                }
            }
            return misClientes;
        }


        internal static int guardar(Cliente cliente)
        {
            string noQuery = "";

            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@dni_clie", cliente.dni));
            ListaParametros.Add(new SqlParameter("@nombre_clie", cliente.nombre));
            ListaParametros.Add(new SqlParameter("@apellido_clie", cliente.apellido));
            ListaParametros.Add(new SqlParameter("@mail_clie", cliente.mail));
            ListaParametros.Add(new SqlParameter("@telefeno_clie", cliente.telefono));
            ListaParametros.Add(new SqlParameter("@calle_clie", cliente.calle));
            ListaParametros.Add(new SqlParameter("@nro_piso_clie", cliente.nro_piso));
            ListaParametros.Add(new SqlParameter("@depto_clie", cliente.depto));
            ListaParametros.Add(new SqlParameter("@localidad_clie", cliente.localidad));
            ListaParametros.Add(new SqlParameter("@cod_postal_clie", cliente.cod_postal));
            ListaParametros.Add(new SqlParameter("@fecha_nac_clie", cliente.fecha_nac));


            if (cliente.fecha_baja == null)
            {
                ListaParametros.Add(new SqlParameter("@fecha_baja", DBNull.Value));
            }
            else
            {
                ListaParametros.Add(new SqlParameter("@fecha_baja", cliente.fecha_baja));
            }

            if (existeClienteSegun("dni_clie", cliente.dni.ToString()))
            {
                noQuery = "UPDATE MARGINADOS.Cliente " +
                       "SET nombre_clie = @nombre_clie " +
                          ",apellido_clie = @apellido_clie " +
                          ",mail_clie = @mail_clie " +
                          ",telefeno_clie = @telefeno_clie " +
                          ",calle_clie = @calle_clie " +
                          ",nro_piso_clie = @nro_piso_clie " +
                          ",depto_clie = @depto_clie " +
                          ",localidad_clie = @localidad_clie " +
                          ",cod_postal_clie = @cod_postal_clie " + 
                          ",fecha_nac_clie = @fecha_nac_clie " +
                          ",fecha_baja = @fecha_baja " +                     
                     "WHERE dni_clie = @dni_clie ";
            }
            else
            {
                noQuery = "INSERT INTO MARGINADOS.Cliente " +
               "(dni_clie " +
               ",nombre_clie " +
               ",apellido_clie " +
               ",mail_clie " +
               ",telefeno_clie " +
               ",calle_clie " +
               ",nro_piso_clie " +
               ",depto_clie " +
               ",localidad_clie " +
               ",cod_postal_clie " +
               ",fecha_nac_clie " +
               ",fecha_baja ) " +
         "VALUES " +
               "(@dni_clie " +
               ",@nombre_clie " +
               ",@apellido_clie " +
               ",@mail_clie " +
               ",@telefeno_clie " +
               ",@calle_clie " +
               ",@nro_piso_clie " +
               ",@depto_clie " +
               ",@localidad_clie " +
               ",@cod_postal_clie " +
               ",@fecha_nac_clie " +
               ",@fecha_baja ) ";

            }
            return DBAcess.WriteInBase(noQuery, "T", ListaParametros);
        }

        internal static bool existeClienteSegun(string campo, string valor)
        {
            List<Cliente> clie_lis= getClientesQueCumplenCon(campo + " = " + valor);
            return clie_lis.Count > 0;
        }

        internal static Cliente getCliente(decimal dni)
        {
            List<Cliente> misClientes = new List<Cliente>();
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@dni_clie", dni));
            Cliente unCliente = new Cliente();

            SqlDataReader lector = DBAcess.GetDataReader("SELECT * FROM MARGINADOS.Cliente WHERE dni_clie = @dni_clie", "T", paramList);
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    
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
                    if (lector["fecha_baja"] == DBNull.Value)
                    {
                        unCliente.fecha_baja = null;
                    }
                    else
                    {
                        unCliente.fecha_baja = (DateTime)lector["fecha_baja"];
                    }
                }
            }
            return unCliente;
        }
    }
}
