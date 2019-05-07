<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Desinscribir.aspx.cs" Inherits="Gestor_Actividades.Vista.Desinscribir" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Desinscribir Participante</title>
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
                <h1>Desinscribir Participante</h1>
            </div>
            <br /><br />

            <div class="row">
                <div class=column>
                    <asp:CheckBoxList ID="CheckBoxList_Participantes" runat="server" RepeatDirection="Vertical" TextAlign="Right" CellSpacing="20">
                        <asp:ListItem>Participante 1</asp:ListItem>
                        <asp:ListItem>Participante 2</asp:ListItem>
                    </asp:CheckBoxList>
                </div>
               <div class=column>
                   <br />
                   <br />
                   <br />
                   <br />
                   <br />
                   <br />
                   <asp:Button ID="botonDesinscribir" runat="server" Text="Desinscribir" CssClass="botones" Width="170px" OnClick="botonDesinscribirParticipante_Click" />
                </div>
                <br />
                <br />
                <br /><br />
                <br /><br />
                
            </div> 
        </div>
           

             
            
    </form>
</body>
</html>
