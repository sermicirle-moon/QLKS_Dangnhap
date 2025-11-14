using QLKS_Dangnhap.Database;
using QLKS_Dangnhap.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QLKS_Dangnhap.Proccess
{
    public class TaikhoanProcess
    {
        public static bool KiemTraTrung(string username,string email)
        {
            DatabaseConnection db=new DatabaseConnection();
            using(SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM taiKhoan WHERE username=@u OR email=@e ";
                SqlCommand cmd=new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@e", email);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        public static void Them(Taikhoan tk)
        {
            DatabaseConnection db = new DatabaseConnection();
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string mahoa = Hash.HashPassword(tk.Password);
                string sql = "INSERT INTO taiKhoan(username,email,password,role) VALUES(@u, @e, @p, @r)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@u", tk.Username);
                cmd.Parameters.AddWithValue("@e", tk.Email);
                cmd.Parameters.AddWithValue("@p", mahoa);
                cmd.Parameters.AddWithValue("@r", "user");
                cmd.ExecuteNonQuery();
            }
        }

        public static bool KiemTraEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
    }
}
