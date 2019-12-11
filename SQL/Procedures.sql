use PawnSystem
go

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
	INSERT INTO Empleado VALUES(@p_nom,@s_nom,@p_apell,@s_apell,@cedula,@dir,@telefono,@correo,'HABILITADO');
	SELECT * FROM Empleado;

EXEC insertar_Empleado 's','s','sdf','fdsa','001520','adfas','asdfas','s'
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

create procedure insertar_pago_empeño
@id_empeño integer,
@fecha date,
@monto_pagado money,
@estado varchar(50)
as
	insert into Pago_Empeño values(@id_empeño,@fecha,@monto_pagado,@estado);
	select * from Pago_Empeño;


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

	---vta
create proc sp_Realizar_Venta
@id_ClienteComprador int,
@id_Producto int,
@id_Empleado int
as

insert into Venta values
(@id_ClienteComprador,@id_Empleado,GETDATE());

declare @id_venta int

set @id_venta = (
select v.Id_Venta from Venta v 
where Id_Cliente_Comprador
= @id_ClienteComprador and v.Id_Empleado = @id_Empleado
 and Fecha = GETDATE());

insert into  Detalle_Venta values
(@id_venta,@id_Producto)

go

--Empeno 
create proc sp_add_Empeno
@idEmpeno int,
@idEmpleado int,
@Monto_Empeno money,
@Cuota int,
@frecuencia int,
@FechaVencimiento date,
--Producto
@id_tipo_producto integer,
@valor money,
@descripcion varchar(100),
@nombre varchar(50),
@precio_venta money,
--Cliente
@p_nom varchar(50),
@s_nom varchar(50), 
@p_apell varchar(50),
@s_apell varchar(50), 
@cedula varchar(50),
@dir varchar(100),
@tel nvarchar(10),
@corr varchar(50)

as

	INSERT INTO Cliente_Vendedor VALUES
	(@p_nom,@s_nom,@p_apell,@s_apell,@cedula,@dir,@tel,@corr);
	
	declare @idClient int
	set @idClient = (select cv.Id_Cliente_Vendedor from Cliente_Vendedor cv where cv.Cédula = @cedula);

	insert into Empeño values
	(@idClient,@idEmpleado,GETDATE());

	
	insert into Producto values
	(@id_tipo_producto,@valor,@descripcion,@nombre,@precio_venta,'HABILITADO');
		
		--Id empeno	
	declare @idE int
	set @idE = (select e.Id_Empeño from Empeño e where e.Id_Cliente_Vendedor 
	=@idClient and e.Id_Empleado = @idEmpleado);
	
		--Idproducto
	declare @idP int
	set @idP = (select Id_Producto from Producto p where p.Nombre = @nombre and p.Id_Tipo_Producto = @id_tipo_producto
	and p.Descripcion = @descripcion);

		
	insert into Detalle_Empeño values
	(@idE,@idP,@Monto_Empeno,@Cuota,@frecuencia,@FechaVencimiento
	,'HABILITADO');
go
select *from Detalle_Empeño

--------------Fran
--HACER PROCESO DE TABLA DE AMORTIZACION
---Mostrar todo
alter proc sp_mostrarCliente_Empleado
@tipo varchar(20)
as
	if @tipo = 'Cliente'
	begin
	select CONCAT(Primer_Nombre,'',Segundo_Nombre) as Nombres,
	CONCAT(Primer_Apellido,'',Segundo_Apellido),Cédula,
	Dirrección from Cliente_Vendedor
	end
	else if @tipo = 'Empleado'
	begin
	select CONCAT(Primer_Nombre,'',Segundo_Nombre) as Nombres,
	Concat(Primer_Apellido,' ',Segundo_Apellido)as Apellidos,Cédula,
	Dirrección, Telefono, Correo, Estado from Empleado
	end

	exec sp_mostrarCliente_Empleado 'Empleado'

--Proceso para buscar un cliente comprador
create proc sp_buscarClienteComprador
@Dato varchar(100)
as
select 
c.Primer_Nombre,
c.Segundo_Nombre,
c.Primer_Apellido,
c.Segundo_Apellido,
c.Cédula ,
c.Dirrección
from Cliente_Comprador c
where c.Primer_Nombre like @Dato + '%' or
	  c.Segundo_Nombre like @Dato + '%' or
	  c.Primer_Apellido like @Dato + '%' or
	  c.Segundo_Apellido like @Dato + '%' 

---Mostrar todos los datos cliente comprador
create proc sp_mostrarTodoClienteComprador
as
select Primer_Nombre, Segundo_Nombre,
Primer_Apellido, Segundo_Apellido,
Telefono, Correo
 from Cliente_Comprador


--Proceso para buscar un cliente o un empleado
create proc sp_buscarCliente_Empleado
@Tipo varchar(20),
@Dato varchar(100)
as
if @Tipo = 'Cliente'
begin
select 
c.Primer_Nombre,
c.Segundo_Nombre,
c.Primer_Apellido,
c.Segundo_Apellido,
c.Cédula ,
c.Dirrección
from Cliente_Vendedor c
where c.Primer_Nombre like @Dato + '%' or
	  c.Segundo_Nombre like @Dato + '%' or
	  c.Primer_Apellido like @Dato + '%' or
	  c.Segundo_Apellido like @Dato + '%' or
	  c.Cédula like @Dato + '%';

	  end
