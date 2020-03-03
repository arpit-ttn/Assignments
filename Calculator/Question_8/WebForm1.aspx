<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Question_8.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <html>
    <head>
    <title>REGISTRATION FORM</title>
    <style type="text/css">
        body
        {
            font-family: Arial;
            font-size: 10pt;
        }
        input
        {
            width: 200px;
        }
        table
        {
            border: 1px solid #ccc;
        }
        table th
        {
            background-color: #F7F7F7;
            color: #333;
            font-weight: bold;
        }
        table th, table td
        {
            padding: 5px;
            border-color: #ccc;
        }
    .auto-style1 {
        height: 32px;
    }
    </style>
</head>
<body>
  <%-- web page/web form using RequiredFieldValidator , CompareValidator, RangeValidator  and ValidationSummary and submitting to database.--%>
    <table border="0" cellpadding="0" cellspacing="0">
        <tr>
            <th colspan="3">
                Employee_Details
            </th>
        </tr>
        <tr>
            <td>
                Emp_Name
            </td>
            <td>
                <asp:TextBox ID="txtUsername" runat="server" />
            </td>
            <td>
                <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Blue" ControlToValidate="txtUsername"
                    runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                Emp_Age
            </td>
            <td>
                <asp:TextBox ID="txtage" runat="server" />
            </td>
            <td>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Age should be in between 21-50 only.." ControlToValidate="txtage" ForeColor="Red" MaximumValue="50" MinimumValue="21" Display="Dynamic"></asp:RangeValidator> 
            </td>
        </tr>
        
        <tr>
            <td>
                Emp_Password
            </td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" />
            </td>
            <td>
                <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Blue" ControlToValidate="txtPassword"
                    runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                Retype_Password
            </td>
            <td>
                <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" />
            </td>
            <td>
                <asp:CompareValidator ErrorMessage="Passwords do not match." ForeColor="Blue" ControlToCompare="txtPassword"
                    ControlToValidate="txtConfirmPassword" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                Emp_Email
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="txtEmail" runat="server" />
            </td>
            <td class="auto-style1">
                <asp:RequiredFieldValidator ErrorMessage="Required" Display="Dynamic" ForeColor="Blue"
                    ControlToValidate="txtEmail" runat="server" />
                <asp:RegularExpressionValidator runat="server" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                    ControlToValidate="txtEmail" ForeColor="Red" ErrorMessage="Invalid email address." />
            &nbsp;&nbsp;
            </td>
        </tr>
            <tr>
            <td>
                Emp_Salary
            </td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server" />
            </td>
        </tr>
          
            <td>
                <asp:Button Text="Submit" runat="server" OnClick="RegisterUser" />
            </td>
            <td>
            </td>
        </tr>
        
    </table>
          <asp:Label ID="Label1" runat="server"></asp:Label>

    
   
    <%-- program to handle Button related events--%>
    <asp:Button ID="Button1" runat="server" Text="Button" CommandName="Button1" OnCommand="Button1_Command" CausesValidation="False" />
    <asp:Label ID="Label2" runat="server"></asp:Label>
</body>
</html>
    <br />
    <asp:Button ID="Button2" runat="server" Text="Button" CommandName="Button2" OnCommand="Button1_Command" CausesValidation="False" />
    <asp:Label ID="Label3" runat="server"></asp:Label>
</asp:Content>
