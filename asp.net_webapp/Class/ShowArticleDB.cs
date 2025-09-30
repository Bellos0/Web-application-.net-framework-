using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace asp.net_webapp.Class
{
    public class ShowArticleDB
    {
        public ShowArticleDB()
        {
        }

        public DataTable loadArticleSQL()
        {
            Common common = new Common();
            string query = "select * from ArticleStorage";
            DataTable dt = common.Read_SQLData(query);
            return dt;
        }
    }
}