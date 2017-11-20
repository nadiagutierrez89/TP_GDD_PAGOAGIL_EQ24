using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PagoAgilFrba.Models.BO;
using PagoAgilFrba.Models.DataBase;


namespace PagoAgilFRBA.Models.DAO
{
    class DAOListadoEstadistico
    {
        public DataTable PorcentajeFacturasCobradasXEmpresa(int trim, int anio)
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@trim", trim));
            paramList.Add(new SqlParameter("@anio", anio));

            string query = @"SELECT TOP 5 
                E.cod_empresa, 
                E.nombre_empresa,
                P.cant_pagos,
                P.pagos_totales,
                CASE WHEN P.cant_pagos = 0 THEN 0 ELSE (P.cant_pagos + 0.0)/P.pagos_totales  END as porcentaje
                FROM GD2C2017.MARGINADOS.Empresa E 
                LEFT JOIN 
                (SELECT cod_empresa, COUNT(nro_pago) as cant_pagos, (SELECT COUNT (*)FROM GD2C2017.MARGINADOS.Factura F2 
														                WHERE F2.nro_pago is not null 
															                AND @anio = YEAR(F2.fecha_alta_fac)  
															                AND ( (@trim = 1 and MONTH(F2.fecha_alta_fac) IN (1,2,3)) 
																                or (@trim = 2 and MONTH(F2.fecha_alta_fac) IN (4,5,6)) 
																                or (@trim = 3 and MONTH(F2.fecha_alta_fac) IN (7,8,9)) 
																                or (@trim = 4 and MONTH(F2.fecha_alta_fac) IN (10,11,12)) )

							                  ) AS pagos_totales
	                FROM GD2C2017.MARGINADOS.Factura F
	                WHERE F.nro_pago is not null
		                AND @anio = YEAR(F.fecha_alta_fac) 
		                AND ((@trim = 1 AND MONTH(F.fecha_alta_fac) IN (1, 2, 3))
			                OR (@trim = 2 AND MONTH(F.fecha_alta_fac) IN (4, 5, 6))
			                OR (@trim = 3 AND MONTH(F.fecha_alta_fac) IN (7, 8, 9))
			                OR (@trim = 4 AND MONTH(F.fecha_alta_fac) IN (10, 11, 12)))
	                GROUP BY F.cod_empresa ) AS P
                ON E.cod_empresa = P.cod_empresa
                ORDER BY porcentaje DESC";

            SqlDataReader lector = DBAcess.GetDataReader(query, "T", paramList);
            DataTable dt = new DataTable("listado");
            dt.Load(lector);
            return dt;
        }



        public DataTable EmpresasConMatorMontoRendido(int trim, int anio)
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@trim", trim));
            paramList.Add(new SqlParameter("@anio", anio));

            string query = @"SELECT TOP 5 E.cod_empresa, E.nombre_empresa, isnull(P.monto,0) as monto_rendido
                FROM GD2C2017.MARGINADOS.Empresa E 
                LEFT JOIN 
                (SELECT R.cod_empresa, SUM(r.importe_total_rendicion) as monto
		                FROM GD2C2017.MARGINADOS.Rendicion R
			                WHERE @anio = YEAR(R.fecha_rendicion) AND
							 ((@trim = 1 AND MONTH(R.fecha_rendicion) IN (1, 2,3))
				                OR (@trim = 2 AND MONTH(R.fecha_rendicion) IN (4, 5, 6))
				                OR (@trim = 3 AND MONTH(R.fecha_rendicion) IN (7, 8, 9))
				                OR (@trim = 4 AND MONTH(R.fecha_rendicion) IN (10, 11, 12)))
			                GROUP BY R.cod_empresa ) AS P
                 ON E.cod_empresa = P.cod_empresa
                 ORDER BY monto_rendido DESC";

            SqlDataReader lector = DBAcess.GetDataReader(query, "T", paramList);
            DataTable dt = new DataTable("listado");
            dt.Load(lector);
            return dt;
        }

        public DataTable clientesConMAsPagos(int trim, int anio)
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@trim", trim));
            paramList.Add(new SqlParameter("@anio", anio));

            string query = @"SELECT TOP 5 C.nombre_clie, C.apellido_clie, C.dni_clie, isnull(P.cant, 0) as cantidad_pagos
                FROM GD2C2017.MARGINADOS.Cliente C
                LEFT JOIN 
                (SELECT dni_cliente, COUNT(nro_pago) AS cant
		                                FROM GD2C2017.MARGINADOS.Pago Pa
			                               WHERE
											@anio = YEAR(Pa.fecha_pago) and
										    ((@trim = 1 AND MONTH(Pa.fecha_pago) IN (1, 2, 3))
				                                OR (@trim = 2 AND MONTH(Pa.fecha_pago) IN (4, 5, 6))
				                                OR (@trim = 3 AND MONTH(Pa.fecha_pago) IN (7, 8, 9))
				                                OR (@trim = 4 AND MONTH(Pa.fecha_pago) IN (10, 11, 12)))
			                                GROUP BY dni_cliente ) AS P
                 ON C.dni_clie = P.dni_cliente
                 ORDER BY cantidad_pagos DESC";

            SqlDataReader lector = DBAcess.GetDataReader(query, "T", paramList);
            DataTable dt = new DataTable("listado");
            dt.Load(lector);
            return dt;
        }


        public DataTable clientesCumplidores(int trim, int anio)
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@trim", trim));
            paramList.Add(new SqlParameter("@anio", anio));


            string query = @"SELECT TOP 5 
C.nombre_clie, 
C.apellido_clie, 
C.dni_clie, 
P.cant, 
P.cant_total, 
CASE WHEN P.cant_total = 0 THEN 0 ELSE (P.cant + 0.0)/P.cant_total  END as porcentaje
FROM GD2C2017.MARGINADOS.Cliente C
LEFT JOIN 
                (SELECT F.dni_cliente, 
					COUNT(F.nro_pago) as cant, 
					(SELECT COUNT (*)FROM GD2C2017.MARGINADOS.Factura F2 
						WHERE F2.nro_pago is not null 
							AND @anio = YEAR(F2.fecha_alta_fac)  
							AND ( (@trim = 1 and MONTH(F2.fecha_alta_fac) IN (1,2,3)) 
								or (@trim = 2 and MONTH(F2.fecha_alta_fac) IN (4,5,6)) 
								or (@trim = 3 and MONTH(F2.fecha_alta_fac) IN (7,8,9)) 
								or (@trim = 4 and MONTH(F2.fecha_alta_fac) IN (10,11,12)) ) 

							) AS cant_total
		         FROM GD2C2017.MARGINADOS.Factura F
					WHERE 
						F.nro_pago is not null 
							AND @anio = YEAR(F.fecha_alta_fac)  
							AND ( (@trim = 1 and MONTH(F.fecha_alta_fac) IN (1,2,3)) 
								or (@trim = 2 and MONTH(F.fecha_alta_fac) IN (4,5,6)) 
								or (@trim = 3 and MONTH(F.fecha_alta_fac) IN (7,8,9)) 
								or (@trim = 4 and MONTH(F.fecha_alta_fac) IN (10,11,12)) )
			     GROUP BY dni_cliente ) AS P
 ON C.dni_clie = P.dni_cliente
 where cant is not null 
 ORDER BY porcentaje DESC";

            SqlDataReader lector = DBAcess.GetDataReader(query, "T", paramList);
            DataTable dt = new DataTable("listado");
            dt.Load(lector);
            return dt;
        }


    }
}