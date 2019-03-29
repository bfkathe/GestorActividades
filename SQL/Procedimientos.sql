--Procedimientos--
use ProyectoGestorActividades

go
create proc agregarStaff @nombre varchar(40),@nombreUsuario varchar(30),@contrasenna varchar(30)
as
begin
insert into Staff(Nombre,Usuario,Contraseña) values (@nombre,@nombreUsuario,@contrasenna)
end


exec agregarStaff 'katherina','kattbf','123'
