using QLKS_Dangnhap.Database;
using QLKS_Dangnhap.Proccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using QLKS_Dangnhap.GUI;

namespace QLKS_Dangnhap
{
    public partial class FrmDangKy : Form
    {
        private bool check = false;
        public FrmDangKy()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckhien1.Checked)
                txtPass.PasswordChar = '\0';
            else
                txtPass.PasswordChar = '*';
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            FrDangnhap DangnhapForm = new FrDangnhap();
            DangnhapForm.Show();
            this.Hide();
        }

        private void btndangki_Click(object sender, EventArgs e)
        {
            if(!check)
            {
                MessageBox.Show("Thông tin nhập không hợp lệ");
                return;
            }
            else
            {
                string username = txtUsername.Text;
                string email = txtGmail.Text;
                string password = txtPass.Text;
                string result = Logic.DangKy(username, email, password);
                MessageBox.Show(result);
                if (result == "Đăng ký thành công.")
                {
                    
                    FrDangnhap DangnhapForm = new FrDangnhap();
                    DangnhapForm.Show();
                    this.Hide();
                }
            }
        }

        private void txtGmail_Leave(object sender, EventArgs e)
        {
            string email = txtGmail.Text;
            if (!TaikhoanProcess.KiemTraEmail(email))
            {
                lbValidateGmail.Text = "Email không hợp lệ!";
                lbValidateGmail.ForeColor = Color.Red;
            }
            else
            {
                lbValidateGmail.Text = "";
            }
        }

        private void ckhien2_CheckedChanged(object sender, EventArgs e)
        {
            if (ckhien2.Checked)
                txtConfirmPass.PasswordChar = '\0';
            else
                txtConfirmPass.PasswordChar = '*';
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            bool valid = true;

            if (txtPass.Text.Length < 6)
            {
                lbpass3.ForeColor = Color.Red;
                valid = false;
            }
            else
            {
                lbpass3.ForeColor = Color.Green;
            }

            if (!txtPass.Text.Any(c => char.IsUpper(c)))
            {
                lbpass1.ForeColor = Color.Red;
                valid = false;
            }
            else
            {
                lbpass1.ForeColor = Color.Green;
            }

            if (!txtPass.Text.Any(c => char.IsDigit(c)))
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

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {
            bool valid = true;

            if (txtConfirmPass.Text.Length < 6)
            {
                lbcompass3.ForeColor = Color.Red;
                valid = false;
            }
            else
            {
                lbcompass3.ForeColor = Color.Green;
            }

            if (!txtConfirmPass.Text.Any(c => char.IsUpper(c)))
            {
                lbcompass1.ForeColor = Color.Red;
                valid = false;
            }
            else
            {
                lbcompass1.ForeColor = Color.Green;
            }

            if (!txtConfirmPass.Text.Any(c => char.IsDigit(c)))
            {
                lbcompass2.ForeColor = Color.Red;
                valid = false;
            }
            else
            {
                lbcompass2.ForeColor = Color.Green;
            }
            if (txtConfirmPass.Text != txtPass.Text)
            {
                valid = false;
            }

            check = valid;
        }

        private void lbpass3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
