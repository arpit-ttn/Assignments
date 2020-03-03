<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Calculator.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

   
    
      <div >
            <nav style="height: 20px">Number1</nav>
            <asp:TextBox ID="txtNumber1" runat="server"></asp:TextBox>
            <nav style="height: 20px">Number2</nav>
            <asp:TextBox ID="txtNumber2" runat="server"></asp:TextBox>
            <nav style="height: 20px">Operator</nav>
             <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem Value="+">ADD</asp:ListItem>
                    <asp:ListItem Value="-">SUBTRACT</asp:ListItem>
                    <asp:ListItem Value="*">MULTIPLY</asp:ListItem>
                    <asp:ListItem Value="/">DIVIDE</asp:ListItem>
             </asp:DropDownList>
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
          <%--<asp:Button ID="Button1" runat="server" Text="Button" />--%>
            <nav style="height: 20px">&nbsp;</nav>
            <nav style="height: 20px">Result</nav>
            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>

     </div>
</asp:Content>
