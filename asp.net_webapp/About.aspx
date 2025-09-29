<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="asp.net_webapp.About" %>
<%@ Register TagPrefix="bello" TagName="ucTimKiem" Src="~/ucTimKiem.ascx"  %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <h3>Welcome to About Page</h3>
    </main>
    <bello:ucTimKiem runat="server" ID="searchPanel" />
</asp:Content>
