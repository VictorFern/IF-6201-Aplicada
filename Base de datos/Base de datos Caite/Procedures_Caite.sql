USE if6201_caite;

DELIMITER $$
CREATE PROCEDURE sp_categorias()
BEGIN
	SELECT 
    ID
    ,NOMBRE
    FROM tb_CATEGORIA;
END$$


DELIMITER $$
CREATE PROCEDURE sp_insetar_producto(param_NOMBRE VARCHAR(50)
                                    , param_DESCRIPCION VARCHAR(100)
                                    , param_PRECIO INT
                                    , param_TALLA INT
                                    , param_COLOR VARCHAR(50)
                                    , param_MARCA VARCHAR(50)
                                    , param_FOTO VARCHAR(220)
                                    , param_IDC INT)

BEGIN
	DECLARE param_ID INT; 
	INSERT INTO tb_PRODUCTO(
	NOMBRE
    , DESCRIPCION
    , PRECIO
    , TALLA
    , COLOR
    , MARCA
    , IMAGEN
    )VALUES(
    param_NOMBRE
    ,param_DESCRIPCION
    ,param_PRECIO
    ,param_TALLA
    ,param_COLOR
    ,param_MARCA
    ,param_FOTO
    );
    SET param_ID = (SELECT ID FROM tb_PRODUCTO order by ID desc LIMIT 1);
    INSERT INTO tb_producto_categoria(
    CODIGOP
    , CODIGOC
    )VALUES(
    param_ID
    ,param_IDC
    );
END$$

DELIMITER $$
CREATE PROCEDURE sp_mostrar_producto_nombre(param_PRODUCTO VARCHAR(50))
BEGIN
	SELECT
    P.ID
    , P.NOMBRE
    , P.DESCRIPCION
    , P.PRECIO
    , P.TALLA
    , P.COLOR
    , P.MARCA
    , P.IMAGEN
    , C.NOMBRE AS CATEGORIA
    FROM tb_PRODUCTO P
    JOIN tb_producto_categoria PC
		ON P.ID = PC.CODIGOP
        JOIN tb_categoria C
			ON C.ID = PC.CODIGOC
    WHERE P.NOMBRE LIKE CONCAT('%', param_PRODUCTO , '%') and IsDelete!=1;
END $$
call sp_mostrar_producto_nombre('Nike')
DELIMITER $$
CREATE PROCEDURE sp_mostrar_producto()
BEGIN
	SELECT
    ID
    , NOMBRE
    , DESCRIPCION
    , PRECIO
    , TALLA
    , COLOR
    , MARCA
    , IMAGEN
    FROM tb_PRODUCTO
    where IsDelete!=1;
END $$

CALL sp_mostrar_producto_id(1)

DELIMITER $$
CREATE PROCEDURE sp_mostrar_producto_id(param_ID int)
begin
	select
		producto.ID
		,producto.NOMBRE
		,producto.DESCRIPCION
		,producto.PRECIO
		,producto.TALLA
		,producto.COLOR
		,producto.MARCA
		,producto.IMAGEN
        ,categoria.nombre Categoria
    from tb_producto as producto
		join tb_producto_categoria as producto_categoria
			on 
				producto_categoria.CODIGOP=producto.ID
        join tb_categoria  as categoria
			on 
				categoria.ID=producto_categoria.CODIGOC
    where producto.ID like param_ID and producto.IsDelete != 1;           
end $$

DELIMITER $$
CREATE PROCEDURE sp_actualizar_producto(param_ID INT
									, param_NOMBRE VARCHAR(50)
                                    , param_DESCRIPCION VARCHAR(100)
                                    , param_PRECIO INT
                                    , param_TALLA INT
                                    , param_COLOR VARCHAR(50)
                                    , param_MARCA VARCHAR(50)
                                    , param_CATEGORIA INT)
BEGIN

UPDATE tb_producto
 SET 
	NOMBRE= param_NOMBRE
    ,DESCRIPCION=param_DESCRIPCION
    ,PRECIO= param_PRECIO
    ,TALLA=param_TALLA
	,COLOR=param_COLOR
    , MARCA=param_MARCA
    WHERE ID = param_ID;
    
UPDATE tb_producto_categoria
SET CODIGOC=param_CATEGORIA
WHERE CODIGOP = param_ID;
              
END $$
ALTER TABLE tb_producto 
ADD COLUMN IsDelete bit;

DELIMITER $$
CREATE PROCEDURE sp_eliminar_producto(param_ID INT)
BEGIN

UPDATE tb_producto
SET IsDelete=1
WHERE ID = param_ID;
              
END $$
