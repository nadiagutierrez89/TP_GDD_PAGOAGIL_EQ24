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

USE GD2C2017;
/******************************************************************************/
-- Creamos el esquema
/******************************************************************************/

IF NOT EXISTS (SELECT schema_name FROM   information_schema.SCHEMATA WHERE  schema_name = 'MARGINADOS')
    EXEC('CREATE SCHEMA MARGINADOS');
GO

/******************************************************************************/
-- Creamos las tablas
/******************************************************************************/

-- --> Funcionalidad <-- --
CREATE TABLE MARGINADOS.Funcionalidad
( 
     cod_funcionalidad numeric(3, 0) NOT NULL PRIMARY KEY, 
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
     pass nvarchar(20), --password
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
     cod_sucursal numeric(4, 0) IDENTITY PRIMARY KEY,
     codigo_postal numeric(18,0) NOT NULL UNIQUE, 
     nombre_suc nvarchar(50) NOT NULL,	 
	 direccion_suc nvarchar(50) NOT NULL,	   
     habilitado bit
)

-- --> UsuarioSucursal <-- --
CREATE TABLE MARGINADOS.UsuarioSucursal
( 
     cod_user NUMERIC(18, 0) FOREIGN KEY REFERENCES MARGINADOS.Usuario(cod_user), 
     cod_sucursal NUMERIC(4, 0) FOREIGN KEY REFERENCES MARGINADOS.Sucursal(cod_sucursal),
	 CONSTRAINT sinDuplicadosUsuarioSucursal UNIQUE(cod_user,cod_sucursal) 
)

-- --> Cliente <-- --
  CREATE TABLE MARGINADOS.Cliente 
( 
     dni_clie numeric(18, 0) NOT NULL PRIMARY KEY, 
     nombre_clie nvarchar(255) NOT NULL,
	 apellido_clie nvarchar(255) NOT NULL,
	 mail_clie nvarchar(255) NOT NULL UNIQUE,	   
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
     cod_rubro numeric(3, 0) IDENTITY PRIMARY KEY, 
     descripcion_rubro nvarchar(50) 
)

-- --> Empresa <-- --
  CREATE TABLE MARGINADOS.Empresa 
( 
     cod_empresa numeric(18, 0) NOT NULL IDENTITY PRIMARY KEY, 
     nombre_empresa nvarchar(255) NOT NULL,
	 cuit_empresa nvarchar(50) NOT NULL UNIQUE,
	 direccion_empresa nvarchar(255) NOT NULL ,	   
     cod_rubro numeric(3, 0) NOT NULL FOREIGN KEY REFERENCES MARGINADOS.Rubro(cod_rubro),
	 habilitado bit
)

-- --> Factura <-- --
  CREATE TABLE MARGINADOS.Factura 
( 
     nro_factura numeric(18, 0) NOT NULL, 
     cod_empresa numeric(18, 0) FOREIGN KEY REFERENCES MARGINADOS.Empresa(cod_empresa),
	 dni_cliente numeric(18, 0) FOREIGN KEY REFERENCES MARGINADOS.Cliente(dni_clie),
	 fecha_alta_fac datetime NOT NULL,	   
     fecha_vto_fac datetime NOT NULL,
	 Importe_total_fac numeric(18,2) NOT NULL,
	 --cod_pago, falta ver que hacemos con los pagos
	 --cod_rendicion falta ver que hacemos con las rendiciones
	 PRIMARY KEY(nro_factura,cod_empresa) 
)

-- --> FacturaItem <-- --
CREATE TABLE MARGINADOS.FacturaItem  
(
     nro_item numeric(18,0) IDENTITY(1,1) NOT NULL,
     nro_factura numeric(18, 0) NOT NULL,
     cod_empresa numeric(18, 0) NOT NULL,
	 monto_item numeric(18, 2),
	 cantidad_item numeric(18, 0),
	 PRIMARY KEY(nro_item,nro_factura,cod_empresa), 
     CONSTRAINT idFactEmpr FOREIGN KEY (nro_factura,cod_empresa) REFERENCES MARGINADOS.Factura(nro_factura,cod_empresa)
)

