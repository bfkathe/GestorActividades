<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PRUEBA.aspx.cs" Inherits="Gestor_Actividades.Vista.PRUEBA" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="Stylesheet" href="Styles/bootstrap.min.css" style="" />  
        <link rel="Stylesheet" href="Styles/bootstrap.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="container">
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="btnUpload_Click" />
        </div>



    </form>
</body>
</html>
