<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Question_4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <div>
            <h1>
                 <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                 </h1>
            <nav style="height: 20px">First Name</nav>
            <asp:TextBox ID="txtNumber1" runat="server"></asp:TextBox>
            <nav style="height: 20px">Second Name</nav>
            <asp:TextBox ID="txtNumber2" runat="server"></asp:TextBox>
                 <br />
                 <br />
        <asp:Button ID="Button1" runat="server" Text="Register Employee" OnClick="Button1_Click" />
        
     </div>
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
