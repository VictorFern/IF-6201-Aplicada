USE [lenguajes]
GO

INSERT INTO [dbo].[product]
           ([nombre]
           ,[marca]
           ,[descripcion]
           ,[precio]
           ,[dimensiones]
           ,[foto]
           ,[id_proveedor]
           ,[id_categoria])
     VALUES
           ('cerveza'
           ,'imperial'
           ,'producto nacional'
           ,1000
           ,'355 ml'
           ,'https://i.postimg.cc/pdxShsH7/0005341-cerveza-imperial-lata-350ml.jpg'
           ,2
           ,1)
GO

exec SelectProduct 


