<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ActividadesXParticipante.aspx.cs" Inherits="Gestor_Actividades.Vista.ActividadesXParticipante" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Actividades por participante</title>
    <link href="../CSS/StyleSheet2.css" rel="stylesheet" runat="server" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <nav id="barraNav">
            <ul>
                <li><img src="../Imagenes/engranaje.png" width="30px" height="30px"/>&nbsp;&nbsp;&nbsp; </li>
                <li style="font-size:large">Escuela de Ingeniería en Computación</li>  
                <li style="font-size:large;padding-left:300px">&nbsp; Sistema Gestor de Actividades&nbsp;&nbsp;</li>              
            </ul>
        </nav>
        <div id="menuInicio" style="background-color:#adadad;margin:0;width:auto;height:40px">
            <ul>
                <li><a href="Inicio.aspx">Inicio</a></li>
                <li><a href="ActividadesXParticipante.aspx">Actividades por participante</a></li>
                <li><a href="Login.aspx">Iniciar Sesión</a></li>
            </ul>
        </div>
        <div align="center">
            <br>
            <h3>Carné/Identificación</h3>
            <asp:TextBox ID="txt_ID" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="botonBuscar" runat="server" Text="Buscar" CssClass="botones" OnClick="botonBuscar_Click" Height="35px" Width="130px" float="left"/><br /><br />
            <asp:ListBox ID="ListBox_Actividades" runat="server" Width ="297px" Height ="94px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
