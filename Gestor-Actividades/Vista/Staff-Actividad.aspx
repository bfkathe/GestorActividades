<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Staff-Actividad.aspx.cs" Inherits="Gestor_Actividades.Vista.Staff_Actividad" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff de actividad</title>
    <link href="/CSS/StyleSheet2.css" rel="Stylesheet" type="text/css" />
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

        <div id="seccion" class="auto-style2">
            <br />
            <div id="titulo">
                <h1>Staff de actividad</h1>
            </div>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <h2 style="margin-left: 120px">Actividades&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Staff</h2><br />
            <div id="listas" align="center">
                <div class="row">
                    <div class="column">
                        <asp:CheckBoxList ID="CheckBoxList_Actividades" runat="server" OnSelectedIndexChanged="CheckBoxList_Actividades_SelectedIndexChanged" CellSpacing="30" TextAlign="Right">
                        </asp:CheckBoxList>
                    </div>
                    <div class="column">
                        <asp:CheckBoxList ID="CheckBoxList_Staff" runat="server" CellSpacing="30" TextAlign="Right">
                        </asp:CheckBoxList>
                        
                    </div>
                </div>
                <asp:Button ID="botonConfirmar" runat="server" Text="Confirmar" CssClass="botones" OnClick="botonConfirmar_Click" />
            </div>
            <br />
        </div>
    </form>
</body>
</html>
