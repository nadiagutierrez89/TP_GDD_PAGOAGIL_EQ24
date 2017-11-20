USE GD2C2017;
/******************************************************************************/
-- Borramos todas las tablas
/******************************************************************************/

-- --> Devolucion <-- --
IF OBJECT_ID('MARGINADOS.Devolucion') IS NOT NULL
  DROP TABLE MARGINADOS.Devolucion;
-- --> Motivo_devolucion <-- --

IF OBJECT_ID('MARGINADOS.MotivoDevolucion') IS NOT NULL
  DROP TABLE MARGINADOS.MotivoDevolucion;

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

IF NOT EXISTS (SELECT
    schema_name
  FROM information_schema.SCHEMATA
  WHERE schema_name = 'MARGINADOS')
  EXEC ('CREATE SCHEMA MARGINADOS');
GO

/******************************************************************************/
-- Creamos las tablas
/******************************************************************************/

-- --> Funcionalidad <-- --
CREATE TABLE MARGINADOS.Funcionalidad (
  cod_funcionalidad numeric(3, 0) IDENTITY NOT NULL PRIMARY KEY,
  nombre_func nvarchar(50)
)

-- --> Rol <-- --
CREATE TABLE MARGINADOS.Rol (
  cod_rol numeric(3, 0) IDENTITY (1, 1) NOT NULL PRIMARY KEY,
  nombre_rol nvarchar(50) NOT NULL,
  habilitado bit
)

-- --> RolFuncionalidad <-- --
CREATE TABLE MARGINADOS.RolFuncionalidad (
  cod_funcionalidad numeric(3, 0) FOREIGN KEY REFERENCES MARGINADOS.Funcionalidad (cod_funcionalidad),
  cod_rol numeric(3, 0) FOREIGN KEY REFERENCES MARGINADOS.Rol (cod_rol),
  CONSTRAINT sinDuplicadosRolFunc UNIQUE (cod_funcionalidad, cod_rol)
)

-- --> Usuario <-- --
CREATE TABLE MARGINADOS.Usuario (
  username nvarchar(20) NOT NULL UNIQUE,
  pass nvarchar(64), --password
  cod_user numeric(18, 0) IDENTITY PRIMARY KEY,
  habilitado bit,
  nro_intentos numeric(1, 0)
)

-- --> RolUsuario <-- --
CREATE TABLE MARGINADOS.RolUsuario (
  cod_user numeric(18, 0) FOREIGN KEY REFERENCES MARGINADOS.Usuario (cod_user),
  cod_rol numeric(3, 0) FOREIGN KEY REFERENCES MARGINADOS.Rol (cod_rol),
  CONSTRAINT sinDuplicadosRolUser UNIQUE (cod_user, cod_rol)
)

-- --> Sucursal <-- --
CREATE TABLE MARGINADOS.Sucursal (
  codigo_postal_suc numeric(18, 0) NOT NULL PRIMARY KEY,
  nombre_suc nvarchar(50) NOT NULL,
  direccion_suc nvarchar(50) NOT NULL,
  habilitado bit
)

-- --> UsuarioSucursal <-- --
CREATE TABLE MARGINADOS.UsuarioSucursal (
  cod_user numeric(18, 0) FOREIGN KEY REFERENCES MARGINADOS.Usuario (cod_user),
  codigo_postal_suc numeric(18, 0) FOREIGN KEY REFERENCES MARGINADOS.Sucursal (codigo_postal_suc),
  CONSTRAINT sinDuplicadosUsuarioSucursal UNIQUE (cod_user, codigo_postal_suc)
)

