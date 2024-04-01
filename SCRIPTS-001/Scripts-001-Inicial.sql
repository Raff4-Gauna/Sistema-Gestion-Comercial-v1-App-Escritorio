
/*##########################  INICIO DE TABLAS ##########################*/
/*----------------------- Tabla de Rol -------------------------*/
create table ROL(
IdRol int primary key identity,
Descripcion varchar(50),
FechaRegistro datetime default getdate()
)
go

/*-------------------- Tabla de PERMISO-------------------------*/
create table PERMISO(
IdPermiso int primary key identity,
IdRol int references ROL(IdRol),
NombreMenu varchar(100),
FechaRegistro datetime default getdate()
)
go


/*-------------------- Tabla de Usuarios-------------------------*/
create table USUARIO(
IdUsuario int primary key identity,
Documento varchar(50),
NombreCompleto varchar(50),
Clave varchar(50),
IdRol int references ROL(IdRol),
Estado bit,
FechaRegistro datetime default getdate()
)

go

/*-------------------- Tabla de Negocio-------------------------*/
create table NEGOCIO(
IdNegocio int primary key,
Nombre varchar(60),
Telefono varchar(60),
Direccion varchar(60),
Titular varchar(60) NULL,
CUIT varchar(100) NULL,
NumIngresosBrutos varchar(150) NULL,
Logo varbinary(max) NULL
)

go

/*-------------------- Tabla de Sucursales-------------------------*/
create table SUCURSALES(
IdSucursales int primary key identity,
Nombre varchar(60),
Direccion varchar(60),
Telefono varchar(60) NULL,
Estado bit,
FechaRegistro datetime default getdate()
)
go

/*-------------------- Tabla de Correo SMTP-------------------------*/
create table SMTP (
    IdSmtp int primary key identity,
    EmailRemitente varchar(100),
    ContraseñaRemitente varchar(50)
)
go

/*-------------------- Tabla de TipoContribuyentes-------------------------*/
create table TIPO_CONTRIBUYENTE(
IdTipoContribuyentes int primary key identity,
Contribuyente varchar(60) NOT NULL,
PrMaximoEfectivo decimal(10, 2),
Estado bit,
FechaRegistro datetime default getdate()
)
go

/*-------------------- Tabla de Clientes-------------------------*/
create table CLIENTE(
IdCliente int primary key identity,
IdTipoContribuyentes int references TIPO_CONTRIBUYENTE(IdTipoContribuyentes),
NombreCompleto varchar(50),
Documento varchar(50) NULL,
CUIT varchar(100) NULL,
Correo varchar(50) NULL,
Telefono varchar(50) NULL,
Notas VARCHAR(MAX) NULL,
Estado bit,
FechaRegistro datetime default getdate()
)
go

/*-------------------- Tabla de TasasImpuestos-------------------------*/
CREATE TABLE TASA_IMPUESTOS (
    IdTasaImpuesto INT primary key identity,
    NombreTasa NVARCHAR(50) NOT NULL,
    Porcentaje FLOAT NOT NULL,
    Descripcion NVARCHAR(255) NULL,
    Estado bit,
	FechaRegistro datetime default getdate()
);
go

/*-------------------- Tabla de MetodosPago-------------------------*/
CREATE TABLE METODOS_PAGOS (
    IdMetodosPagos INT primary key identity,
    NombreMetodo NVARCHAR(50) NOT NULL,
    Descripcion NVARCHAR(255) NULL,
    Estado bit,
	FechaRegistro datetime default getdate()
);
go

/*-------------------- Tabla de PROVEEDOR-------------------------*/
create table PROVEEDOR(
IdProveedor int primary key identity,
Documento varchar(50)NULL,
RazonSocial varchar(100) NOT NULL,
Correo varchar(50)NULL,
Telefono varchar(50)NULL,
Notas varchar(MAX) NULL,
Estado bit,
FechaRegistro datetime default getdate()
)
go

/*-------------------- Tabla de Categorias-------------------------*/
create table CATEGORIAS (
IdCategoria int primary key identity,
NombreCategoria VARCHAR(50) UNIQUE NOT NULL,
Estado bit,
FechaRegistro datetime default getdate()
)
go

/*-------------------- Tabla de SubCategorias-------------------------*/
CREATE TABLE SUBCATEGORIAS (
    IdSubcategoria int primary key identity,
    IdCategoria INT REFERENCES CATEGORIAS(IdCategoria),
    NombreSubcategoria VARCHAR(50),
	Estado bit,
	FechaRegistro datetime default getdate()
);
go

/*-------------------- Tabla de Tipo Unidades-------------------------*/
CREATE TABLE TIPOS_UNIDADES (
    IdTipoUnidad int primary key identity,
    NombreTipoUnidad VARCHAR(50) UNIQUE NOT NULL
);
GO

/*-------------------- Tabla de MargenesGanancia-------------------------*/
CREATE TABLE MARGENES_GANANCIA (
    IdMargenGanancia INT PRIMARY KEY IDENTITY,
    NombreMargen NVARCHAR(50) NULL,
    Porcentaje DECIMAL(5, 2) NOT NULL,
    Estado BIT,
    FechaRegistro DATETIME DEFAULT GETDATE()
);
go

/*-------------------- Tabla de Productos -------------------------*/
CREATE TABLE PRODUCTOS (
    IdProducto INT PRIMARY KEY IDENTITY,
    IdCategoria INT REFERENCES CATEGORIAS(IdCategoria),
    IdSubcategoria INT REFERENCES SUBCATEGORIAS(IdSubcategoria),
    IdTasaImpuesto INT REFERENCES TASA_IMPUESTOS(IdTasaImpuesto),
    IdTipoUnidad INT REFERENCES TIPOS_UNIDADES(IdTipoUnidad),
    ProveedorAsociado INT REFERENCES PROVEEDOR(IdProveedor) NULL,
	Imagen VARBINARY(MAX) NULL,
    CodigoBarras VARCHAR(100) UNIQUE NOT NULL,
    Codigo VARCHAR(50) UNIQUE NULL,
    DescripcionGeneral VARCHAR(100) NOT NULL,
    PrecioCompra DECIMAL(18,2) DEFAULT 0.00,
	IdMargenGanancia INT REFERENCES MARGENES_GANANCIA(IdMargenGanancia),
    PrecioFinal DECIMAL(18,2) DEFAULT 0.00,
    UbicacionProducto VARCHAR(100) NULL,
    StockExistente DECIMAL(18,2) NOT NULL,
    StockMinimo DECIMAL(18,2) NOT NULL,
	FechaActualizacion  DATETIME DEFAULT GETDATE(),
    Estado BIT,
    FechaRegistro DATETIME DEFAULT GETDATE()
);
go

-- Trigger para actualizar la FechaActualizacion cuando se modifica PrecioFinal
CREATE TRIGGER TRG_ActualizarFecha
ON PRODUCTOS
AFTER UPDATE
AS
BEGIN
    IF UPDATE(PrecioFinal)
    BEGIN
        UPDATE PRODUCTOS
        SET FechaActualizacion = GETDATE()
        FROM inserted
        WHERE PRODUCTOS.IdProducto = inserted.IdProducto;
    END
END;


/*-------------------- Tabla de VENTA -------------------------*/
create table VENTA(
IdVenta int primary key identity,
IdUsuario int references USUARIO(IdUsuario),
TipoDocumento varchar(80),
NumeroDocumento varchar(80),
DocumentoCliente varchar(50),
NombreCliente varchar(100),
DescripcionMetodoPago varchar(100),
MontoPago DECIMAL(18,2),
MontoCambio DECIMAL(18,2),
MontoTotal DECIMAL(18,2),
FechaRegistro datetime default getdate()
)
go

