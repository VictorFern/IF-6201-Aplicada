USE IF6201_Proyecto_PUMB
GO


CREATE TABLE product(
	product_id int IDENTITY(1,1) primary key,
	nombre nvarchar(max) NOT NULL,
	marca nvarchar(max) NOT NULL,
	descripcion nvarchar(max) NOT NULL,
	precio int not null,
	dimensiones nvarchar(max) NOT NULL,
	foto nvarchar(max) NOT NULL,
	id_proveedor int not null,
	id_categoria int not null
)

create table categoria(
	id int IDENTITY(1,1) primary key,
	nombre nvarchar(max) NOT NULL
)


