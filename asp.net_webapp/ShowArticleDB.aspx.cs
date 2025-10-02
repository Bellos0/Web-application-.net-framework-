using asp.net_webapp.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace asp.net_webapp
{
    public partial class ShowArticleDB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                LoadArticleSQL();
            }
        }

       
        public void LoadArticleSQL()
        {
            asp.net_webapp.Class.ShowArticleDB service = new asp.net_webapp.Class.ShowArticleDB();
            DataTable dt = service.loadArticleSQL();
            dtlArticleSQL.DataSource = dt;
            dtlArticleSQL.DataBind();
            
        }

        protected void dtlArticleSQL_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            
        }

        protected void dtlArticleSQL_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "EditArticle")
            {
                string artID = e.CommandArgument.ToString();
                Response.Redirect($"EditArticle.aspx?artID={artID}");
            }
        }
    }
}