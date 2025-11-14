using QLKS_Dangnhap.Database;
using QLKS_Dangnhap.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS_Dangnhap.Proccess
{
    public class KhachhangProccess
    {
        public static void ThemKhachHang(Taikhoan tk)
        {
            DatabaseConnection db = new DatabaseConnection();
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string sql = "INSERT INTO khachhang (hoten, email, username) VALUES(@ten, @email, @username)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ten", tk.Username);
                cmd.Parameters.AddWithValue("@email", tk.Email);
                cmd.Parameters.AddWithValue("@username", tk.Username);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
