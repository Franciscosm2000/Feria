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




