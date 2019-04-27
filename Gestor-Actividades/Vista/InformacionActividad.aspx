<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InformacionActividad.aspx.cs" Inherits="Gestor_Actividades.Vista.InformacionActividad" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Información de Actividad</title>
    <link href="../CSS/StyleSheet2.css" rel="stylesheet" runat="server" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <nav id="barraNav">
            <ul>
                <li style="font-size:large">Escuela de Ingeniería en Computación</li>
                <li style="font-size:large;margin-left:300px">Sistema Gestor de Actividades</li>
            </ul>
            
           <asp:Button ID="boton_inicioSesion" runat="server" Text="Iniciar Sesión" Style="background-color: #ffffff; margin-top: 18px; width: 150px; border-radius: 3px 4px;margin-left:450px" OnClick="boton_inicioSesion_Click" />
        </nav>

        <div align="center">
            <br>
            <asp:Image ID="imagenActividad" runat="server" src="/Imagenes/actividad.jpg" Width="350px" Height="500px"/>
            <br />
            <asp:TextBox ID="txt_informacion" runat="server" Height="146px" Width="218px" BorderStyle="Dotted" TextMode="MultiLine"></asp:TextBox>
            <br /><br />
            <asp:Button ID="boton_Inscripcion" runat="server" Text="Inscripción" CssClass="botones" Width="120px"/>
        </div>
        
    </form>
</body>
</html>
