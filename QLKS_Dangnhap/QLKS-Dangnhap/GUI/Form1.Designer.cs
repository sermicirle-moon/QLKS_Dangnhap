namespace QLKS_Dangnhap
{
    partial class FrmDangKy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGmail = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.ckhien1 = new System.Windows.Forms.CheckBox();
            this.ckhien2 = new System.Windows.Forms.CheckBox();
            this.btndangki = new System.Windows.Forms.Button();
            this.lbValidateGmail = new System.Windows.Forms.Label();
            this.lbpass1 = new System.Windows.Forms.Label();
            this.lbpass2 = new System.Windows.Forms.Label();
            this.lbcompass2 = new System.Windows.Forms.Label();
            this.lbcompass1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbcompass3 = new System.Windows.Forms.Label();
            this.lbpass3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng Ký Tài Khoản";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gmail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 244);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên người dùng: ";
            // 
            // txtGmail
            // 
            this.txtGmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGmail.Location = new System.Drawing.Point(279, 149);
            this.txtGmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.Size = new System.Drawing.Size(348, 30);
            this.txtGmail.TabIndex = 3;
            this.txtGmail.Leave += new System.EventHandler(this.txtGmail_Leave);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(279, 245);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(348, 30);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 332);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mật khẩu:";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(279, 330);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(348, 30);
            this.txtPass.TabIndex = 6;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 506);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Xác nhận mật khẩu:";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPass.Location = new System.Drawing.Point(279, 503);
            this.txtConfirmPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '*';
            this.txtConfirmPass.Size = new System.Drawing.Size(348, 30);
            this.txtConfirmPass.TabIndex = 8;
            this.txtConfirmPass.TextChanged += new System.EventHandler(this.txtConfirmPass_TextChanged);
            // 
            // ckhien1
            // 
            this.ckhien1.AutoSize = true;
            this.ckhien1.Location = new System.Drawing.Point(501, 362);
            this.ckhien1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckhien1.Name = "ckhien1";
            this.ckhien1.Size = new System.Drawing.Size(114, 20);
            this.ckhien1.TabIndex = 9;
            this.ckhien1.Text = "Hiện mật khẩu";
            this.ckhien1.UseVisualStyleBackColor = true;
            this.ckhien1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ckhien2
            // 
            this.ckhien2.AutoSize = true;
            this.ckhien2.Location = new System.Drawing.Point(501, 535);
            this.ckhien2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckhien2.Name = "ckhien2";
            this.ckhien2.Size = new System.Drawing.Size(114, 20);
            this.ckhien2.TabIndex = 10;
            this.ckhien2.Text = "Hiện mật khẩu";
            this.ckhien2.UseVisualStyleBackColor = true;
            this.ckhien2.CheckedChanged += new System.EventHandler(this.ckhien2_CheckedChanged);
            // 
            // btndangki
            // 
            this.btndangki.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangki.Location = new System.Drawing.Point(256, 716);
            this.btndangki.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btndangki.Name = "btndangki";
            this.btndangki.Size = new System.Drawing.Size(255, 69);
            this.btndangki.TabIndex = 11;
            this.btndangki.Text = "ĐĂNG KÝ";
            this.btndangki.UseVisualStyleBackColor = true;
            this.btndangki.Click += new System.EventHandler(this.btndangki_Click);
            // 
            // lbValidateGmail
            // 
            this.lbValidateGmail.AutoSize = true;
            this.lbValidateGmail.Location = new System.Drawing.Point(275, 177);
            this.lbValidateGmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbValidateGmail.Name = "lbValidateGmail";
            this.lbValidateGmail.Size = new System.Drawing.Size(0, 16);
            this.lbValidateGmail.TabIndex = 12;
            this.lbValidateGmail.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbpass1
            // 
            this.lbpass1.AutoSize = true;
            this.lbpass1.BackColor = System.Drawing.SystemColors.Control;
            this.lbpass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpass1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbpass1.Location = new System.Drawing.Point(275, 423);
            this.lbpass1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbpass1.Name = "lbpass1";
            this.lbpass1.Size = new System.Drawing.Size(279, 20);
            this.lbpass1.TabIndex = 13;
            this.lbpass1.Text = "-Mật khẩu phải chứa một kí tự in hoa";
            this.lbpass1.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // lbpass2
            // 
            this.lbpass2.AutoSize = true;
            this.lbpass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpass2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbpass2.Location = new System.Drawing.Point(275, 462);
            this.lbpass2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbpass2.Name = "lbpass2";
            this.lbpass2.Size = new System.Drawing.Size(216, 20);
            this.lbpass2.TabIndex = 14;
            this.lbpass2.Text = "-Mật khẩu phải chứa một số";
            this.lbpass2.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbcompass2
            // 
            this.lbcompass2.AutoSize = true;
            this.lbcompass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcompass2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbcompass2.Location = new System.Drawing.Point(275, 649);
            this.lbcompass2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbcompass2.Name = "lbcompass2";
            this.lbcompass2.Size = new System.Drawing.Size(216, 20);
            this.lbcompass2.TabIndex = 16;
            this.lbcompass2.Text = "-Mật khẩu phải chứa một số";
            // 
            // lbcompass1
            // 
            this.lbcompass1.AutoSize = true;
            this.lbcompass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcompass1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbcompass1.Location = new System.Drawing.Point(275, 603);
            this.lbcompass1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbcompass1.Name = "lbcompass1";
            this.lbcompass1.Size = new System.Drawing.Size(279, 20);
            this.lbcompass1.TabIndex = 15;
            this.lbcompass1.Text = "-Mật khẩu phải chứa một kí tự in hoa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(237, 804);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "Đã có tài khoản?";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label11.Location = new System.Drawing.Point(411, 805);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 24);
            this.label11.TabIndex = 18;
            this.label11.Text = "Đăng Nhập";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // lbcompass3
            // 
            this.lbcompass3.AutoSize = true;
            this.lbcompass3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcompass3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbcompass3.Location = new System.Drawing.Point(275, 560);
            this.lbcompass3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbcompass3.Name = "lbcompass3";
            this.lbcompass3.Size = new System.Drawing.Size(228, 20);
            this.lbcompass3.TabIndex = 19;
            this.lbcompass3.Text = "-Mật khẩu phải dài hơn 6 kí tự";
            // 
            // lbpass3
            // 
            this.lbpass3.AutoSize = true;
            this.lbpass3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpass3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbpass3.Location = new System.Drawing.Point(275, 386);
            this.lbpass3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbpass3.Name = "lbpass3";
            this.lbpass3.Size = new System.Drawing.Size(228, 20);
            this.lbpass3.TabIndex = 20;
            this.lbpass3.Text = "-Mật khẩu phải dài hơn 6 kí tự";
            this.lbpass3.Click += new System.EventHandler(this.lbpass3_Click);
            // 
            // FrmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 859);
            this.Controls.Add(this.lbpass3);
            this.Controls.Add(this.lbcompass3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbcompass2);
            this.Controls.Add(this.lbcompass1);
            this.Controls.Add(this.lbpass2);
            this.Controls.Add(this.lbpass1);
            this.Controls.Add(this.lbValidateGmail);
            this.Controls.Add(this.btndangki);
            this.Controls.Add(this.ckhien2);
            this.Controls.Add(this.ckhien1);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtGmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Ký";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.CheckBox ckhien1;
        private System.Windows.Forms.CheckBox ckhien2;
        private System.Windows.Forms.Button btndangki;
        private System.Windows.Forms.Label lbValidateGmail;
        private System.Windows.Forms.Label lbpass1;
        private System.Windows.Forms.Label lbpass2;
        private System.Windows.Forms.Label lbcompass2;
        private System.Windows.Forms.Label lbcompass1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbcompass3;
        private System.Windows.Forms.Label lbpass3;
    }
}

