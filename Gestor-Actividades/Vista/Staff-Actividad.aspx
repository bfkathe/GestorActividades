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
            <asp:Button ID="botonDesinscribir" runat="server" Text="Desinscribir Participante" CssClass="botones" OnClick="botonDesinscribir_Click"/>
        </div>

        <div id="seccion" class="auto-style2">
            <br />
            <div id="titulo">
                <h1>Staff de actividad</h1>
            </div>
            <br />
            <br />
            <div id="listas" align="center">
                <table align="center" style="border:solid #808080">
                    <tr>
                        <th style="background-color:#808080;font-size:large">Actividades</th>
                        <th style="background-color:#808080"></th>
                        <th style="background-color:#808080;font-size:large">Usuarios de Staff</th>
                    </tr>
                    <tr>
                        <td>
                            <asp:CheckBoxList ID="CheckBoxList_Actividades" runat="server" OnSelectedIndexChanged="CheckBoxList_Actividades_SelectedIndexChanged" CellSpacing="30" TextAlign="Right">
                            </asp:CheckBoxList>
                        </td>
                        <td style="background-color:#808080">&nbsp;</td>
                        <td>
                            <asp:CheckBoxList ID="CheckBoxList_Staff" runat="server" CellSpacing="30" TextAlign="Right">
                            </asp:CheckBoxList>
                        </td>
                    </tr>
                </table>
                <br />
                <br />
                <asp:Button ID="botonConfirmar" runat="server" Text="Confirmar" CssClass="botones" OnClick="botonConfirmar_Click" />
            </div>
            <br />
        </div>
    </form>
</body>
</html>
