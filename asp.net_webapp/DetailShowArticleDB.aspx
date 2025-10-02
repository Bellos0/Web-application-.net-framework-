<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetailShowArticleDB.aspx.cs" Inherits="asp.net_webapp.DetailShowArticleDB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Detail Show Article Database</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:label id="lbTitle" runat="server">Title</asp:label>
        </div>
        <div>
            <asp:Label ID="lbCategory" runat="server" Text="Label">category</asp:Label>
        </div>
        <div>
            <asp:Image ID="imgArticle" runat="server" Height="200px" Width="200px" />
        </div>
        <div>
            <asp:TextBox ID="txtDes" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lbAuthor" runat="server" Text="Label">Author</asp:Label>
        </div>
    </form>
</body>
</html>
