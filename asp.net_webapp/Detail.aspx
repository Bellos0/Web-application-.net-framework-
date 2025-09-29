<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detail.aspx.cs" Inherits="asp.net_webapp.Detail" %>
<%@ Register TagName="ucTimKiem" Src="~/ucTimKiem.ascx" TagPrefix="Bello" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="lbTitle" runat="server" Text="Title"></asp:Label>
    <asp:Literal ID="ltrDes" runat="server"></asp:Literal>
    <div>
        <asp:Image ID="imgDemo" runat="server" AlternateText="Image Demo" />
        <p>
            this text will show on the screen, reading all of this
            thank you
        </p>
    </div>
</asp:Content>
