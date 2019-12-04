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


--proceso para actualizar datos del cliente y del empleado
CREATE proc Actualizar_Cliente_Empleado
@tipo varchar(20),
@id_registro int, @p_nom varchar(15),
@s_nom varchar(15), @p_apell varchar(15),
@s_apell varchar(15), @dir varchar(70),
@numero nvarchar(10), @correo varchar(50)
as
	IF @tipo = 'Cliente'
	begin
	UPDATE Cliente_Vendedor SET Primer_Nombre = @p_nom,
	Segundo_Nombre = @s_nom, Primer_Apellido = @p_apell,
	Segundo_Apellido= @s_apell, Dirrección = @dir
	WHERE Id_Cliente_Vendedor =@id_registro;
	end

	If @tipo ='Empleado'
	begin
	UPDATE Empleado SET Primer_Nombre = @p_nom,
	Segundo_Nombre = @s_nom, Primer_Apellido = @p_apell,
	Segundo_Apellido= @s_apell, Dirrección = @dir,
	Telefono =@numero , Correo = @correo
	WHERE Id_Empleado =@id_registro;
	end

----Crear usuarios dentro de la base de datos /REVISAR PENDIENTE/
-----Usuario
create proc sp_addUsuario
@Nombre varchar(50),
@pass nvarchar(30),
@id_cargo int 
as
	insert into Usuario values 
	(@Nombre,@pass,@id_cargo);
go

create proc sp_BuscarUsuario
@Usuario varchar(50),
@pass nvarchar(30)
as
	select *from Usuario u where u.Usuario = @Usuario
	and u.clave = @pass 
go
----Cargo
create proc sp_addCargo
@Cargo varchar(50)
as
	insert into Cargo values 
	(@Cargo);
go


 ----Producto

 create proc BuscarProducto
 @Dato varchar(50)
 as
 select p.Nombre, tp.Tipo,p.Descripcion,p.Estado from Producto p 
 inner join Tipo_Producto tp on p.Id_Tipo_Producto = tp.Id_Tipo_Producto
 where
 p.Nombre like @Dato +'%' or
 tp.Tipo like @Dato + '%'