create table COMPRA(
IdCompra int primary key identity,
IdUsuario int references USUARIO(IdUsuario),
IdProveedor int references PROVEEDOR(IdProveedor),
TipoDocumento varchar(50),
NumeroDocumento varchar(50),
DescripcionMetodoPago varchar(100),
MontoTotal DECIMAL(18,2),
FechaRegistro datetime default getdate()
)
go

/*-------------------- Tabla de DETALLE VENTA -------------------------*/
create table DETALLE_VENTA(
IdDetalleVenta int primary key identity,
IdVenta int references VENTA(IdVenta),
IdProducto int references PRODUCTOS(IdProducto),
PrecioVenta decimal(10,2),
Cantidad decimal(10,2),
Total decimal(10,2),
FechaRegistro datetime default getdate()
)
go

create table DETALLE_COMPRA(
IdDetalleCompra int primary key identity,
IdCompra int references COMPRA(IdCompra),
IdProducto int references PRODUCTOS(IdProducto),
PrecioCompra DECIMAL(18,2) DEFAULT 0.00,
PrecioVenta DECIMAL(18,2) DEFAULT 0.00,
Cantidad DECIMAL(18,2),
MontoTotal DECIMAL(18,2) DEFAULT 0.00,
FechaRegistro datetime default getdate()
)
go



/*-------------------- Tabla para almacenar anulaciones de venta -------------------------*/
CREATE TABLE ANULACION_VENTA (
    IdAnulacionVenta INT PRIMARY KEY IDENTITY,
    IdVenta INT REFERENCES VENTA(IdVenta),
	IdUsuario int references USUARIO(IdUsuario),
    FechaAnulacion DATETIME DEFAULT GETDATE()
);
go

/*----------------------- Tabla de Apertura de Caja -------------------------*/
CREATE TABLE APERTURA_CAJA(
    IdAperturaCaja int PRIMARY KEY IDENTITY,
    IdUsuario int REFERENCES USUARIO(IdUsuario),
    MontoInicial decimal(18,2),
    FechaApertura datetime DEFAULT GETDATE(),
    FechaCierre datetime,
    EstadoCaja bit, -- 0 para abierta, 1 para cerrada
    CONSTRAINT UC_Usuario_FechaApertura UNIQUE (IdUsuario, FechaApertura)
);
go

/*----------------------- Tabla de Ingresos -------------------------*/
CREATE TABLE INGRESOS_CAJA(
    IdIngreso int PRIMARY KEY IDENTITY,
    IdAperturaCaja int REFERENCES APERTURA_CAJA(IdAperturaCaja),
    Monto decimal(18,2),
    Descripcion varchar(255),
    FechaIngreso datetime DEFAULT GETDATE()
);
go

/*----------------------- Tabla de Egresos -------------------------*/
CREATE TABLE EGRESOS_CAJA(
    IdEgreso int PRIMARY KEY IDENTITY,
    IdAperturaCaja int REFERENCES APERTURA_CAJA(IdAperturaCaja),
    Monto decimal(18,2),
    Descripcion varchar(255),
    FechaEgreso datetime DEFAULT GETDATE()
);
go

/*----------------------- Tabla de Clave Unica -------------------------*/
CREATE TABLE ClaveUnica (
    IdUsuario int REFERENCES USUARIO(IdUsuario) PRIMARY KEY,
    ClaveUnica varchar(50),
    FechaRegistro datetime DEFAULT GETDATE(),
    CONSTRAINT CK_ClaveUnica_FechaRegistro CHECK (FechaRegistro <= GETDATE())
);
GO

/*----------------------- Tabla de Caducidad -------------------------*/
CREATE TABLE Caducidad (
    FechaInicio datetime,
    FechaFin datetime,
    DiasDiferencia int,
    FechaRegistro datetime DEFAULT GETDATE(),
    CONSTRAINT CK_Caducidad_Fechas CHECK (FechaInicio <= FechaFin),
    CONSTRAINT CK_Caducidad_FechaRegistro CHECK (FechaRegistro <= GETDATE())
);
GO

/*##########################  FIN DE TABLAS ##########################*/


/*##########################  INICIO PROCEDIMIENTOS ALMACENADS ##########################*/

/*########################## INICIO PROC USUARIOS ##########################*/
create PROC SP_REGISTRARUSUARIO(
@Documento varchar(50),
@NombreCompleto varchar(100),
@Clave varchar(100),
@IdRol int,
@Estado bit,
@IdUsuarioResultado int output,
@Mensaje varchar(500) output
)
as
begin
	set @IdUsuarioResultado = 0
	set @Mensaje = ''


	if not exists(select * from USUARIO where Documento = @Documento)
	begin
		insert into usuario(Documento,NombreCompleto,Clave,IdRol,Estado) values
		(@Documento,@NombreCompleto,@Clave,@IdRol,@Estado)

		set @IdUsuarioResultado = SCOPE_IDENTITY()
		
	end
	else
		set @Mensaje = 'No se puede repetir el documento para mas de un usuario'


end
go

