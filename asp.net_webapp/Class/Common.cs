using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Ajax.Utilities;
using System.CodeDom;
using System.Collections.Specialized;

namespace asp.net_webapp.Class
{
    public class Common
    {
        private static Common _instance;

        public static Common Instance { get => _instance; set => _instance = value; }
        private string strCon = "Server=DESKTOP-HKV2ORJ\\SQLEXPRESS;Database=WebServer;Integrated Security=SSPI;trustservercertificate=true";
        public Common()
        {

        }

        public DataTable Read_SQLData(string query, SqlParameter[] parameters = null)
        {
            // giong nhu trong wpf, su dung sqlreader de doc du lieu trong database.
            // sau do load vao trong datatable
            // return datatable ra ngoai de su dung dien vao dropdownlist.


            DataTable dt = new DataTable();
            SqlDataReader reader;
            using(SqlConnection connection = new SqlConnection(strCon))
            {
                using(SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                   reader = cmd.ExecuteReader();
                    dt.Load(reader);

                }
                
            }
            return dt;
        }

        

        public DataTable GetTable(string query, SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(strCon))
            {

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    // thuc te parameter la @taikhoan, da duoc khai bao o ben nguoidungbussiness
                    // sang ben nay chi can add them no vao de getable hieu duoc @taikhoan la gi.
                    // vi khai bao paramaters la dang array [] nen su dung addrange
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        da.Fill(dt);

                }
            }
            return dt;
        }

        public int excuteSQL(string query, SqlParameter[] parameters = null)
        {
            using(SqlConnection connection = new SqlConnection(strCon))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return 1; // thanh cong
                    }
                    else
                    {
                        return 0; // that bai
                    }
                    
                }
            }
        }
    }
}