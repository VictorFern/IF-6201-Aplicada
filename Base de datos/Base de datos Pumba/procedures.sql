-- 1. INSERT OPERATION
CREATE PROCEDURE [dbo].[InsertProduct]
	@nombre nvarchar(max),
	@marca nvarchar(max),
	@descripcion nvarchar(max),
	@precio int,
	@dimensiones nvarchar(max),
	@foto nvarchar(max),
	@id_proveedor int,
	@id_categoria int

AS
BEGIN

	INSERT INTO product([nombre], [marca], [descripcion], [precio], [dimensiones], [foto], [id_proveedor], [id_categoria])
	VALUES(
		@nombre, 
		@marca, 
		@descripcion, 
		@precio, 
		@dimensiones, 
		@foto, 
		@id_proveedor, 
		@id_categoria
	);
END


-- 2. DELETE OPERATION

CREATE PROCEDURE [dbo].[DeleteProductById] (@product_id integer) 

AS 
  BEGIN 

	delete from product
	WHERE product_id = @product_id

END

-- 3. UPDATE OPERATION

CREATE PROCEDURE [dbo].[UpdateProductById] (
	@product_id int,
	@nombre nvarchar(max),
	@marca nvarchar(max),
	@descripcion nvarchar(max),
	@precio int,
	@dimensiones nvarchar(max),
	@foto nvarchar(max),
	@id_proveedor int,
	@id_categoria int
) 

AS 
  BEGIN 

	UPDATE product
	SET nombre = @nombre,
	marca = @marca,
	descripcion = @descripcion,
	precio = @precio,
	dimensiones = @dimensiones,
	foto = @foto,
	id_proveedor = @id_proveedor,
	id_categoria = @id_categoria 
	WHERE product_id = @product_id

END

-- 4 SELECT OPERATION

create PROCEDURE [dbo].[SelectProduct] 

AS 
  BEGIN 
      SELECT *
	  FROM product 
END 

-- 5. SELECT BY ID OPERATION

create PROCEDURE [dbo].[SelectProductById] (@product_id  INTEGER) 

AS 
  BEGIN 
	  SELECT
		  * from product
	   WHERE product_id = @product_id; 
END


-- CATEGORIAS

--DELETE
CREATE PROCEDURE [dbo].[DeleteCategoriaById] (@id integer) 

AS 
  BEGIN 

	delete from categoria
	WHERE id = @id

END

-- UPDATE

CREATE PROCEDURE [dbo].[UpdateCategoriaById] (
	@id int,
	@nombre nvarchar(max)
) 

AS 
  BEGIN 

	UPDATE categoria
	SET nombre = @nombre
	WHERE id = @id

END

-- INSERT

CREATE PROCEDURE [dbo].[InsertCategoria](
	@nombre nvarchar(max))

AS
BEGIN

	INSERT INTO categoria([nombre])
	VALUES(@nombre);
END

-- SELECT

CREATE PROCEDURE [dbo].[SelectCategoria] 

AS 
  BEGIN 
      SELECT * FROM categoria
END

-- SELECT BY ID

CREATE PROCEDURE [dbo].[SelectCategoria] (@id int)

AS 
  BEGIN 
      SELECT * FROM categoria WHERE id = @id
END