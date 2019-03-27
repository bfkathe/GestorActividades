<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerEventos.aspx.cs" Inherits="Gestor_Actividades.Vista.VerEventos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Eventos de Actividad</title>
    <link href="/CSS/StyleSheet1.css" rel="Stylesheet" type="text/css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div id="menuOpciones"><br />
            <asp:Button ID="botonCrearAct" runat="server" Text="Crear Actividad" CssClass="botones" OnClick="botonCrearAct_Click"/><br />
            <asp:Button ID="botonVerAct" runat="server" Text="Ver Actividades" CssClass="botones" OnClick="botonVerAct_Click"/><br />
            <asp:Button ID="botonCrearStaff" runat="server" Text="Crear Staff" CssClass="botones" OnClick="botonCrearStaff_Click"/>
        </div>

        <div id="seccion"><br />
            <div id="titulo">
                <h1>Eventos</h1>
            </div>
            <br /><br /><br />
            <div id="form2">
                <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                    <asp:ListItem>Evento 1</asp:ListItem>
                    <asp:ListItem>Evento 2</asp:ListItem>
                </asp:CheckBoxList><br /><br />
                <asp:Button ID="botonAgregarEvento" runat="server" Text="Agregar" CssClass="botones" Width="100px" OnClick="botonAgregarEvento_Click"/> <br /><br />
                <asp:Button ID="botonEliminarEvento" runat="server" Text="Eliminar" CssClass="botones" Width="100px"/><br /><br />
                <asp:Button ID="botonEditarEvento" runat="server" Text="Editar" CssClass="botones" Width="100px" OnClick="botonEditarEvento_Click"/><br /><br />
                
            </div>
            
        </div>

        
    </form>
</body>
</html>
