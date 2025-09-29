<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="articleList.aspx.cs" Inherits="asp.net_webapp.articleList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <fieldset>
        <legend>Article information and search</legend>
        <table style="widows:100;">
            <tr>
                <td style="width:10%;">
                    Title:
                </td>
                <td style="width:100%;">
                    <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox></td>
                <td >
                    <asp:LinkButton ID="lbtnSearch" runat="server">Search</asp:LinkButton></td>
            </tr>
        </table>
    </fieldset>
    <div style ="text-align:right; padding-bottom:10px; height:10px;">
        <asp:HyperLink ID="hplAdd" runat="server" NavigateUrl="~/AddArticle.aspx">Add Article</asp:HyperLink>
    </div>

    <div>
        <asp:DataList ID="dtlArticle" runat="server" Width="100%" OnItemDataBound="dtlArticle_ItemDataBound">
            <HeaderTemplate >
                <table></table>
            </HeaderTemplate>

            <ItemTemplate>
                <tr>
                    <td>
                        <asp:Image ID="imgDes" runat="server" AlternateText="Images"  Height="100px"  Width="100px" />
                    </td>
                    <td>

                        <%--text bind title can co method code behind de co the biet 
                        chinh xac gia tri nao de bind
                            duoc su dung trong cac phan tu grdview, datalist...--%>

                        <asp:HyperLink ID="hplArticleLink" runat="server" Font-Bold="true" Text='<%#Bind( "Title") %>'>Title Link</asp:HyperLink><br />
                        <asp:Literal ID="ltrDes" runat="server" Text='<%# Bind("Description") %>' >Description</asp:Literal>
                    </td>
                </tr>
                <br />
            </ItemTemplate>

            <FooterTemplate>
                <table></table>
            </FooterTemplate>
        </asp:DataList>
    </div>
</asp:Content>

