<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerActividades.aspx.cs" Inherits="Gestor_Actividades.Vista.VerActividades" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ver Actividades</title>
    <link href="../CSS/StyleSheet2.css" rel="stylesheet" />
    <script runat="server">
    </script>
    <style type="text/css">
        .auto-style1 {
            width: 417px;
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

        <div id="menuOpciones">
            <br />
            <asp:Button ID="botonCrearAct" runat="server" Text="Crear Actividad" CssClass="botones" OnClick="botonCrearAct_Click" /><br />
            <asp:Button ID="botonVerAct" runat="server" Text="Ver Actividades" CssClass="botones" OnClick="botonVerAct_Click" /><br />
            <asp:Button ID="botonCrearStaff" runat="server" Text="Crear Staff" CssClass="botones" OnClick="botonCrearStaff_Click" /><br />
            <asp:Button ID="botonDesinscribir" runat="server" Text="Desinscribir Participante" CssClass="botones" OnClick="botonDesinscribir_Click"/>
        </div>
        <div id="seccion" align="center">
            <br />
            <div id="titulo">
                <h1>Ver Actividades</h1>
            </div>
            <br />
            <div id="form3" align="center">
                <div style="font-weight:600;border:ridge" class="auto-style1">
                    <asp:CheckBoxList ID="CheckBoxList_Actividades" runat="server" RepeatDirection="Vertical" TextAlign="Right" CellSpacing="20">
                        <asp:ListItem>Actividad 1</asp:ListItem>
                        <asp:ListItem>Actividad 2</asp:ListItem>
                    </asp:CheckBoxList>
                </div>

                <br />
                <br />
                <asp:Button ID="botonEliminar" runat="server" Text="Eliminar" CssClass="botones" Width="170px" OnClick="botonEliminarActividad_Click" /><br />
                <br />
                <asp:Button ID="botonEditar" runat="server" Text="Editar" CssClass="botones" Width="170px" OnClick="botonEditarActividad_Click" OnClientClick="True" /><br />
                <br />
                <asp:Button ID="botonVerEventos" runat="server" Text="Eventos" CssClass="botones" Width="170px" OnClick="botonVerEventos_Click" /><br />
                <br />
                <asp:Button ID="botonArchivos" runat="server" Text="Archivos" CssClass="botones" Width="170px" OnClick="botonArchivos_Click" />
                <br />
                <br />
                <br />

                <br />
                <br />


            </div>
        </div>



    </form>
</body>
</html>
