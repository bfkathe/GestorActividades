<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrearEvento.aspx.cs" Inherits="Gestor_Actividades.Vista.CrearEvento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Crear Evento</title>
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
                <h1>Crear evento</h1>
            </div>
            <br /><br />
            <div id="form2" class="auto-style1">
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Actividad&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DropDownList_VerActividades" runat="server" Height="16px" Width="129px">
                </asp:DropDownList>
                <br />
                <br />
                <asp:TextBox ID="txtBox_nombre" runat="server" Text="Nombre"></asp:TextBox><br /><br />
                <asp:TextBox ID="txtBox_horario" runat="server" Text="Horario"></asp:TextBox><br /><br />
                <asp:TextBox ID="txtBox_expositor" runat="server" Text="Expositor"></asp:TextBox><br /><br />
                <asp:TextBox ID="txtBox_descripcion" runat="server" Text="Descripción" Height="100px" Width="300px"></asp:TextBox><br /><br />
                <asp:Button ID="botonRegistrar" runat="server" Text="Registrar" CssClass="botones" />
                
                </div>
            
            <br />
            
        </div>
    </form>
</body>
</html>
