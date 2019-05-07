<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inscripcion.aspx.cs" Inherits="Gestor_Actividades.Vista.Inscripcion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Formulario de Inscripción</title>
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
                <li><img src="../Imagenes/engranaje.png" width="30px" height="30px"/>&nbsp;&nbsp;&nbsp; </li>
                <li style="font-size:large">Escuela de Ingeniería en Computación</li>  
                <li style="font-size:large;padding-left:300px">&nbsp; Sistema Gestor de Actividades&nbsp;&nbsp;</li>              
            </ul>
        </nav>
        <div id="menuInicio" style="background-color:#adadad;margin:0;width:auto;height:67px">
            <ul>
                <li><a href="Inicio.aspx">Inicio</a></li>
                <li><a href="ActividadesXParticipante.aspx">Actividades por participante</a></li>
                <li><a href="Login.aspx">Iniciar Sesión</a></li>
            </ul>
        </div>
            <div id="titulo">
                <h1>Formulario de Inscripción</h1>
            </div>
            <br /><br />

            <div class="row">
                <div class="column">
                                    
                Tipo de Participante:<br /><br />
                    <asp:DropDownList ID="DropDownList_TipoParticipante" runat="server" Width="165px" style="margin-left: 150px">
                        <asp:ListItem>Participante 1</asp:ListItem>
                        <asp:ListItem>Participante 2</asp:ListItem>
                    </asp:DropDownList><br /><br />

                Curso (En caso de no ser estudiante, seleccionar la opción "No aplica"):<br /><br />
                    <asp:DropDownList ID="DropDownList_Curso" runat="server" Width="165px" style="margin-left: 150px">
                        <asp:ListItem>Participante 1</asp:ListItem>
                        <asp:ListItem>Participante 2</asp:ListItem>
                    </asp:DropDownList><br /><br />

                Campus/Centro Académico: <br /><br />
                    <asp:DropDownList ID="DropDownList_Campus" runat="server" Width="165px" style="margin-left: 150px">
                    <asp:ListItem>Campus Cartago</asp:ListItem>
                    <asp:ListItem>Campus San Carlos</asp:ListItem>
                    <asp:ListItem>CA San José</asp:ListItem>
                    <asp:ListItem>CA Alajuela</asp:ListItem>
                    <asp:ListItem>CA Limón</asp:ListItem>
                </asp:DropDownList><br /><br />

                Identificación (Si es estudiante, por favor ingrese su número de carné):<br /><br />
                <asp:TextBox ID="txtBox_identificacion" runat="server" Width="165px" style="margin-left: 150px" ></asp:TextBox><br />
               

               </div>
               <div class="column">
                

                Nombre:
                   <br />
                   <br />
                   <asp:TextBox ID="txtBox_nombreParticipante" runat="server" Width="165px" style="margin-left: 150px"></asp:TextBox><br /><br />
                Primer Apellido:
                   <br />
                   <br />
                   <asp:TextBox ID="txtBox_primerAParticipante" runat="server" Width="165px" style="margin-left: 150px"></asp:TextBox><br /><br />
                Segundo Apellido:
                   <br />
                   <br />
                   <asp:TextBox ID="txtBox_segundoAParticipante" runat="server" Width="165px" style="margin-left: 150px"></asp:TextBox><br /><br />
                Correo electrónico:
                   <br />
                   <br />
                   <asp:TextBox ID="txtBox_correo" runat="server" Width="165px" style="margin-left: 150px"></asp:TextBox><br /><br />
                   <br />
                   <asp:Button ID="botonInscribirse" runat="server" Text="Inscribirse" CssClass="botones" Width="170px" OnClick="botonInscribirParticipante_Click" BorderStyle="None" Height="27px" />
               </div>
            </div> 
 
           

             
            
    </form>
</body>
</html>
