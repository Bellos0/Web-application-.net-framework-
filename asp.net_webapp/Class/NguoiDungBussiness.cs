using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using asp.net_webapp.Class;
using System.Data.SqlClient;


namespace asp.net_webapp
{
    public class NguoiDungBussiness
    {
        /// <summary>
        /// ham kiem tra dang nhap nguoi dung vao he thong
        /// </summary>
        /// <param name="taikhoan"></param>
        /// <returns></returns>
        public DataTable KiemtraDangnhap(string taikhoan)
        {

            string strSQL = "SELECT id, tendangnhap, matkhau FROM NguoiDung WHERE tendangnhap = @taikhoan";
            //So yes, SqlParameter[] is the syntax to declare and pass parameters safely into the query.
            // bao mat, an toan cho co so du lieu. tham chieu so sanh chu k can phai ghi vao trong co so du lieu
            //SqlParameter parameters = new SqlParameter("@taikhoan", taikhoan);

            // cai nay dung dang array de declare parameters, neu dung cai nay thi sang ben Common.cs phair dung addrange() thay vi add()
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter("@taikhoan", taikhoan)
            };



            Common common = new Common();
            return common.GetTable_addrange(strSQL, parm);
        }
    }
}