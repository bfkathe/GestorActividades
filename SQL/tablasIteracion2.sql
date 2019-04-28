----tablas de la segunda iteración----
use ProyectoGestorActividades

create table Participantes(
	ParticipanteId int identity(1,1) primary key,
	Apellido1 varchar(25) not null,
	Apellido2 varchar(25) not null,
	Nombre varchar(25) not null,
	Identidicacion int not null,
	Correo nvarchar(255) not null
);

select * from Participantes


create table Curso(
	CursoId int identity(1,1) primary key,
	Nombre nvarchar(255) not null,
	Numero int
);


create table ParticipantesxActividad(
	ParticipanteActividadId int identity(1,1) primary key,
	ParticipanteId int not null,
	ActividadId int not null,
	Asistencia bit not null, ---0 No, 1 Sí
	CursoId int,
	NumeroCurso int,
);

alter table ParticipantesxActividad add tipoParticipanteId int

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

--Llave de participante en participantes por actividad
alter table ParticipantesxActividad
add constraint FK_ParticipantePA
foreign key (ParticipanteId) references Participantes(ParticipanteId);

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