-- --> Cliente <-- --
CREATE TABLE MARGINADOS.Cliente (
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
CREATE TABLE MARGINADOS.Rubro (
  cod_rubro numeric(18, 0) IDENTITY PRIMARY KEY,
  descripcion_rubro nvarchar(50)
)

-- --> Empresa <-- --
CREATE TABLE MARGINADOS.Empresa (
  cod_empresa numeric(18, 0) NOT NULL IDENTITY PRIMARY KEY,
  nombre_empresa nvarchar(255) NOT NULL,
  cuit_empresa nvarchar(50) NOT NULL UNIQUE,
  direccion_empresa nvarchar(255) NOT NULL,
  cod_rubro numeric(18, 0) NOT NULL FOREIGN KEY REFERENCES MARGINADOS.Rubro (cod_rubro),
  habilitado bit
)

--- --> Rendicion <-- --
CREATE TABLE MARGINADOS.Rendicion (
  nro_rendicion numeric(18, 0) IDENTITY (1, 1) NOT NULL,
  fecha_rendicion datetime NOT NULL,
  cant_facturas_rendidas numeric(18, 0) NOT NULL,
  importe_comision numeric(18, 2) NOT NULL,
  cod_empresa numeric(18, 0) NOT NULL,
  porcentaje_comision numeric(18, 4) NOT NULL,
  importe_total_rendicion numeric(18, 2) NOT NULL,
  PRIMARY KEY (nro_rendicion),
  FOREIGN KEY (cod_empresa) REFERENCES MARGINADOS.Empresa (cod_empresa)
)

-- --> MedioDePago <-- --
CREATE TABLE MARGINADOS.MedioDePago (
  cod_medioDePago numeric(3, 0) IDENTITY NOT NULL PRIMARY KEY,
  descripcion_MP nvarchar(50) NOT NULL
)

--- --> Pago <-- --
CREATE TABLE MARGINADOS.Pago (
  nro_pago numeric(18, 0) NOT NULL IDENTITY (1, 1),
  fecha_pago datetime NOT NULL,
  dni_cliente numeric(18, 0) NOT NULL,
  importe_total_pago numeric(18, 2) NOT NULL,
  codigo_postal_suc numeric(18, 0) NOT NULL,
  cod_user numeric(18, 0) NOT NULL,
  cod_medioDePago numeric(3, 0) NOT NULL,
  PRIMARY KEY (nro_pago),
  FOREIGN KEY (dni_cliente) REFERENCES MARGINADOS.Cliente (dni_clie),
  FOREIGN KEY (codigo_postal_suc) REFERENCES MARGINADOS.Sucursal (codigo_postal_suc),
  FOREIGN KEY (cod_medioDePago) REFERENCES MARGINADOS.MedioDePago (cod_medioDePago)
)

-- --> Factura <-- --
CREATE TABLE MARGINADOS.Factura (
  nro_factura numeric(18, 0) NOT NULL,
  cod_empresa numeric(18, 0) FOREIGN KEY REFERENCES MARGINADOS.Empresa (cod_empresa),
  dni_cliente numeric(18, 0) FOREIGN KEY REFERENCES MARGINADOS.Cliente (dni_clie),
  fecha_alta_fac datetime NOT NULL,
  fecha_vto_fac datetime NOT NULL,
  importe_total_fac numeric(18, 2) NOT NULL,
  nro_pago numeric(18, 0) FOREIGN KEY REFERENCES MARGINADOS.Pago (nro_pago),
  nro_rendicion numeric(18, 0) FOREIGN KEY REFERENCES MARGINADOS.Rendicion (nro_rendicion),
  PRIMARY KEY (nro_factura, cod_empresa)
)

-- --> FacturaItem <-- --
CREATE TABLE MARGINADOS.FacturaItem (
  cod_empresa numeric(18, 0) NOT NULL,
  nro_factura numeric(18, 0) NOT NULL,
  nro_item numeric(18, 0) NOT NULL,
  monto_item numeric(18, 2),
  cantidad_item numeric(18, 0),
  PRIMARY KEY (nro_item, nro_factura, cod_empresa),
  CONSTRAINT idFactEmpr FOREIGN KEY (nro_factura, cod_empresa) REFERENCES MARGINADOS.Factura (nro_factura, cod_empresa)
)

-- --> MotivoDevolucion <-- --
CREATE TABLE MARGINADOS.MotivoDevolucion (
  cod_motivoDevolucion numeric(18, 0) NOT NULL IDENTITY (1, 1),
  descripcion varchar(50)
  PRIMARY KEY (cod_motivoDevolucion),
)
-- --> Devolucion <-- --
CREATE TABLE MARGINADOS.Devolucion (
  cod_devolucion numeric(18, 0) NOT NULL IDENTITY (1, 1),
  cod_user numeric(18, 0) NOT NULL,
  nro_factura numeric(18, 0) NOT NULL,
  cod_empresa numeric(18, 0) NOT NULL,
  cod_motivoDevolucion numeric(18, 0) NOT NULL,
  fecha_devolucion datetime NOT NULL,
  PRIMARY KEY (cod_devolucion),
  FOREIGN KEY (cod_user) REFERENCES MARGINADOS.Usuario (cod_user),
  FOREIGN KEY (nro_factura, cod_empresa) REFERENCES MARGINADOS.Factura (nro_factura, cod_empresa),
  FOREIGN KEY (cod_motivoDevolucion) REFERENCES MARGINADOS.MotivoDevolucion (cod_motivoDevolucion)
)

/******************************************************************************/
-- Llenamos las tablas
/******************************************************************************/

-- --> Funcionalidad <-- --
INSERT INTO MARGINADOS.Funcionalidad (nombre_func)
  VALUES 
  ('Login y Seguridad'),
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
  VALUES 
  ('Administrador', 1),
  ('Cobrador', 1)
GO

-- --> RolFuncionalidad <-- --
INSERT INTO MARGINADOS.RolFuncionalidad (cod_funcionalidad, cod_rol)
  VALUES 
  (1, 1), (2, 1), (3, 1), (4, 1), (5, 1), (6, 1), (7, 1), (8, 1), (9, 1), (10, 1), (11, 1),
  (1, 2), (3, 2), (4, 2), (5, 2), (6, 2), (7, 2), (8, 2), (9, 2)
GO

-- --> Usuario <-- --
INSERT INTO MARGINADOS.Usuario (username, pass, habilitado, nro_intentos)
  VALUES 
  ('admin', CONVERT(nvarchar(64), HASHBYTES('SHA2_256', 'w23e'), 2), 1, 0),
  ('cobrador', CONVERT(nvarchar(64), HASHBYTES('SHA2_256', 'cobrador'), 2), 1, 0)
GO

-- --> RolUsuario <-- --
INSERT INTO MARGINADOS.RolUsuario (cod_user, cod_rol)
  VALUES 
  (1, 1), -- admin es administrador
  (1, 2), -- y tambien admin es cobrador
  (2, 2)
GO

-- --> Sucursal <-- --
INSERT INTO MARGINADOS.Sucursal (codigo_postal_suc, nombre_suc, direccion_suc, habilitado)
  SELECT DISTINCT
    Sucursal_Codigo_Postal,
    Sucursal_Nombre,
    Sucursal_Dirección,
    1
  FROM gd_esquema.Maestra
  WHERE Sucursal_Nombre IS NOT NULL
GO

-- --> UsuarioSucursal <-- --
INSERT INTO MARGINADOS.UsuarioSucursal (cod_user, codigo_postal_suc)
  VALUES 
  (1, 7210),
  (2, 7210)
GO

-- --> Cliente <-- --
INSERT INTO MARGINADOS.Cliente (dni_clie, nombre_clie, apellido_clie, mail_clie, telefeno_clie,	calle_clie, 
					nro_piso_clie, depto_clie, localidad_clie, cod_postal_clie, fecha_nac_clie, fecha_baja)
  SELECT DISTINCT
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
    NULL
  FROM [gd_esquema].[Maestra]
GO

UPDATE MARGINADOS.Cliente
SET MARGINADOS.Cliente.mail_clie = ' ' + MARGINADOS.Cliente.mail_clie
WHERE MARGINADOS.Cliente.dni_clie IN (31294365, 2592862)
GO

ALTER TABLE MARGINADOS.Cliente
ADD CONSTRAINT email_sinDuplicados UNIQUE (mail_clie);
GO

-- --> Rubro <-- --
INSERT INTO MARGINADOS.Rubro (descripcion_rubro)
  SELECT DISTINCT
    Rubro_Descripcion
  FROM gd_esquema.Maestra
GO

-- --> Empresa <-- --
INSERT INTO MARGINADOS.Empresa (nombre_empresa, cuit_empresa, direccion_empresa, cod_rubro, habilitado)
  SELECT DISTINCT
    [Empresa_Nombre],
    [Empresa_Cuit],
    [Empresa_Direccion],
    [Empresa_Rubro],
    1
  FROM gd_esquema.Maestra
GO

-- --> MedioDePago <-- --
INSERT INTO MARGINADOS.MedioDePago (descripcion_MP)
  SELECT DISTINCT
    [FormaPagoDescripcion]
  FROM gd_esquema.Maestra
  WHERE FormaPagoDescripcion IS NOT NULL
GO

-- --> Factura  <-- --
INSERT INTO MARGINADOS.Factura (nro_factura, cod_empresa, dni_cliente, fecha_alta_fac, fecha_vto_fac, Importe_total_fac, nro_pago, nro_rendicion)
  SELECT DISTINCT
    m.[Nro_Factura],
    e.cod_empresa,
    m.[Cliente-Dni],
    m.[Factura_Fecha],
    m.[Factura_Fecha_Vencimiento],
    m.[Factura_Total],
    NULL,
    NULL
  FROM gd_esquema.Maestra m
  INNER JOIN MARGINADOS.Empresa e
    ON m.Empresa_Cuit = e.cuit_empresa
  WHERE [Nro_Factura] IS NOT NULL
GO

-- --> FacturaItem  <-- --
INSERT INTO MARGINADOS.FacturaItem (cod_empresa, nro_factura, nro_item, monto_item, cantidad_item)
  SELECT
    e.cod_empresa,
    m.[Nro_Factura],
    ROW_NUMBER() OVER (PARTITION BY [Nro_Factura], e.cod_empresa ORDER BY [ItemFactura_Monto]) AS Row,
    m.[ItemFactura_Monto],
    m.[ItemFactura_Cantidad]
  FROM [gd_esquema].[Maestra] m
  INNER JOIN MARGINADOS.Empresa e
    ON m.Empresa_Cuit = e.cuit_empresa
  WHERE m.[ItemFactura_Monto] IS NOT NULL
    AND m.Pago_nro IS NULL
    AND m.Rendicion_Nro IS NULL
  ORDER BY 1, 2
GO

-- --> Pago <-- --
/*Habilitamos el insertado explicito de valores en la columna de tipo identity para mantener los valores antiguos del campo ID*/
SET IDENTITY_INSERT MARGINADOS.Pago ON
INSERT INTO MARGINADOS.Pago (nro_pago, fecha_pago, dni_cliente, importe_total_pago, codigo_postal_suc, cod_user,cod_medioDePago)
  SELECT DISTINCT
    m.pago_nro,
    m.Pago_Fecha,
    m.[Cliente-Dni],
    m.Total,
    m.Sucursal_Codigo_Postal,
    1,
	p.cod_medioDePago
  FROM gd_esquema.Maestra m
  INNER JOIN MARGINADOS.MedioDePago p
    ON m.FormaPagoDescripcion = p.descripcion_MP
  WHERE m.pago_nro IS NOT NULL
GO
/*Deshabilitamos el insertado explicito de valores en la columna de tipo identity*/
SET IDENTITY_INSERT MARGINADOS.Pago OFF

-- actualizo la tabla factuas
UPDATE MARGINADOS.Factura
SET MARGINADOS.Factura.nro_pago = p.Pago_nro
FROM MARGINADOS.Factura
INNER JOIN (SELECT DISTINCT
  Nro_Factura,
  Pago_nro
FROM gd_esquema.Maestra
WHERE Pago_nro IS NOT NULL) p
  ON MARGINADOS.Factura.nro_factura = p.Nro_Factura;
GO

--- --> Rendicion <-- --
--lleno la tabla rendicion
/*Habilitamos el insertado explicito de valores en la columna de tipo identity para mantener los valores antiguos del campo ID*/
SET IDENTITY_INSERT MARGINADOS.Rendicion ON

INSERT INTO MARGINADOS.Rendicion (nro_rendicion, fecha_rendicion, cant_facturas_rendidas, importe_comision, cod_empresa, porcentaje_comision, importe_total_rendicion)
  SELECT
    Rendicion_Nro,
    Rendicion_Fecha,
    cant_fact,
    imp_fact - imp_ren,
    cod_empresa,
    ROUND(1 - imp_ren / imp_fact, 2),
    imp_ren
  FROM (SELECT
    r.Rendicion_Nro,
    r.Rendicion_Fecha,
    e.cod_empresa,
    (SELECT COUNT(*) FROM (SELECT DISTINCT 1.Nro_Factura FROM [gd_esquema].[Maestra] f1 WHERE f1.Rendicion_Nro = r.Rendicion_Nro) f) AS cant_fact,
    (SELECT SUM(Factura_Total) FROM (SELECT DISTINCT f1.Factura_Total FROM [gd_esquema].[Maestra] f1 WHERE f1.Rendicion_Nro = r.Rendicion_Nro) f) AS imp_fact,
    (SELECT SUM(ItemRendicion_Importe) FROM (SELECT DISTINCT f1.ItemRendicion_Importe FROM [gd_esquema].[Maestra] f1 WHERE f1.Rendicion_Nro = r.Rendicion_Nro) f) AS imp_ren
  FROM (SELECT DISTINCT
    r1.[Rendicion_Nro],
    r1.[Rendicion_Fecha],
    r1.Empresa_Cuit
  FROM [gd_esquema].[Maestra] r1
  WHERE [Rendicion_Nro] IS NOT NULL) r
  INNER JOIN MARGINADOS.Empresa e
    ON r.Empresa_Cuit = e.cuit_empresa) rendicion
  ORDER BY 1
GO

/*Deshabilitamos el insertado explicito de valores en la columna de tipo identity*/
SET IDENTITY_INSERT MARGINADOS.Rendicion OFF

-- actualizo la tabla factuas
UPDATE MARGINADOS.Factura
SET MARGINADOS.Factura.nro_rendicion = r.Rendicion_Nro
FROM MARGINADOS.Factura
INNER JOIN (SELECT DISTINCT
  Nro_Factura,
  Rendicion_Nro
FROM gd_esquema.Maestra
WHERE Rendicion_Nro IS NOT NULL) r
  ON MARGINADOS.Factura.nro_factura = r.Nro_Factura;
GO

-- --> MotivoDevolucion <-- --
INSERT INTO MARGINADOS.MotivoDevolucion (descripcion)
  VALUES 
  ('Factura erronea'),
  ('Solicitud del cliente'),
  ('Monto incorrecto')
GO

/******************************************************************************/
--- Triggers stored procedures
/******************************************************************************/

IF OBJECT_ID('MARGINADOS.sp_rolesDe') IS NOT NULL
	DROP PROCEDURE MARGINADOS.sp_rolesDe;
GO

CREATE PROCEDURE MARGINADOS.sp_rolesDe (@cod_user numeric(18, 0))
AS
BEGIN 
	SELECT ru.cod_user, r.cod_rol, r.nombre_rol, r.habilitado
	  FROM MARGINADOS.RolUsuario ru 
	  inner join MARGINADOS.Rol r
	  on r.cod_rol = ru.cod_rol
	  and r.habilitado = 1
	  and ru.cod_user = @cod_user
END
GO

IF OBJECT_ID('MARGINADOS.sp_funcionalidadesDe') IS NOT NULL
	DROP PROCEDURE MARGINADOS.sp_funcionalidadesDe;
GO

CREATE PROCEDURE MARGINADOS.sp_funcionalidadesDe (@cod_rol numeric(18, 0))
AS
BEGIN 
	SELECT rf.cod_rol, f.cod_funcionalidad, f.nombre_func
	  FROM MARGINADOS.RolFuncionalidad rf 
	  inner join MARGINADOS.Funcionalidad f
	  on f.cod_funcionalidad = rf.cod_funcionalidad
	  and rf.cod_rol = @cod_rol
END
GO

--- Actualiza Intentos fallidos ---
IF Object_id('MARGINADOS.sp_ActualizaIntentos') IS NOT NULL 
      DROP PROCEDURE MARGINADOS.sp_ActualizaIntentos; 
  GO

  CREATE PROCEDURE MARGINADOS.sp_ActualizaIntentos (@intentos_login NUMERIC(18, 0), 
                                           @nombre         VARCHAR(25)) 
AS 
  BEGIN 
      IF( @intentos_login = 3 ) 
        BEGIN 
            UPDATE MARGINADOS.USUARIO 
            SET    habilitado = 0, 
                   nro_intentos = @intentos_login 
            WHERE  username = @nombre 
        END 
      ELSE 
        BEGIN 
            UPDATE MARGINADOS.USUARIO 
            SET    nro_intentos = @intentos_login 
            WHERE  username = @nombre 
        END 
  END
  GO

--- --- ---
IF OBJECT_ID('MARGINADOS.rol_update') IS NOT NULL
  DROP TRIGGER MARGINADOS.rol_update;
GO
CREATE TRIGGER MARGINADOS.rol_update ON MARGINADOS.Rol
    FOR UPDATE
    AS
    BEGIN

		DELETE ru
		FROM MARGINADOS.RolUsuario ru inner join inserted i
			on ru.cod_rol = i.[cod_rol] 			
			WHERE i.habilitado = 0

 END

--- --- ---
 IF OBJECT_ID('MARGINADOS.sucursal_update') IS NOT NULL
  DROP TRIGGER MARGINADOS.sucursal_update;
GO
CREATE TRIGGER MARGINADOS.sucursal_update ON MARGINADOS.Sucursal
    FOR UPDATE
    AS
    BEGIN

		DELETE su
		FROM MARGINADOS.UsuarioSucursal su inner join inserted i
			on su.codigo_postal_suc = i.codigo_postal_suc			
			WHERE i.habilitado = 0

 END