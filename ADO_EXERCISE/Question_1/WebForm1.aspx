<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Question_1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </div>
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:GridView ID="GridView3" runat="server">
        </asp:GridView>
        <br />
    </form>
</body>
</html>
