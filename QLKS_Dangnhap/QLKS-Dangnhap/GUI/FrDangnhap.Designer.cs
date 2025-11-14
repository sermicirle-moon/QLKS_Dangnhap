namespace QLKS_Dangnhap.GUI
{
    partial class FrDangnhap
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.lbpass3 = new System.Windows.Forms.Label();
            this.lbpass2 = new System.Windows.Forms.Label();
            this.lbpass1 = new System.Windows.Forms.Label();
            this.ckhien1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDangky = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(184, 208);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 16);
            this.lblStatus.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(178, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "Đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tên đăng nhập";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(203, 140);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(189, 22);
            this.txtpass.TabIndex = 11;
            this.txtpass.TextChanged += new System.EventHandler(this.txtpass_TextChanged);
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(203, 94);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(189, 22);
            this.txtuser.TabIndex = 10;
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangnhap.Location = new System.Drawing.Point(48, 356);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(190, 46);
            this.btnDangnhap.TabIndex = 8;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.UseVisualStyleBackColor = true;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // lbpass3
            // 
            this.lbpass3.AutoSize = true;
            this.lbpass3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpass3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbpass3.Location = new System.Drawing.Point(180, 208);
            this.lbpass3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbpass3.Name = "lbpass3";
            this.lbpass3.Size = new System.Drawing.Size(228, 20);
            this.lbpass3.TabIndex = 24;
            this.lbpass3.Text = "-Mật khẩu phải dài hơn 6 kí tự";
            // 
            // lbpass2
            // 
            this.lbpass2.AutoSize = true;
            this.lbpass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpass2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbpass2.Location = new System.Drawing.Point(180, 284);
            this.lbpass2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbpass2.Name = "lbpass2";
            this.lbpass2.Size = new System.Drawing.Size(216, 20);
            this.lbpass2.TabIndex = 23;
            this.lbpass2.Text = "-Mật khẩu phải chứa một số";
            // 
            // lbpass1
            // 
            this.lbpass1.AutoSize = true;
            this.lbpass1.BackColor = System.Drawing.SystemColors.Control;
            this.lbpass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpass1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbpass1.Location = new System.Drawing.Point(180, 245);
            this.lbpass1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbpass1.Name = "lbpass1";
            this.lbpass1.Size = new System.Drawing.Size(279, 20);
            this.lbpass1.TabIndex = 22;
            this.lbpass1.Text = "-Mật khẩu phải chứa một kí tự in hoa";
            // 
            // ckhien1
            // 
            this.ckhien1.AutoSize = true;
            this.ckhien1.Location = new System.Drawing.Point(345, 169);
            this.ckhien1.Margin = new System.Windows.Forms.Padding(4);
            this.ckhien1.Name = "ckhien1";
            this.ckhien1.Size = new System.Drawing.Size(114, 20);
            this.ckhien1.TabIndex = 21;
            this.ckhien1.Text = "Hiện mật khẩu";
            this.ckhien1.UseVisualStyleBackColor = true;
            this.ckhien1.CheckedChanged += new System.EventHandler(this.ckhien1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(318, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 22);
            this.label4.TabIndex = 25;
            this.label4.Text = "Chưa có tài khoản ?";
            // 
            // btnDangky
            // 
            this.btnDangky.AutoSize = true;
            this.btnDangky.BackColor = System.Drawing.SystemColors.Control;
            this.btnDangky.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangky.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnDangky.Location = new System.Drawing.Point(490, 366);
            this.btnDangky.Name = "btnDangky";
            this.btnDangky.Size = new System.Drawing.Size(113, 19);
            this.btnDangky.TabIndex = 26;
            this.btnDangky.Text = "Đăng ký tại đây";
            this.btnDangky.Click += new System.EventHandler(this.btnDangky_Click);
            // 
            // FrDangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 450);
            this.Controls.Add(this.btnDangky);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbpass3);
            this.Controls.Add(this.lbpass2);
            this.Controls.Add(this.lbpass1);
            this.Controls.Add(this.ckhien1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.btnDangnhap);
            this.Name = "FrDangnhap";
            this.Text = "FrDangnhap";
            this.Load += new System.EventHandler(this.FrDangnhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.Label lbpass3;
        private System.Windows.Forms.Label lbpass2;
        private System.Windows.Forms.Label lbpass1;
        private System.Windows.Forms.CheckBox ckhien1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label btnDangky;
    }
}