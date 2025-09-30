using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace asp.net_webapp.Class
{
    public class RegiterClass
    {
        public RegiterClass() { }

        public bool RegiterProccess(string username, string password, string email, string phone)
        {
            // xu ly cac thu o day.
            Common common = new Common();
            int id = 0;
            Random rnd = new Random();
            DataTable dtcheckID = new DataTable();
            string strquery = "insert into NguoiDung (id, tendangnhap, matkhau, email, dienthoai) values (@id, @tendangnhap, @matkhau, @email, @dienthoai) ";
            string strCheckID = "select id from NguoiDung where id = @id";
            string checkUsername = "select tendangnhap from NguoiDung where tendangnhap = @tendangnhap";
            DataTable dtCheckUsername = new DataTable();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", id),
                new SqlParameter("@tendangnhap", username),
                new SqlParameter("@matkhau", password),
                new SqlParameter("@email", email),
                new SqlParameter("@dienthoai", phone)
            };


            /*
             * follow step
             * 1. kiem tra username co ton tai tren database hay khong
             * 2. tao id ngau nhien
             * 3. kiem tra id da ton tai tren database chua
             */
            dtCheckUsername = common.GetTable(checkUsername, parameters);

            if (dtCheckUsername.Rows.Count == 0 )
            {
                do
                {
                    id = rnd.Next(0, 100000);
                    dtcheckID = common.GetTable(strCheckID,parameters);
                } while (dtcheckID.Rows.Count < 0);

                if (common.excuteSQL(strquery, parameters) == 1)
                {
                    return true; // thanh cong
                }
                return true; // thanh cong
            }

            //do
            //{
            //    id = rnd.Next(0, 100000);
            //     dtcheckID = common.GetTable(strCheckID);
            //} while (dtcheckID.Rows.Count < 0 );
            //if (common.excuteSQL(strquery, parameters) == 1)
            //{
            //    return true; // thanh cong
            //}
            else
            {
                
                return false; // that bai
            }
            
        }
    }


}