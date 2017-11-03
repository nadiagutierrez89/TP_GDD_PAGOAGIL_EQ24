USE GD2C2017;
/******************************************************************************/
-- Borramos todas las tablas
/******************************************************************************/

-- --> FacturaItem <-- --
IF OBJECT_ID('MARGINADOS.FacturaItem') IS NOT NULL
	DROP TABLE MARGINADOS.FacturaItem;

-- --> Factura <-- --
IF OBJECT_ID('MARGINADOS.Factura') IS NOT NULL
	DROP TABLE MARGINADOS.Factura;

-- --> PagoMedioDePago <-- --
IF OBJECT_ID('MARGINADOS.PagoMedioDePago') IS NOT NULL
	DROP TABLE MARGINADOS.PagoMedioDePago;

-- --> Pago <-- --
IF OBJECT_ID('MARGINADOS.Pago') IS NOT NULL
	DROP TABLE MARGINADOS.Pago;

-- --> MedioDePago <-- --
IF OBJECT_ID('MARGINADOS.MedioDePago') IS NOT NULL
	DROP TABLE MARGINADOS.MedioDePago;

-- --> Rendicion <-- --
IF OBJECT_ID('MARGINADOS.Rendicion') IS NOT NULL
	DROP TABLE MARGINADOS.Rendicion;

-- --> Devolucion <-- --
IF OBJECT_ID('MARGINADOS.Devolucion') IS NOT NULL
	DROP TABLE MARGINADOS.Devolucion;
-- --> Motivo_devolucion <-- --

IF OBJECT_ID('MARGINADOS.Motivo_devolucion') IS NOT NULL
	DROP TABLE MARGINADOS.Motivo_devolucion;

-- --> Empresa <-- --
IF OBJECT_ID('MARGINADOS.Empresa') IS NOT NULL
	DROP TABLE MARGINADOS.Empresa;

-- --> Rubro <-- --
IF OBJECT_ID('MARGINADOS.Rubro') IS NOT NULL
	DROP TABLE MARGINADOS.Rubro;

-- --> Cliente <-- --
IF OBJECT_ID('MARGINADOS.Cliente') IS NOT NULL
	DROP TABLE MARGINADOS.Cliente;

-- --> UsuarioSucursal <-- --
IF OBJECT_ID('MARGINADOS.UsuarioSucursal') IS NOT NULL
	DROP TABLE MARGINADOS.UsuarioSucursal;

-- --> Sucursal <-- --
IF OBJECT_ID('MARGINADOS.Sucursal') IS NOT NULL
	DROP TABLE MARGINADOS.Sucursal;

-- --> RolUsuario <-- --
IF OBJECT_ID('MARGINADOS.RolUsuario') IS NOT NULL
	DROP TABLE MARGINADOS.RolUsuario;

-- --> Usuario <-- --
IF OBJECT_ID('MARGINADOS.Usuario') IS NOT NULL
	DROP TABLE MARGINADOS.Usuario;

-- --> RolFuncionalidad <-- --
IF OBJECT_ID('MARGINADOS.RolFuncionalidad') IS NOT NULL
	DROP TABLE MARGINADOS.RolFuncionalidad;

-- --> Rol <-- --
IF OBJECT_ID('MARGINADOS.Rol') IS NOT NULL
	DROP TABLE MARGINADOS.Rol;

-- --> Funcionalidad <-- --
IF OBJECT_ID('MARGINADOS.Funcionalidad') IS NOT NULL
	DROP TABLE MARGINADOS.Funcionalidad;	


/******************************************************************************/
-- Creamos el esquema
/******************************************************************************/
USE GD2C2017;

IF NOT EXISTS (SELECT schema_name FROM   information_schema.SCHEMATA WHERE  schema_name = 'MARGINADOS')
    EXEC('CREATE SCHEMA MARGINADOS');
GO

/******************************************************************************/
-- Creamos las tablas
/******************************************************************************/

