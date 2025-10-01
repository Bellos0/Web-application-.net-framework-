using asp.net_webapp.Class;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp.net_webapp
{
    public partial class DetailShowArticleDB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int artID = 0;
            string StrArtID = Request.QueryString["artID"];
            int.TryParse(StrArtID, out artID);
            if (IsPostBack)
            {
                LoadDetailSQL(artID);
            }
        }

        public void LoadDetailSQL(int artID)
        {
            DetailShowArticleStoredSQL service = new DetailShowArticleStoredSQL();
            SqlDataReader reader = service.LoadDetailSQL(artID);
            if (reader.Read())
            {
               lbTitle.Text = reader["title"].ToString();
                lbCategory.Text = reader["categories"].ToString();
                imgArticle.ImageUrl = reader["images"].ToString();
                txtDes.Text = reader["description"].ToString();
                lbAuthor.Text = reader["author"].ToString();
            }

        }

    }
}