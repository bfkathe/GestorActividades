<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrearEvento.aspx.cs" Inherits="Gestor_Actividades.Vista.CrearEvento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Crear Evento</title>
    <link href="/CSS/StyleSheet2.css" rel="Stylesheet" type="text/css"/>
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

        <div id="seccion" class="auto-style2"><br />
            <div id="titulo">
                <h1>Crear evento</h1>
            </div>
            <br /><br />
            <div id="form2" class="auto-style1">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <br />
                Nombre: <asp:TextBox ID="txtBox_nombre" runat="server" ></asp:TextBox><br /><br />
                Horario: <asp:TextBox ID="txtBox_horario" runat="server" Height="100px" Width="300px"></asp:TextBox><br /><br />
                Expositor: <asp:TextBox ID="txtBox_expositor" runat="server" ></asp:TextBox><br /><br />
                Descripcion: <asp:TextBox ID="txtBox_descripcion" runat="server" Height="100px" Width="300px"></asp:TextBox><br /><br />
                <asp:Button ID="botonRegistrar" runat="server" Text="Registrar" CssClass="botones" OnClick="botonRegistrar_Click1" />
                
                </div>
            
            <br />
            
        </div>
    </form>
</body>
</html>
