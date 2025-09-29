using asp.net_webapp.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp.net_webapp
{
    public partial class Detail : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                showDetail();
            }
        }

        private void showDetail()
        {
            int articleID = 0;

            /*
             * thuc hien ep kieu de lay ArticleID de chuyen vao articleID
             * 
             */
            int.TryParse(Request["ArticleID"], out articleID);

            if (articleID > 0)
            {
                List<ArticleInfor> listarticle = new List<ArticleInfor>();

                /*
                 * article_bussiness la class
                 * new article_bussiness() la cau lenh tao moi 1 bien torng class
                 * .getarticleindors la su dung method thoi
                 */
                listarticle = new article_bussiness().GetArticleInfors();
                

                //tao ra doi tuong bai viet de bat dau kiem tra va hien thi
                ArticleInfor objArticle = null;


                foreach (ArticleInfor obj in listarticle)
                {
                    if (obj.ArticleID == articleID)
                    {
                        objArticle = obj;
                        break;
                    }
                }

                //hien thi thong tin chi tiet
                if (objArticle !=null)
                {
                    lbTitle.Text = objArticle.Title;
                    ltrDes.Text = objArticle.Description;
                    imgDemo.ImageUrl = "~/images/" + objArticle.ImageName;
                }
            }
        }
    }
}