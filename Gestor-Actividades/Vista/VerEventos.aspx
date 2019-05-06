<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerEventos.aspx.cs" Inherits="Gestor_Actividades.Vista.VerEventos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Eventos de Actividad</title>
    <link href="/CSS/StyleSheet2.css" rel="Stylesheet" type="text/css"/>
    <style type="text/css">
        .auto-style3 {
            width: 401px;
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
        </div>

        <div id="seccion" align="center"><br />
            <div id="titulo">
                <h1>Eventos</h1>
            </div>
            <br />
            <div id="form2">

                <div style="font-weight: 600; border: ridge" class="auto-style3" align="center">
                    <asp:CheckBoxList ID="CheckBoxList_Eventos" runat="server" RepeatDirection="Vertical" TextAlign="Right" CellSpacing="20">
                        <asp:ListItem>Evento 1</asp:ListItem>
                        <asp:ListItem>Evento 2</asp:ListItem>
                    </asp:CheckBoxList>
                </div>

                <br />
                <br />
                <asp:Button ID="botonAgregarEvento" runat="server" Text="Agregar" CssClass="botones" Width="170px" OnClick="botonAgregarEvento_Click"/> <br /><br />
                <asp:Button ID="botonEliminarEvento" runat="server" Text="Eliminar" CssClass="botones" Width="170px" OnClick="botonEliminarEvento_Click"/><br /><br />
                <asp:Button ID="botonEditarEvento" runat="server" Text="Editar" CssClass="botones" Width="170px" OnClick="botonEditarEvento_Click"/><br /><br />
                
            </div>

             
            
        </div>

        
    </form>
</body>
</html>
