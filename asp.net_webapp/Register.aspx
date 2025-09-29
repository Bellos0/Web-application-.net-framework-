<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="asp.net_webapp.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <fieldset>
                <legend>Regiter Panel
                </legend>
                <table>
                    <tr>
                        <td>User Name:
                        </td>
                        <td>
                            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserName" ErrorMessage="RequiredFieldValidator" Text="*" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>

                    <tr>
                        <td>Password:
                        </td>
                        <td>
                            <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPass" ErrorMessage="RequiredFieldValidator" Text="*" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>

                    <tr>
                        <td>Confirm Password:
                        </td>
                        <td>
                            <asp:TextBox TextMode="Password" ID="txtCPass" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtCPass" ErrorMessage="RequiredFieldValidator" Text="*" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>

                    <tr>
                        <td>Email:
                        </td>
                        <td>
                            <asp:TextBox ID="txtMail" TextMode="Email" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtMail" ErrorMessage="RequiredFieldValidator" Text="*" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>

                    <tr>
                        <td>Phone:
                        </td>
                        <td>
                            <asp:TextBox ID="txtPhone" TextMode="Phone" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtPhone" ErrorMessage="RequiredFieldValidator" Text="*" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>

                </table>
            </fieldset>
        </div>
        <div>
            <asp:Button ID="btnReg" runat="server" Text="Regiter User" OnClick="btnReg_Click" />
            &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp 
            <asp:Button ID="btnTerminal" runat="server" Text="Terminal" />
        </div>
    </form>
</body>
</html>
