use PawnSystem
go

CREATE PROCEDURE Insertar_Cliente_vendedor
@p_nom varchar(50),
@s_nom varchar(50), 
@p_apell varchar(50),
@s_apell varchar(50), 
@cedula varchar(50),
@dir varchar(100),
@tel nvarchar(10),
@correo varchar(50)
AS
	INSERT INTO Cliente_Vendedor VALUES(@p_nom,@s_nom,@p_apell,@s_apell,@cedula,@dir,@tel,@correo);

	exec Insertar_Cliente_vendedor 'as','asdf','asdf','asdf','741','sdaf42','74','asdf'
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
@valor money,
@descripcion varchar(100),
@nombre varchar(50),
@precio_venta money
as
	insert into Producto values(@id_tipo_producto,@valor,@descripcion,@nombre,@precio_venta,'HABILITADO');
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

---Cliente
create proc sp_IdClienteVendedor
@cedula varchar(30)
as
	select c.Id_Cliente_Vendedor from Cliente_Vendedor c where c.Cédula = @cedula
go

create proc sp_IdProducto
@Nombre varchar(30),
@tipo int
as
	select c.Id_Producto from Producto c where c.Nombre = @Nombre and c.Id_Tipo_Producto = @tipo
go

select e.Id_Empeño from Empeño e where e.Id_Cliente_Vendedor = 9 and e.Id_Empleado = 9 

--Empeno ---------------------
alter proc sp_add_Empeno
@idClient int,
@idEmpleado int,
@idP int,
@Monto_Empeno money,
@Cuota int,
@frecuencia int,
@FechaVencimiento date
as

	insert into Empeño values (@idClient,@idEmpleado,GETDATE()); 
	select *from Empeño
	declare @idE int

	set @idE = (select e.Id_Empeño from Empeño e where e.Id_Cliente_Vendedor = @idClient and e.Id_Empleado = @idEmpleado )		
	select @idE

	/*insert into Detalle_Empeño values
	(@idE,@idP,@Monto_Empeno,@Cuota,@frecuencia,@FechaVencimiento
	,'HABILITADO');*/
	
go
select * FROM Empeño
SELECT *FROM Producto
SELECT *FROM Detalle_Empeño
Select *from Cliente_Vendedor
select *from Producto
delete Empeño

exec sp_add_Empeno 0,2,6,200,100,2,'2019-12-11'

----------------------------------------
select *from Empleado


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
	select Id_Empleado ,CONCAT(Primer_Nombre,'',Segundo_Nombre) as Nombres,
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
alter proc sp_buscarCliente_Empleado
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

 --Mostrar Tipo Producto
 create proc MostrarTipoProducto
 as
 select tp.Id_Tipo_Producto, tp.Tipo from 
  Tipo_Producto tp 


  exec MostrarTipoProducto

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

alter proc sp_BuscarEmpeño
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
	on e.Id_Empeño = de.Id_Empeño
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

	----------------------------------------------------------
select CONCAT(YEAR(GETDATE()),'/',MONTH(GETDATE()),'/',day(GETDATE()))

select GETDATE()
----------------------------------------------------------------
exec sp_BuscarEmpeño 'fran'
	-----Tabla amortizacion
	
create PROCEDURE sp_prestamo 
@meses INT, @tasa float, @principal money, @email VARCHAR(50)
as

	IF OBJECT_ID('tempdb.dbo.#Prestamo') IS NOT NULL
	BEGIN
		DROP TABLE #prestamo;
	END

	CREATE TABLE #prestamo(
	id_prestamo INTEGER PRIMARY KEY IDENTITY(0,1),
	meses INTEGER NOT NULL, 
	fecha DATE NOT NULL,
	principal MONEY NOT NULL,
	cuota MONEY,
	interes FLOAT,
	aporte_capital FLOAT,
	saldo_final FLOAT);

	DECLARE @cuota MONEY, @interes FLOAT, @capital MONEY, @saldofinal MONEY
	SET @cuota=(((@principal*(@tasa/12))/(1-POWER(1+(@tasa/12),-@meses))))

	--llenada de tabla temporal
	DECLARE @cont int, @fecha DATE;
	SET @cont=1;
	SET @fecha=GETDATE();
	WHILE(@cont<=@meses)
	BEGIN
		IF(@cont=1)
		BEGIN
			SET @saldofinal=@principal;
		END
		ELSE
		BEGIN
			SET @principal=@saldofinal;
		END
		SET @interes=@saldofinal*(@tasa/12);
		SET @capital=@cuota-@interes;
		SET @saldofinal=@saldofinal-@capital;
		INSERT INTO #prestamo VALUES(@cont, @fecha, @principal, @cuota, @interes, @capital, @saldofinal);
		SET @fecha=DATEADD(MONTH, 1, @fecha); 
		SET @cont=@cont+1;
	END
	select *from #prestamo
	
	exec sp_prestamo 12, 0.15, 100000, 'jf_mejiar547@live.com';




	select *from Producto