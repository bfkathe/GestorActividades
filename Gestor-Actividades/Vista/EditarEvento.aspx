﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditarEvento.aspx.cs" Inherits="Gestor_Actividades.Vista.EditarEvento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Editar Evento</title>
    <link href="/CSS/StyleSheet1.css" rel="Stylesheet" type="text/css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div id="menuOpciones"><br />
            <asp:Button ID="botonCrearAct" runat="server" Text="Crear Actividad" CssClass="botones" OnClick="botonCrearAct_Click"/><br />
            <asp:Button ID="botonVerAct" runat="server" Text="Ver Actividades" CssClass="botones" OnClick="botonVerAct_Click"/><br />
            <asp:Button ID="botonCrearStaff" runat="server" Text="Crear Staff" CssClass="botones" OnClick="botonCrearStaff_Click"/>
        </div>

        <div id="seccion" class="auto-style2"><br />
            <div id="titulo">
                <h1>Editar evento</h1>
            </div>
            <br /><br /><br />
            <div id="form2" class="auto-style1">
                <asp:TextBox ID="txtBox_nombre" runat="server" Text="Nombre"></asp:TextBox><br /><br />
                <asp:TextBox ID="txtBox_horario" runat="server" Text="Horario"></asp:TextBox><br /><br />
                <asp:TextBox ID="txtBox_expositor" runat="server" Text="Expositor"></asp:TextBox><br /><br />
                <asp:TextBox ID="txtBox_descripcion" runat="server" Text="Descripción" Height="100px" Width="300px"></asp:TextBox><br /><br />
                <asp:Button ID="botonGuardarCambios" runat="server" Text="Guardar cambios" CssClass="botones" />
                
                </div>
            
        </div>
    </form>
</body>
</html>