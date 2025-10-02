using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace asp.net_webapp.Class
{
    public class EditArticle
    {

        public EditArticle()
        {
        }

        public DataTable _loadArticleSQL(int artID)
        {
            Common service = new Common();
            string query = "select * from ArticleStorage where artID = @artID";
            SqlParameter[] parameters = new SqlParameter[]{
                new SqlParameter("@artID", artID)
            };
           DataTable dt =  service.GetTable(query,parameters);
            return dt;
        }

        public DataTable _loadCategorySQL()
        {
            Common service = new Common();
            string query = "select * from categoriesArticle ";
            
            DataTable dt = service.GetTable(query, null);
            return dt;
        }
    }
}