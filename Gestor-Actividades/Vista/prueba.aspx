<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="prueba.aspx.cs" Inherits="Gestor_Actividades.Vista.prueba" %>

<!DOCTYPE html>



<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>How to use TextAlign (text align left right) in CheckBoxList</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2 style="color:Green">CheckBoxList: Change TextAlign</h2>
        <asp:Label 
             ID="Label1"
             runat="server"
             Font-Bold="true"
             ForeColor="SaddleBrown"
             Text="asp.net controls"
             >
        </asp:Label>
        <asp:CheckBoxList 
             ID="CheckBoxList1"
             runat="server"
             BackColor="Lavender"
             ForeColor="Magenta"
             Font-Bold="true"
             >
             <asp:ListItem>MultiView</asp:ListItem>
             <asp:ListItem>Substitution</asp:ListItem>
             <asp:ListItem>AppearanceEditorPart</asp:ListItem>
             <asp:ListItem>BehaviorEditorPart</asp:ListItem>
             <asp:ListItem>UpdateProgress</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <asp:CheckBoxList ID="CheckBoxList2" runat="server">
            <asp:ListItem Text="Act" />
            <asp:ListItem Text="Act2" />
        </asp:CheckBoxList>
        
        
    </div>
    </form>
</body>
</html>
