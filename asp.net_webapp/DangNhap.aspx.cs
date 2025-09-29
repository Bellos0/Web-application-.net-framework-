using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp.net_webapp
{
    public partial class DangNhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbtDangNhap_Click(object sender, EventArgs e)
        {
            //ltrThongBao.Text = string.Empty;
            // khai bao bien
            string tendangnhap = "", matkhau = "";

            // lay thong tin
            tendangnhap = txtTenTaiKhoan.Text.Trim();
            matkhau= txtMatKhau.Text.Trim();

            NguoiDungBussiness service = new NguoiDungBussiness();

            // thuc hien truy van tren database tendangnhap va mat khau 
            // neu gia tri tham so tendangnhap truyen vao khop voi 
            // gia tri tren database thi dtUser.Rows.Count > 0.
            // khi do tai khoan co ton tai
            DataTable dtUser = service.KiemtraDangnhap(tendangnhap);

            if (dtUser.Rows.Count > 0 )
                // dieu kien kiem tra tai khoan co ton tai
                // trong co so du lieu hay khong
            {
                string matkhauDB =  dtUser.Rows[0]["matkhau"].ToString();
                if (matkhauDB.Equals(matkhau))
                {
                    // luu thong tin dang nhap vao session
                    Session["username"] = tendangnhap;

                    //ben doi la cach thu hai de luu thong tin dang nhap vao session
                    //Session["tendangnhap"] = dtUser.Rows[0]["tendangnhap"].ToString();
                    Response.Redirect("~/articleList.aspx");
                }
                else
                {
                    ltrThongBao.Text= "mat khau khong dung cho tai khoan ";
                }
            }
            else
            {
                ltrThongBao.Text = "tai khoan khong ton tai";
            }
        }
    }
}