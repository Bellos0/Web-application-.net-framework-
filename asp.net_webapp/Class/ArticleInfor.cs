using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace asp.net_webapp.Class
{
    public class ArticleInfor
    {
        private int articleID;
        private string title;
        private string description;
        private string authorName;
        private string imageName;
        private DateTime dateCreate;

        public int ArticleID { get => articleID; set => articleID = value; }
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public string AuthorName { get => authorName; set => authorName = value; }
        public string ImageName { get => imageName; set => imageName = value; }
        public DateTime DateCreate { get => dateCreate; set => dateCreate = value; }
    }
}