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
                <h1>Formulario de Inscripción</h1>
            </div>
            <br /><br />

            <div class="row">
                <div class=column>

                </div>
               <div class=column>
                   <asp:Button ID="botonInscribirse" runat="server" Text="Inscribirse" CssClass="botones" Width="170px" OnClick="botonInscribirParticipante_Click" />
                </div>
         
                
            </div> 
        </div>
           

             
            
    </form>
</body>
</html>
