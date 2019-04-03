<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerActividades.aspx.cs" Inherits="Gestor_Actividades.Vista.VerActividades" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ver Actividades</title>
    <link href="../CSS/StyleSheet1.css" rel="stylesheet" />
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
                <h1>Ver Actividades</h1>
            </div>
            <br />
            <div id="form2">             
                <table align="center" style="text-align:left;margin:auto;">
                    <tr>
                        <td>
                            <asp:CheckBoxList ID="CheckBoxList_Actividades" runat="server" OnSelectedIndexChanged="CheckBoxList_Actividades_SelectedIndexChanged" Width="361px" CellSpacing="30" TextAlign="Left">
                                <asp:ListItem>Actividad 1</asp:ListItem>
                                <asp:ListItem>Actividad 2</asp:ListItem>
                            </asp:CheckBoxList>
                        </td>
                    </tr>
                </table>
                <br /><br />
                <asp:Button ID="botonEliminar" runat="server" Text="Eliminar" CssClass="botones" Width="170px"  OnClick ="botonEliminarActividad_Click"/><br /><br />
                <asp:Button ID="botonEditar" runat="server" Text="Editar" CssClass="botones" Width="170px" OnClick="botonEditarActividad_Click" OnClientClick="True"/><br /><br />
                <asp:Button ID="botonVerEventos" runat="server" Text="Eventos" CssClass="botones" Width="170px" OnClick="botonVerEventos_Click"/> 
            <br /><br /><br />
            <div id="form2" aria-orientation="vertical">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:CheckBoxList ID="CheckBoxList_Actividades" runat="server" Width="82px">
                    <asp:ListItem>Actividad 1</asp:ListItem>
                    <asp:ListItem>Actividad 2</asp:ListItem>
                </asp:CheckBoxList>
                <asp:Button ID="botonEliminar" runat="server" Text="Eliminar" CssClass="botones" Width="100px"  OnClick ="botonEliminarActividad_Click"/><br /><br />
                <asp:Button ID="botonEditar" runat="server" Text="Editar" CssClass="botones" Width="100px" OnClick="botonEditarActividad_Click" OnClientClick="True"/><br /><br />
                <asp:Button ID="botonVerEventos" runat="server" Text="Eventos" CssClass="botones" Width="100px" OnClick="botonVerEventos_Click"/> 
                <br />
                <asp:Button ID="botonArchivos" runat="server" Text="Archivos" CssClass="botones" Width="100px" OnClick="botonArchivos_Click"/> 
            </div>
            
        </div>
    </form>
</body>
</html>
