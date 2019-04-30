<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Gestor_Actividades.Vista.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gestor de Actividades</title>
    <link href="/CSS/StyleSheet2.css" rel="Stylesheet" type="text/css"/>
 
</head>
<body>
    <form id="form1" runat="server">
        <nav id="barraNav">
            <ul>
                <li><img src="../Imagenes/engranaje.png" width="30px" height="30px"/>&nbsp;&nbsp;&nbsp; </li>
                <li style="font-size:large">Escuela de Ingeniería en Computación</li>  
                <li style="font-size:large;padding-left:260px">&nbsp; Sistema Gestor de Actividades&nbsp;&nbsp;</li>              
            </ul>
        </nav>
        <div id="menuInicio" style="background-color:#adadad;margin:0;width:auto;height:40px">
            <ul>
                <li><a href="Inicio.aspx">Inicio</a></li>
                <li><a href="ActividadesXParticipante.aspx">Actividades por participante</a></li>
                <li><a href="Login.aspx">Iniciar Sesión</a></li>
            </ul>
        </div>


        <h2 align="center">Módulo administrativo</h2>
        <img id="imagen" src="/Imagenes/imagen.png" height="150px" width="150px">

        <div id="form" align="center">
            <br />
            <asp:TextBox ID="txtBox_username" runat="server" Text="Username"></asp:TextBox><br>
            <br>
            <asp:TextBox ID="txtBox_password" runat="server" TextMode="Password"></asp:TextBox><br>
            <br>
            <asp:Button ID="botonLogIn" runat="server" Text="Ingresar" CssClass="botones" Width="120px" Height="35px" OnClick="botonLoggear_Click"/>
        </div>
    </form>
</body>
</html>
