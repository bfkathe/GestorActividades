<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Gestor_Actividades.Vista.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gestor de Actividades</title>
    <link href="/CSS/StyleSheet1.css" rel="Stylesheet" type="text/css"/>
 
</head>
<body>
    <form id="form1" runat="server">
        <div id="titulo">
            <h1 align="center">Escuela de Ingeniería en Computación</h1>
        </div>

        <h2 align="center">Gestor de Actividades</h2>
        <img id="imagen" src="/Imagenes/imagen.png" height="150px" width="150px">

        <div id="form" align="center">
            <asp:TextBox ID="txtBox_username" runat="server" Text="Username"></asp:TextBox><br>
            <br>
            <asp:TextBox ID="txtBox_password" runat="server" TextMode="Password"></asp:TextBox><br>
            <br>
            <asp:Button ID="botonLogIn" runat="server" Text="LogIn" CssClass="botones" OnClick="botonLoggear_Click"/>
        </div>
    </form>
</body>
</html>
