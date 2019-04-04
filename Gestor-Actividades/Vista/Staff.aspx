<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="Gestor_Actividades.Vista.Staff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff</title>
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
                <h1>Crear usuarios de staff</h1>
            </div>
            <br /><br /><br />
            <div id="form2">
                Nombre: <asp:TextBox ID="txtBox_nombre" runat="server"></asp:TextBox><br /><br />
                Nombre Usuario: <asp:TextBox ID="txtBox_nombreUsuario" runat="server"/><br /><br />
                Contraseña: <asp:TextBox ID="txtBox_contrasenna" runat="server" TextMode="Password" /><br /><br />
                <asp:Button ID="botonStaffNuevo" runat="server" Text="Crear" CssClass="botones" OnClick="botonStaffNuevo_Click"/>
                <br /><br /><br /><br />
                <br />
                <br />
                <asp:Button ID="botonAsignarStaff" runat="server" Text="Asignar Staff-Actividad" CssClass="botones" OnClick="botonAsignarStaff_Click"/>
            </div>
            
        </div>
    </form>
</body>
</html>
