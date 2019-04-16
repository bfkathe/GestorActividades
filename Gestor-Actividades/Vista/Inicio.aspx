<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Gestor_Actividades.Vista.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Inicio</title>
    <link href="../CSS/StyleSheet2.css" rel="stylesheet" runat="server" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            width: 268px;
        }
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
                <li style="font-size:large">Escuela de Ingeniería en Computación</li>
                <li style="font-size:large">Sistema Gestor de Actividades</li>
            </ul>
            <asp:Button ID="boton_inicioSesion" runat="server" Text="Iniciar Sesión" Style="background-color: #ffffff; margin-top: 15px; width: 150px; border-radius: 3px 4px" OnClick="boton_inicioSesion_Click" />
        </nav>

        <div style="text-align: center; align: center" class="auto-style2">
            <br />
            <h1>Actividades</h1>
            <br />
            <img id="imagen" src="/Imagenes/bombillo.png" style="margin-left:auto" class="auto-style3">
            <div style="font-weight: 600; border: ridge; margin:0 auto" class="auto-style1">
                <asp:CheckBoxList ID="CheckBoxList_Actividades" runat="server" RepeatDirection="Vertical" TextAlign="Right" CellSpacing="20">
                    <asp:ListItem>Actividad 1</asp:ListItem>
                    <asp:ListItem>Actividad 2</asp:ListItem>
                </asp:CheckBoxList>
            </div>
        </div>
    </form>

       
</body>
</html>
