use ProyectoGestorActividades;

create table Actividades(
	ActividadId int identity(1,1) primary key,
	Fecha date not null,
	Nombre varchar(125) not null,
	Horario varchar(125) not null,
	Campus varchar(35) not null,
	Restriccion bit not null,
	Encargado varchar(125) not null
);

create table Eventos(
	EventosId int identity(1,1) primary key,
	Nombre varchar(125) not null,
	Fecha date not null,
	Expositor varchar(125) not null
);

create table EventosxActividad(
	EventosActividadId int identity(1,1) primary key,
	ActividadId int not null,
	EventoId int not null
);


create table Staff(
	StaffId int identity(1,1) primary key,
	Nombre varchar(40) not null,
	Usuario varchar(30) not null,
	Contraseña varchar(30) not null
);

create table StaffxActividad(
	StaffActividadId int identity(1,1) primary key,
	ActividadId int not null,
	StaffId int not null
);

create table Usuarios(
	UsuarioId int identity(1,1) primary key,
	Usuario varchar(30) not null,
	Contraseña varchar(30) not null
);

create table Archivos(
	ArchivoId int identity(1,1) primary key,
	Archivo binary
);

create table ArhivosxActividad(
	ArchivosActividadId int identity(1,1) primary key,
	ActividadId int not null,
	ArchivoId int not null
);

--Llaves foraneas

--Llave de actividad en eventos por actividad
alter table EventosxActividad
add constraint FK_ActividadEA
foreign key (ActividadId) references Actividades(ActividadId);

--Llave de evento en eventos por actividad
alter table EventosxActividad
add constraint FK_EventoEA
foreign key (EventoId) references Eventos(EventosId);

--Llave de actividad en staff por actividad
alter table StaffxActividad
add constraint FK_ActividadSA
foreign key (ActividadId) references Actividades(ActividadId);

--Llave de staff en staff por actividad
alter table StaffxActividad
add constraint FK_StaffSA
foreign key (StaffId) references Staff(StaffId);

--Llave de actividad en archivos por actividad
alter table ArhivosxActividad
add constraint FK_ActividadAA
foreign key (ActividadId) references Actividades(ActividadId);

--Llave de archivos en archivos por actividad
alter table ArhivosxActividad
add constraint FK_ArchivosAA
foreign key (ArchivoId) references Archivos(ArchivoId);