using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using asp.net_webapp.Class;
using System.IO;

namespace asp.net_webapp
{
    /// <summary>
    /// hien tai khi bam nut today thi categries bi load lai tu dau, mat gia tri da chon truoc do. 
    /// hang muc image dang anh tren sql dang co van de khi thuc hien truy van insert 
    /// </summary>
    public partial class AddArticle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {

                categorySelectd();
            }
            else
            {
                LoadCategory();


                ltrMess.Visible = false;
            }
        }


        public void LoadCategory()
        {

            // doan ddlcategory datasource va datatextfield co 2 gia tri vi trong table minh cos 2 cojt tuong ung voi ten categoryID va categories.

            asp.net_webapp.Class.AddArticle addArt = new asp.net_webapp.Class.AddArticle();
            DataTable dt = addArt.read_categorySQL();
            ddlCategory.DataSource = dt;
            ddlCategory.DataTextField = "categories"; // hien thi category dang text len dropdown list
            ddlCategory.DataValueField = "categoryID";
            ddlCategory.DataBind();
            ddlCategory.Items.Insert(0, new ListItem("select category", ""));

        }

        public void categorySelectd()
        {
            if (ddlCategory.SelectedValue != null)
            {
                ddlCategory.SelectedItem.Text = ddlCategory.SelectedItem.ToString();
            }
        }

        protected void btTerminal_Click(object sender, EventArgs e)
        {

            Response.Redirect("About.aspx");

        }

        protected void btToday_Click(object sender, EventArgs e)
        {
            txt_dateCreate.Text = DateTime.Now.ToString(string.Format("dd/MM/yyyy"));
        }

        protected void btUpload_Click(object sender, EventArgs e)
        {
            int maxFileSize = 1024 * 1024 * 5; // 5MB, unit la byte (B)


            // dieu kien de xac nhan fileupload da tro den file can upload chua
            if (fu_upImg.HasFile)
            {
                // save the upload file to tamporary location
                // su dung path.getfilename de lay phan mo rong cua file.
                // vi du anh1.png thi .png la phan mo rong vaf nguoc lai
                string fileExtension = Path.GetExtension(fu_upImg.FileName).ToLower();
                string mimeType = fu_upImg.PostedFile.ContentType;
                string originalName = Path.GetFileNameWithoutExtension(fu_upImg.FileName);
                string fileName = Guid.NewGuid().ToString() + originalName + fileExtension; // guid de tranh viec upload file trung ten len tren server
                string folderPath = Server.MapPath( "~/imagesSQL/"); // tro duong dan luu tren server cua web, no la folder ao trong web.

                string filePath = "~/imagesSQL/" + fileName;

                // su dung contenlength de kiem tra kich thuoc cua file upload
                if (fu_upImg.PostedFile.ContentLength > maxFileSize)
                {
                    ltrMess.Text = "file size exceed 5MB";
                    ltrMess.Visible = true;
                    return;
                }

                else
                {
                    if (fileExtension == ".jpg" || fileExtension == ".png" || mimeType == "image/PNG" || mimeType == "image/JPG")
                    {

                        // su dung server.mappath de chuyen doi tu virsual path sang physicla path de luu tren server.
                        // khong nen su dung link local vi no chi hoat trong trong may minh, tiem an rui do folder trong link local khong cho phep truy cap lam code bi loi


                        fu_upImg.SaveAs(Server.MapPath(filePath ));
                        img.ImageUrl = filePath ;
                        fu_upImg.SaveAs(Path.Combine(folderPath, fileName));
                    }
                    else
                    {
                        ltrMess.Text = "wrong file type";
                        ltrMess.Visible = true;
                    }


                }
            }
            else
            {
                ltrMess.Text = "please select file to upload or re-select file properly";
                ltrMess.Visible = true;
            }
        }

        protected void bt_addArticle_Click(object sender, EventArgs e)
        {
            asp.net_webapp.Class.AddArticle service = new asp.net_webapp.Class.AddArticle();
            string title = txtTitle.Text;
            string categories = ddlCategory.SelectedItem.ToString();
            string images = img.ImageUrl;
            string description = txtDes.Text;
            string author = txtAuthor.Text;
            string dateCreate =  txt_dateCreate.ToString();

            string messageFalse = "Operation False!";
            string messageSucc = "Add Article Successfully!";

            

            try
            {
                
               if (txtTitle.Text == string.Empty || txtDes.Text == string.Empty || txtAuthor.Text == string.Empty || txt_dateCreate.Text == string.Empty)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", $"alert('{messageFalse}')", true);
                }

                else
                {
                    service.insertArticleSQL(title, categories, images, description, author, dateCreate);

                    ClientScript.RegisterStartupScript(this.GetType(), "alert", $"alert('{messageSucc}')", true); // hien thi khi thanh cong
                }

                
            }
            catch (Exception)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", $"alert('{messageFalse}')", true); // hien thi pop up khi co loi xay ra
                return;
            }



        }
    }
}