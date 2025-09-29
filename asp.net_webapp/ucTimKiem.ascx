<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucTimKiem.ascx.cs" Inherits="asp.net_webapp.ucTimKiem" %>
<style type="text/css">
    .auto-style1 {
        width: 82px;
    }
</style>
<fieldset>
    <legend>Search Panel</legend>
    <table style="widows:100;">
        <tr>
            <td >
                <asp:Label ID="Label1" runat="server" Text="Key Word"></asp:Label>
            </td>
            <td style="width:70%;">
                <asp:TextBox ID="txtKeyWord" runat="server" Width="100%"></asp:TextBox></td>
            <td >
                <asp:LinkButton  ID="lbtnSearch" OnClick="lbtnSearch_Click" runat="server">Search</asp:LinkButton></td>
        </tr>
    </table>
</fieldset>