-- --> Funcionalidad <-- --
CREATE TABLE MARGINADOS.Funcionalidad
( 
     cod_funcionalidad numeric(3, 0) IDENTITY NOT NULL PRIMARY KEY, 
     nombre_func nvarchar(50) 
)

-- --> Rol <-- --
CREATE TABLE MARGINADOS.Rol 
( 
     cod_rol numeric(3, 0) IDENTITY NOT NULL PRIMARY KEY, 
     nombre_rol nvarchar(50) NOT NULL, 
     habilitado bit 
) 

-- --> RolFuncionalidad <-- --
CREATE TABLE MARGINADOS.RolFuncionalidad 
( 
     cod_funcionalidad numeric(3, 0) FOREIGN KEY REFERENCES MARGINADOS.Funcionalidad(cod_funcionalidad), 
     cod_rol numeric(3, 0) FOREIGN KEY REFERENCES MARGINADOS.Rol(cod_rol),
	 CONSTRAINT sinDuplicadosRolFunc UNIQUE(cod_funcionalidad,cod_rol) 
) 

-- --> Usuario <-- --
CREATE TABLE MARGINADOS.Usuario 
( 
     username nvarchar(20) NOT NULL UNIQUE, 
     pass nvarchar(64), --password
	 cod_user numeric(18, 0) IDENTITY PRIMARY KEY,
	 habilitado bit,	   
     nro_intentos numeric(1, 0)
)

-- --> RolUsuario <-- --
CREATE TABLE MARGINADOS.RolUsuario
( 
     cod_user NUMERIC(18, 0) FOREIGN KEY REFERENCES MARGINADOS.Usuario(cod_user), 
     cod_rol NUMERIC(3, 0) FOREIGN KEY REFERENCES MARGINADOS.Rol(cod_rol),
	 CONSTRAINT sinDuplicadosRolUser UNIQUE(cod_user,cod_rol) 
) 

-- --> Sucursal <-- --
CREATE TABLE MARGINADOS.Sucursal 
( 
     codigo_postal_suc numeric(18,0) NOT NULL PRIMARY KEY, 
     nombre_suc nvarchar(50) NOT NULL,	 
	 direccion_suc nvarchar(50) NOT NULL,	   
     habilitado bit
)

-- --> UsuarioSucursal <-- --
CREATE TABLE MARGINADOS.UsuarioSucursal
( 
     cod_user NUMERIC(18, 0) FOREIGN KEY REFERENCES MARGINADOS.Usuario(cod_user), 
     codigo_postal_suc NUMERIC(18, 0) FOREIGN KEY REFERENCES MARGINADOS.Sucursal(codigo_postal_suc),
	 CONSTRAINT sinDuplicadosUsuarioSucursal UNIQUE(cod_user,codigo_postal_suc) 
)

-- --> Cliente <-- --
  CREATE TABLE MARGINADOS.Cliente 
( 
     dni_clie numeric(18, 0) NOT NULL PRIMARY KEY, 
     nombre_clie nvarchar(255) NOT NULL,
	 apellido_clie nvarchar(255) NOT NULL,
	 mail_clie nvarchar(255) NOT NULL,	   
     telefeno_clie nvarchar(20) NOT NULL,
	 calle_clie nvarchar(100) NOT NULL,
	 nro_piso_clie char(2) NOT NULL,
	 depto_clie char(3) NOT NULL,
	 localidad_clie nvarchar(50) NOT NULL,
	 cod_postal_clie nvarchar(255) NOT NULL,
	 fecha_nac_clie datetime NOT NULL,
	 fecha_baja datetime
)

-- --> Rubro <-- --
CREATE TABLE MARGINADOS.Rubro
( 
     cod_rubro numeric(18, 0) IDENTITY PRIMARY KEY, 
     descripcion_rubro nvarchar(50) 
)

-- --> Empresa <-- --
  CREATE TABLE MARGINADOS.Empresa 
