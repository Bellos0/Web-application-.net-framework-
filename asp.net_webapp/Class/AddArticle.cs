using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using asp.net_webapp.Class;

namespace asp.net_webapp.Class
{
    public class AddArticle
    {
        public AddArticle()
        {
        }

        public DataTable read_categorySQL()
        {
            // doc gia tri trong bang categoris de tro vao dropdownlist.
            string strquery = "select categoryID, categories from [WebServer].[dbo].[categoriesArticle]";
            Common common = new Common();
            DataTable dt = new DataTable();
            dt.Columns.Add("categoryID", typeof(int));
            dt.Columns.Add("categories", typeof(string)); 

            dt = common.Read_SQLData(strquery);


            return dt;
        }

        public void insertArticleSQL( string title, string categories, string images, string description, string author, string dateCreate)
        {
            int artID;
            Random rnd = new Random();

            string strCheckID = "select artID from [WebServer].[dbo].[ArticleStorage]";
            DataTable dtArtID = new DataTable();
            Common common = new Common();
           
            do
            {
                artID = rnd.Next(1, 1000000);
                dtArtID = common.GetTable(strCheckID);
            } while (dtArtID.Rows.Count < 0); // neu tra ve true thi lap lai sinh ID khac.

            string strQuery = "insert into [WebServer].[dbo].[ArticleStorage] (artID, title, categories, images, description, author, dateCreate) values (@artID, @title, @categories, @images, @description, @author, @dateCreate)  ";

            SqlParameter[] sqlParameters = new SqlParameter[]
                {
                    new SqlParameter("@artID", artID),
                    new SqlParameter("@title", title),
                    new SqlParameter("@categories", categories),
                    new SqlParameter("@images", images),
                    new SqlParameter("@description", description),
                    new SqlParameter("@author", author),
                    new SqlParameter("@dateCreate", dateCreate)
                };
            
            common.excuteSQL(strQuery, sqlParameters);
        }
    }
}