using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp.net_webapp
{
    public partial class NguoiDung : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // khoi tao su kien cho form web nguoidung
            ucTimKiemNguoiDung.NhanNutTimKiem += 
                UcTimKiemNguoiDung_NhanNutTimKiem;
        }

        private void UcTimKiemNguoiDung_NhanNutTimKiem(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            // cong viec can su ly o day, 
            //o day la tim kiem nguoi dung
            string tukhoa = ucTimKiemNguoiDung.Tukhoa;

            // xu ly ket noi lay thong tin nguoi dung trong database
        }
    }
}