( 
     cod_empresa numeric(18, 0) NOT NULL IDENTITY PRIMARY KEY, 
     nombre_empresa nvarchar(255) NOT NULL,
	 cuit_empresa nvarchar(50) NOT NULL UNIQUE,
	 direccion_empresa nvarchar(255) NOT NULL ,	   
     cod_rubro numeric(18, 0) NOT NULL FOREIGN KEY REFERENCES MARGINADOS.Rubro(cod_rubro),
	 habilitado bit
)

--- --> Rendicion <-- --
CREATE TABLE MARGINADOS.Rendicion 
(
     nro_rendicion numeric(18,0) IDENTITY(1,1) NOT NULL,
     fecha_rendicion datetime NOT NULL,
     cant_facturas_rendidas numeric(3, 0) NOT NULL,
	 importe_comision numeric(9, 2) NOT NULL,
	 cod_empresa numeric(18, 0) NOT NULL,
	 porcentaje_comision char(3) NOT NULL,
	 importe_total_comision numeric(9, 2) NOT NULL,
	 item_pago_numero char(4),
	 PRIMARY KEY(nro_rendicion), 
     FOREIGN KEY (cod_empresa) REFERENCES MARGINADOS.Empresa(cod_empresa)
)

-- --> Motivo Devolucion <-- --
CREATE TABLE MARGINADOS.Motivo_devolucion
(
     cod_motivoDevolucion char(2) NOT NULL,
     descripcion varchar(50)
	 PRIMARY KEY(cod_motivoDevolucion), 
)
-- --> Devolucion <-- --
CREATE TABLE MARGINADOS.Devolucion 
(
     cod_devolucion char(8)  NOT NULL,
     username nvarchar(20),
     nro_factura numeric(18, 0),
	 cod_empresa numeric(18, 0) NOT NULL,
	 cod_motivoDevolucion char(2),
	 fecha_devolucion datetime,
	 PRIMARY KEY(cod_devolucion), 
     FOREIGN KEY (cod_motivoDevolucion) REFERENCES MARGINADOS.Motivo_devolucion(cod_motivoDevolucion)
)

-- --> MedioDePago <-- --
CREATE TABLE MARGINADOS.MedioDePago 
( 
     cod_medioDePago numeric(3, 0) IDENTITY NOT NULL PRIMARY KEY, 
     descripcion_MP nvarchar(50) NOT NULL
)

--- --> Pago <-- --
CREATE TABLE MARGINADOS.Pago 
(
     nro_pago numeric(18,0) NOT NULL IDENTITY(1,1),
     fecha_pago datetime NOT NULL,
     dni_cliente numeric(18, 0) NOT NULL,
	 importe_total_pago numeric(18, 2) NOT NULL,
	 codigo_postal_suc numeric(18, 0) NOT NULL,
	 cod_user numeric(18,0) NOT NULL,
	 PRIMARY KEY(nro_pago), 
     FOREIGN KEY (dni_cliente) REFERENCES MARGINADOS.Cliente(dni_clie),
	 FOREIGN KEY (codigo_postal_suc) REFERENCES MARGINADOS.Sucursal(codigo_postal_suc)
)

--- --> PagoMedioDePago <-- --
CREATE TABLE MARGINADOS.PagoMedioDePago 
(
     nro_pago numeric(18,0) NOT NULL,
     cod_pago_MP numeric(3,0) NOT NULL,
     importe numeric(18, 2) NOT NULL,
     FOREIGN KEY (nro_pago) REFERENCES MARGINADOS.Pago(nro_pago),
	 FOREIGN KEY (cod_pago_MP) REFERENCES MARGINADOS.MedioDePago(cod_medioDePago)
)

/*Habilitamos el insertado explicito de valores en la columna de tipo identity para mantener los valores antiguos del campo ID*/
SET IDENTITY_INSERT MARGINADOS.Pago ON

-- --> Factura <-- --
  CREATE TABLE MARGINADOS.Factura 
