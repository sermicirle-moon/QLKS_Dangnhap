using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS_Dangnhap.GUI
{
    public partial class Main : Form
    {
        public static string currentUser = "";
        public Main()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += Main_Load;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lbWelcome.Text = "Chào mừng " + currentUser;
        }
    }
}
