<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditArticle.aspx.cs" Inherits="asp.net_webapp.EditArticle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
    <fieldset>
        <legend>Edit an Article Page</legend>
        <table>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Tiltle: "></asp:Label>
                    &nbsp 
                </td>
                <td>
                    <asp:TextBox ID="txtTitle" runat="server" Width="500px" Height="10px" ValidateRequestMode="Disabled"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label1" runat="server" Text="Categories"></asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:DropDownList ID="ddlCategory" runat="server" Width="300px"></asp:DropDownList>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Images"></asp:Label>

                    &nbsp;

                </td>
                <td>
                    <asp:Image ID="img" AlternateText="Image alternative" runat="server" ImageAlign="AbsMiddle" Height="200px" Width="200px" />
                    &nbsp &nbsp
                    <asp:FileUpload ID="fu_upImg" runat="server" /> &nbsp 
                    <asp:Button ID="btUpdateImage" type="submit" runat="server"  Text="Upload Image" OnClick="btUpdateImage_Click" />
                    <asp:Literal ID="ltrMess" runat="server"></asp:Literal>
                </td>
                <td></td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Description"></asp:Label>
                    &nbsp;

                </td>
                <td>
                    <asp:TextBox ID="txtDes" runat="server" Height="500px" TextMode="MultiLine" Width="800px" ValidateRequestMode="Disabled"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Author"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtAuthor" runat="server" ValidateRequestMode="Disabled"></asp:TextBox>
                </td>
            </tr>
        </table>
    </fieldset>
</div>

<div>
    <table style="padding:5px;">
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Date Create"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:TextBox ID="txt_dateCreate" runat="server" TextMode="Date"  ></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txt_dateCreate">*</asp:RequiredFieldValidator>
                &nbsp
            </td>
            <td class="auto-style3">
                <%--<asp:Button ID="btNow" runat="server"   Text="Now" OnClick="btToday_Click" OnClientClick="return confirm('are you sure pick the date?');" />
                &nbsp 
                Format date: dd-MM-yyyy"--%>
            </td>
            <td class="auto-style4">
                &nbsp;

            </td>
        </tr>
    </table>

</div>
<div>
    <asp:Button ID="bt_EditArticle" runat="server" Text="Edit Article" onclick="bt_EditArticle_Click" />
    &nbsp &nbsp &nbsp &nbsp &nbsp&nbsp
    <asp:Button ID="btTerminal" runat="server" Text="Terminal" OnClientClick="return confirm('Are you sure?');" OnClick="btTerminal_Click" />
    &nbsp 
</div>
    </form>
</body>
</html>