--/* INICIO --- SP_EDITARUSUARIO*/
create PROC SP_EDITARUSUARIO(
@IdUsuario int,
@Documento varchar(50),
@NombreCompleto varchar(100),
@Clave varchar(100),
@IdRol int,
@Estado bit,
@Respuesta bit output,
@Mensaje varchar(500) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ''


	if not exists(select * from USUARIO where Documento = @Documento and idusuario != @IdUsuario)
	begin
		update  usuario set
		Documento = @Documento,
		NombreCompleto = @NombreCompleto,
		Clave = @Clave,
		IdRol = @IdRol,
		Estado = @Estado
		where IdUsuario = @IdUsuario

		set @Respuesta = 1
		
	end
	else
		set @Mensaje = 'No se puede repetir el documento para mas de un usuario'

end
go


--/* INICIO --- SP_ELIMINARUSUARIO*/
CREATE PROC SP_ELIMINARUSUARIO (
    @IdUsuario INT,
    @Respuesta BIT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @Respuesta = 0;
    SET @Mensaje = '';

    -- Eliminar usuario
    DELETE FROM USUARIO WHERE IdUsuario = @IdUsuario;

    SET @Respuesta = 1;
END
GO

/*########################## FIN PROC USUARIOS ##########################*/

/*########################## INICIO PROC PROC APERTURA CAJA ##########################*/

CREATE PROCEDURE SP_APERTURA_CAJA
    @IdUsuario int,
    @MontoInicial decimal(18,2),
    @Resultado int OUTPUT,
    @Mensaje varchar(500) OUTPUT
AS
BEGIN
    SET @Resultado = 0
    SET @Mensaje = ''

    BEGIN TRY
        DECLARE @FechaApertura datetime = GETDATE();

        -- Verificar si ya existe una apertura de caja para el usuario en la fecha actual
        IF NOT EXISTS (SELECT 1 FROM APERTURA_CAJA WHERE IdUsuario = @IdUsuario AND CAST(FechaApertura AS DATE) = CAST(@FechaApertura AS DATE) AND EstadoCaja = 0)
        BEGIN
            -- Insertar nueva apertura de caja
            INSERT INTO APERTURA_CAJA (IdUsuario, MontoInicial, FechaApertura, EstadoCaja)
            VALUES (@IdUsuario, @MontoInicial, @FechaApertura, 0);
            
            SET @Resultado = SCOPE_IDENTITY()
        END
        ELSE
        BEGIN
            SET @Mensaje = 'Ya existe una apertura de caja para este usuario en la fecha actual.';
        END
    END TRY
    BEGIN CATCH
        SET @Mensaje = 'Error al realizar la apertura de caja. Detalles: ' + ERROR_MESSAGE();
    END CATCH
END;
GO
-- Procedimiento almacenado para el cierre de caja

CREATE PROCEDURE SP_CIERRE_CAJA
    @IdAperturaCaja int,
    @IdUsuario int,
    @Resultado int OUTPUT,
    @Mensaje varchar(500) OUTPUT
AS
BEGIN
    SET @Resultado = 0
    SET @Mensaje = ''

    BEGIN TRY
        DECLARE @FechaCierre datetime = GETDATE();

        -- Verificar si la apertura de caja existe y aún no ha sido cerrada
        IF EXISTS (SELECT 1 FROM APERTURA_CAJA WHERE IdAperturaCaja = @IdAperturaCaja AND IdUsuario = @IdUsuario AND EstadoCaja = 0)
        BEGIN
            -- Actualizar la apertura de caja con la fecha de cierre y cambiar el estado a cerrada
            UPDATE APERTURA_CAJA
            SET FechaCierre = @FechaCierre,
                EstadoCaja = 1
            WHERE IdAperturaCaja = @IdAperturaCaja;

            SET @Resultado = 1
        END
        ELSE
        BEGIN
            SET @Mensaje = 'La apertura de caja no existe, no pertenece al usuario actual o ya ha sido cerrada.';
        END
    END TRY
    BEGIN CATCH
        SET @Mensaje = 'Error al realizar el cierre de caja. Detalles: ' + ERROR_MESSAGE();
    END CATCH
END;
GO


/*########################## FIN PROC PROC APERTURA CAJA ##########################*/

/*########################## INICIO PROC PROC SUCURSALES ##########################*/
create PROC SP_REGISTARSUCURSAL(
@Nombre varchar(60),
@Direccion varchar(60),
@Telefono varchar(60),
@Estado bit,
@Resultado int output,
@Mensaje varchar(500) output
)
as
begin
    SET @Resultado = 0
	
    IF NOT EXISTS (SELECT * FROM SUCURSALES WHERE Nombre = @Nombre)
    begin
        insert into SUCURSALES (Nombre, Direccion, Telefono, Estado) values (
            @Nombre, @Direccion, @Telefono, @Estado
        )

        set @Resultado = SCOPE_IDENTITY()
    end
    else
        set @Mensaje = 'El nombre de la sucursal ya existe'
end
go

--/* INICIO --- SP_MODIFICARSUCURSAL*/

create PROC SP_MODIFICARSUCURSAL(
@IdSucursales int,
@Nombre varchar(60),
@Direccion varchar(60),
@Telefono varchar(60),
@Estado bit,
@Resultado bit output,
@Mensaje varchar(500) output
)
as
begin
    SET @Resultado = 1
    
    IF NOT EXISTS (SELECT * FROM SUCURSALES WHERE Nombre = @Nombre and IdSucursales != @IdSucursales)
    begin
        update SUCURSALES set
            Nombre = @Nombre,
            Direccion = @Direccion,
            Telefono = @Telefono,
            Estado = @Estado
        where IdSucursales = @IdSucursales
    end
    else
    begin
        SET @Resultado = 0
        set @Mensaje = 'El nombre de la sucursal ya existe'
    end
end
GO
/*########################## FIN PROC SUCURSALES ##########################*/

/*########################## INICIO PROC PROC TIPO_CONTRIBUYENTE ##########################*/
create PROC SP_REGISTARTIPOCONTRIBUYENTE(
@Contribuyente varchar(60),
@PrMaximoEfectivo decimal(10, 2),
@Estado bit,
@Resultado int output,
@Mensaje varchar(500) output
)
as
begin
    SET @Resultado = 0
	
    IF NOT EXISTS (SELECT * FROM TIPO_CONTRIBUYENTE WHERE Contribuyente = @Contribuyente)
    begin
        insert into TIPO_CONTRIBUYENTE (Contribuyente, PrMaximoEfectivo, Estado) values (
            @Contribuyente, @PrMaximoEfectivo, @Estado
        )

        set @Resultado = SCOPE_IDENTITY()
    end
    else
        set @Mensaje = 'El tipo de contribuyente ya existe'
end
go

--/* INICIO --- SP_MODIFICARTIPOCONTRIBUYENTE*/

create PROC SP_MODIFICARTIPOCONTRIBUYENTE(
@IdTipoContribuyentes int,
@Contribuyente varchar(60),
@PrMaximoEfectivo decimal(10, 2),
@Estado bit,
@Resultado bit output,
@Mensaje varchar(500) output
)
as
begin
    SET @Resultado = 1
    
    IF NOT EXISTS (SELECT * FROM TIPO_CONTRIBUYENTE WHERE Contribuyente = @Contribuyente and IdTipoContribuyentes != @IdTipoContribuyentes)
    begin
        update TIPO_CONTRIBUYENTE set
            Contribuyente = @Contribuyente,
            PrMaximoEfectivo = @PrMaximoEfectivo,
            Estado = @Estado
        where IdTipoContribuyentes = @IdTipoContribuyentes
    end
    else
    begin
        SET @Resultado = 0
        set @Mensaje = 'El tipo de contribuyente ya existe'
    end
end
GO
/*########################## FIN PROC TIPO_CONTRIBUYENTE ##########################*/


/*########################## INICIO PROC CLIENTE ##########################*/
CREATE PROC SP_REGISTRARCLIENTE(
    @IdTipoContribuyentes INT,
    @NombreCompleto VARCHAR(50),
    @Documento VARCHAR(50),
    @CUIT VARCHAR(100),
    @Correo VARCHAR(50),
    @Telefono VARCHAR(50),
    @Notas VARCHAR(MAX),
    @Estado BIT,
    @Resultado INT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @Resultado = 0

    IF NOT EXISTS (SELECT * FROM CLIENTE WHERE Documento = @Documento)
    BEGIN
        INSERT INTO CLIENTE(IdTipoContribuyentes, NombreCompleto, Documento, CUIT, Correo, Telefono, Notas, Estado)
        VALUES (@IdTipoContribuyentes, @NombreCompleto, @Documento, @CUIT, @Correo, @Telefono, @Notas, @Estado)

        SET @Resultado = SCOPE_IDENTITY()
    END
    ELSE
    BEGIN
        SET @Mensaje = 'El número de documento ya existe'
    END
END

GO

--/* INICIO --- SP_MODIFICARCLIENTE*/

CREATE PROC SP_MODIFICARCLIENTE(
    @IdCliente INT,
    @IdTipoContribuyentes INT,
    @NombreCompleto VARCHAR(50),
    @Documento VARCHAR(50),
    @CUIT VARCHAR(100),
    @Correo VARCHAR(50),
    @Telefono VARCHAR(50),
    @Notas VARCHAR(MAX),
    @Estado BIT,
    @Resultado BIT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @Resultado = 1

    IF NOT EXISTS (SELECT * FROM CLIENTE WHERE Documento = @Documento AND IdCliente != @IdCliente)
    BEGIN
        UPDATE CLIENTE
        SET
            IdTipoContribuyentes = @IdTipoContribuyentes,
            NombreCompleto = @NombreCompleto,
            Documento = @Documento,
            CUIT = @CUIT,
            Correo = @Correo,
            Telefono = @Telefono,
            Notas = @Notas,
            Estado = @Estado
        WHERE IdCliente = @IdCliente
    END
    ELSE
    BEGIN
        SET @Resultado = 0
        SET @Mensaje = 'El número de documento ya existe'
    END
END

GO
/*########################## FIN PROC CLIENTE ##########################*/



/*########################## INICIO PROC PROC TASA IMPUESTOS ##########################*/
create PROC SP_REGISTARTASAIMPUESTOS(
@NombreTasa varchar(50),
@Porcentaje FLOAT,
@Descripcion nvarchar(255),
@Estado bit,
@Resultado int output,
@Mensaje varchar(500) output
)
as
begin
    SET @Resultado = 0
	
    IF NOT EXISTS (SELECT * FROM TASA_IMPUESTOS WHERE NombreTasa = @NombreTasa)
    begin
        insert into TASA_IMPUESTOS (NombreTasa, Porcentaje, Descripcion, Estado) values (
            @NombreTasa, @Porcentaje, @Descripcion, @Estado
        )

        set @Resultado = SCOPE_IDENTITY()
    end
    else
        set @Mensaje = 'El nombre de la tasa de impuesto ya existe'
end
go

--/* INICIO --- SP_MODIFICARTASAIMPUESTOS*/

create PROC SP_MODIFICARTASAIMPUESTOS(
@IdTasaImpuesto int,
@NombreTasa varchar(50),
@Porcentaje FLOAT,
@Descripcion nvarchar(255),
@Estado bit,
@Resultado int output,
@Mensaje varchar(500) output
)
as
begin
    SET @Resultado = 1
    
    IF NOT EXISTS (SELECT * FROM TASA_IMPUESTOS WHERE NombreTasa = @NombreTasa and IdTasaImpuesto != @IdTasaImpuesto)
    begin
        update TASA_IMPUESTOS set
            NombreTasa = @NombreTasa,
            Porcentaje = @Porcentaje,
            Descripcion = @Descripcion,
            Estado = @Estado
        where IdTasaImpuesto = @IdTasaImpuesto
    end
    else
    begin
        SET @Resultado = 0
        set @Mensaje = 'El nombre de la tasa de impuesto ya existe'
    end
end
GO
/*########################## FIN PROC  TASA IMPUESTOS  ##########################*/

/*########################## INICIO PROC PROC MARGEN DE GANANCIA ##########################*/
CREATE PROC SP_REGISTARMARGENESGANANCIA(
    @NombreMargen VARCHAR(50),
    @Porcentaje DECIMAL(5, 2),  -- Cambiado el tipo de dato a DECIMAL(5, 2)
    @Estado BIT,
    @Resultado INT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @Resultado = 0;
	
    IF NOT EXISTS (SELECT * FROM MARGENES_GANANCIA WHERE NombreMargen = @NombreMargen)
    BEGIN
        INSERT INTO MARGENES_GANANCIA (NombreMargen, Porcentaje, Estado) VALUES (
            @NombreMargen, @Porcentaje, @Estado
        );

        SET @Resultado = SCOPE_IDENTITY();
    END
    ELSE
        SET @Mensaje = 'El nombre del margen de ganancia ya existe';
END;
GO

--/* INICIO --- SP_MODIFICARTASAIMPUESTOS*/

CREATE PROC SP_MODIFICARMARGENESGANANCIA(
    @IdMargenGanancia INT,
    @NombreMargen VARCHAR(50),
    @Porcentaje DECIMAL(5, 2),  -- Cambiado el tipo de dato a DECIMAL(5, 2)
    @Estado BIT,
    @Resultado INT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @Resultado = 1;
    
    IF NOT EXISTS (SELECT * FROM MARGENES_GANANCIA WHERE NombreMargen = @NombreMargen AND IdMargenGanancia != @IdMargenGanancia)
    BEGIN
        UPDATE MARGENES_GANANCIA SET
            NombreMargen = @NombreMargen,
            Porcentaje = @Porcentaje,
            Estado = @Estado
        WHERE IdMargenGanancia = @IdMargenGanancia;
    END
    ELSE
    BEGIN
        SET @Resultado = 0;
        SET @Mensaje = 'El nombre del margen de ganancia ya existe';
    END;
END;
GO
/*########################## FIN PROC MARGEN DE GANANCIA ##########################*/


/*########################## INICIO PROC METODOS PAGOS ##########################*/
create PROC SP_REGISTARMETODOSPAGOS(
@NombreMetodo varchar(50),
@Descripcion nvarchar(255),
@Estado bit,
@Resultado int output,
@Mensaje varchar(500) output
)
as
begin
    SET @Resultado = 0
	
    IF NOT EXISTS (SELECT * FROM METODOS_PAGOS WHERE NombreMetodo = @NombreMetodo)
    begin
        insert into METODOS_PAGOS (NombreMetodo, Descripcion,Estado) values (
            @NombreMetodo,@Descripcion, @Estado
        )

        set @Resultado = SCOPE_IDENTITY()
    end
    else
        set @Mensaje = 'El nombre del metodo de pago ya existe'
end
go

--/* INICIO --- SP_MODIFICARMETODOSPAGOS*/

create PROC SP_MODIFICARMETODOSPAGOS(
@IdMetodosPagos int,
@NombreMetodo nvarchar(50),
@Descripcion nvarchar(255),
@Estado bit,
@Resultado int output,
@Mensaje varchar(500) output
)
as
begin
    SET @Resultado = 1
    
    IF NOT EXISTS (SELECT * FROM METODOS_PAGOS WHERE NombreMetodo = @NombreMetodo and IdMetodosPagos != @IdMetodosPagos)
    begin
        update METODOS_PAGOS set
            NombreMetodo = @NombreMetodo,
            Descripcion = @Descripcion,
            Estado = @Estado
        where IdMetodosPagos = @IdMetodosPagos
    end
    else
    begin
        SET @Resultado = 0
        set @Mensaje = 'El nombre del metodo de pago ya existe'
    end
end
GO
/*########################## FIN PROC METODOS PAGOS  ##########################*/

/*########################## FIN PROC PROVEEDOR ##########################*/

create PROC SP_REGISTARPROVEEDOR(
@Documento varchar(50),
@RazonSocial varchar(50),
@Correo varchar(50),
@Telefono varchar(50),
@Notas varchar(MAX),
@Estado bit,
@Resultado int output,
@Mensaje varchar(500) output
)as
begin
	SET @Resultado = 0
	DECLARE @IDPERSONA INT 
	IF NOT EXISTS (SELECT * FROM PROVEEDOR WHERE Documento = @Documento)
	begin
		insert into PROVEEDOR(Documento,RazonSocial,Correo,Telefono,Notas, Estado) values (
		@Documento,@RazonSocial,@Correo,@Telefono,@Notas,@Estado)

		set @Resultado = SCOPE_IDENTITY()
	end
	else
		set @Mensaje = 'El numero de documento ya existe'
end
go

--/* INICIO --- SP_MODIFICARPROVEEDOR*/

create PROC SP_MODIFICARPROVEEDOR(
@IdProveedor int,
@Documento varchar(50),
@RazonSocial varchar(100),
@Correo varchar(50),
@Telefono varchar(50),
@Notas varchar(MAX),
@Estado bit,
@Resultado bit output,
@Mensaje varchar(500) output
)as
begin
	SET @Resultado = 1
	DECLARE @IDPERSONA INT 
	IF NOT EXISTS (SELECT * FROM PROVEEDOR WHERE Documento = @Documento and IdProveedor != @IdProveedor)
	begin
		update PROVEEDOR set
		Documento = @Documento,
		RazonSocial = @RazonSocial,
		Correo = @Correo,
		Telefono = @Telefono,
		Notas = @Notas,
		Estado = @Estado
		where IdProveedor = @IdProveedor
	end
	else
	begin
		SET @Resultado = 0
		set @Mensaje = 'El numero de documento ya existe'
	end
end
go

--/* INICIO --- SP_ELIMINARPROVEEDOR*/

create procedure SP_ELIMINARPROVEEDOR(
@IdProveedor int,
@Resultado bit output,
@Mensaje varchar(500) output
)
as
begin
	SET @Resultado = 1
	IF NOT EXISTS (
	 select *  from PROVEEDOR p
	 inner join COMPRA c on p.IdProveedor = c.IdProveedor
	 where p.IdProveedor = @IdProveedor
	)
	begin
	 delete top(1) from PROVEEDOR where IdProveedor = @IdProveedor
	end
	ELSE
	begin
		SET @Resultado = 0
		set @Mensaje = 'El proveedor se encuentara relacionado a una compra'
	end
end
go

/*##########################  FIN PROC PROVEEDOR ##########################*/

/*########################## INICIO PROC CATEGORIA ##########################*/
create PROC SP_REGISTRARCATEGORIA(
@NombreCategoria varchar(50),
@Estado bit,
@Resultado int output,
@Mensaje varchar(500) output
)as
begin
	SET @Resultado = 0
	IF NOT EXISTS (SELECT * FROM CATEGORIAS WHERE NombreCategoria = @NombreCategoria)
	begin
		insert into CATEGORIAS(NombreCategoria,Estado) values (@NombreCategoria,@Estado)
		set @Resultado = SCOPE_IDENTITY()
	end
	ELSE
		set @Mensaje = 'No se puede repetir el nombre de una categoria existente'	
end

go
--/* INICIO --- SP_EDITARCATEGORIA*/
Create procedure SP_EDITARCATEGORIA(
@IdCategoria int,
@NombreCategoria varchar(50),
@Estado bit,
@Resultado int output,
@Mensaje varchar(500) output
)
as
begin
	SET @Resultado = 1
	IF NOT EXISTS (SELECT * FROM CATEGORIAS WHERE NombreCategoria =@NombreCategoria and IdCategoria != @IdCategoria)
		update CATEGORIAS set
		NombreCategoria = @NombreCategoria,
		Estado = @Estado
		where IdCategoria = @IdCategoria
	ELSE
	begin
		SET @Resultado = 0
		set @Mensaje = 'No se puede repetir el nombre de una categoria existente'
	end

end
go
--/* INICIO --- SP_ELIMINARCATEGORIA*/
create procedure SP_ELIMINARCATEGORIA(
@IdCategoria int,
@Resultado bit output,
@Mensaje varchar(500) output
)
as
begin
	SET @Resultado = 1
	IF NOT EXISTS (
	 select *  from CATEGORIAS c
	 inner join PRODUCTOS p on p.IdCategoria = c.IdCategoria
	 where c.IdCategoria = @IdCategoria
	)
	begin
	 delete top(1) from CATEGORIAS where IdCategoria = @IdCategoria
	end
	ELSE
	begin
		SET @Resultado = 0
		set @Mensaje = 'La categoria se encuentara relacionada a un producto'
	end

end
GO
/*########################## FIN PROC CATEGORIA  ##########################*/


/*########################## INICIO PROC SUBCATEGORIA ##########################*/
CREATE PROC SP_REGISTRARSUBCATEGORIA(
    @IdCategoria INT,
    @NombreSubcategoria VARCHAR(50),
    @Estado BIT,
    @Resultado INT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
) AS
BEGIN
    SET @Resultado = 0;

    IF NOT EXISTS (SELECT * FROM SUBCATEGORIAS WHERE NombreSubcategoria = @NombreSubcategoria)
    BEGIN
        IF EXISTS (SELECT * FROM CATEGORIAS WHERE IdCategoria = @IdCategoria)
        BEGIN
            INSERT INTO SUBCATEGORIAS (IdCategoria, NombreSubcategoria, Estado)
            VALUES (@IdCategoria, @NombreSubcategoria, @Estado);

            SET @Resultado = SCOPE_IDENTITY();
        END
        ELSE
        BEGIN
            SET @Mensaje = 'La categoría asociada no existe';
        END
    END
    ELSE
    BEGIN
        SET @Mensaje = 'No se puede repetir el nombre de una subcategoría existente';
    END
END
GO
--/* INICIO --- SP_EDITARSUBCATEGORIA*/
CREATE PROC SP_EDITARSUBCATEGORIA(
    @IdSubcategoria INT,
    @IdCategoria INT,
    @NombreSubcategoria VARCHAR(50),
    @Estado BIT,
    @Resultado INT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
) AS
BEGIN
    SET @Resultado = 1;

    IF EXISTS (SELECT 1 FROM CATEGORIAS WHERE IdCategoria = @IdCategoria)
    BEGIN
        UPDATE SUBCATEGORIAS
        SET IdCategoria = @IdCategoria,
            NombreSubcategoria = @NombreSubcategoria,
            Estado = @Estado
        WHERE IdSubcategoria = @IdSubcategoria;

        IF @@ROWCOUNT = 0
        BEGIN
            SET @Resultado = 0;
            SET @Mensaje = 'La subcategoría no existe';
        END
    END
    ELSE
    BEGIN
        SET @Resultado = 0;
        SET @Mensaje = 'La categoría asociada no existe';
    END
END
GO

--/* INICIO --- SP_ELIMINARSUBCATEGORIA*/
CREATE PROC SP_ELIMINARSUBCATEGORIA(
    @IdSubcategoria INT,
    @Resultado BIT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
) AS
BEGIN
    SET @Resultado = 1;

    IF NOT EXISTS (SELECT * FROM SUBCATEGORIAS WHERE IdSubcategoria = @IdSubcategoria)
    BEGIN
        DELETE FROM SUBCATEGORIAS WHERE IdSubcategoria = @IdSubcategoria;
    END
    ELSE
    BEGIN
        SET @Resultado = 0;
        SET @Mensaje = 'La subcategoría se encuentra relacionada a un producto';
    END
END
GO

/*########################## FIN PROC SUBCATEGORIA ##########################*/


/*########################## INICIO PROC PROC TIPOS UNIDADES ##########################*/
create PROC SP_REGISTARTIPOSUNIDADES(
@NombreTipoUnidad varchar(50),
@Resultado int output,
@Mensaje varchar(500) output
)
as
begin
    SET @Resultado = 0
	
    IF NOT EXISTS (SELECT * FROM TIPOS_UNIDADES WHERE NombreTipoUnidad = @NombreTipoUnidad)
    begin
        insert into TIPOS_UNIDADES (NombreTipoUnidad) values (
            @NombreTipoUnidad
        )

        set @Resultado = SCOPE_IDENTITY()
    end
    else
        set @Mensaje = 'El nombre de la unidad de medida ya existe'
end
go

--/* INICIO --- SP_MODIFICARTIPOSUNIDADES*/

create PROC SP_MODIFICARTIPOSUNIDADES(
@IdTipoUnidad int,
@NombreTipoUnidad varchar(50),
@Resultado bit output,
@Mensaje varchar(500) output
)
as
begin
    SET @Resultado = 1
    
    IF NOT EXISTS (SELECT * FROM TIPOS_UNIDADES WHERE NombreTipoUnidad = @NombreTipoUnidad and IdTipoUnidad != @IdTipoUnidad)
    begin
        update TIPOS_UNIDADES set
            NombreTipoUnidad = @NombreTipoUnidad

        where IdTipoUnidad = @IdTipoUnidad
    end
    else
    begin
        SET @Resultado = 0
        set @Mensaje = 'El nombre de la unidad de medida ya existe'
    end
end
GO
/*########################## FIN PROC TIPOS UNIDADES  ##########################*/

/*########################## INICIO PROC PRODUCTOS ##########################*/
CREATE PROC SP_REGISTRARPRODUCTO(
    @CodigoBarras VARCHAR(100),
    @Codigo VARCHAR(50),
    @DescripcionGeneral VARCHAR(100),
    @IdCategoria INT,
    @IdSubcategoria INT,
    @IdTasaImpuesto INT,
    @IdTipoUnidad INT,
    @ProveedorAsociado INT,
	@Imagen VARBINARY(MAX),
    @PrecioCompra DECIMAL(18,2),
    @IdMargenGanancia INT,
    @PrecioFinal DECIMAL(18,2),
    @UbicacionProducto VARCHAR(100),
    @StockExistente DECIMAL(18,2),
    @StockMinimo DECIMAL(18,2),
    @Estado BIT,
    @Resultado INT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @Resultado = 0;

    IF NOT EXISTS (SELECT * FROM PRODUCTOS WHERE CodigoBarras = @CodigoBarras)
    BEGIN
        INSERT INTO PRODUCTOS (
            CodigoBarras, Codigo, DescripcionGeneral, IdCategoria, IdSubcategoria, IdTasaImpuesto,
            IdTipoUnidad, ProveedorAsociado, Imagen, PrecioCompra, IdMargenGanancia, PrecioFinal,
            UbicacionProducto, StockExistente, StockMinimo,
            Estado
        ) 
        VALUES (
            @CodigoBarras, @Codigo, @DescripcionGeneral, @IdCategoria, @IdSubcategoria, @IdTasaImpuesto,
            @IdTipoUnidad, @ProveedorAsociado, @Imagen, @PrecioCompra, @IdMargenGanancia, @PrecioFinal,
            @UbicacionProducto, @StockExistente, @StockMinimo,
            @Estado
        );

        SET @Resultado = SCOPE_IDENTITY();
    END
    ELSE
    BEGIN
        SET @Mensaje = 'Ya existe un producto con el mismo código de barras.';
    END
END;
GO


---

CREATE PROCEDURE SP_MODIFICARPRODUCTO(
    @IdProducto INT,
    @CodigoBarras VARCHAR(100),
    @Codigo VARCHAR(50),
    @DescripcionGeneral VARCHAR(100),
    @IdCategoria INT,
    @IdSubcategoria INT,
    @IdTasaImpuesto INT,
    @IdTipoUnidad INT,
    @ProveedorAsociado INT,
	@Imagen VARBINARY(MAX),
    @PrecioCompra DECIMAL(18,2),
    @IdMargenGanancia INT,
    @PrecioFinal DECIMAL(18,2),
    @UbicacionProducto VARCHAR(100),
    @StockExistente DECIMAL(18,2),
    @StockMinimo DECIMAL(18,2),
    @Estado BIT,
    @Resultado BIT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @Resultado = 1;

    IF NOT EXISTS (SELECT * FROM PRODUCTOS WHERE CodigoBarras = @CodigoBarras AND IdProducto != @IdProducto)
    BEGIN
        UPDATE PRODUCTOS
        SET
            CodigoBarras = @CodigoBarras,
            Codigo = @Codigo,
            DescripcionGeneral = @DescripcionGeneral,
            IdCategoria = @IdCategoria,
            IdSubcategoria = @IdSubcategoria,
            IdTasaImpuesto = @IdTasaImpuesto,
            IdTipoUnidad = @IdTipoUnidad,
            ProveedorAsociado = @ProveedorAsociado,
			Imagen = @Imagen,
            PrecioCompra = @PrecioCompra,
            IdMargenGanancia = @IdMargenGanancia,
            PrecioFinal = @PrecioFinal,
            UbicacionProducto = @UbicacionProducto,
            StockExistente = @StockExistente,
            StockMinimo = @StockMinimo,
            Estado = @Estado
        WHERE IdProducto = @IdProducto;
    END
    ELSE
    BEGIN
        SET @Resultado = 0;
        SET @Mensaje = 'Ya existe un producto con el mismo código de barras.';
    END
END;
GO
---

CREATE PROCEDURE SP_ELIMINARPRODUCTO(
    @IdProducto INT,
    @Respuesta BIT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT,
    @EliminarForzado BIT
)
AS
BEGIN
    SET @Respuesta = 0;
    SET @Mensaje = '';
    DECLARE @pasoreglas BIT = 1;

    -- Verificar si el producto está relacionado con alguna compra
    IF EXISTS (
        SELECT *
        FROM DETALLE_COMPRA dc
        WHERE dc.IdProducto = @IdProducto
    )
    BEGIN
        IF @EliminarForzado = 0
        BEGIN
            SET @pasoreglas = 0;
            SET @Respuesta = 0;
            SET @Mensaje = @Mensaje + 'No se puede eliminar porque se encuentra relacionado a una COMPRA\n';
        END
    END

    -- Verificar si el producto está relacionado con alguna venta
    IF EXISTS (
        SELECT *
        FROM DETALLE_VENTA dv
        WHERE dv.IdProducto = @IdProducto
    )
    BEGIN
        IF @EliminarForzado = 0
        BEGIN
            SET @pasoreglas = 0;
            SET @Respuesta = 0;
            SET @Mensaje = @Mensaje + 'No se puede eliminar porque se encuentra relacionado a una VENTA\n';
        END
    END

    -- Eliminar el producto si pasa las reglas o si se ha habilitado la eliminación forzada
    IF (@pasoreglas = 1 OR @EliminarForzado = 1)
    BEGIN
        DELETE FROM PRODUCTOS WHERE IdProducto = @IdProducto;
        SET @Respuesta = 1;
    END
END;
GO
/*########################## INICIO FIN PROC PRODUCTOS ##########################*/

-- SP_ACTUALIZARPRODUCTO "Funcionalidad para actualizar el stock y precio final de un producto"
CREATE PROCEDURE SP_ACTUALIZARPRODUCTO
    @IdProducto INT,
    @PrecioFinal DECIMAL(18,2) = NULL,
    @StockExistente DECIMAL(18,2) = NULL,
    @Resultado BIT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
AS
BEGIN
    SET @Resultado = 0;

    -- Si se encontró el producto
    IF @IdProducto IS NOT NULL
    BEGIN
        -- Obtener los valores existentes
        DECLARE @PrecioFinalExistente DECIMAL(18,2);
        DECLARE @StockExistenteExistente DECIMAL(18,2);

        SELECT @PrecioFinalExistente = PrecioFinal,
               @StockExistenteExistente = StockExistente
        FROM PRODUCTOS
        WHERE IdProducto = @IdProducto;

        -- Actualizar los valores
        UPDATE PRODUCTOS
        SET
            PrecioFinal = COALESCE(@PrecioFinal, @PrecioFinalExistente),
            StockExistente = COALESCE(@StockExistente + @StockExistenteExistente, @StockExistenteExistente)
        WHERE IdProducto = @IdProducto;

        SET @Resultado = 1;
        SET @Mensaje = 'Producto actualizado correctamente.';
    END
    ELSE
    BEGIN
        SET @Mensaje = 'No se encontró el producto con el Id proporcionado.';
    END
END;
GO
-- SP_OBTENER_CODIGO_O_CODIGO_BARRAS "Funcionalidad para filtrar y buscar por codigos a productos"

CREATE PROCEDURE SP_OBTENER_CODIGO_O_CODIGO_BARRAS
    @Codigo NVARCHAR(50) = NULL,
    @CodigoBarras NVARCHAR(50) = NULL
AS
BEGIN
    SELECT IdProducto, CodigoBarras, Codigo, DescripcionGeneral, PrecioFinal, UbicacionProducto, StockExistente
    FROM PRODUCTOS
    WHERE Codigo = @Codigo OR CodigoBarras = @CodigoBarras;
END;
GO

--SP_OBTENERIDPRODUCTO "Funcionalidad para obtener el id de un producto"

CREATE PROCEDURE SP_OBTENERIDPRODUCTO
(
    @IdProducto INT,
    @Resultado INT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @Resultado = 0;
    SET @Mensaje = '';

    -- Verificar si el producto existe
    IF EXISTS (
        SELECT 1
        FROM PRODUCTOS
        WHERE IdProducto = @IdProducto
    )
    BEGIN
        SET @Resultado = 1;
    END
    ELSE
    BEGIN
        SET @Mensaje = 'No se encontró un producto con el ID especificado.';
    END
END;
GO

--SP_ACTUALIZAR_PRECIOS_MASIVOS "Funcionalidad pra actualizar masivamente los precios de varios productos a la vez"
CREATE PROCEDURE SP_ACTUALIZAR_PRECIOS_MASIVOS(
    @IdCategoria INT,
    @IdSubcategoria INT,
    @IdMargenGanancia INT, 
    @PorcentajeAumento DECIMAL(5,2),
    @Resultado BIT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @Resultado = 0;

    -- Verificar si la categoría y subcategoría existen
    IF NOT EXISTS (SELECT * FROM CATEGORIAS WHERE IdCategoria = @IdCategoria)
    BEGIN
        SET @Mensaje = 'La categoría especificada no existe.';
        RETURN;
    END

    IF NOT EXISTS (SELECT * FROM SUBCATEGORIAS WHERE IdSubcategoria = @IdSubcategoria AND IdCategoria = @IdCategoria)
    BEGIN
        SET @Mensaje = 'La subcategoría especificada no existe o no pertenece a la categoría proporcionada.';
        RETURN;
    END

    -- Obtener el porcentaje de ganancia
    DECLARE @PorcentajeGanancia DECIMAL(5,2);
    SELECT @PorcentajeGanancia = ISNULL(MG.Porcentaje, 0)
    FROM MARGENES_GANANCIA MG
    INNER JOIN PRODUCTOS P ON MG.IdMargenGanancia = P.IdMargenGanancia
    WHERE P.IdSubcategoria = @IdSubcategoria;

    -- Actualizar precios de productos y contar la cantidad actualizada
    UPDATE PRODUCTOS
    SET PrecioFinal = PrecioFinal * (1 + (@PorcentajeGanancia + @PorcentajeAumento) / 100),
        FechaActualizacion = GETDATE() -- Asignar la fecha de actualización
    WHERE IdCategoria = @IdCategoria
      AND IdSubcategoria = @IdSubcategoria;

    -- Obtener la cantidad de filas afectadas (productos actualizados)
    DECLARE @CantidadActualizada INT;
    SET @CantidadActualizada = @@ROWCOUNT;

    SET @Resultado = 1;
    SET @Mensaje = 'Actualización masiva de precios realizada con éxito. Se actualizaron ' + CAST(@CantidadActualizada AS VARCHAR) + ' productos.';
END;
GO


--SP_ACTUALIZAR_PRECIOS_MASIVOS "Funcionalidad Cuando se selecciona una categoria lista solo la SUBCATEGORIA relacionada"
CREATE PROCEDURE SP_OBTENER_SUBCATEGORIAS_POR_CATEGORIAS
    @IdCategoria INT
AS
BEGIN
    SELECT IdSubcategoria, NombreSubcategoria
    FROM SUBCATEGORIAS
    WHERE IdCategoria = @IdCategoria; -- No se especifica ningún filtro adicional en el estado
END;
GO

/*########################## INICIO FIN PRODUCTOS ##########################*/

/*########################## INICIO PROC VENTAS ##########################*/

/* Tipo de tabla actualizado para DETALLE_VENTA */
CREATE TYPE [dbo].[EDetalle_Venta] AS TABLE(
    [IdProducto] INT NULL,
    [PrecioVenta] DECIMAL(18,2) NULL,
    [Cantidad] DECIMAL(18,2) NULL,
    [Total] DECIMAL(18,2) NULL
);
GO
/* PROCESOS PARA REGISTRAR UNA VENTA ACTUALIZADO */
CREATE PROCEDURE SP_REGUISTRARVENTAS(
    @IdUsuario INT,
    @TipoDocumento VARCHAR(500),
    @NumeroDocumento VARCHAR(500),
    @DocumentoCliente VARCHAR(500),
    @NombreCliente VARCHAR(500),
    @DescripcionMetodoPago VARCHAR(500),
    @MontoPago DECIMAL(18,2),
    @MontoCambio DECIMAL(18,2),
    @MontoTotal DECIMAL(18,2),
    @DetalleVenta [EDetalle_Venta] READONLY,                                      
    @Resultado BIT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    BEGIN TRY
        DECLARE @idventa INT = 0
        SET @Resultado = 1
        SET @Mensaje = ''

        BEGIN TRANSACTION registro

        INSERT INTO VENTA (IdUsuario,TipoDocumento, NumeroDocumento, DocumentoCliente, NombreCliente, DescripcionMetodoPago, MontoPago, MontoCambio, MontoTotal)
        VALUES (@IdUsuario, @TipoDocumento, @NumeroDocumento, @DocumentoCliente, @NombreCliente, @DescripcionMetodoPago, @MontoPago, @MontoCambio, @MontoTotal)

        SET @idventa = SCOPE_IDENTITY()

        INSERT INTO DETALLE_VENTA (IdVenta, IdProducto, PrecioVenta, Cantidad, Total)
        SELECT @idventa, IdProducto, PrecioVenta, Cantidad, Total FROM @DetalleVenta

        COMMIT TRANSACTION registro
    END TRY
    BEGIN CATCH
        SET @Resultado = 0
        SET @Mensaje = ERROR_MESSAGE()
        ROLLBACK TRANSACTION registro
    END CATCH
END
GO

------- Procedimiento para obtener y mostrar una VENTA
CREATE PROCEDURE SP_OBTENERVENTA
    @IdVenta INT
AS
BEGIN
    SELECT
        V.IdVenta,
        V.TipoDocumento,
        V.NumeroDocumento,
        V.DocumentoCliente,
        V.NombreCliente,
        V.DescripcionMetodoPago,
        V.MontoPago,
        V.MontoCambio,
        V.MontoTotal,
        DV.IdProducto,
        DV.PrecioVenta,
        DV.Cantidad,
        DV.Total
    FROM
        VENTA V
        INNER JOIN DETALLE_VENTA DV ON V.IdVenta = DV.IdVenta
    WHERE
        V.IdVenta = @IdVenta;
END
GO

--ObtenerDetallesVentaRDLC
-- Procedimiento para obtener los detalles de la venta
CREATE PROCEDURE detalleVenta
    @IdVenta INT
AS
BEGIN
    -- Obtener detalles de la venta
    SELECT
        dv.IdDetalleVenta,
        dv.IdProducto,
        p.DescripcionGeneral,
        dv.PrecioVenta,
        dv.Cantidad,
        dv.Total AS TotalDetalle
    FROM
        DETALLE_VENTA dv
    LEFT JOIN
        PRODUCTOS p ON dv.IdProducto = p.IdProducto
    WHERE
        dv.IdVenta = @IdVenta;
END;
GO

-- Procedimiento para obtener datos generales de la venta
CREATE PROCEDURE datosGeneralesVenta
    @IdVenta INT
AS
BEGIN
    -- Obtener datos generales de la venta
    SELECT
        v.IdVenta,
        v.IdUsuario,
        u.NombreCompleto,
        v.TipoDocumento,
        v.NumeroDocumento,
        v.DocumentoCliente,
        v.NombreCliente,
        v.DescripcionMetodoPago,
        v.MontoPago,
        v.MontoTotal,
        v.FechaRegistro,
        n.IdNegocio,
        n.Nombre as NombreNegocio,
        n.Telefono as TelefonoNegocio,
        n.Direccion as DireccionNegocio,
        n.Titular,
        n.CUIT,
        n.NumIngresosBrutos,
        n.Logo
    FROM
        VENTA v
    INNER JOIN
        USUARIO u ON u.IdUsuario = v.IdUsuario
    LEFT JOIN
        NEGOCIO n ON n.IdNegocio = 1 -- Valor
    WHERE
        v.IdVenta = @IdVenta;
END;
GO

-- Procedimiento para obtener detalles generales y detalle de la venta
CREATE PROCEDURE ObtenerDetallesGeneralesYDetalleVenta
    @IdVenta INT
AS
BEGIN
    -- Obtener detalles de la venta
    EXEC detalleVenta @IdVenta;

    -- Obtener datos generales de la venta
    EXEC datosGeneralesVenta @IdVenta;
END;
GO

/*########################## FIN PROC VENTAS ##########################*/

/*########################## INICIO PROC SP_REGISTRAR_INICIO_FIN_FECHAS ##########################*/

CREATE PROCEDURE SP_REGISTRAR_INICIO_FIN_FECHAS
    @FechaInicio DATETIME,
    @FechaFin DATETIME,
    @DiasDiferencia INT OUTPUT,
    @Resultado INT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
AS
BEGIN
    -- Verificar que la fecha de inicio sea menor o igual a la fecha de fin
    IF @FechaInicio > @FechaFin
    BEGIN
        SET @Resultado = 0; -- 0 indica error
        SET @Mensaje = 'La Fecha de Inicio no puede ser posterior a la Fecha de Fin.';
        RETURN;
    END

    -- Calcular la diferencia en días entre FechaInicio y FechaFin
    SET @DiasDiferencia = DATEDIFF(DAY, @FechaInicio, @FechaFin);

    -- Verificar restricción de al menos 1 día de diferencia
    IF @DiasDiferencia < 1
    BEGIN
        SET @Resultado = 0; -- 0 indica error
        SET @Mensaje = 'Debe haber al menos 1 día de diferencia entre FechaInicio y FechaFin.';
        RETURN;
    END

    -- Insertar datos en la tabla Caducidad
    INSERT INTO Caducidad (FechaInicio, FechaFin, DiasDiferencia)
    VALUES (@FechaInicio, @FechaFin, @DiasDiferencia);

    SET @Resultado = 1; -- 1 indica éxito
    SET @Mensaje = 'Registro exitoso.';
END
GO
/*########################## FIN PROC SP_REGISTRAR_INICIO_FIN_FECHAS ##########################*/



/****************** INSERTAMOS REGISTROS A LAS TABLAS ******************/
insert into rol (Descripcion)
 values('ADMINISTRADOR')

GO

insert into rol (Descripcion)
 values('EMPLEADO')

 GO

insert into USUARIO(Documento,NombreCompleto,Clave,IdRol,Estado)
 values 
 ('123','ADMIN','123',1,1)

GO
------------------------------------------------------

/*ClaveUnica privada Gestión de caducidad*/
INSERT INTO ClaveUnica (IdUsuario, ClaveUnica)
VALUES (1, '123');

-------------------------------------------------------
  
insert into PERMISO(IdRol,NombreMenu) values
  (1,'mdConfiguracion')
  
GO

insert into PERMISO(IdRol,NombreMenu) values
  (1,'mdSocios')
  
GO

insert into PERMISO(IdRol,NombreMenu) values
  (1,'mdInventarios')
  
GO

insert into PERMISO(IdRol,NombreMenu) values
  (1,'mdVentas')
  
GO

insert into PERMISO(IdRol,NombreMenu) values
  (1,'mdCompras')
  
GO

insert into PERMISO(IdRol,NombreMenu) values
  (1,'mdReportes')
  
GO

insert into PERMISO(IdRol,NombreMenu) values
  (1,'mdLicencia')
  
GO

------------------------------------------------------

insert into NEGOCIO(IdNegocio,Nombre,Telefono,Direccion,Titular,CUIT,NumIngresosBrutos,Logo) values
  (1,'Prueba','20202020','av. codigo 123',null,null,null,null)
  
GO
-------------------------------------------------------
insert into SMTP ( EmailRemitente, ContraseñaRemitente)
  values('test@gmail','123')  

GO
----------------------------------------------------------------
insert into TASA_IMPUESTOS (NombreTasa, Porcentaje, Descripcion, Estado)
	values ('IVA', 21.0, 'Impuesto al Valor Agregado del 21%', 1);
GO

insert into TASA_IMPUESTOS (NombreTasa, Porcentaje, Descripcion, Estado)
	values ('SNIVA', 0, 'Sin impuesto', 1);
GO
--------------------------------------------------------------------


INSERT INTO TIPOS_UNIDADES (NombreTipoUnidad) VALUES 
--('UNIDAD'), ('KILOGRAMO'), ('LITRO'), ('CAJA'), ('BULTO'), ('SACO'), ('METRO'), ('PIEZA'), ('JUEGO'), ('DOCENA'), ('SERVICIO');
  ('KG'), ('UN');
GO
---------------------------------------------------------------------

--#########################################################################--

-- PRUEBAS --

------------------------
select * from Caducidad

delete Caducidad

DECLARE @FechaInicio DATETIME = '2024-02-25T00:00:00';
DECLARE @FechaFin DATETIME = '2024-02-26T00:00:00';
DECLARE @DiasDiferencia INT;
DECLARE @Resultado INT;
DECLARE @Mensaje VARCHAR(500);

-- Ejecutar el procedimiento almacenado
EXEC SP_REGISTRAR_INICIO_FIN_FECHAS
    @FechaInicio = @FechaInicio,
    @FechaFin = @FechaFin,
    @DiasDiferencia = @DiasDiferencia OUTPUT,
    @Resultado = @Resultado OUTPUT,
    @Mensaje = @Mensaje OUTPUT;

-- Imprimir los resultados
PRINT 'Resultado: ' + CAST(@Resultado AS VARCHAR(10));
PRINT 'Mensaje: ' + @Mensaje;
PRINT 'Días de Diferencia: ' + CAST(@DiasDiferencia AS VARCHAR(10));