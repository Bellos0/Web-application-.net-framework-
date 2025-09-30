using asp.net_webapp.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp.net_webapp
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReg_Click(object sender, EventArgs e)
        {
            string messSuccess = "Register successfully!";
            string messFail = "Register fail! Username maybe exist or something else. Please try again.";
            string username = txtUserName.Text.Trim();
            string password = txtPass.Text.Trim();
            string email = txtMail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            RegiterClass service = new RegiterClass();
            if (service.RegiterProccess(username,password,email,phone))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", $"alert('{messSuccess}')", true);
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", $"alert('{messFail}')", true);
            }
        }

        protected void btnTerminal_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/DangNhap.aspx");
        }
    }
}