( 
     nro_factura numeric(18, 0) NOT NULL, 
     cod_empresa numeric(18, 0) FOREIGN KEY REFERENCES MARGINADOS.Empresa(cod_empresa),
	 dni_cliente numeric(18, 0) FOREIGN KEY REFERENCES MARGINADOS.Cliente(dni_clie),
	 fecha_alta_fac datetime NOT NULL,	   
     fecha_vto_fac datetime NOT NULL,
	 Importe_total_fac numeric(18,2) NOT NULL,
	 nro_pago numeric(18, 0) FOREIGN KEY REFERENCES MARGINADOS.Pago (nro_pago),
	 nro_rendicion numeric(18, 0) FOREIGN KEY REFERENCES MARGINADOS.Rendicion (nro_rendicion),
	 PRIMARY KEY(nro_factura,cod_empresa) 
)

-- --> FacturaItem <-- --
CREATE TABLE MARGINADOS.FacturaItem  
(
     cod_empresa numeric(18, 0) NOT NULL,
	 nro_factura numeric(18, 0) NOT NULL,
     nro_item numeric(18,0) NOT NULL,
	 monto_item numeric(18, 2),
	 cantidad_item numeric(18, 0),
	 PRIMARY KEY(nro_item,nro_factura,cod_empresa), 
     CONSTRAINT idFactEmpr FOREIGN KEY (nro_factura,cod_empresa) REFERENCES MARGINADOS.Factura(nro_factura,cod_empresa)
)

/******************************************************************************/
-- Llenamos las tablas
/******************************************************************************/

-- --> Funcionalidad <-- --
INSERT INTO MARGINADOS.Funcionalidad (nombre_func) 
VALUES      ('Login y Seguridad'), 
            ('AMB de Rol'), 
            ('Registro de Usuario'), 
            ('ABM de Cliente'), 
            ('ABM de Empresa'), 
            ('ABM de Sucursal'), 
            ('ABM Facturas'), 
            ('Registro de Pago de Facturas'), 
            ('Rendición de Facturas cobradas'),
			('Devoluciones'), 
            ('Listado Estadistico')
GO

-- --> Rol <-- --
INSERT INTO MARGINADOS.Rol (nombre_rol, habilitado) 
VALUES      ('Administrador',1), 
            ('Cobrador',1)
GO

-- --> RolFuncionalidad <-- --
INSERT INTO MARGINADOS.RolFuncionalidad (cod_funcionalidad, cod_rol)
VALUES 
	(1,1),(2,1),(3,1),(4,1),(5,1),(6,1),(7,1),(8,1),(9,1),(10,1),(11,1),
	(1,2),(2,2),(3,2),(4,2),(5,2),(6,2),(7,2),(8,2),(9,2),(11,2)
GO

-- --> Usuario <-- --
INSERT INTO MARGINADOS.Usuario(username, pass,habilitado,nro_intentos)
VALUES 
	('admin',CONVERT(nvarchar(64),HashBytes('SHA2_256', 'w23e'),2),1,0),
	('cobrador',CONVERT(nvarchar(64),HashBytes('SHA2_256', 'cobrador'),2),1,0)
GO

-- --> RolUsuario <-- --
INSERT INTO MARGINADOS.RolUsuario(cod_user, cod_rol)
VALUES 
	(1,1), -- admin es administrador
	(1,2), -- y tambien admin es cobrador
	(2,2)
GO

-- --> Sucursal <-- --
INSERT INTO MARGINADOS.Sucursal (codigo_postal_suc, nombre_suc, direccion_suc, habilitado) 
	SELECT distinct Sucursal_Codigo_Postal, Sucursal_Nombre,Sucursal_Dirección, 1
		FROM gd_esquema.Maestra where Sucursal_Nombre is not null
GO

-- --> UsuarioSucursal <-- --
INSERT INTO MARGINADOS.UsuarioSucursal(cod_user, codigo_postal_suc)
VALUES 
	(1,7210),
	(2,7210)
GO

