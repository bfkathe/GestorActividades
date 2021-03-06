﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrearActividad.aspx.cs" Inherits="Gestor_Actividades.Vista.CrearActividad" %>

<!DOCTYPE html>
<script runat="server">
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Crear Actividad</title>
    <link href="/CSS/StyleSheet2.css" rel="Stylesheet" type="text/css"/>
    <style type="text/css">
        .auto-style2 {
            height: 646px;
        }
        .auto-style3 {
            float: left;
            width: 47%;
            max-height: 400px;
            height: 400px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <nav id="barraNav">
            <ul>
                <li style="font-size:large">Escuela de Ingeniería en Computación</li>
                <li style="font-size:large;margin-left:300px">Sistema Gestor de Actividades</li>
            </ul>
        </nav>

        <div id="menuOpciones"><br />
            <asp:Button ID="botonCrearAct" runat="server" Text="Crear Actividad" CssClass="botones" OnClick="botonCrearAct_Click"/><br />
            <asp:Button ID="botonVerAct" runat="server" Text="Ver Actividades" CssClass="botones" OnClick="botonVerAct_Click"/><br />
            <asp:Button ID="botonCrearStaff" runat="server" Text="Crear Staff" CssClass="botones" OnClick="botonCrearStaff_Click"/><br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="botonLogOut" runat="server" Text="Cerrar Sesión" CssClass="botones" Width="170px" OnClick="botonLogOut_Click" />
        </div>

        <div id="seccion" class="auto-style2"><br />
            <div id="titulo">
                <h1>Crear actividad</h1>
            </div>
            <br /><br /><br />

                <div class="row2">
                    <div class="auto-style3" style="padding-left:30px">
                        
                        Nombre de la actividad:
                        <br />
                        <br />
                        <asp:TextBox ID="txtBox_nombre" runat="server" Width="165px" style="margin-left: 150px"></asp:TextBox>
                        <br />
                        Campus/Centro Académico:
                        <br />
                        <br />
                        <asp:DropDownList ID="DropDownList_Campus" runat="server" Width="165px" style="margin-left: 150px">
                            <asp:ListItem>Campus Cartago</asp:ListItem>
                            <asp:ListItem>Campus San Carlos</asp:ListItem>
                            <asp:ListItem>CA San José</asp:ListItem>
                            <asp:ListItem>CA Alajuela</asp:ListItem>
                            <asp:ListItem>CA Limón</asp:ListItem>
                        </asp:DropDownList>
                        <br />
                        Lugar:
                        <br />
                        <br />
                        <asp:TextBox ID="txtBox_lugar" runat="server" Width="165px" style="margin-left: 150px"></asp:TextBox>
                        <br />
                        Fecha:
                        <br />
                        <br />
                        <asp:TextBox ID="txtBox_fecha" runat="server" placeholder="dd/mm/yyyy format only" Width="165px" style="margin-left: 150px"></asp:TextBox>
                        <br />
                        Horario:
                        <br />
                        <br />
                        <asp:TextBox ID="txtBox_horario" runat="server" Height="100px" Width="300px" style="margin-left: 100px"></asp:TextBox>
                        <br />

                    </div>
                    <div class="column2">
                        Cupo Reservado:
                        <asp:CheckBox ID="CheckBoxCupo" Text= " " runat="server" style="margin-left: 100px"/>
                        <br />
                        <br />
                        Cantidad de Cupos:
                        <br />
                        <br />
                        <asp:TextBox ID="txtBox_cantCupos" runat="server" Width="165px" style="margin-left: 150px"></asp:TextBox>
                        <br />
                        Descripcion:
                        <br />
                        <br />
                        <asp:TextBox ID="txtDescripcion" runat="server" Height="100px" Width="300px" style="margin-left: 100px"></asp:TextBox>
                        <br />
                        Encargados:
                        <br />
                        <br />
                        <asp:TextBox ID="txtEncargado" runat="server" Width="165px" style="margin-left: 150px"></asp:TextBox>
                        <br />
                        Imagen de Actividad: <asp:FileUpload ID="FileUpload1" runat="server" />
                        <br />
                        <br />
                        <asp:Button ID="botonRegistrar" runat="server" Text="Registrar" CssClass="botones" OnClick="botonRegistrar_Click" />
                     </div>
                </div>
            
        </div>
    </form>
</body>
</html>
