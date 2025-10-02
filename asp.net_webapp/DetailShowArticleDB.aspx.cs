using asp.net_webapp.Class;
using System;
using System.Collections.Generic;
using System.Data;
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
            string StrArtID = Request.QueryString["artID"];// hien tai gia tri tra ve dang bi null
            int.TryParse(StrArtID, out artID);
            
                LoadDetailSQL(artID);
           
        }
        /// <summary>
        /// chua hien thi duoc thong tin cu the can xem lai cai reader.read xem da nhan gia tri nhu the nao
        /// co the su dung datable de hien thi thong tin cung duoc khong naht thiet phai la datareader
        /// dang reader thi su dung reader.read()
        /// textbox.text = reader["title"].tostring() hien thi gia tri o cot title trong database.
        /// </summary>
        
        public void LoadDetailSQL(int artID)
        {
            DetailShowArticleStoredSQL service = new DetailShowArticleStoredSQL();
            DataTable dt = service.LoadDetailSQL_datatable(artID);
            if (dt.Rows.Count == 1)
            {
               lbTitle.Text = dt.Rows[0]["title"].ToString();
                lbCategory.Text = dt.Rows[0]["categories"].ToString(); ;
                imgArticle.ImageUrl = dt.Rows[0]["images"].ToString(); ;
                txtDes.Text = dt.Rows[0]["description"].ToString(); ;
                lbAuthor.Text = dt.Rows[0]["author"].ToString(); ;
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('aarticle no exist')", true);
            }
        }

    }
}