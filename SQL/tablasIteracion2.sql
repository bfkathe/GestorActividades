----tablas de la segunda iteración----
use ProyectoGestorActividades

create table Curso(
	CursoId int identity(1,1) primary key,
	Nombre nvarchar(255) not null,
	Numero int
);

create table ParticipantesxActividad(
	ParticipanteActividadId int identity(1,1) primary key,
	ActividadId int not null,
	Asistencia bit not null default 0, ---0 No, 1 Sí
	CursoId int,
);


alter table ParticipantesxActividad add tipoParticipanteId int
alter table ParticipantesxActividad add Apellido1 varchar(25)
alter table ParticipantesxActividad add Apellido2 varchar(25)
alter table ParticipantesxActividad add Nombre varchar(25)
alter table ParticipantesxActividad add Identificacion int
alter table ParticipantesxActividad add Correo varchar(255)

create table TipoParticipante(
	TipoId int identity(1,1) primary key,
	Nombre varchar(30)
);


--Llaves foraneas

--Llave de actividad en participantes por actividad
alter table ParticipantesxActividad
add constraint FK_ActividadPA
foreign key (ActividadId) references Actividades(ActividadId);

--Llave de curso en participantes por actividad
alter table ParticipantesxActividad
add constraint FK_CursoPA
foreign key (CursoId) references Curso(CursoId);

--Llave de tipo en participantes por actividad
alter table ParticipantesxActividad
add constraint FK_TipoPA
foreign key (tipoParticipanteId) references TipoParticipante(TipoId);


--------Insertar en Tipo de Participante---------------

create procedure insertarTipos(
	@Nombre varchar(125)

)
AS 
insert into TipoParticipante(Nombre) values(@Nombre)
GO

exec insertarTipos 'Estudiante'
exec insertarTipos 'Externo'
exec insertarTipos 'Profesor'

--------Insertar en Cursos---------------

create procedure insertarCursos(
	@Nombre varchar(125),
	@Numero int

)
AS 
insert into Curso(Nombre,Numero) values(@Nombre,@Numero)
GO

exec insertarCursos 'Proyecto',1
exec insertarCursos 'Diseño de Software',1
exec insertarCursos 'Administración de Proyectos',3

create table Pruebas(
	Nombre varchar(125)
);
