using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp.net_webapp
{
    public partial class ucTimKiem : System.Web.UI.UserControl
    {
        /// <summary>
        /// dinh nghai su kien nhan nut tim kiem
        /// </summary>
        public event EventHandler NhanNutTimKiem = null;
        private string _tukhoa = "";

        public string Tukhoa
        { get => _tukhoa; set => _tukhoa = value; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbtnSearch_Click(object sender, EventArgs e)
        {
            /*
             * khi click vao nut search, kich hoat su kien 
             * nhannuttimkiem tao o tren.
             * truyen tu khoa thong qua textbox,
             * cac doi so sender va e cho nhannuttimkiem
             */
            if (NhanNutTimKiem != null)
            {
                // lay thong tin tu khoa cho thuoc tinh 
                _tukhoa = txtKeyWord.Text.Trim();

                //goi su kien dinh nghia de thuc hien cong viec
                NhanNutTimKiem(sender, e);
            }
        }
    }
}