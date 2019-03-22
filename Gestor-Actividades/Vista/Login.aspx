<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Gestor_Actividades.Vista.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gestor de Actividades</title>
    <link href="/CSS/StyleSheet1.css" rel="Stylesheet" type="text/css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="contenido">
            <h1 align="center">Escuela de Ingeniería en Computación</h1>
        </div>
        <h2 align="center">Gestor de Actividades</h2>
        <img id="imagen" src="/Imagenes/imagen.png" height="150px" width="150px">

        <div class="form" align="center">
            <input type="text" name="username" value="Username"><br>
            <br>
            <input type="password" name="password" value="Password"><br>
            <br>
            <input type="submit" value="Log In">
        </div>
    </form>
</body>
</html>
