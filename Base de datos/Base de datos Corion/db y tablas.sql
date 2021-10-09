CREATE DATABASE CORION_TOMEYLLEVE_IF6201
USE CORION_TOMEYLLEVE_IF6201
CREATE SCHEMA CORION
CREATE TABLE CORION.CATEGORIA
(
ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL
,NOMBRE VARCHAR(100) NOT NULL
)

CREATE TABLE CORION.ADMINS
(
ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL
,USUARIO VARCHAR(100) NOT NULL
,CONTRASENA VARCHAR(100) NOT NULL
)

CREATE TABLE CORION.CLAVE
(
ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL
,CLAVE VARCHAR(100) NOT NULL
)

CREATE TABLE CORION.PRODUCTO
(
ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL
,NOMBRE VARCHAR(100) NOT NULL
,MARCA VARCHAR(100) NOT NULL
,PRECIO FLOAT NOT NULL
,DIMENSIONES VARCHAR(100) NOT NULL
,DESCRIPCION VARCHAR(200) NOT NULL
,PIMAGE VARCHAR(100) NOT NULL
,ID_CATEGORIA INT NOT NULL
,FOREIGN KEY (ID_CATEGORIA) REFERENCES CORION.CATEGORIA (ID)
)

CREATE TABLE CORION.PRODUCTO_CATEGORIA
(
ID_PRODUCTO INT NOT NULL
,ID_CATEGORIA INT NOT NULL
,FOREIGN KEY (ID_PRODUCTO) REFERENCES CORION.PRODUCTO (ID)
,FOREIGN KEY (ID_CATEGORIA) REFERENCES CORION.CATEGORIA (ID)
)

INSERT INTO CORION.CATEGORIA
(NOMBRE)
VALUES
('Destornilladores')
,('Herramientas electricas')
,('Llaves')
,('Pinturas, Barnices y esmaltes')
,('Lubricantes')
,('Equipo de proteccion')
,('Equipo de soldadura')
,('Fijacion y sellado')
,('Alicates')
,('Sierra de mano')
,('Tenazas')