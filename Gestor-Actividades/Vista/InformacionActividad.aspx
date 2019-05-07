<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InformacionActividad.aspx.cs" Inherits="Gestor_Actividades.Vista.InformacionActividad" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Información de Actividad</title>
    <link href="../CSS/StyleSheet2.css" rel="stylesheet" runat="server" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            margin-top: 41px;
        }
    </style>
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

        <div align="center" class="auto-style1">
            <br>
            <asp:Image ID="Image1" runat="server" width="350" Height="500px"/>
            <br />
            <asp:TextBox ID="txt_informacion" runat="server" Height="146px" Width="300px" BorderStyle="Dotted" TextMode="MultiLine" ></asp:TextBox>
            <br /><br />
            <asp:Button ID="boton_Inscripcion" runat="server" Text="Inscripción" CssClass="botones" Width="120px" OnClick="boton_Inscripcion_Click"/>
            <br />        
        </div>
        
    </form>
</body>
</html>
