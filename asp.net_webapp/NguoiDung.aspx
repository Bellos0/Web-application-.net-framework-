<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NguoiDung.aspx.cs" Inherits="asp.net_webapp.NguoiDung" %>
<%@ Register TagPrefix="bello" TagName ="ucTimKiem" Src="~/ucTimKiem.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <bello:ucTimKiem runat="server" ID="ucTimKiemNguoiDung"  />
</asp:Content>
