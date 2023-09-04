CREATE DATABASE PRACTICA_TABLAS_REL
GO
USE PRACTICA_TABLAS_REL
GO

CREATE TABLE CATEGORIAS(
IDCATEG INT IDENTITY (1,1) PRIMARY KEY,
CATEGORIA NVARCHAR (100)
)
GO
CREATE TABLE MARCAS(
IDMARCA INT IDENTITY (1,1) PRIMARY KEY,
MARCA NVARCHAR (100)
)
GO
CREATE TABLE PRODUCTOS(
IDPROD INT IDENTITY (1,1) PRIMARY KEY,
IDCATEGORIA INT,
IDMARCA INT, 
DESCRIPCION NVARCHAR(100),
PRECIO FLOAT
--RELACIONES 
CONSTRAINT RELACION_A_CATEGORIAS FOREIGN KEY (IDCATEGORIA) REFERENCES CATEGORIAS (IDCATEG),
CONSTRAINT RELACION_A_MARCAS FOREIGN KEY (IDMARCA) REFERENCES MARCAS(IDMARCA)
)
GO

insert into CATEGORIAS values 
(''),
('Laptop'),
('Desktop'),
('Impresora'),
('Monitor'),
('Teclado'),
('Tarjeta'),
('Altavoz')
GO
insert into MARCAS values 
(''),
('HP'),
('LG'),
('Samsung'),
('Logitech'),
('Lenovo'),
('Asus'),
('Dell'),
('MSI'),
('Gygabyte'),
('Epson'),
('Nvidia')
GO

--PROCEDIMIENTOS
create proc listaCategoria
as
select * from CATEGORIAS 
order by CATEGORIA asc

execute listaCategoria
go

create proc listaMarca
as
select * from Marcas
order by marca asc

execute listaMarca
go

create proc insetarProducto
@idcat int,
@idmarca int,
@desc nvarchar(100),
@precio float
as
insert into PRODUCTOS
values
(
@idcat,
@idmarca,
@desc,
@precio
)

go

create proc mostrarProducto
as
select IDPROD as ID, c.CATEGORIA, m.MARCA, DESCRIPCION, PRECIO
from PRODUCTOS p
join CATEGORIAS c on p.IDCATEGORIA = c.IDCATEG
join MARCAS m on p.IDMARCA = m.IDMARCA
go

--para verificar datos guardados
select p.IDPROD, p.IDCATEGORIA, c.CATEGORIA, p.IDMARCA, m.MARCA, p.DESCRIPCION, p.PRECIO
from PRODUCTOS p
join CATEGORIAS c on p.IDCATEGORIA = c.IDCATEG
join MARCAS m on p.IDMARCA = m.IDMARCA
go

create proc modificarProducto
@idprod int,
@idcat int,
@idmarca int,
@desc nvarchar(100),
@precio float
as
update PRODUCTOS set
IDCATEGORIA = @idcat,
IDMARCA = @idmarca,
DESCRIPCION = @desc,
PRECIO = @precio
where IDPROD = @idprod
go

create proc eliminarProducto
@idprod int
as
delete from PRODUCTOS
where IDPROD = @idprod