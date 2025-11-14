using QLKS_Dangnhap.Proccess;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QLKS_Dangnhap.GUI
{
    public partial class FrDangnhap : Form
    {
        private bool check = false;
        public FrDangnhap()
        {
            InitializeComponent();
        }

        private void FrDangnhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string username = txtuser.Text;
            string password = txtpass.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Không được để trống tên đăng nhập hoặc mật khẩu!");
                return;
            }

            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;User ID=sa;Password=123;";
            string hashedPass = Hash.HashPassword(password);

            string query = "SELECT COUNT(*) FROM taikhoan WHERE username=@tk AND password=@mk";
            

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
            FrmDangKy FrDangky = new FrmDangKy();
            FrDangky.Show();
            this.Hide();
        }

        private void ckhien1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckhien1.Checked)
                txtpass.PasswordChar = '\0';
            else
                txtpass.PasswordChar = '*';
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            bool valid = true;

            if (txtpass.Text.Length < 6)
            {
                lbpass3.ForeColor = Color.Red;
                valid = false;
            }
            else
            {
                lbpass3.ForeColor = Color.Green;
            }

            if (!txtpass.Text.Any(c => char.IsUpper(c)))
            {
                lbpass1.ForeColor = Color.Red;
                valid = false;
            }
            else
            {
                lbpass1.ForeColor = Color.Green;
            }

            if (!txtpass.Text.Any(c => char.IsDigit(c)))
            {
                lbpass2.ForeColor = Color.Red;
                valid = false;
            }
            else
            {
                lbpass2.ForeColor = Color.Green;
            }

            check = valid;
        }
    }
}
