using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp.net_webapp
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Page_Init(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                hplUser.Text="Welcome "+Session["username"].ToString();
                lbtLogin.Visible=false;
                hplReg.Visible= false;
                lbtLogout.Visible=true;
            }
            else
            {
                Response.Redirect("~/DangNhap.aspx");
            }
        }

        protected void lbtLogin_Click(object sender, EventArgs e)
        {
            // xoa session dang luu username dang co
            Session.Remove("username");
            // chuyen huong ve trang dang nhap
            Response.Redirect("~/DangNhap.aspx");
        }

        protected void lbtLogout_Click(object sender, EventArgs e)
        {
            Session.Remove("username");
            Response.Redirect("~/articleList.aspx");
            lbtLogin.Visible = true;

        }
    }
}