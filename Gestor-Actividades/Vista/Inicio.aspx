<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Gestor_Actividades.Vista.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Inicio</title>
    <script type="text/javascript" language="javascript">

        function DisableBackButton() {
        window.history.forward()
        }
        DisableBackButton();
        window.onload = DisableBackButton;
        window.onpageshow = function(evt) { if (evt.persisted) DisableBackButton() }
        window.onunload = function() { void (0) }
    </script>
    <link href="../CSS/StyleSheet2.css" rel="stylesheet" runat="server" type="text/css" />
    <style type="text/css">
        .auto-style2 {
            height: 364px;
        }
        .auto-style3 {
            float: right;
            width: 123px;
            height: 114px;
        }
    </style>
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
        
        <div style="text-align: center; align: center" class="auto-style2">
            <br />
            <h1>Actividades</h1>
            <br />
            
            <div class= "row">
                <div class="column">
                <asp:CheckBoxList ID="CheckBoxList_Actividades" runat="server" RepeatDirection="Vertical" TextAlign="Left" CellSpacing="20" style="margin-left: 150px">
                    <asp:ListItem>Actividad 1</asp:ListItem>
                    <asp:ListItem>Actividad 2</asp:ListItem>
                </asp:CheckBoxList>
                </div>
                <div class="column">
                    <br /><br />
                    &nbsp;<br /><br />
                    <br />
                    <img id="imagen" src="/Imagenes/bombillo.png" style="margin-left:auto" class="auto-style3"><br />
                    <br /><br />
                    <br /><br />
                    <br /><br />
                    <br /><br />
                    <br /><br />
                    <asp:Button ID="ButtonVer" runat="server" Text="Ver" class="botones" OnClick="ButtonVer_Click"/>
                </div>
            </div>
            
        </div>
    </form>

       
</body>
</html>
