using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace asp.net_webapp.Class
{
    public class DetailShowArticleStoredSQL
    {

        public DetailShowArticleStoredSQL()
        {
        }

        public SqlDataReader LoadDetailSQL(int artID)
        {
            SqlDataReader reader;
            Common common = new Common();
            string query = "select * from ArticleStorage where artID = @artID";
            SqlParameter[] parameters = new SqlParameter[]{
                new SqlParameter("@artID", artID)
                };
            reader = common.readData_SQLreader(query,parameters);
            return reader;
        }

        public DataTable LoadDetailSQL_datatable(int artID)
        {
            DataTable dt;
            Common common = new Common();
            string query = "select * from ArticleStorage where artID = @artID";
            SqlParameter[] parameters = new SqlParameter[]{
                new SqlParameter("@artID", artID)
                };
            dt = common.GetTable(query, parameters);
            return dt;
        }
    }
}