<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditarActividades.aspx.cs" Inherits="Gestor_Actividades.Vista.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Editar Actividad</title>
    <link href="../CSS/StyleSheet1.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            height: 378px;
        }
        .auto-style2 {
            height: 747px;
        }
    </style>
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
                <h1>Editar Actividades</h1>
            </div>
            <br /><br /><br />

            <div id="form2" class="auto-style1">
                <input id="nombre" name="nombre" type="text" value="Nombre"/><br /><br />
                <label>Campus/Centro Académico</label>
                <select id="dropdown" name="campus">
                    <option>Campus Cartago</option>
                    <option>Campus San Carlos</option>
                    <option>Centro Académico San José</option>
                    <option>Centro Académico Alajuela</option>
                    <option>Centro Académico Limón</option>                 
                </select><br /><br />

                <asp:TextBox ID="txtBox_lugar" runat="server" Text="Lugar"></asp:TextBox><br /><br />
                <asp:TextBox ID="txtBox_fecha" runat="server" Text="Fecha"></asp:TextBox><br /><br />
                <asp:TextBox ID="txtBox_horario" runat="server" Text="Horario"></asp:TextBox>
                <br />
                <br />
                <label>Cupo</label>
                <asp:TextBox ID="txtBox_cupo" runat="server"></asp:TextBox><br /><br /> 
                <asp:TextBox ID="txtBox_descripcion" runat="server" Height="100px" Width="300px"></asp:TextBox>
                <br /><br />
                <label>Encargados</label><br />
                <asp:ListBox ID="ListBox1" runat="server" ></asp:ListBox><br /><br />
                <asp:FileUpload ID="FileUpload1" runat="server" /><br /><br />
                <asp:Button ID="botonRegistrar" runat="server" Text="Registrar" CssClass="botones" OnClick="botonRegistrar_Click"/>
                </div>
            
        </div>


    </form>
</body>
</html>
