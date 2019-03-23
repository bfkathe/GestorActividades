<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="Gestor_Actividades.Vista.Staff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff</title>
    <link href="/CSS/StyleSheet1.css" rel="Stylesheet" type="text/css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div id="menuOpciones"><br />
            <button>Crear actividades</button><br/><br />
            <button>Crear usuarios de Staff</button><br />
        </div>

        <div id="lugar"><br />
            <div id="titulo">
                <h1>Crear usuarios de staff</h1>
            </div>
            <br /><br /><br />
            <div id="form2">
                <input name="nombre" type="text" value="Nombre"/><br /><br />
                <input name="nombreUsuario" type="text" value="Nombre de usuario" /><br /><br />
                <input name="contrasenna" type="password" /><br /><br />
                <button>Registrar</button>
            </div>
            
        </div>
    </form>
</body>
</html>
