<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShowArticleDB.aspx.cs" Inherits="asp.net_webapp.ShowArticleDB" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h1>Show article stores at database</h1>
    </div>
    <div>
        <asp:DataList ID="dtlArticleSQL" runat="server" Width="608px" OnItemDataBound="dtlArticleSQL_ItemDataBound">
            <HeaderTemplate>
                <table></table>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td>
                        <asp:Image ID="img" runat="server" ImageAlign="Left" Height="200px" Width="200px" />
                    </td>
                    <td>
                        <asp:HyperLink ID="hplTitle" runat="server" Text='<%# Bind("title") %>' Font-Bold="True" BorderColor="White" ForeColor="#0000CC" Font-Size="Large">Title Article</asp:HyperLink>
                    </td>
                </tr>
               
            </ItemTemplate>
            <FooterTemplate>
                <table></table>
            </FooterTemplate>
        </asp:DataList>
    </div>
</asp:Content>
