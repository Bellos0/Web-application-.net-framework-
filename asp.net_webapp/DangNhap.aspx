<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DangNhap.aspx.cs" Inherits="asp.net_webapp.DangNhap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center; width: 350px; margin-left: auto; margin-right: auto">

            <fieldset style="padding: 10px;">
                <legend>Dang Nhap He Thong</legend>
                <table>
                    <tr>
                        <td>Ten Dang Nhap</td>
                        <td>
                            <asp:TextBox ID="txtTenTaiKhoan" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="nhap ten dang nhap" Text="*" ControlToValidate="txtTenTaiKhoan"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>Mat Khau</td>
                        <td>
                            <asp:TextBox ID="txtMatKhau" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Nhap mat khau" ForeColor="#FF3300" ControlToValidate="txtMatKhau">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <%--tao ra de nut dang nhap va huy bo dat sang ben canh--%>
                        </td>
                    <td>
                        
                        <asp:LinkButton ID="lbtDangNhap" runat="server" OnClick="lbtDangNhap_Click">Dang Nhap</asp:LinkButton>
                        &nbsp &nbsp &nbsp &nbsp 
    
                        <asp:HyperLink ID="hplHuyBo" runat="server" NavigateUrl="~/articleList.aspx">Huy Bo</asp:HyperLink>
                    </td>
                    </tr>
                    <tr>
                        <td>

                        </td>
                        <td style="color:red;">
                            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                            <asp:Literal ID="ltrThongBao" runat="server"></asp:Literal>
                        </td>
                    </tr>
                </table>
            </fieldset>
        </div>

    </form>
</body>
</html>
