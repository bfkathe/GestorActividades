<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerArchivos.aspx.cs" Inherits="Gestor_Actividades.Vista.VerArchivos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Archivos de Actividad</title>
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
                <h1>Archivos</h1>
            </div>
            <br /><br /><br />
            <div id="form2">
                <asp:CheckBoxList ID="CheckBoxList_Archivos" runat="server">
                    <asp:ListItem>Archivo 1</asp:ListItem>
                    <asp:ListItem>Archivo 2</asp:ListItem>
                </asp:CheckBoxList>
                <br />
                <label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:FileUpload ID="FileUpload_VerArchivos" runat="server" OnDataBinding="FileUpload_VerArchivos_DataBinding" />
                </label>
                <p style="margin-left: 40px">
                <br />
                </p>
                <asp:Button ID="btn_EliminarArchivo" runat="server" CssClass="botones" OnClick="btn_EliminarArchivo_Click" Text="Eliminar" Width="101px" />
                <br />
                <br /><br />
                
            </div>
            
        </div>
    </form>
</body>
</html>
