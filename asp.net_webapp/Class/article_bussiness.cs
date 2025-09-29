using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace asp.net_webapp.Class
{
    public class article_bussiness
    {
        public article_bussiness()
        {
            // ham khoi tao khong co gi
        }

        public List<ArticleInfor> GetArticleInfors()
        {
            List<ArticleInfor> listArticle = new List<ArticleInfor>();

            ArticleInfor objlist1 = new ArticleInfor();

            objlist1.ArticleID = 1;
            objlist1.Title = "CPC-Thailan dat thoa thuan ngung ban";
            objlist1.Description = "thu tuong malai thong bao cpc-tl dat thoat thuan ngung ban";
            objlist1.AuthorName = "human1";
            objlist1.ImageName = "img1.png";
            objlist1.DateCreate = DateTime.Now;

            ArticleInfor objlist2 = new ArticleInfor();

            objlist2.ArticleID = 2;
            objlist2.Title = "Sân bay trọng yếu Ukraine nghi trúng tên lửa mang đầu đạn chùm";
            objlist2.Description = "Ukraine nói Nga tập kích nước này bằng 324 UAV và 7 tên lửa, video hiện trường cho thấy căn cứ không quân Starokostiantyniv dường như trúng đầu đạn chùm.";
            objlist2.AuthorName = "human2";
            objlist2.ImageName = "img2.png";
            objlist2.DateCreate = DateTime.Now;

            ArticleInfor objlist3 = new ArticleInfor();

            objlist3.ArticleID = 3;
            objlist3.Title = "Houthi dọa tấn công mọi tàu có liên hệ với Israel";
            objlist3.Description = "Lực lượng Houthi khởi động giai đoạn thứ tư trong chiến dịch chống lại Israel, đe dọa tấn công mọi tàu có liên hệ trực tiếp với nước này. ";
            objlist3.AuthorName = "human3";
            objlist3.DateCreate = DateTime.Now;
            objlist3.ImageName = "img3.png";


            ArticleInfor objlist4 = new ArticleInfor();

            objlist4.ArticleID = 4;
            objlist4.Title = "Campuchia - Thái Lan bắt đầu đàm phán ngừng bắn";
            objlist4.Description = "Phái đoàn Campuchia - Thái Lan bắt đầu đàm phán tại Malaysia, hướng tới thỏa thuận ngừng bắn sau cuộc giao tranh khiến ít nhất 35 người thiệt mạng. ";
            objlist4.AuthorName = "human4";
            objlist4.DateCreate = DateTime.Now;
            objlist4.ImageName = "img4.png";


            ArticleInfor objlist5 = new ArticleInfor();

            objlist5.ArticleID = 5;
            objlist5.Title = "Xả súng ở Bangkok, 6 người thiệt mạng";
            objlist5.Description = "Nghi phạm xả súng tại khu chợ nổi tiếng ở thủ đô Bangkok của Thái Lan, khiến nhiều người thiệt mạng, sau đó tự sát.";
            objlist5.AuthorName = "human5";
            objlist5.DateCreate = DateTime.Now;
            objlist5.ImageName = "img5.png";

            listArticle.Add(objlist1);
            listArticle.Add(objlist2);
            listArticle.Add(objlist3);
            listArticle.Add(objlist4);
            listArticle.Add(objlist5);

            return listArticle;
        }

    }
}