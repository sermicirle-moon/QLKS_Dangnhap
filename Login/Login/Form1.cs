using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string username = txtuser.Text.Trim();
            string password = txtpass.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Không được để trống tên đăng nhập hoặc mật khẩu!");
                return;
            }

            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;User ID=sa;Password=123;";
            string query = "SELECT COUNT(*) FROM nguoidung WHERE Username=@tk AND Password=@mk";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@tk", username);
                    cmd.Parameters.AddWithValue("@mk", password);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {

                        MessageBox.Show("✅ Đăng nhập thành công!");

                        Main.currentUser = username;    // lưu username
                        Main mainForm = new Main();      // tạo instance form chính
                        mainForm.Show();                 // hiển thị
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("❌ Sai tài khoản hoặc mật khẩu!");
                        lblStatus.Text = "Trạng thái: Đăng nhập thất bại";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }
        

        private void btnDangky_Click(object sender, EventArgs e)
        {

        }

        //private void btnconnect_Click(object sender, EventArgs e)
        //{
        //    string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;User ID=sa;Password=123;";

        //    try
        //    {
        //        SqlConnection conn = new SqlConnection(connectionString);
        //        conn.Open(); // Mở kết nối
        //        MessageBox.Show("✅ Kết nối cơ sở dữ liệu thành công!");
        //        conn.Close(); // Đóng kết nối
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("❌ Kết nối thất bại: " + ex.Message);
        //    }


        //}
    }
}
