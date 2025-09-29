using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp.net_webapp
{
    public partial class KhachHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // khoi tao su kien cho form khachhang
            ucTimKiemKhachHang.NhanNutTimKiem += 
                UcTimKiemKhachHang_NhanNutTimKiem;
        }

        private void UcTimKiemKhachHang_NhanNutTimKiem(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            // thuc hien tim kiem khach hang
            string tukhoa = ucTimKiemKhachHang.Tukhoa;
        }
    }
}