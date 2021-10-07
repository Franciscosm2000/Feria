drop database PawnSystem
go

create database PawnSystem
go

---tablas

create table Cliente_Vendedor(
	Id_Cliente_Vendedor integer primary key identity(0,1),
	Primer_Nombre varchar(50),
	Segundo_Nombre varchar(50),
	Primer_Apellido varchar(50),
	Segundo_Apellido varchar(50),
	Cédula varchar(50),
	Dirrección varchar(100),
	Telefono nvarchar(10),
	Correo varchar(50)
);

create table Cliente_Comprador(
	Id_Cliente_Comprador integer primary key identity(0,1),
	Primer_Nombre varchar(50),
	Segundo_Nombre varchar(50),
	Primer_Apellido varchar(50),
	Segundo_Apellido varchar(50),
	Telefono nvarchar(10),
	Correo varchar(50)
);

create table Empleado(
	Id_Empleado integer primary key identity(0,1),
	Primer_Nombre varchar(50),
	Segundo_Nombre varchar(50),
	Primer_Apellido varchar(50),
	Segundo_Apellido varchar(50),
	Cédula varchar(50),
	Dirrección varchar(100),
	Telefono nvarchar(10),
	Correo varchar(50),
	Estado varchar(50)
);

create table Empeño(
	Id_Empeño integer primary key identity(0,1),
	Id_Cliente_Vendedor integer not null,
	Id_Empleado integer not null,
	Fecha Date
);


create table Pago_Empeño(
	Id_Pago_Empeño integer primary key identity(0,1),
	Id_Empeño integer not null,
	Fecha Date,
	Monto_Pagado Money,
	Estado varchar(50)
);

create table Detalle_Empeño(
	Id_Detalle_Empeño integer primary key identity(0,1),
	Id_Empeño integer not null,
	Id_producto integer not null,
	Monto_Empeño money,
	Cuota Integer,
	Frecuencia varchar(20),
	Fecha_Vencimiento Date,
	Estado varchar(50)
);

create table Producto(
	Id_Producto integer primary key identity(0,1),
	Id_Tipo_Producto integer not null,
	Valor money,
	Descripcion varchar(100),
	Nombre varchar(50),
	Precio_Venta money,
	Estado varchar(50)
);

create table Tipo_Producto(
	Id_Tipo_Producto integer primary key identity(0,1),
	Tipo varchar(50),
	Descripcion varchar(100)
);

create table Detalle_Venta(
	Id_Detalle_Venta integer primary key identity(0,1),
	Id_Venta integer not null,
	Id_Producto integer not null
);

create table Venta(
	Id_Venta integer primary key identity(0,1),
	Id_Cliente_Comprador integer not null,
	Id_Empleado integer not null,
	Fecha date
);

create table Usuario(
	Id_Usuario integer primary key identity(0,1),
	Id_cargo integer not null,
	usuario varchar(50),
	clave varchar(50),
	correo varchar(50)
);

create table Cargo(
	Id_Cargo integer primary key identity(0,1),
	Nombre_Cargo varchar(50)
);

---relaciones de tablas 

alter table Usuario 
add foreign key (Id_Cargo) 
references Cargo(id_Cargo);


alter table Detalle_Empeño 
add foreign key (Id_Empeño) 
references Empeño(id_Empeño);

alter table Detalle_Empeño 
add foreign key (Id_Producto) 
references Producto(Id_Producto);

alter table Pago_Empeño 
add foreign key (Id_Empeño) 
references Empeño(id_Empeño);

alter table Empeño 
add foreign key (Id_Cliente_Vendedor) 
references Cliente_Vendedor(id_Cliente_Vendedor);

alter table Producto 
add foreign key (Id_Tipo_Producto) 
references Tipo_Producto(id_Tipo_Producto);

alter table Detalle_Venta 
add foreign key (Id_Producto) 
references Producto(id_Producto);

alter table Detalle_Venta 
add foreign key (Id_Venta) 
references Venta(id_Venta);

alter table Venta 
add foreign key (Id_Cliente_Comprador) 
references Cliente_Comprador(id_Cliente_Comprador);

alter table Venta
add foreign key (Id_Empleado) 
references Empleado(id_Empleado);

--constrains

alter table Cliente_Vendedor
add constraint CK_Cliente_Cedula
check (Cédula  like '[0-9][0-9][0-9][-][0-9][0-9][0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9][a-z]');

alter table Empleado
add constraint CK_Empleado
check (Cédula  like '[0-9][0-9][0-9][-][0-9][0-9][0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9][a-z]');

ALTER TABLE Producto
add constraint CK_Producto
check(Estado='Disponible' OR Estado='No Disponible');

ALTER TABLE Usuario
add constraint CK_rol_usuario
check(usuario='ADMIN' OR usuario='EMPLEADO');

ALTER TABLE Detalle_Empeño
add constraint CK_Detalle_Empeño
check(Estado='' OR Estado='');
