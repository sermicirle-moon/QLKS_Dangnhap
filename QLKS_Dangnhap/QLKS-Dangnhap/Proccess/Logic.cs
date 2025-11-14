using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKS_Dangnhap.Models;

namespace QLKS_Dangnhap.Proccess
{
    public class Logic
    {
        public static string DangKy(string username, string email, string password)
        {
            if (TaikhoanProcess.KiemTraTrung(username, email))
            {
                return "Username hoặc Email đã tồn tại.";
            }
            Taikhoan tk = new Taikhoan
            {
                Username = username,
                Email = email,
                Password = password
            };
            TaikhoanProcess.Them(tk);
            KhachhangProccess.ThemKhachHang(tk);
            return "Đăng ký thành công.";
        }
    }
}
