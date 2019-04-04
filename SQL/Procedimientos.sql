--Procedimientos--
use ProyectoGestorActividades


-----------Crear usuarios de Staff------------------
go
alter proc agregarStaff @nombre varchar(40),@nombreUsuario varchar(30),@contrasenna nvarchar(30)
as
begin
insert into Staff(Nombre,Usuario,Contraseña) values (@nombre,@nombreUsuario,ENCRYPTBYPASSPHRASE('password',@contrasenna)) --encriptacion
end

EXEC agregarStaff 'Katherina Bonilla','katherinabf','789'
EXEC agregarStaff 'Audra Rodriguez','audrar','123'
EXEC agregarStaff 'André Arroyo','andrearr','456'

------------Alterar columnas Contraseña para Staff y Usuarios-----------------
alter table Staff drop column Contraseña
alter table Staff add Contraseña varbinary(max)

alter table Usuarios drop column Contraseña
alter table Usuarios add Contraseña varbinary(max)


----------------Agregar Admin--------------------- 
go
create proc agregarUsuario @usuario varchar(30), @contrasenna nvarchar(30)
as
begin
insert into Usuarios(Usuario,Contraseña) values (@usuario,ENCRYPTBYPASSPHRASE('password',@contrasenna)) --encriptacion
end

exec agregarUsuario 'Admin','admin'


---------Verificar login de los usuarios (Admin)--------------
go
create proc verificarLoginUsuarios(@Usuario nvarchar(50),@Pass nvarchar(50))
as
begin
	Declare @PassCodificado As nvarchar(300)
    Declare @PassDecodificado As nvarchar(50)

	Select @PassCodificado = Contraseña From Usuarios Where Usuario = @Usuario
    Set @PassDecodificado = CONVERT(NVARCHAR,DECRYPTBYPASSPHRASE('password', @PassCodificado))

	select * from Usuarios where @PassDecodificado = @Pass and Usuario = @Usuario COLLATE SQL_Latin1_General_CP1_CS_AS
end
go

exec verificarLoginUsuarios 'Admin','admin'
go

---------Verificar login del Staff ------- (para después)
create proc verificarLoginStaff(@Usuario nvarchar(50),@Pass nvarchar(50))
as
begin
	Declare @PassCodificado As nvarchar(300)
    Declare @PassDecodificado As nvarchar(50)

	Select @PassCodificado = Contraseña From Staff Where Usuario = @Usuario
    Set @PassDecodificado = CONVERT(NVARCHAR,DECRYPTBYPASSPHRASE('password', @PassCodificado))

	select * from Staff where @PassDecodificado = @Pass and Usuario = @Usuario COLLATE SQL_Latin1_General_CP1_CS_AS
end
go

-------usuarios de staff unicos-----------
create proc staffUnico(@nombreUsuario varchar(40))
as
begin
	select * from Staff where Usuario = @nombreUsuario
end

exec staffUnico 'k'

-----------Arregla la tabla de Actividad--------------------
Alter table Actividades ADD CantCupos int
Alter table Actividades ADD Lugar varchar(50);
Alter table Actividades ADD Descripcion varchar(250);  

-----------Insertar Actividades----------------------------------------------

alter procedure insertarActividad(
	@Fecha date,
	@Nombre varchar(125),
	@Horario varchar(125),
	@Campus varchar(35),
	@Restriccion bit,
	@Encargado varchar(125),
	@cantCupos int,
	@lugar varchar(50),
	@Descripcion varchar(250)
)
AS 
insert into Actividades(Fecha,Nombre,Horario,Campus,Restriccion,Encargado,CantCupos,Lugar,Descripcion) values(@Fecha,@Nombre,@Horario,@Campus,@Restriccion,@Encargado,@cantCupos,@lugar,@Descripcion)
GO