if @Tipo = 'Empleado'
	begin 
	select 
	c.Primer_Nombre,
	c.Segundo_Nombre,
	c.Primer_Apellido,
	c.Segundo_Apellido,
	c.Cédula ,
	c.Dirrección,
	c.Telefono,
	c.Correo
	from Empleado c
	where c.Primer_Nombre like @Dato + '%' or
		  c.Segundo_Nombre like @Dato + '%' or
		  c.Primer_Apellido like @Dato + '%' or
		  c.Segundo_Apellido like @Dato + '%' or
		  c.Cédula like @Dato + '%';
	end

	exec sp_buscarCliente_Empleado 'Empleado','fra'

--proceso para actualizar datos del cliente y del empleado
CREATE proc Actualizar_Cliente_Empleado
@tipo varchar(20),
@id_Cedula int, @p_nom varchar(15),
@s_nom varchar(15), @p_apell varchar(15),
@s_apell varchar(15), @dir varchar(70),
@tel nvarchar(10), @corr varchar(50)
as
	IF @tipo = 'Cliente'
	begin
	UPDATE Cliente_Vendedor SET Primer_Nombre = @p_nom,
	Segundo_Nombre = @s_nom, Primer_Apellido = @p_apell,
	Segundo_Apellido= @s_apell, Dirrección = @dir,
	Telefono = @tel , Correo = @corr
	WHERE Cédula = @id_Cedula;
	end

	If @tipo ='Empleado'
	begin
	UPDATE Empleado SET Primer_Nombre = @p_nom,
	Segundo_Nombre = @s_nom, Primer_Apellido = @p_apell,
	Segundo_Apellido= @s_apell, Dirrección = @dir,
	Telefono =@tel , Correo = @corr
	WHERE Cédula = @id_Cedula;
	end
-----Usuario
create proc sp_addUsuario
@Nombre varchar(50),
@pass nvarchar(30),
@id_cargo int ,
@correo nvarchar(50)
as
	insert into Usuario values 
	(@id_cargo,@Nombre,@pass,@correo);
go
exec sp_addUsuario'fran','123',0,'dsa'

create proc sp_BuscarUsuario
@Usuario varchar(50),
@pass nvarchar(30),
@Tipo varchar(50)
as

	if @Tipo = 'login'
	begin
	select u.usuario, c.Nombre_Cargo, u.correo from Usuario u
	inner join Cargo c 
	on u.id_cargo = c.id_cargo
	where u.Usuario = @Usuario
	and u.clave = @pass 
	end

	else if @Tipo = 'RecuperarUsuario'
	begin 
	select u.usuario,u.clave, u.correo from Usuario u
	where u.Usuario = @Usuario
	end 
go
 

----Cargo
create proc sp_addCargo
@Cargo varchar(50)
as
	insert into Cargo values 
	(@Cargo);
go

exec sp_addCargo 'Administrador'
 ----Producto

 create proc BuscarProducto
 @Dato varchar(50)
 as
 select p.Nombre, tp.Tipo,p.Descripcion,p.Estado from Producto p 
 inner join Tipo_Producto tp on p.Id_Tipo_Producto = tp.Id_Tipo_Producto
 where
 p.Nombre like @Dato +'%' or
 tp.Tipo like @Dato + '%'

 create proc MostrarProducto
 as
 select p.Nombre,p.Descripcion,tp.Tipo,p.Valor 
 , p.Precio_Venta, p.Estado
 from Producto p
inner join Tipo_Producto  tp
 on p.Id_Tipo_Producto = tp.Id_Tipo_Producto 

 SELECT *FROM EMPLEADO


 create proc sp_Cambiar_EstadoEmpleado
 @Cedula nvarchar(16)
 as
 if((SELECT estado FROM Empleado WHERE Cédula=@Cedula)='HABILITADO')
	BEGIN
		UPDATE Empleado SET estado='DESHABILITADO' WHERE Cédula=@Cedula;
	END
	ELSE
	BEGIN
		UPDATE Empleado SET estado='HABILITADO' WHERE Cédula=@Cedula;
	END


	---Empeño

create proc sp_BuscarEmpeño
@dato varchar(50)
as
	select 
	e.Id_Empeño as [Contrato], e.Fecha,de.Estado,
	Concat(em.Primer_Nombre,' ',em.Primer_Apellido)
	as [Nombre Empleado],
	CONCAT (cv.Primer_Nombre,' ', cv.Primer_Apellido) 
	as [Nombre Cliente],
	de.Fecha_Vencimiento,
	de.Monto_Empeño,
	de.Cuota,
	de.Frecuencia
	from Empeño e
	inner join Detalle_Empeño de 
	on e.Id_Empeño = de.Id_Detalle_Empeño
	inner join Empleado em 
	on e.Id_Empleado = em.Id_Empleado
	inner join Cliente_Vendedor cv
	on e.Id_Cliente_Vendedor = cv.Id_Cliente_Vendedor 
	where 
	e.Id_Empeño like @dato + '%' or
	e.Fecha like @dato + '%' or
	de.Estado like @dato + '%' or
	em.Primer_Nombre like @dato + '%' or
	em.Segundo_Nombre like @dato + '%' or
	em.Primer_Apellido like @dato + '%' or
	em.Segundo_Apellido like @dato + '%' or
	cv.Primer_Nombre like @dato + '%' or
	cv.Segundo_Nombre like @dato + '%' or
	cv.Primer_Apellido like @dato + '%' or
	cv.Segundo_Apellido like @dato + '%'

select CONCAT(YEAR(GETDATE()),'/',MONTH(GETDATE()),'/',day(GETDATE()))

select GETDATE()