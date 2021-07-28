create database ALPAKA
USE ALPAKA


CREATE TABLE Usuarios(
	ID int identity (001,1),
	usuario varchar(30) not null,
	contrase�a varchar(30) not null,
	telefono varchar(15) null,
	direccion varchar(50) null,
	admin tinyint default  0,
	imagen varchar(100) null,
	constraint pk_Usuario Primary key clustered (ID)
)

CREATE TABLE Ventas(
 ID int identity(001,1),
 ID_Usuario int not null,
 total float not null,
 fecha date default getdate(),
 constraint pk_Venta Primary key clustered (ID)
)
CREATE TABLE Detalles(
	ID_Venta int not null,
	ID_producto int not null,
	cantidad int not null,
	constraint pk_Detalle Primary key clustered (ID_Venta,ID_producto)
)
create table Producto(
	ID int identity(001,1),
	nombre varchar(50) not null,
	talle varchar(150) not null,
	color varchar(30) not null,
	composicion varchar(15) not null,
	precio float not null,
	Categoria varchar(30) not null,
	sub_categoria varchar(30) not null,
	imagen varchar(100) null,
	stock int default 1,
	constraint pk_Producto Primary key clustered (ID)

)
CREATE TABLE Carrito(
	ID_Usuario int not null,
	ID_producto int not null,
	cantidad int not null,
	constraint pk_Carrito Primary key clustered (ID_Usuario,ID_producto)
	)
ALTER TABLE Carrito with check add constraint fk_Carrito_Producto foreign key(ID_producto) references Producto(ID)
ALTER TABLE Carrito with check add constraint fk_Carrito_Usuario foreign key(ID_Usuario) references Usuarios(ID)
ALTER TABLE Detalles with check add constraint fk_Detalle_Producto foreign key(ID_producto) references Producto(ID)
ALTER TABLE Detalles with check add constraint fk_Detalle_Venta foreign key(ID_Venta) references Ventas(ID)

Alter table Ventas with check add constraint fk_Ventas_Usuario foreign key (ID_Usuario) references Usuarios(ID)


insert into Usuarios(usuario,contrase�a,telefono,direccion,admin) values('---','123','---','---',1)
SELECT * FROM Usuarios where usuario = ''

insert into Producto values ('Remera larga Sara','XS','blanco','algodon',150,'mujeres','remeras','resources/ropa/mujeres/remeralarga_blanco_algodon_XS.jpg',10)
insert into Producto values ('Remera larga Uniqlo','S','negro','lino',300,'mujeres','remeras','resources/ropa/mujeres/remeralarga_negro_lino_S.jpg',10)
insert into Producto values ('Remera larga 47 Street','S','azul','algodon',150,'mujeres','remeras','resources/ropa/mujeres/remeralarga_azul_algodon_S.jpg',10)

insert into Producto values ('Pantalon de jean Boken','S','azul','jean',120,'mujeres','pantalones','resources/ropa/mujeres/pantalondejean_azul_jean_S.jpg',10)
insert into Producto values ('Pantalon de gabardina 47 Street','M','blaco','gabrdina',120,'mujeres','pantalones','resources/ropa/mujeres/pantalondegabardina_blanco_gabardina_M.jpg',10)
insert into Producto values ('Pantalon jogger Nike','S','gris','algodon',150,'mujeres','pantalones','resources/ropa/mujeres/pantalonjogger_gris_algodon_S.jpg',10)
insert into Producto values ('Pantalon de gabardina A+','M','rojo','algodon',150,'mujeres','pantalones','resources/ropa/mujeres/pantalondegabardina_rojo_gabardina_M.jpg',10)

insert into Producto values ('Remera con estampa Precious','XS','blanco','algodon',150,'hombre','remeras','resources/ropa/hombres/remeraconestampa_blanco_algodon_XS.jpg',10)
insert into Producto values ('Remera lisa','M','negro','algodon',200,'hombre','remeras','resources/ropa/hombres/remeralisa_negro_algodon_M.jpg',10)
insert into Producto values ('Remera con estampa zebra','S','gris','algodon',190,'hombre','remeras','resources/ropa/hombres/remeraconestampa_gris_algodon_S.jpg',10)