exec insertarActividad '2019-03-29', 'Actividad1' , '5:00pm', 'Sede Cartago', 0, 'Audra Rodriguez', 28, 'Centro de las Artes', 'Descripcion'
exec insertarActividad '2019-03-30', 'Actividad2' , '5:00pm', 'Sede Cartago', 0, 'Audra Rodriguez', 28, 'Centro de las Artes', 'Descripcion'
exec insertarActividad '2019-03-30', 'Actividad3' , '5:00pm', 'Sede Cartago', 0, 'Audra Rodriguez', 28, 'Centro de las Artes', 'Descripcion'

-----------Editar Actividad----------------------------------------------
alter procedure editarActividad(
	@id int,
	@Fecha date,
	@Nombre varchar(125),
	@Horario varchar(125),
	@Campus varchar(35),
	@Restriccion bit,
	@Encargado varchar(125),
	@cantCupos int,
	@lugar varchar(50),
	@Despcripcion varchar(250)
)
AS 
UPDATE Actividades
SET Fecha = @Fecha,
	Nombre = @Nombre,
	Horario = @Horario,
	Campus = @Campus,
	Restriccion = @Restriccion,
	Encargado = @Encargado,
	CantCupos = @cantCupos,
	Lugar = @lugar,
	Descripcion = @Despcripcion
WHERE ActividadId = @id
GO

exec editarActividad 9,'2019-03-29', 'Actividad1' , '4:00pm', 'Sede SJ', 0, 'Audra Rodriguez Mora', 27, 'Casa Verde', 'Descripcion'

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
ALTER TABLE Eventos DROP COLUMN Fecha
Alter table Eventos ADD Horario varchar(150)
Alter table Eventos ADD ActividadId int; 
Alter table Eventos ADD FOREIGN KEY (ActividadId) REFERENCES Actividades(ActividadId); 
-----------Insertar Eventos----------------------------------------------

alter procedure insertarEvento(
	@idActividad int,
	@Nombre varchar(125),
	@Horario varchar(50),	
	@Expositor varchar(125),
	@Descripcion varchar(150)
)
AS 
insert into Eventos(ActividadId,Nombre,Horario,Expositor,Descripcion) values(@idActividad,@Nombre,@Horario,@Expositor,@Descripcion)
GO

exec insertarEvento 'Evento1', '2019-03-29', 'Audra Rodriguez', 'Conferencia'

-----------Editar Actividad----------------------------------------------
alter procedure editarEvento(
	@id int,
	@Nombre varchar(125),
	@Horario varchar(125),
	@Expositor varchar(125),
	@Descripcion varchar(150)
)
AS 
UPDATE Eventos
SET Horario = @Horario,
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

drop table EventosxActividad

select * from Eventos

----CORRER ESTA PARTE---------------------------------------------------------------------
ALTER TABLE Eventos
DROP CONSTRAINT FK__Eventos__Activid__45F365D3

Alter table Eventos ADD FOREIGN KEY (ActividadId) REFERENCES Actividades(ActividadId) ON DELETE CASCADE; 

SELECT * FROM sys.objects WHERE type_desc LIKE '%CONSTRAINT'


go
create proc staffXActividadProc (@idActividad int, @idStaff int)
as
begin
insert into StaffxActividad(ActividadId,StaffId) values (@idActividad,@idStaff)
end


exec staffXActividadProc 1,2

----ARCHIVOS------------------------------
Drop table ArhivosxActividad

Alter table Archivos DROP Column Archivo

Alter table Archivos ADD Name nvarchar(50)
Alter table Archivos ADD FileType nvarchar(50)
Alter table Archivos ADD Data varbinary(MAX)
Alter table Archivos ADD ActividadId int; 
Alter table Archivos ADD FOREIGN KEY (ActividadId) REFERENCES Actividades(ActividadId) ON DELETE CASCADE; 

create procedure agregarArchivo(
	@Name nvarchar(50),
	@FileType nvarchar(50),
	@Data varbinary(MAX),
	@ActividadId int
)
AS
	insert into Archivos(Name,FileType,Data,ActividadId) Values(@Name,@FileType,@Data,@ActividadId)
GO

create procedure eliminarArchivo(
	@id int
)
AS
	DELETE FROM Archivos WHERE ArchivoId = @id
GO


