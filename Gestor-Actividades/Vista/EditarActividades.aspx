<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditarActividades.aspx.cs" Inherits="Gestor_Actividades.Vista.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Editar Actividad</title>
    <link href="../CSS/StyleSheet1.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            height: 1074px;
        }
        .auto-style2 {
            height: 1291px;
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

        <div id="seccion" class="auto-style2"><br />
            <div id="titulo">
                <h1>Editar actividad</h1>
            </div>
            <br /><br /><br />
                <div id="form2" class="auto-style1">
                    Nombre de la actividad:<br />
                <asp:TextBox ID="txtBox_nombre" runat="server"></asp:TextBox><br />
                <label>Campus/Centro Académico&nbsp;                 &nbsp;
                    <!----<asp:D&nbsp;--->
                    <asp:DropDownList ID="DropDownList_Campus" runat="server">
                    <asp:ListItem>Campus Cartago</asp:ListItem>
                    <asp:ListItem>Campus San Carlos</asp:ListItem>
                    <asp:ListItem>CA San José</asp:ListItem>
                    <asp:ListItem>CA Alajuela</asp:ListItem>
                    <asp:ListItem>CA Limón</asp:ListItem>
                </asp:DropDownList><br /><br />
                
                <br />
                Lugar:<asp:TextBox ID="txtBox_lugar" runat="server" ></asp:TextBox><br />
                Fecha:<br />
                <asp:TextBox ID="txtBox_fecha" runat="server" placeholder="dd/mm/yyyy format only"></asp:TextBox><br /><br />
               

        Horario:<asp:TextBox ID="txtBox_horario" runat="server" Height="100px" Width="300px"></asp:TextBox>
                <br />
                Cupo Reservado: <asp:CheckBox ID="CheckBoxCupo" Text= " " runat="server" />
                <br />
                <br />
                Cantidad de Cupos: <asp:TextBox ID="txtBox_cantCupos" runat="server"></asp:TextBox>
                <br /><br />
                Descripcion: <asp:TextBox ID="txtDescripcion" runat="server" Height="100px" Width="300px"></asp:TextBox>
                <br /><br />
                Encargados: <asp:TextBox ID="txtEncargado" runat="server"></asp:TextBox>

                <br /><br />
                Archivos: <asp:FileUpload ID="FileUpload1" runat="server" /><br /><br />
                <asp:Button ID="botonRegistrar" runat="server" Text="Guardar Cambios" CssClass="botones" OnClick="botonRegistrar_Click" />
                </div>
            
        </div>


    </form>
</body>
</html>
