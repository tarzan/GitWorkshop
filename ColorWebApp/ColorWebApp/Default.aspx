<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ColorWebApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
       <asp:RadioButtonList ID="RadioButtonList1" runat="server">
          <asp:ListItem Selected="True">Red</asp:ListItem>
          <asp:ListItem>Blue</asp:ListItem>
       </asp:RadioButtonList>
       <asp:Label ID="Label1" runat="server" Text="Color"></asp:Label>
    </div>
       <p>
       <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
       </p>
    </form>
</body>
</html>
