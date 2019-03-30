--Procedimientos--
use ProyectoGestorActividades

go
create proc agregarStaff @nombre varchar(40),@nombreUsuario varchar(30),@contrasenna varchar(30)
as
begin
insert into Staff(Nombre,Usuario,Contraseña) values (@nombre,@nombreUsuario,@contrasenna)
end


exec agregarStaff 'katherina','kattbf','123'

-----------Arregla la tabla de Actividad--------------------
Alter table Actividades ADD CantCupos int

-----------Insertar Actividades----------------------------------------------

alter procedure insertarActividad(
	@Fecha date,
	@Nombre varchar(125),
	@Horario varchar(125),
	@Campus varchar(35),
	@Restriccion bit,
	@Encargado varchar(125),
	@cantCupos int
)
AS 
insert into Actividades(Fecha,Nombre,Horario,Campus,Restriccion,Encargado,CantCupos) values(@Fecha,@Nombre,@Horario,@Campus,@Restriccion,@Encargado,@cantCupos)
GO

exec insertarActividad '2019-03-29', 'Actividad1' , '5:00pm', 'Sede Cartago', 0, 'Audra Rodriguez', 28

-----------Editar Actividad----------------------------------------------
create procedure editarActividad(
	@id int,
	@Fecha date,
	@Nombre varchar(125),
	@Horario varchar(125),
	@Campus varchar(35),
	@Restriccion bit,
	@Encargado varchar(125),
	@cantCupos int
)
AS 
UPDATE Actividades
SET Fecha = @Fecha,
	Nombre = @Nombre,
	Horario = @Horario,
	Campus = @Campus,
	Restriccion = @Restriccion,
	Encargado = @Encargado,
	CantCupos = @cantCupos
WHERE ActividadId = @id
GO

exec editarActividad 1,'2019-03-29', 'Actividad1' , '4:00pm', 'Sede SJ', 0, 'Audra Rodriguez Mora', 27

---------------------Eliminar Actividad----------------------------------
create procedure eliminarActividad(
	@id int
)
AS 
DELETE FROM Actividades WHERE ActividadId = @id
GO

exec eliminarActividad 1

-----------Arregla la tabla de eventos--------------------
Alter table Eventos ADD Descripcion varchar(150)

-----------Insertar Eventos----------------------------------------------

create procedure insertarEvento(
	@Nombre varchar(125),
	@Fecha date,	
	@Expositor varchar(125),
	@Descripcion varchar(150)
)
AS 
insert into Eventos(Nombre,Fecha,Expositor,Descripcion) values(@Nombre,@Fecha,@Expositor,@Descripcion)
GO

exec insertarEvento 'Evento1', '2019-03-29', 'Audra Rodriguez', 'Conferencia'

-----------Editar Actividad----------------------------------------------
create procedure editarEvento(
	@id int,
	@Nombre varchar(125),
	@Fecha date,
	@Expositor varchar(125),
	@Descripcion varchar(150)
)
AS 
UPDATE Eventos
SET Fecha = @Fecha,
	Nombre = @Nombre,
	Expositor = @Expositor,
	Descripcion = @Descripcion
WHERE EventosId = @id
GO

exec editarEvento 1,'Evento1', '2019-03-29', 'Audra Rodriguez Mora', 'Conferencia Nueva'

---------------------Eliminar Actividad----------------------------------
create procedure eliminarEvento(
	@id int
)
AS 
DELETE FROM Eventos WHERE EventosId = @id
GO

exec eliminarEvento 1


