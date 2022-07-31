<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="assignment4.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Username:<asp:TextBox ID="txtUser" runat="server" ReadOnly="True"></asp:TextBox>
            <br />
            <br />
            Email:<asp:TextBox ID="txtEmail" runat="server" ReadOnly="True"></asp:TextBox>
            <br />
            <br />
            First Name:<asp:TextBox ID="txtFN" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFN" ErrorMessage="*Required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            Last Name:<asp:TextBox ID="txtLN" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLN" ErrorMessage="*Required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            Password:<asp:TextBox ID="txtPass" runat="server" OnTextChanged="TextBox5_TextChanged"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtPass" ErrorMessage="*Required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtPass" ErrorMessage="Password Must Start with a Letter and contain: A minimum of 8 characters, 1 Uppercase Letter, 1 Lowercase Letter, and 1 Number" ValidationExpression="^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$"></asp:RegularExpressionValidator>
            <br />
            Re-enter Password:<asp:TextBox ID="txtReP" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtReP" ErrorMessage="*Required" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPass" ControlToValidate="txtReP" ErrorMessage="Please make Passwords the same"></asp:CompareValidator>
            <br />
            <br />
            Country:<asp:DropDownList ID="dlCountry" runat="server">
                <asp:ListItem Value="-1">Please choose one</asp:ListItem>
                <asp:ListItem Value="United States">United States</asp:ListItem>
                <asp:ListItem Value="United Kingdom">United Kingdom</asp:ListItem>
                <asp:ListItem Value="Turkey">Turkey</asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="dlCountry" ErrorMessage="*Required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:UserTestConnectionString2 %>" OnSelecting="SqlDataSource1_Selecting" SelectCommand="SELECT * FROM [User]"></asp:SqlDataSource>
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
