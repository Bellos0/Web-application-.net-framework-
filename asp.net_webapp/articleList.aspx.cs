using asp.net_webapp.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp.net_webapp
{
    public partial class articleList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowArticle();
            }
        }
        /// <summary>
        /// doan nay dang khong hien thi duoc 
        /// datalist article nhu mong muon
        /// xem xet lai phan khai bao trong class article infor
        /// 7825: da clear duoc hien thi datalist article
        /// </summary>
        private void ShowArticle()
        {
            article_bussiness articleShow = new article_bussiness();

            // cau lenh ben duoi giup cho text bind biet chinh xac
            // dau la title, dua la description de binding
            dtlArticle.DataSource = articleShow.GetArticleInfors();
            dtlArticle.DataBind();
        }

        protected void dtlArticle_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            // itemdatabound nay su dung de co the pop up bai viet khi nhan vao title tuong ung
            if (e.Item.ItemIndex < 0)
            {
                return;
            }

            //ArticleInfor obj = ((ArticleInfor)e.Item.DataItem);
            // ep kieu (cast) de bien co the truy xuat cu the vao 
            //thuoc tinh cua kieu giu lieu, o day articleinfor

            ArticleInfor obj = new ArticleInfor();
            obj = (ArticleInfor)e.Item.DataItem;

            // findcontrol tim tung doi tuong dang anh sau do gan lai url 
            //de hien thi hinh anh nhu mong muon

            Image imgDes = ((Image)e.Item.FindControl("imgDes"));

            if (imgDes != null)
            {
                imgDes.ImageUrl = "images/" + obj.ImageName;
            }

            // doan nay la click chuot vao title thi nhay sang 1 
            // tab khac, 

            HyperLink hplArticleLink = ((HyperLink)e.Item.FindControl("hplArticleLink"));
            if (hplArticleLink != null)
            {
                hplArticleLink.NavigateUrl = "Detail.aspx?articleID=" + obj.ArticleID;
            }
        }
    }
}