insert into Producto values ('Pantalon de jean Wrangler','S','negro','jean',140,'hombre','pantalones','resources/ropa/hombres/pantalondejean_negro_jean_S.jpg',10)
insert into Producto values ('Pantalon de jean abercrombie','S','azul','jean',150,'hombre','pantalones','resources/ropa/hombres/pantalondejean_azul_jean_S.jpg',10)
insert into Producto values ('Pantalon jogger','M','gris','jean',160,'hombre','pantalones','resources/ropa/hombres/pantalonjogger_gris_algodon_M.jpg',10)

insert into Producto values ('Perfume importado aqua','XL','aqua de gio','giorgio armani',1500,'accesorios','perfumes','resources/ropa/accesorios/perfumeimportadoaqua_aquadegio_giorgioarmani_XL.jpg',10)
insert into Producto values ('Perfume nacional','XL','Polo','Ralph Lauren',1400,'accesorios','perfumes','resources/ropa/accesorios/perfumenacional_polo_RalphLauren_XL.jpg',10)
insert into Producto values ('Perfume importado 212','M','212 vip','Carolina H.',1700,'accesorios','perfumes','resources/ropa/accesorios/perfumeimportado212_212vip_CarolinaHerrera_M.jpg',10)

insert into Producto values ('Anillo swarovski','15','dorado','oro',2500,'accesorios','bijouterie','resources/ropa/accesorios/anilloswarovski_dorado_oro_15.jpg',10)
insert into Producto values ('Collar cefora','12','dorado','oro',6000,'accesorios','bijouterie','resources/ropa/accesorios/collarcefora_dorado_oro_12.jpg',10)
insert into Producto values ('Set pulseras swarovski','13','dorado','oro',3400,'accesorios','bijouterie','resources/ropa/accesorios/setpulserasswarovski_dorado_oro_13.jpg',10)
insert into Producto values ('Pa�uelo de cuello','S','multicolor','algodon',1400,'accesorios','bijouterie','resources/ropa/accesorios/pa�uelodecuello_multicolor_algodon_S.jpg',1)
select * from Producto
select * from Ventas
select * from Detalle
select * from Usuarios

delete from Producto
delete from Detalles
delete from Ventas
delete from Usuarios
select * from Producto where nombre like('%'+'pan'+'%') and Categoria='hombre'

select * from Producto where nombre like('%'+'pan'+'%') and talle='S' and Categoria='hombre'

select * from Producto where talle='S' and Categoria='hombre'
select ID from Producto where nombre like( '%' + '"+  nombre  +"' + '%' ) and talle='" + strtalle + "' and Categoria='" + categoria + "'
delete from Ventas
insert into Detalles(ID_Venta,ID_producto,cantidad)	values(1,1,2)
select TOP 1 ID from Ventas order by ID DESC
select * from Producto where Categoria='mujeres' and sub_categoria='pantalones'
select * from Carrito
UPDATE Producto set stock=((select stock from Producto where nombre='remera lisa')-1) where nombre='remera lisa'
UPDATE Usuarios set imagen='hola' where usuario='--'

update Ventas set total= (select SUM(Producto.precio * Detalles.cantidad) from Producto INNER JOIN Detalles ON Detalles.ID_producto=Producto.ID AND Detalles.ID_Venta= 7)where Ventas.ID=7


insert into Carrito values(1,1,2)
select * from Carrito where ID_Usuario=(select ID from Usuarios where Usuarios.usuario='' )
select * from Carrito
delete from Carrito where ID_Usuario=(select ID from Usuarios where Usuarios.usuario='' )
insert into Carrito values((select ID from Usuarios where Usuarios.usuario=''),2,1)