-- --> Cliente <-- --
INSERT INTO MARGINADOS.Cliente (
		 dni_clie,
		 nombre_clie,
		 apellido_clie,
		 mail_clie,
		 telefeno_clie,
		 calle_clie,
		 nro_piso_clie,
		 depto_clie,
		 localidad_clie,
		 cod_postal_clie,
		 fecha_nac_clie,
		 fecha_baja) 
	SELECT distinct 
		[Cliente-Dni],
		[Cliente-Nombre], 
		[Cliente-Apellido],
		[Cliente_Mail],
		'-',
		[Cliente_Direccion],
		'-',
		'-',
		'-',
		[Cliente_Codigo_Postal],
		[Cliente-Fecha_Nac],
		null
from [gd_esquema].[Maestra]
GO

UPDATE MARGINADOS.Cliente   
SET MARGINADOS.Cliente.mail_clie  = ' ' + MARGINADOS.Cliente.mail_clie
WHERE MARGINADOS.Cliente.dni_clie in (31294365,2592862)
GO


ALTER TABLE MARGINADOS.Cliente
ADD CONSTRAINT email_sinDuplicados UNIQUE (mail_clie);   
GO

-- --> Rubro <-- --
INSERT INTO MARGINADOS.Rubro (descripcion_rubro) 
	SELECT distinct Rubro_Descripcion FROM gd_esquema.Maestra
GO

-- --> Empresa <-- --
INSERT INTO MARGINADOS.Empresa (nombre_empresa,cuit_empresa,direccion_empresa,cod_rubro,habilitado) 
	SELECT distinct [Empresa_Nombre],[Empresa_Cuit],[Empresa_Direccion],[Empresa_Rubro],1 from gd_esquema.Maestra
GO

-- --> MedioDePago <-- --
INSERT INTO MARGINADOS.MedioDePago (descripcion_MP) 
	SELECT distinct [FormaPagoDescripcion] from gd_esquema.Maestra
		where FormaPagoDescripcion is not null
GO

-- --> Pago <-- --
INSERT INTO MARGINADOS.Pago (nro_pago,fecha_pago,dni_cliente,importe_total_pago,codigo_postal_suc,cod_user) 
	SELECT distinct pago_nro, Pago_Fecha, [Cliente-Dni], Total, Sucursal_Codigo_Postal, 1 from gd_esquema.Maestra
		where pago_nro is not null
GO
/*Deshabilitamos el insertado explicito de valores en la columna de tipo identity*/
SET IDENTITY_INSERT MARGINADOS.Pago OFF

-- --> PagoMedioDePago  <-- --
INSERT INTO MARGINADOS.PagoMedioDePago (nro_pago,cod_pago_MP,importe) 
	SELECT distinct m.pago_nro, p.cod_medioDePago, m.Total from gd_esquema.Maestra m
		inner join MARGINADOS.MedioDePago p on m.FormaPagoDescripcion = p.descripcion_MP
		where m.pago_nro is not null
GO

-- --> Factura  <-- --
INSERT INTO MARGINADOS.Factura(nro_factura,cod_empresa,dni_cliente,fecha_alta_fac,fecha_vto_fac,Importe_total_fac,nro_pago,nro_rendicion) 
	SELECT distinct m.[Nro_Factura], e.cod_empresa, m.[Cliente-Dni], m.[Factura_Fecha], m.[Factura_Fecha_Vencimiento], m.[Factura_Total], null, null
		from gd_esquema.Maestra m inner join MARGINADOS.Empresa e on m.Empresa_Cuit = e.cuit_empresa
		where [Nro_Factura] is not null
GO

-- --> FacturaItem  <-- --
INSERT INTO MARGINADOS.FacturaItem (cod_empresa,nro_factura,nro_item,monto_item,cantidad_item) 
select 
	e.cod_empresa,
	m.[Nro_Factura],	
	ROW_NUMBER() OVER(PARTITION BY [Nro_Factura],e.cod_empresa ORDER BY [ItemFactura_Monto] ) AS Row,
	m.[ItemFactura_Monto],
	m.[ItemFactura_Cantidad]
from [gd_esquema].[Maestra] m inner join MARGINADOS.Empresa e on m.Empresa_Cuit = e.cuit_empresa
where m.[ItemFactura_Monto] is not null and m.Pago_nro is null and m.Rendicion_Nro is null	
order by 1,2
GO