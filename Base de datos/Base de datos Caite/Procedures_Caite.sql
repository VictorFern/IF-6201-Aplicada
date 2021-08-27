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
