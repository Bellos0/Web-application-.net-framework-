using asp.net_webapp.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp.net_webapp
{
    public partial class EditArticle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string Str_artID = Request.QueryString["artID"];
                int artID = 0;
                artID = int.Parse(Str_artID);
                loadArticleSQL(artID);
                loadCategory();
            }
        }

        public void loadArticleSQL(int artID)
        {
            asp.net_webapp.Class.EditArticle service = new asp.net_webapp.Class.EditArticle();

            DataTable dt = service._loadArticleSQL(artID);
            if (dt.Rows.Count == 1)
            {
                txtTitle.Text = dt.Rows[0]["title"].ToString();
                txtDes.Text = dt.Rows[0]["description"].ToString();
                txtAuthor.Text = dt.Rows[0]["author"].ToString();
                img.ImageUrl = dt.Rows[0]["images"].ToString();
                //ddlCategory.i = dt.Rows[0]["categories"].ToString();
                txt_dateCreate.Text = dt.Rows[0]["dateCreate"].ToString();
            }
           

        }

        public void loadCategory()
        {
            asp.net_webapp.Class.EditArticle editArt = new asp.net_webapp.Class.EditArticle();
            DataTable dt = editArt._loadCategorySQL();
            ddlCategory.DataSource = dt;
            ddlCategory.DataTextField = "categories"; // hien thi category dang text len dropdown list
            ddlCategory.DataValueField = "categoryID";
            ddlCategory.DataBind();
            ddlCategory.Items.Insert(0, new ListItem("---select category---", ""));
        }


        protected void bt_EditArticle_Click(object sender, EventArgs e)
        {

        }

        protected void btUpdateImage_Click(object sender, EventArgs e)
        {

        }

        protected void btTerminal_Click(object sender, EventArgs e)
        {

        }
    }
}