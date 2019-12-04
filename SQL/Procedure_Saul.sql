use PawnSystem

CREATE PROCEDURE Insertar_Cliente_vendedor
@p_nom varchar(50),
@s_nom varchar(50), 
@p_apell varchar(50),
@s_apell varchar(50), 
@cedula varchar(50),
@dir varchar(100)
AS
	INSERT INTO Cliente_Vendedor VALUES(@p_nom,@s_nom,@p_apell,@s_apell,@cedula,@dir);
	SELECT * FROM Cliente_Vendedor;

CREATE PROCEDURE Insertar_Cliente_Comprador
@p_nom varchar(50),
@s_nom varchar(50), 
@p_apell varchar(50),
@s_apell varchar(50), 
@cedula varchar(50),
@dir varchar(100)
AS
	INSERT INTO Cliente_Comprador VALUES(@p_nom,@s_nom,@p_apell,@s_apell,@cedula,@dir);
	SELECT * FROM Cliente_Comprador;

create procedure insertar_Empleado
@p_nom varchar(50),
@s_nom varchar(50), 
@p_apell varchar(50),
@s_apell varchar(50), 
@cedula varchar(50),
@dir varchar(100),
@telefono nvarchar(10),
@correo varchar(50)
AS
	INSERT INTO Empleado VALUES(@p_nom,@s_nom,@p_apell,@s_apell,@cedula,@dir,@telefono,@correo);
	SELECT * FROM Empleado;

create procedure insertar_Telefono_Cliente_Vendedor
@telefono nvarchar(50)
as
	insert into Telefono values(@telefono);
	select * from Telefono;
	
create procedure insertar_correo_Cliente_Vendedor
@correo varchar(50)
as
	insert into Correo values(@correo);
	select * from Correo;

create procedure insertar_empeño
@id_cliente_vendedor integer,
@fecha Date,
@Estado varchar(50)
as
	insert into Empeño values(@id_cliente_vendedor,@fecha,@Estado)
	select * from Empeño;

create procedure insertar_pago_empeño
@id_empeño integer,
@fecha date,
@monto_pagado money,
@estado varchar(50)
as
	insert into Pago_Empeño values(@id_empeño,@fecha,@monto_pagado,@estado);
	select * from Pago_Empeño;

create procedure insertar_detalle_empeño
@id_empeño integer,
@id_producto integer,
@id_empleado integer,
@monto_empeño money,
@cuota integer,
@frecuencia varchar(20),
@fecha_vencimiento date,
@estado varchar(50)
as
	insert into Detalle_Empeño values(@id_empeño,@id_producto,@id_empleado,@monto_empeño,@cuota,@frecuencia,@fecha_vencimiento,@estado);
	select * from Detalle_Empeño;


create procedure insertar_producto
@id_tipo_producto integer,
@estado varchar(50),
@valor money,
@descripcion varchar(100),
@nombre varchar(50),
@precio_venta money
as
	insert into Producto values(@id_tipo_producto,@estado,@valor,@descripcion,@nombre,@precio_venta);
	select * from Producto;

create procedure insertar_tipo_producto
@tipo varchar(50),
@descripcion varchar(100)
as
	insert into Tipo_Producto values(@tipo,@descripcion);
	select * from Tipo_Producto;

create procedure insertar_venta
@id_cliente_comprador integer,
@fecha date
as
	insert into Venta values(@id_cliente_comprador,@fecha);
	select * from Venta;

create procedure insertar_detalle_venta
@id_venta integer,
@id_producto integer
as
	insert into Detalle_Venta values(@id_venta,@id_producto);
	select * from Detalle_Venta;









