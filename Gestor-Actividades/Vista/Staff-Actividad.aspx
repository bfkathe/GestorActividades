<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Staff-Actividad.aspx.cs" Inherits="Gestor_Actividades.Vista.Staff_Actividad" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff de actividad</title>
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
                <h1>Staff de actividad</h1>
            </div>
            <br /><br />
            <div id="listas" align="center">
                <table align="center">
                    <tr>
                        <th>Actividades</th>
                        <th></th>
                        <th>Usuarios de Staff</th>
                    </tr>
                    <tr>                      
                        <td>
                            <asp:CheckBoxList ID="CheckBoxList_Actividades" runat="server" OnSelectedIndexChanged="CheckBoxList_Actividades_SelectedIndexChanged" CellSpacing="30" TextAlign="Left">                           
                            </asp:CheckBoxList>
                        </td>
                        <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>

                        <td>
                            <asp:CheckBoxList ID="CheckBoxList_Staff" runat="server" CellSpacing="30" TextAlign="Left">
                                
                            </asp:CheckBoxList>
                      </td>
                    </tr>
                </table> 
                <br /><br />
                <asp:Button ID="botonConfirmar" runat="server" Text="Confirmar" CssClass="botones" OnClick="botonConfirmar_Click"/>
                
            </div>            
            <br />
        </div>
    </form>
</body>
</html>
