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

            string query = @" SELECT top 5 e.nombre_empresa, t.cod_empresa, 100 *(TotalEmpresa / TotalSistema) As Porcentaje
				FROM
				(SELECT  f.cod_empresa, count(*) AS TotalEmpresa,
					(SELECT count(*) FROM [GD2C2017].[MARGINADOS].[Factura] F where 
						(@trim = 1 and month(F.fecha_alta_fac) in (1,2,3) and @anio = year(F.fecha_alta_fac))
						or (@trim = 2 and month(F.fecha_alta_fac) in (4,5,6) and @anio = year(F.fecha_alta_fac))
						or (@trim = 3 and month(F.fecha_alta_fac) in (7,8,9) and @anio = year(F.fecha_alta_fac))  
						or (@trim = 4 and month(F.fecha_alta_fac) in (10,11,12) and @anio = year(F.fecha_alta_fac))
						) AS TotalSistema
				FROM [GD2C2017].[MARGINADOS].[Factura] F
				where  (@trim = 1 and month(F.fecha_alta_fac) in (1,2,3) and @anio = year(F.fecha_alta_fac))
					or (@trim = 2 and month(F.fecha_alta_fac) in (4,5,6) and @anio = year(F.fecha_alta_fac))
					or (@trim = 3 and month(F.fecha_alta_fac) in (7,8,9) and @anio = year(F.fecha_alta_fac))  
					or (@trim = 4 and month(F.fecha_alta_fac) in (10,11,12) and @anio = year(F.fecha_alta_fac))
				GROUP BY f.cod_empresa ) AS t
			INNER JOIN [GD2C2017].[MARGINADOS].[Empresa] e ON e.cod_empresa = t.cod_empresa
			ORDER BY (TotalEmpresa / TotalSistema) DESC";

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

            string query = @" select top 5 R.[cod_empresa], e.nombre_empresa, sum(R.importe_total_rendicion)  As monto 
			from [GD2C2017].[MARGINADOS].[Rendicion] R
			INNER JOIN [GD2C2017].[MARGINADOS].[Empresa] e ON e.cod_empresa = R.cod_empresa
			where (@trim = 1 and month(R.fecha_rendicion) in (1,2,3) and @anio = year(R.fecha_rendicion))
				or (@trim = 2 and month(R.fecha_rendicion) in (4,5,6) and @anio = year(R.fecha_rendicion))
				or (@trim = 3 and month(R.fecha_rendicion) in (7,8,9) and @anio = year(R.fecha_rendicion))  
				or (@trim = 4 and month(R.fecha_rendicion) in (10,11,12) and @anio = year(R.fecha_rendicion))
			group by R.cod_empresa, e.nombre_empresa
			order by sum(R.importe_total_rendicion)
			";

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

            string query = @" select top 5 P.dni_cliente, C.nombre_clie, C.apellido_clie, count(*)  As cantidadPagos 
			from [GD2C2017].[MARGINADOS].[Pago] P
			INNER JOIN [GD2C2017].[MARGINADOS].[Cliente] C ON C.dni_clie = P.dni_cliente
			where (@trim = 1 and month(P.fecha_pago) in (1,2,3) and @anio = year(P.fecha_pago))
				or (@trim = 2 and month(P.fecha_pago) in (4,5,6) and @anio = year(P.fecha_pago))
				or (@trim = 3 and month(P.fecha_pago) in (7,8,9) and @anio = year(P.fecha_pago))  
				or (@trim = 4 and month(P.fecha_pago) in (10,11,12) and @anio = year(P.fecha_pago))
			group by P.dni_cliente, C.nombre_clie,C.apellido_clie
			order by count(*)  desc ";

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

            string query = @"SELECT top 5 C.nombre_clie, C.apellido_clie, t.dni_cliente,   
							100 * ((Totalcliente + 0.00) / TotalSistema) As Porcentaje
			FROM (SELECT f.dni_cliente, count(*) AS TotalCliente,
					(SELECT count(*) FROM [GD2C2017].[MARGINADOS].[Factura] F where 
						(@trim = 1 and month(F.fecha_alta_fac) in (1,2,3) and @anio = year(F.fecha_alta_fac))
						or (@trim = 2 and month(F.fecha_alta_fac) in (4,5,6) and @anio = year(F.fecha_alta_fac))
						or (@trim = 3 and month(F.fecha_alta_fac) in (7,8,9) and @anio = year(F.fecha_alta_fac))  
						or (@trim = 4 and month(F.fecha_alta_fac) in (10,11,12) and @anio = year(F.fecha_alta_fac))
						and F.nro_pago is not null) AS TotalSistema
				FROM [GD2C2017].[MARGINADOS].[Factura] F
				where  (@trim = 1 and month(F.fecha_alta_fac) in (1,2,3) and @anio = year(F.fecha_alta_fac))
						or (@trim = 2 and month(F.fecha_alta_fac) in (4,5,6) and @anio = year(F.fecha_alta_fac))
						or (@trim = 3 and month(F.fecha_alta_fac) in (7,8,9) and @anio = year(F.fecha_alta_fac))  
						or (@trim = 4 and month(F.fecha_alta_fac) in (10,11,12) and @anio = year(F.fecha_alta_fac))
						and F.nro_pago is not null
				GROUP BY f.dni_cliente ) AS t
			INNER JOIN [GD2C2017].[MARGINADOS].[Cliente] C ON C.dni_clie = t.dni_cliente
			ORDER BY (TotalCliente / TotalSistema) DESC	";

            SqlDataReader lector = DBAcess.GetDataReader(query, "T", paramList);
            DataTable dt = new DataTable("listado");
            dt.Load(lector);
            return dt;
        }


    }
}